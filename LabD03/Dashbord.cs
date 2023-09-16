using LabD03.Models;
using LabD03.UserControls;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabD03
{
    public partial class Dashbord : Form
    {
        private ITIDbContext db = new ITIDbContext();
        public string Email { get; set; }
        public string Password { get; set; }
        public int Id { get; set; }
        public int Login_Register { get; set; }
        public Dashbord()
        {
            InitializeComponent();
        }


        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            Container_Panel.Controls.Clear();
            Container_Panel.Controls.Add(userControl);
            userControl.BringToFront();
            userControl.Visible = true;
        }

        private void myProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyProfile myProfile = new MyProfile();
            myProfile.Email = Email;
            myProfile.Password = Password;
            addUserControl(myProfile);

        }
        Author user;
        public void Dashbord_Load(object sender, EventArgs e)
        {

            if (Id != 0)
            {
                AllPosts allPosts = new AllPosts();
                user = db.Authors.SingleOrDefault(x => x.Email == Email && x.Password == Password);
                allPosts.Id = user.Id;
                addUserControl(allPosts);
                menuStrip1.Enabled = true;
                btn_Register.Visible = false;
                Btn_Login.Visible = false;
                Btn_Logout.Visible = true;
                lab_user.Visible = false;
                btn_welcome.Visible = true;

            }
            else
            {
                menuStrip1.Enabled = false;
                btn_Register.Visible = true;
                Btn_Login.Visible = true;
                Btn_Logout.Visible = false;
               
                lab_user.Visible = true;
                btn_welcome.Visible = true;
            }
            

        }


        private void catalogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Catalogs catalogs = new Catalogs();
            addUserControl(catalogs);
        }

        private void allPostsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllPosts allPosts = new AllPosts();
            allPosts.Id = user.Id;
            addUserControl(allPosts);
        }

        private void myPostsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyPosts myPosts = new MyPosts();
            myPosts.Id = user.Id;
            addUserControl(myPosts);
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Dock = DockStyle.Fill;
            login.SetDashbordReference(this);


            addUserControl(login);

        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.SetDashbordReference(this);
            addUserControl(register);

        }

        private void Btn_Logout_Click(object sender, EventArgs e)
        {
            Id = 0;
            Email = "";
            Password = "";
            user = null; // Reset user information

            // Hide elements specific to logged-in state
            menuStrip1.Enabled = false;
            Btn_Logout.Visible = false;

            // Show elements specific to logged-out state
            btn_Register.Visible = true;
            Btn_Login.Visible = true;


            Welcome welcome = new Welcome();
            welcome.Dock = DockStyle.Fill;
            welcome.SetDashbordReference(this);

            addUserControl(welcome);


        }

       
    }
}
