namespace LabD03.UserControls
{
    partial class Login
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
            Btn_SignIn = new Button();
            label2 = new Label();
            txt_Email = new TextBox();
            label4 = new Label();
            txt_Password = new TextBox();
            lab_user = new Label();
            btn_welcome = new Button();
            SuspendLayout();
            // 
            // Btn_SignIn
            // 
            Btn_SignIn.BackColor = Color.FromArgb(255, 128, 0);
            Btn_SignIn.Location = new Point(512, 506);
            Btn_SignIn.Name = "Btn_SignIn";
            Btn_SignIn.Size = new Size(166, 54);
            Btn_SignIn.TabIndex = 28;
            Btn_SignIn.Text = "Sign In";
            Btn_SignIn.UseVisualStyleBackColor = false;
            Btn_SignIn.Click += Btn_SignIn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(385, 304);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 34;
            label2.Text = "Email";
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(563, 297);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(191, 27);
            txt_Email.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(385, 403);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 36;
            label4.Text = "Password";
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(563, 400);
            txt_Password.Name = "txt_Password";
            txt_Password.PasswordChar = '*';
            txt_Password.Size = new Size(191, 27);
            txt_Password.TabIndex = 35;
            txt_Password.UseSystemPasswordChar = true;
            // 
            // lab_user
            // 
            lab_user.AutoSize = true;
            lab_user.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lab_user.Location = new Point(385, 608);
            lab_user.Name = "lab_user";
            lab_user.Size = new Size(385, 25);
            lab_user.TabIndex = 44;
            lab_user.Text = "Default User : admin@gmail.com , admin123";
            // 
            // btn_welcome
            // 
            btn_welcome.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_welcome.Location = new Point(245, 91);
            btn_welcome.Name = "btn_welcome";
            btn_welcome.Size = new Size(643, 101);
            btn_welcome.TabIndex = 45;
            btn_welcome.Text = "Welcome To Our Blog";
            btn_welcome.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_welcome);
            Controls.Add(lab_user);
            Controls.Add(label4);
            Controls.Add(txt_Password);
            Controls.Add(label2);
            Controls.Add(txt_Email);
            Controls.Add(Btn_SignIn);
            Name = "Login";
            Size = new Size(1130, 691);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_SignIn;
        private Label label2;
        private TextBox txt_Email;
        private Label label4;
        private TextBox txt_Password;

        private Button button2;
        private Label lab_user;
        private Button btn_welcome;
    }
}
