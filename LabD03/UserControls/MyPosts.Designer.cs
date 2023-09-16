namespace LabD03.UserControls
{
    partial class MyPosts
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txt_Name = new TextBox();
            txt_Desc = new TextBox();
            txt_Bref = new TextBox();
            dgv = new DataGridView();
            Btn_Add = new Button();
            DataAndTime = new DateTimePicker();
            Btn_Edit = new Button();
            Btn_Upload = new Button();
            Pic_Box = new PictureBox();
            comb_Catalog = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            openFileDialog = new OpenFileDialog();
            Btn_Cancel = new Button();
            label8 = new Label();
            label9 = new Label();
            Btn_SaveChanges = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pic_Box).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 390);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 446);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 1;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 503);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 2;
            label3.Text = "Bref";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 573);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 3;
            label4.Text = "Catalog";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 640);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 4;
            label5.Text = "Data - Time";
            // 
            // txt_Name
            // 
            txt_Name.Location = new Point(165, 390);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(241, 27);
            txt_Name.TabIndex = 5;
            // 
            // txt_Desc
            // 
            txt_Desc.Location = new Point(165, 446);
            txt_Desc.Name = "txt_Desc";
            txt_Desc.Size = new Size(241, 27);
            txt_Desc.TabIndex = 6;
            // 
            // txt_Bref
            // 
            txt_Bref.Location = new Point(165, 503);
            txt_Bref.Name = "txt_Bref";
            txt_Bref.Size = new Size(241, 27);
            txt_Bref.TabIndex = 7;
            // 
            // dgv
            // 
            dgv.BackgroundColor = SystemColors.ControlLight;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(19, 60);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.RowTemplate.Height = 29;
            dgv.Size = new Size(1091, 301);
            dgv.TabIndex = 9;
            dgv.RowHeaderMouseDoubleClick += dgv_RowHeaderMouseDoubleClick;
            // 
            // Btn_Add
            // 
            Btn_Add.BackColor = Color.Lime;
            Btn_Add.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Add.Location = new Point(479, 570);
            Btn_Add.Name = "Btn_Add";
            Btn_Add.Size = new Size(216, 50);
            Btn_Add.TabIndex = 10;
            Btn_Add.Text = "Add New Post";
            Btn_Add.UseVisualStyleBackColor = false;
            Btn_Add.Click += Btn_Add_Click;
            // 
            // DataAndTime
            // 
            DataAndTime.Location = new Point(165, 635);
            DataAndTime.Name = "DataAndTime";
            DataAndTime.Size = new Size(241, 27);
            DataAndTime.TabIndex = 12;
            DataAndTime.Value = new DateTime(2023, 9, 15, 19, 32, 43, 0);
            // 
            // Btn_Edit
            // 
            Btn_Edit.BackColor = Color.Yellow;
            Btn_Edit.Location = new Point(972, 610);
            Btn_Edit.Name = "Btn_Edit";
            Btn_Edit.Size = new Size(111, 50);
            Btn_Edit.TabIndex = 13;
            Btn_Edit.Text = "Edit";
            Btn_Edit.UseVisualStyleBackColor = false;
            Btn_Edit.Click += Btn_Edit_Click;
            // 
            // Btn_Upload
            // 
            Btn_Upload.Location = new Point(532, 630);
            Btn_Upload.Name = "Btn_Upload";
            Btn_Upload.Size = new Size(104, 41);
            Btn_Upload.TabIndex = 14;
            Btn_Upload.Text = "Choose Img";
            Btn_Upload.UseVisualStyleBackColor = true;
            Btn_Upload.Click += Btn_Upload_Click;
            // 
            // Pic_Box
            // 
            Pic_Box.Location = new Point(454, 419);
            Pic_Box.Name = "Pic_Box";
            Pic_Box.Size = new Size(265, 205);
            Pic_Box.TabIndex = 15;
            Pic_Box.TabStop = false;
            // 
            // comb_Catalog
            // 
            comb_Catalog.FormattingEnabled = true;
            comb_Catalog.Location = new Point(165, 570);
            comb_Catalog.Name = "comb_Catalog";
            comb_Catalog.Size = new Size(241, 28);
            comb_Catalog.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(541, 390);
            label6.Name = "label6";
            label6.Size = new Size(82, 20);
            label6.TabIndex = 18;
            label6.Text = "Post Image";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(19, 0);
            label7.Name = "label7";
            label7.Size = new Size(203, 57);
            label7.TabIndex = 19;
            label7.Text = "My Posts";
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // Btn_Cancel
            // 
            Btn_Cancel.BackColor = Color.Red;
            Btn_Cancel.Location = new Point(822, 610);
            Btn_Cancel.Name = "Btn_Cancel";
            Btn_Cancel.Size = new Size(111, 50);
            Btn_Cancel.TabIndex = 20;
            Btn_Cancel.Text = "Cancel ";
            Btn_Cancel.UseVisualStyleBackColor = false;
            Btn_Cancel.Click += Btn_Cancel_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 25F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label8.ForeColor = Color.ForestGreen;
            label8.Location = new Point(295, 409);
            label8.Name = "label8";
            label8.Size = new Size(568, 57);
            label8.TabIndex = 36;
            label8.Text = "Double Click on Post To Open";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 28F, FontStyle.Italic, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(255, 128, 0);
            label9.Location = new Point(541, 485);
            label9.Name = "label9";
            label9.Size = new Size(69, 62);
            label9.TabIndex = 37;
            label9.Text = "or";
            // 
            // Btn_SaveChanges
            // 
            Btn_SaveChanges.BackColor = Color.LawnGreen;
            Btn_SaveChanges.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_SaveChanges.Location = new Point(867, 610);
            Btn_SaveChanges.Name = "Btn_SaveChanges";
            Btn_SaveChanges.Size = new Size(167, 50);
            Btn_SaveChanges.TabIndex = 38;
            Btn_SaveChanges.Text = "Save Changes";
            Btn_SaveChanges.UseVisualStyleBackColor = false;
            Btn_SaveChanges.Click += Btn_SaveChanges_Click;
            // 
            // MyPosts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Btn_SaveChanges);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(Btn_Cancel);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(comb_Catalog);
            Controls.Add(Pic_Box);
            Controls.Add(Btn_Upload);
            Controls.Add(Btn_Edit);
            Controls.Add(DataAndTime);
            Controls.Add(Btn_Add);
            Controls.Add(dgv);
            Controls.Add(txt_Bref);
            Controls.Add(txt_Desc);
            Controls.Add(txt_Name);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MyPosts";
            Size = new Size(1130, 691);
            Load += MyPosts_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pic_Box).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txt_Name;
        private TextBox txt_Desc;
        private TextBox txt_Bref;
        private TextBox textBox4;
        private DataGridView dgv;
        private Button Btn_Add;
        private DateTimePicker DataAndTime;
        private Button Btn_Edit;
        private Button Btn_Upload;
        private PictureBox Pic_Box;
        private ComboBox comb_Catalog;
        private Label label6;
        private Label label7;
        private OpenFileDialog openFileDialog;
        private Button Btn_Cancel;
        private Label label8;
        private Label label9;
        private Button Btn_SaveChanges;
    }
}
