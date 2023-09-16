using LabD03.Models;
using Microsoft.VisualBasic;
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
    public partial class MyPosts : UserControl
    {
        private ITIDbContext db = new ITIDbContext();

        public MyPosts()
        {
            InitializeComponent();
        }

        public int Id { get; set; }


        private void MyPosts_Load(object sender, EventArgs e)
        {
            GetPosts();
            Btn_Edit.Visible = false;
            Btn_Cancel.Visible = false;
            ReadOnlyFalse();
            hideFileds();
            Btn_SaveChanges.Visible = false;
            
        }

        byte[] imageData;
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            Btn_Edit.Visible = false;
            Btn_Cancel.Visible = false;
            Btn_Add.Visible= false;
            Btn_SaveChanges.Visible = true;
            Btn_Upload.Enabled = true;
            label8.Visible= false;
            label9.Visible= false;
            showFileds();
            
        }

        private void Btn_SaveChanges_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text != "" && txt_Desc.Text != "" && txt_Bref.Text != "")
            {
                try
                {
                    Post item = new Post()
                    {
                        Title = txt_Name.Text,
                        Description = txt_Desc.Text,
                        Bref = txt_Bref.Text,
                        Catalog_Id = Convert.ToInt32(comb_Catalog.SelectedValue),
                        PostDate = DataAndTime.Value,
                        PostTime = DataAndTime.Value.TimeOfDay,
                        Image = imageData,
                        Author_Id = Id,
                    };
                    db.Posts.Add(item);
                    db.SaveChanges();
                    MessageBox.Show("Post Added");
                    GetPosts();
                    ClearFields();
                    Btn_SaveChanges.Visible=false;
                    hideFileds();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }

            }
            else
            {
                MessageBox.Show("Error Fill Requried Data");
            }


        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            var post = db.Posts.Find(postId);
            try
            {
                post.Title = txt_Name.Text;
                post.Description = txt_Desc.Text;
                post.Bref = txt_Bref.Text;
                post.Catalog_Id = Convert.ToInt32(comb_Catalog.SelectedValue);
                post.PostDate = DateAndTime.Now;
                post.PostTime = DateAndTime.Now.TimeOfDay;
                if (imageData != null)
                {
                    post.Image = imageData;
                }
                post.Author_Id = Id;

                db.Posts.Update(post);
                db.SaveChanges();
                MessageBox.Show("Post edited");
                GetPosts();
                ClearFields();

                Btn_Edit.Visible = false;
                Btn_Add.Visible = true;
                Btn_Cancel.Visible = false;
                Btn_Upload.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }



        private void Btn_Upload_Click(object sender, EventArgs e)
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


        void ClearFields()
        {
            txt_Name.Text = txt_Desc.Text = txt_Bref.Text = "";
            comb_Catalog.SelectedValue = 0;
            DataAndTime.Value = DateAndTime.Now;
            Pic_Box.Image = null;
        }
        void GetPosts()
        {
            var posts = db.Posts.Where(x => x.Author_Id == Id).ToList();
            dgv.DataSource = posts;
            comb_Catalog.DataSource = db.Catalogs.ToList();
            comb_Catalog.DisplayMember = "Name";
            comb_Catalog.ValueMember = "Id";
        }
        int postId = 0;
        private void dgv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Btn_Edit.Visible = true;
            try
            {
                DataGridViewRow row = dgv.Rows[e.RowIndex];
                if (Id == Convert.ToInt32(row.Cells[7].Value))
                {
                    Btn_Edit.Show();
                    postId = (int)row.Cells[0].Value;
                    txt_Name.Text = row.Cells[1].Value.ToString();
                    txt_Desc.Text = row.Cells[2].Value.ToString();
                    txt_Bref.Text = row.Cells[3].Value.ToString();
                    var image = row.Cells[4].Value as Byte[];

                    using (MemoryStream memoryStream = new MemoryStream(image))
                    {

                        Pic_Box.Image = Image.FromStream(memoryStream);
                        Pic_Box.SizeMode = PictureBoxSizeMode.Zoom;
                        Pic_Box.Image = new Bitmap(Pic_Box.Image, Pic_Box.Width, Pic_Box.Height);
                    }
                    comb_Catalog.SelectedValue = Convert.ToInt32(row.Cells[9].Value);
                    Btn_Add.Hide();
                    Btn_SaveChanges.Hide();
                    ReadonlyTrue();
                    label8.Visible = false;
                    label9.Visible = false;
                    Btn_Upload.Enabled = true;
                    Btn_Cancel.Visible = true;
                    showFileds();
                    ReadOnlyFalse();
                }
                else
                {
                    MessageBox.Show("Show only not edit");
                    Btn_Edit.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            hideFileds();
            label9.Visible = true;
            label8.Visible = true;
            Btn_Add.Visible= true;
            Btn_Cancel.Visible = false;
            Btn_Edit.Visible= false;
            ClearFields();
        }
        void ReadonlyTrue()
        {
            txt_Name.ReadOnly = true;
            txt_Desc.ReadOnly = true;
            txt_Bref.ReadOnly = true;
            comb_Catalog.Enabled = false;
            DataAndTime.Enabled = false;
           // Btn_Upload.Enabled = true;
           
        }
        void ReadOnlyFalse()
        {

            txt_Name.ReadOnly = false;
            txt_Desc.ReadOnly = false;
            txt_Bref.ReadOnly = false;
            comb_Catalog.Enabled = true;
            DataAndTime.Enabled = true;
            //Btn_Upload.Enabled = false;
           

        }
        void showFileds()
        {
            txt_Name.Visible = true;
            txt_Desc.Visible = true;
            txt_Bref.Visible = true;
            DataAndTime.Visible = true;
            Pic_Box.Visible = true;
            Btn_Upload.Visible = true;
            comb_Catalog.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
           

        }
        void hideFileds()
        {
            txt_Name.Visible = false;
            txt_Desc.Visible = false;
            txt_Bref.Visible = false;
            DataAndTime.Visible = false;
            Pic_Box.Visible = false;
            Btn_Upload.Visible = false;
            comb_Catalog.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
         
         
        }

       
    }
}
