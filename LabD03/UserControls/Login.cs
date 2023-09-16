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
    public partial class Login : UserControl
    {
        ITIDbContext db;
        private Dashbord parentForm;

        public Login()
        {
            InitializeComponent();
            db = new ITIDbContext();
        }
        Validate validateuser = new Validate();
        public void SetDashbordReference(Dashbord dashbord)
        {
            parentForm = dashbord;
        }

        private void Btn_SignIn_Click(object sender, EventArgs e)
        {

            string email = txt_Email.Text;
            string password = txt_Password.Text;
            try
            {
                if (validateuser.ValidateEmail(email) && validateuser.ValidatePassword(password))
                {
                    var user = db.Authors.Where(x => x.Email == txt_Email.Text && x.Password == txt_Password.Text).SingleOrDefault();
                    if (user != null)
                    {
                        string message = "Login Succesfully";
                        string title = "Login ";
                        MessageBox.Show(message, title);

                        if (parentForm != null)
                        {
                            // Set properties of the parent form
                            parentForm.Id = user.Id;
                            parentForm.Email = txt_Email.Text;
                            parentForm.Password = txt_Password.Text;

                            // Hide the Login user control
                            this.Hide();

                            // Display the contents of the Container_Panel
                            parentForm.Container_Panel.Visible = true;
                            parentForm.Dashbord_Load(sender, e);
                        }
                    }
                    else
                    {
                        string message = "Login UnSuccesfully";
                        string title = "Login";
                        MessageBox.Show(message, title);
                    }


                }

            }
            catch (Exception ex)
            {
                string title3 = "Error happend";
                MessageBox.Show(ex.Message, title3);
            }


        }

       
    }
}
