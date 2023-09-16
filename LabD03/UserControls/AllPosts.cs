using LabD03.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
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
    public partial class AllPosts : UserControl
    {
        private ITIDbContext db = new ITIDbContext();
        public string Email { get; set; }
        public string Password { get; set; }
        public int Id { get; set; }
        public AllPosts()
        {
            InitializeComponent();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_Filter_Click(object sender, EventArgs e)
        {

            var posts = db.Posts.Where(x => x.Author_Id == Id).ToList();
            dgv.DataSource = posts;
        }



        private void AllPosts_Load(object sender, EventArgs e)
        {
            var posts = db.Posts.ToList();
            dgv.DataSource = posts;
            hideFileds();
        }
        int postId = 0;
        private void dgv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Btn_Edit.Visible = true;
            showFileds();
            try
            {
                DataGridViewRow row = dgv.Rows[e.RowIndex];
                //if (Id == Convert.ToInt32(Id))
                //{
                // Btn_Edit.Show();
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


                comb_Catalog1.SelectedValue = Convert.ToInt32(row.Cells[9].Value);

                DateTime? postDate = DateTime.Parse(row.Cells[5].Value.ToString());
                TimeSpan? postTime = TimeSpan.Parse(row.Cells[6].Value.ToString());

                DateTime combinedDateTime = postDate.Value.Add(postTime.Value);
                DataAndTime.Value = combinedDateTime;
                //}
                //else
                //{
                //    MessageBox.Show("Show only not edit");
                //  //  Btn_Edit.Show();
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void showFileds()
        {
            txt_Name.Visible = true;
            txt_Desc.Visible = true;
            txt_Bref.Visible = true;
            DataAndTime.Visible = true;
            Pic_Box.Visible = true;
            Btn_Upload.Visible = false;
            comb_Catalog1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
           
            label8.Visible = false;

        }
        void hideFileds()
        {
            txt_Name.Visible = false;
            txt_Desc.Visible = false;
            txt_Bref.Visible = false;
            DataAndTime.Visible = false;
            Pic_Box.Visible = false;
            Btn_Upload.Visible = false;
            comb_Catalog1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
           
            label8.Visible = true;

        }
    }
}
