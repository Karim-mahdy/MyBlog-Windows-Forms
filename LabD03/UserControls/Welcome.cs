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
    public partial class Welcome : UserControl
    {

        private Dashbord parentForm;
        public Welcome()
        {
            InitializeComponent();
        }

        public void SetDashbordReference(Dashbord dashbord)
        {
            parentForm = dashbord;
        }
        private void Btn_Login_Click(object sender, EventArgs e)
        {
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

        private void btn_Register_Click(object sender, EventArgs e)
        {
            if (parentForm != null)
            {
                this.Hide();
                // Display the contents of the Container_Panel
                Register register = new Register();
                register.SetDashbordReference(parentForm);
                parentForm.Container_Panel.Controls.Clear();
                parentForm.Container_Panel.Controls.Add(register);
                register.Dock = DockStyle.Fill;
                register.BringToFront();
            }
        }
    }
}
