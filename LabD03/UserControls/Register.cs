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

namespace LabD03.UserControls
{
    public partial class Register : UserControl
    {

        ITIDbContext db;
        int id;
        byte[] imageData;

        private Dashbord parentForm;
        public Register()
        {
            InitializeComponent();
            db = new ITIDbContext();
        }
        // get parentForm
        public void SetDashbordReference(Dashbord dashbord)
        {
            parentForm = dashbord;
        }

        // Validation 
        Validate validateuser = new Validate();

        private void Btn_SignUp_Click(object sender, EventArgs e)
        {
            try
            {
                if (validateuser.IsEmailValid(txt_Email.Text, db)
                    && validateuser.ValidateAge(num_Age.Value)
                    && validateuser.ValidateEmail(txt_Email.Text)
                    && validateuser.ValidatePassword(txt_Password.Text))
                {
                    if (txt_Password.Text == txt_ConfirmPass.Text)
                    {
                        var author = new Author()
                        {
                            UserName = txt_userName.Text,
                            Email = txt_Email.Text,
                            Age = Convert.ToInt32(num_Age.Value),
                            Password = txt_Password.Text,
                            Image = imageData,
                        };
                        db.Authors.Add(author);
                        db.SaveChanges();

                        string message = "Register Succesfully";
                        string title = "Title";
                        MessageBox.Show(message, title);
                        if (parentForm != null)
                        {
                            this.Hide();
                            // Display the contents of the Container_Panel
                            Login login = new Login();
                            login.SetDashbordReference(parentForm);
                            parentForm.Container_Panel.Controls.Clear();
                            parentForm.Container_Panel.Controls.Add(login);
                            login.Dock = DockStyle.Fill;
                            login.BringToFront();
                        }
                    }
                    else
                    {
                        string message2 = "Password not match";
                        string title2 = "Title";
                        MessageBox.Show(message2, title2);
                    }

                }
                else
                {
                    string message3 = "Invalid Data";
                    string title3 = "Title";
                    MessageBox.Show(message3, title3);
                }

            }
            catch (Exception)
            {
                string message3 = "Register UnSuccesfully";
                string title3 = "Title";
                MessageBox.Show(message3, title3);
            }

            //Login login = new Login();
            //login.Show();
            //this.Hide();
        }




        private void Btn_Add_img_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";
                openFileDialog.Title = "Select an Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    imageData = File.ReadAllBytes(openFileDialog.FileName);

                    try
                    {
                        pictureBox.Image = Image.FromFile(openFileDialog.FileName);
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

