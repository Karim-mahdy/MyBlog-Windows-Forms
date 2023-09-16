namespace LabD03
{
    partial class Dashbord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            menuStrip1 = new MenuStrip();
            allPostsToolStripMenuItem = new ToolStripMenuItem();
            myProfileToolStripMenuItem = new ToolStripMenuItem();
            myPostsToolStripMenuItem = new ToolStripMenuItem();
            catalogsToolStripMenuItem = new ToolStripMenuItem();
            Container_Panel = new Panel();
            lab_user = new Label();
            btn_welcome = new Button();
            btn_Register = new Button();
            Btn_Login = new Button();
            Btn_Logout = new Button();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            Container_Panel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(menuStrip1);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1130, 24);
            panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { allPostsToolStripMenuItem, myProfileToolStripMenuItem, myPostsToolStripMenuItem, catalogsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1130, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // allPostsToolStripMenuItem
            // 
            allPostsToolStripMenuItem.Name = "allPostsToolStripMenuItem";
            allPostsToolStripMenuItem.Size = new Size(78, 24);
            allPostsToolStripMenuItem.Text = "All Posts";
            allPostsToolStripMenuItem.Click += allPostsToolStripMenuItem_Click;
            // 
            // myProfileToolStripMenuItem
            // 
            myProfileToolStripMenuItem.Name = "myProfileToolStripMenuItem";
            myProfileToolStripMenuItem.Size = new Size(90, 24);
            myProfileToolStripMenuItem.Text = "My Profile";
            myProfileToolStripMenuItem.Click += myProfileToolStripMenuItem_Click;
            // 
            // myPostsToolStripMenuItem
            // 
            myPostsToolStripMenuItem.Name = "myPostsToolStripMenuItem";
            myPostsToolStripMenuItem.Size = new Size(80, 24);
            myPostsToolStripMenuItem.Text = "My Posts";
            myPostsToolStripMenuItem.Click += myPostsToolStripMenuItem_Click;
            // 
            // catalogsToolStripMenuItem
            // 
            catalogsToolStripMenuItem.Name = "catalogsToolStripMenuItem";
            catalogsToolStripMenuItem.Size = new Size(81, 24);
            catalogsToolStripMenuItem.Text = "Catalogs";
            catalogsToolStripMenuItem.Click += catalogsToolStripMenuItem_Click;
            // 
            // Container_Panel
            // 
            Container_Panel.Controls.Add(lab_user);
            Container_Panel.Controls.Add(btn_welcome);
            Container_Panel.Controls.Add(btn_Register);
            Container_Panel.Controls.Add(Btn_Login);
            Container_Panel.Location = new Point(0, 46);
            Container_Panel.Name = "Container_Panel";
            Container_Panel.Size = new Size(1130, 677);
            Container_Panel.TabIndex = 1;
            // 
            // lab_user
            // 
            lab_user.AutoSize = true;
            lab_user.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lab_user.Location = new Point(378, 470);
            lab_user.Name = "lab_user";
            lab_user.Size = new Size(385, 25);
            lab_user.TabIndex = 39;
            lab_user.Text = "Default User : admin@gmail.com , admin123";
            lab_user.Visible = false;
            // 
            // btn_welcome
            // 
            btn_welcome.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_welcome.Location = new Point(259, 50);
            btn_welcome.Name = "btn_welcome";
            btn_welcome.Size = new Size(643, 101);
            btn_welcome.TabIndex = 38;
            btn_welcome.Text = "Welcome To Our Blog";
            btn_welcome.UseVisualStyleBackColor = true;
            btn_welcome.Visible = false;
            // 
            // btn_Register
            // 
            btn_Register.BackColor = Color.LawnGreen;
            btn_Register.Location = new Point(634, 335);
            btn_Register.Name = "btn_Register";
            btn_Register.Size = new Size(94, 44);
            btn_Register.TabIndex = 0;
            btn_Register.Text = "Register";
            btn_Register.UseVisualStyleBackColor = false;
            btn_Register.Click += btn_Register_Click;
            // 
            // Btn_Login
            // 
            Btn_Login.BackColor = Color.OrangeRed;
            Btn_Login.Location = new Point(426, 335);
            Btn_Login.Name = "Btn_Login";
            Btn_Login.Size = new Size(94, 44);
            Btn_Login.TabIndex = 1;
            Btn_Login.Text = "Login";
            Btn_Login.UseVisualStyleBackColor = false;
            Btn_Login.Click += Btn_Login_Click;
            // 
            // Btn_Logout
            // 
            Btn_Logout.BackColor = Color.Gold;
            Btn_Logout.Location = new Point(1026, 1);
            Btn_Logout.Name = "Btn_Logout";
            Btn_Logout.Size = new Size(104, 47);
            Btn_Logout.TabIndex = 2;
            Btn_Logout.Text = "Log out";
            Btn_Logout.UseVisualStyleBackColor = false;
            Btn_Logout.Visible = false;
            Btn_Logout.Click += Btn_Logout_Click;
            // 
            // Dashbord
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1130, 721);
            Controls.Add(Container_Panel);
            Controls.Add(Btn_Logout);
            Controls.Add(panel1);
            MainMenuStrip = menuStrip1;
            Name = "Dashbord";
            Text = "Dashbord";
            Load += Dashbord_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            Container_Panel.ResumeLayout(false);
            Container_Panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem myProfileToolStripMenuItem;
        private ToolStripMenuItem myPostsToolStripMenuItem;
        private ToolStripMenuItem allPostsToolStripMenuItem;
        private ToolStripMenuItem catalogsToolStripMenuItem;
        public Panel Container_Panel;
        private Button Btn_Logout;
        private Label lab_user;
        private Button btn_welcome;
        private Button btn_Register;
        private Button Btn_Login;
       
    }
}