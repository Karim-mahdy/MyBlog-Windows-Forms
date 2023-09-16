namespace LabD03.UserControls
{
    partial class MyProfile
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txt_Email = new TextBox();
            txt_userName = new TextBox();
            txt_Password = new TextBox();
            txt_confirmPass = new TextBox();
            num_Age = new NumericUpDown();
            Btn_SaveChanges = new Button();
            Btn_Edit = new Button();
            Pic_Box = new PictureBox();
            label6 = new Label();
            label1 = new Label();
            Btn_upload = new Button();
            openFileDialog = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)num_Age).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pic_Box).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 381);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 1;
            label2.Text = "Age";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(76, 457);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(76, 531);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(76, 599);
            label5.Name = "label5";
            label5.Size = new Size(127, 20);
            label5.TabIndex = 4;
            label5.Text = "Confirm Password";
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(312, 450);
            txt_Email.Name = "txt_Email";
            txt_Email.ReadOnly = true;
            txt_Email.Size = new Size(240, 27);
            txt_Email.TabIndex = 5;
            // 
            // txt_userName
            // 
            txt_userName.Location = new Point(312, 298);
            txt_userName.Name = "txt_userName";
            txt_userName.ReadOnly = true;
            txt_userName.Size = new Size(240, 27);
            txt_userName.TabIndex = 6;
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(312, 524);
            txt_Password.Name = "txt_Password";
            txt_Password.PasswordChar = '*';
            txt_Password.ReadOnly = true;
            txt_Password.Size = new Size(240, 27);
            txt_Password.TabIndex = 7;
            txt_Password.UseSystemPasswordChar = true;
            // 
            // txt_confirmPass
            // 
            txt_confirmPass.Location = new Point(312, 596);
            txt_confirmPass.Name = "txt_confirmPass";
            txt_confirmPass.PasswordChar = '*';
            txt_confirmPass.ReadOnly = true;
            txt_confirmPass.Size = new Size(240, 27);
            txt_confirmPass.TabIndex = 8;
            txt_confirmPass.UseSystemPasswordChar = true;
            // 
            // num_Age
            // 
            num_Age.Enabled = false;
            num_Age.Location = new Point(312, 374);
            num_Age.Name = "num_Age";
            num_Age.ReadOnly = true;
            num_Age.Size = new Size(240, 27);
            num_Age.TabIndex = 9;
            // 
            // Btn_SaveChanges
            // 
            Btn_SaveChanges.BackColor = Color.LimeGreen;
            Btn_SaveChanges.Location = new Point(963, 560);
            Btn_SaveChanges.Name = "Btn_SaveChanges";
            Btn_SaveChanges.Size = new Size(144, 67);
            Btn_SaveChanges.TabIndex = 10;
            Btn_SaveChanges.Text = "Save Changes";
            Btn_SaveChanges.UseVisualStyleBackColor = false;
            Btn_SaveChanges.Click += Btn_SaveChanges_Click;
            // 
            // Btn_Edit
            // 
            Btn_Edit.BackColor = Color.OliveDrab;
            Btn_Edit.Location = new Point(786, 560);
            Btn_Edit.Name = "Btn_Edit";
            Btn_Edit.Size = new Size(149, 67);
            Btn_Edit.TabIndex = 11;
            Btn_Edit.Text = "Edit";
            Btn_Edit.UseVisualStyleBackColor = false;
            Btn_Edit.Click += Btn_Edit_Click;
            // 
            // Pic_Box
            // 
            Pic_Box.Location = new Point(739, 49);
            Pic_Box.Name = "Pic_Box";
            Pic_Box.Size = new Size(326, 323);
            Pic_Box.TabIndex = 12;
            Pic_Box.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(76, 49);
            label6.Name = "label6";
            label6.Size = new Size(273, 67);
            label6.TabIndex = 14;
            label6.Text = "My Profile";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 305);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 15;
            label1.Text = "Name";
            // 
            // Btn_upload
            // 
            Btn_upload.Location = new Point(840, 381);
            Btn_upload.Name = "Btn_upload";
            Btn_upload.Size = new Size(129, 42);
            Btn_upload.TabIndex = 16;
            Btn_upload.Text = "Chose Picture";
            Btn_upload.UseVisualStyleBackColor = true;
            Btn_upload.Visible = false;
            Btn_upload.Click += Btn_upload_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // MyProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Btn_upload);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(Pic_Box);
            Controls.Add(Btn_Edit);
            Controls.Add(Btn_SaveChanges);
            Controls.Add(num_Age);
            Controls.Add(txt_confirmPass);
            Controls.Add(txt_Password);
            Controls.Add(txt_userName);
            Controls.Add(txt_Email);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "MyProfile";
            Size = new Size(1130, 691);
            Load += MyProfile_Load;
            ((System.ComponentModel.ISupportInitialize)num_Age).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pic_Box).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txt_Email;
        private TextBox txt_userName;
        private TextBox txt_Password;
        private TextBox txt_confirmPass;
        private NumericUpDown num_Age;
        private Button Btn_SaveChanges;
        private Button Btn_Edit;
        private PictureBox pictureBox1;
        private Label label6;
        private Label label1;
        private PictureBox Pic_Box;
        private Button Btn_upload;
        private OpenFileDialog openFileDialog;
    }
}
