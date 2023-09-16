namespace LabD03.UserControls
{
    partial class Register
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
            num_Age = new NumericUpDown();
            label6 = new Label();
            txt_ConfirmPass = new TextBox();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            Btn_Add_img = new Button();
            Btn_SignUp = new Button();
            pictureBox = new PictureBox();
            txt_Password = new TextBox();
            txt_Email = new TextBox();
            txt_userName = new TextBox();
            label3 = new Label();
            btn_welcome = new Button();
            ((System.ComponentModel.ISupportInitialize)num_Age).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // num_Age
            // 
            num_Age.Location = new Point(246, 445);
            num_Age.Name = "num_Age";
            num_Age.Size = new Size(191, 27);
            num_Age.TabIndex = 36;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(48, 612);
            label6.Name = "label6";
            label6.Size = new Size(127, 20);
            label6.TabIndex = 35;
            label6.Text = "Confirm Password";
            // 
            // txt_ConfirmPass
            // 
            txt_ConfirmPass.Location = new Point(246, 609);
            txt_ConfirmPass.Name = "txt_ConfirmPass";
            txt_ConfirmPass.PasswordChar = '*';
            txt_ConfirmPass.Size = new Size(191, 27);
            txt_ConfirmPass.TabIndex = 34;
            txt_ConfirmPass.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(554, 277);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 33;
            label5.Text = "Picture";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 363);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 32;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 277);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 31;
            label1.Text = "User Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 532);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 30;
            label4.Text = "Password";
            // 
            // Btn_Add_img
            // 
            Btn_Add_img.Location = new Point(538, 354);
            Btn_Add_img.Name = "Btn_Add_img";
            Btn_Add_img.Size = new Size(94, 29);
            Btn_Add_img.TabIndex = 29;
            Btn_Add_img.Text = "Add Img";
            Btn_Add_img.UseVisualStyleBackColor = true;
            Btn_Add_img.Click += Btn_Add_img_Click_1;
            // 
            // Btn_SignUp
            // 
            Btn_SignUp.BackColor = Color.Lime;
            Btn_SignUp.Location = new Point(951, 609);
            Btn_SignUp.Name = "Btn_SignUp";
            Btn_SignUp.Size = new Size(126, 54);
            Btn_SignUp.TabIndex = 28;
            Btn_SignUp.Text = "Sign Up";
            Btn_SignUp.UseVisualStyleBackColor = false;
            Btn_SignUp.Click += Btn_SignUp_Click;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(653, 259);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(314, 293);
            pictureBox.TabIndex = 25;
            pictureBox.TabStop = false;
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(246, 525);
            txt_Password.Name = "txt_Password";
            txt_Password.PasswordChar = '*';
            txt_Password.Size = new Size(191, 27);
            txt_Password.TabIndex = 24;
            txt_Password.UseSystemPasswordChar = true;
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(246, 363);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(191, 27);
            txt_Email.TabIndex = 23;
            // 
            // txt_userName
            // 
            txt_userName.Location = new Point(246, 274);
            txt_userName.Name = "txt_userName";
            txt_userName.Size = new Size(191, 27);
            txt_userName.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 447);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 21;
            label3.Text = "Age";
            // 
            // btn_welcome
            // 
            btn_welcome.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_welcome.Location = new Point(246, 45);
            btn_welcome.Name = "btn_welcome";
            btn_welcome.Size = new Size(643, 101);
            btn_welcome.TabIndex = 43;
            btn_welcome.Text = "Welcome To Our Blog";
            btn_welcome.UseVisualStyleBackColor = true;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_welcome);
            Controls.Add(num_Age);
            Controls.Add(label6);
            Controls.Add(txt_ConfirmPass);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(Btn_Add_img);
            Controls.Add(Btn_SignUp);
            Controls.Add(pictureBox);
            Controls.Add(txt_Password);
            Controls.Add(txt_Email);
            Controls.Add(txt_userName);
            Controls.Add(label3);
            Name = "Register";
            Size = new Size(1130, 691);
            ((System.ComponentModel.ISupportInitialize)num_Age).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown num_Age;
        private Label label6;
        private TextBox txt_ConfirmPass;
        private Label label5;
        private Label label2;
        private Label label1;
        private Label label4;
        private Button Btn_Add_img;
        private Button Btn_SignUp;

        private PictureBox pictureBox;
        private TextBox txt_Password;
        private TextBox txt_Email;
        private TextBox txt_userName;
        private Label label3;
        private Button button2;
        private Button btn_welcome;
    }
}
