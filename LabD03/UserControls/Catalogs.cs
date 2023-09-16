using LabD03.Models;
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
    public partial class Catalogs : UserControl
    {
        ITIDbContext db = new ITIDbContext();

        int catid = 0;
        public Catalogs()
        {
            InitializeComponent();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Name.Text != "" && txt_Description.Text != "")
                {
                    Catalog cat = new Catalog()
                    {
                        Name = txt_Name.Text,
                        Description = txt_Description.Text,
                    };

                    db.Catalogs.Add(cat);
                    db.SaveChanges();
                    GetData();
                    txt_Description.Text = txt_Name.Text = "";
                    MessageBox.Show("Add successfully");
                }
                else
                {
                    MessageBox.Show("Fill the item ");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                var itemcat = db.Catalogs.Where(x => x.Id == catid).SingleOrDefault();
                itemcat.Name = txt_Name.Text;
                itemcat.Description = txt_Description.Text;

                db.Catalogs.Update(itemcat);
                db.SaveChanges();

                MessageBox.Show("Updated");
                GetData();
                Btn_Edit.Hide();
                Btn_Add.Show();
                txt_Name.Text = txt_Description.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void Catalogs_Load(object sender, EventArgs e)
        {
            Btn_Edit.Hide();

            GetData();
        }
        void GetData()
        {
            dgv.DataSource = db.Catalogs.ToList();

        }

        private void dgv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            DataGridViewRow row = dgv.Rows[e.RowIndex];

            catid = (int)row.Cells[0].Value;
            txt_Name.Text = row.Cells[1].Value.ToString();
            txt_Description.Text = row.Cells[2].Value.ToString();
            Btn_Edit.Show();
            Btn_Add.Hide();
        }
    }
}
