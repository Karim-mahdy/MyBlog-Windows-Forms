namespace LabD03.UserControls
{
    partial class Welcome
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lab_user = new Label();
            btn_welcome = new Button();
            btn_Register = new Button();
            Btn_Login = new Button();
            SuspendLayout();
            // 
            // lab_user
            // 
            lab_user.AutoSize = true;
            lab_user.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lab_user.Location = new Point(393, 524);
            lab_user.Name = "lab_user";
            lab_user.Size = new Size(385, 25);
            lab_user.TabIndex = 43;
            lab_user.Text = "Default User : admin@gmail.com , admin123";
            // 
            // btn_welcome
            // 
            btn_welcome.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_welcome.Location = new Point(249, 113);
            btn_welcome.Name = "btn_welcome";
            btn_welcome.Size = new Size(643, 101);
            btn_welcome.TabIndex = 42;
            btn_welcome.Text = "Welcome To Our Blog";
            btn_welcome.UseVisualStyleBackColor = true;
            // 
            // btn_Register
            // 
            btn_Register.BackColor = Color.LawnGreen;
            btn_Register.Location = new Point(631, 378);
            btn_Register.Name = "btn_Register";
            btn_Register.Size = new Size(94, 44);
            btn_Register.TabIndex = 40;
            btn_Register.Text = "Register";
            btn_Register.UseVisualStyleBackColor = false;
            btn_Register.Click += btn_Register_Click;
            // 
            // Btn_Login
            // 
            Btn_Login.BackColor = Color.OrangeRed;
            Btn_Login.Location = new Point(428, 378);
            Btn_Login.Name = "Btn_Login";
            Btn_Login.Size = new Size(94, 44);
            Btn_Login.TabIndex = 41;
            Btn_Login.Text = "Login";
            Btn_Login.UseVisualStyleBackColor = false;
            Btn_Login.Click += Btn_Login_Click;
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lab_user);
            Controls.Add(btn_welcome);
            Controls.Add(btn_Register);
            Controls.Add(Btn_Login);
            Name = "Welcome";
            Size = new Size(1130, 691);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lab_user;
        private Button btn_welcome;
        private Button btn_Register;
        private Button Btn_Login;
    }
}
