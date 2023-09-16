using LabD03.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LabD03.UserControls
{
    public partial class MyProfile : UserControl
    {

        private readonly ITIDbContext db;
        public MyProfile()
        {
            InitializeComponent();
            db = new ITIDbContext();
        }
        public string Email { get; set; }
        public string Password { get; set; }


        private void MyProfile_Load(object sender, EventArgs e)
        {
            num_Age.Enabled = false;
            try
            {
                var User = db.Authors.Where(x => x.Email == Email && x.Password == Password).SingleOrDefault();
                if (User != null)
                {
                    Author author = new Author()
                    {
                        UserName = User.UserName,
                        Age = User.Age,
                        Email = User.Email,
                        Password = User.Password,
                        Image = User.Image,
                    };

                    txt_userName.Text = author.UserName;
                    num_Age.Value = Convert.ToInt32(author.Age);
                    txt_Email.Text = author.Email;
                    txt_Password.Text = author.Password;
                    txt_confirmPass.Text = author.Password;
                    using (MemoryStream memoryStream = new MemoryStream(author.Image))
                    {
                        Pic_Box.Image = Image.FromStream(memoryStream);
                        Pic_Box.SizeMode = PictureBoxSizeMode.Zoom;
                        Pic_Box.Image = new Bitmap(Pic_Box.Image, Pic_Box.Width, Pic_Box.Height);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data faild Loaded");
            }
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            txt_userName.ReadOnly = num_Age.ReadOnly = txt_Email.ReadOnly = txt_Password.ReadOnly = txt_confirmPass.ReadOnly = false;
            Btn_upload.Visible = true;
            num_Age.Enabled=true;
        }

        byte[] imageData;
        private void Btn_SaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                var User = db.Authors.Where(x => x.Email == Email && x.Password == Password).SingleOrDefault();
                if (txt_Password.Text == txt_confirmPass.Text)
                {
                    if (User != null)
                    {
                        User.UserName = txt_userName.Text;
                        User.Age = Convert.ToInt32(num_Age.Value);
                        User.Email = txt_Email.Text;
                        User.Password = txt_Password.Text;
                        if (imageData != null)
                        {
                            User.Image = imageData;
                        }
                        db.Authors.Update(User);

                        db.SaveChanges();
                        MessageBox.Show(" Updated successful!");

                        txt_userName.ReadOnly = num_Age.ReadOnly = txt_Email.ReadOnly = txt_Password.ReadOnly = txt_confirmPass.ReadOnly = true;
                        Btn_upload.Visible = false;
                    }
                }
                else
                {
                    string message2 = "Password not match";
                    string title2 = "Error";
                    MessageBox.Show(message2, title2);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Btn_upload_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";
                openFileDialog.Title = "Select an Image";


                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    imageData = File.ReadAllBytes(openFileDialog.FileName);
                    Pic_Box.Image = null;
                    try
                    {

                        Pic_Box.Image = Image.FromFile(openFileDialog.FileName);
                        Pic_Box.SizeMode = PictureBoxSizeMode.Zoom;
                        Pic_Box.Image = new Bitmap(Pic_Box.Image, Pic_Box.Width, Pic_Box.Height);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error displaying image: " + ex.Message);
                    }

                }

            }
        }
    }
}
