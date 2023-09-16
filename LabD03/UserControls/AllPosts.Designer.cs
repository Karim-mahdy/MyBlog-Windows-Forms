namespace LabD03.UserControls
{
    partial class AllPosts
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
            dgv = new DataGridView();
            Btn_Filter = new Button();
            label6 = new Label();
            comb_Catalog1 = new ComboBox();
            Pic_Box = new PictureBox();
            Btn_Upload = new Button();
            DataAndTime = new DateTimePicker();
            txt_Bref = new TextBox();
            txt_Desc = new TextBox();
            txt_Name = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label7 = new Label();
            Btn_Edit = new Button();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pic_Box).BeginInit();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(12, 63);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.RowTemplate.Height = 29;
            dgv.Size = new Size(1101, 300);
            dgv.TabIndex = 0;
            dgv.RowHeaderMouseDoubleClick += dgv_RowHeaderMouseDoubleClick;
            // 
            // Btn_Filter
            // 
            Btn_Filter.BackColor = Color.Tomato;
            Btn_Filter.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_Filter.Location = new Point(281, 6);
            Btn_Filter.Name = "Btn_Filter";
            Btn_Filter.Size = new Size(175, 51);
            Btn_Filter.TabIndex = 2;
            Btn_Filter.Text = "Filter : My Postes";
            Btn_Filter.UseVisualStyleBackColor = false;
            Btn_Filter.Click += Btn_Filter_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(484, 395);
            label6.Name = "label6";
            label6.Size = new Size(82, 20);
            label6.TabIndex = 33;
            label6.Text = "Post Image";
            // 
            // comb_Catalog1
            // 
            comb_Catalog1.FormattingEnabled = true;
            comb_Catalog1.Location = new Point(169, 568);
            comb_Catalog1.Name = "comb_Catalog1";
            comb_Catalog1.Size = new Size(241, 28);
            comb_Catalog1.TabIndex = 32;
            // 
            // Pic_Box
            // 
            Pic_Box.Enabled = false;
            Pic_Box.Location = new Point(594, 395);
            Pic_Box.Name = "Pic_Box";
            Pic_Box.Size = new Size(399, 269);
            Pic_Box.TabIndex = 31;
            Pic_Box.TabStop = false;
            // 
            // Btn_Upload
            // 
            Btn_Upload.Location = new Point(474, 444);
            Btn_Upload.Name = "Btn_Upload";
            Btn_Upload.Size = new Size(104, 41);
            Btn_Upload.TabIndex = 30;
            Btn_Upload.Text = "Choose Img";
            Btn_Upload.UseVisualStyleBackColor = true;
            Btn_Upload.Visible = false;
            // 
            // DataAndTime
            // 
            DataAndTime.Enabled = false;
            DataAndTime.Location = new Point(169, 633);
            DataAndTime.Name = "DataAndTime";
            DataAndTime.Size = new Size(241, 27);
            DataAndTime.TabIndex = 28;
            DataAndTime.Value = new DateTime(2023, 9, 15, 19, 32, 43, 0);
            // 
            // txt_Bref
            // 
            txt_Bref.Location = new Point(169, 501);
            txt_Bref.Name = "txt_Bref";
            txt_Bref.ReadOnly = true;
            txt_Bref.Size = new Size(241, 27);
            txt_Bref.TabIndex = 26;
            // 
            // txt_Desc
            // 
            txt_Desc.Location = new Point(169, 444);
            txt_Desc.Name = "txt_Desc";
            txt_Desc.ReadOnly = true;
            txt_Desc.Size = new Size(241, 27);
            txt_Desc.TabIndex = 25;
            // 
            // txt_Name
            // 
            txt_Name.Location = new Point(169, 388);
            txt_Name.Name = "txt_Name";
            txt_Name.ReadOnly = true;
            txt_Name.Size = new Size(241, 27);
            txt_Name.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 638);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 23;
            label5.Text = "Data - Time";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 571);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 22;
            label4.Text = "Catalog";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 501);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 21;
            label3.Text = "Bref";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 444);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 20;
            label2.Text = "Description";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 388);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 19;
            label1.Text = "Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(12, 9);
            label7.Name = "label7";
            label7.Size = new Size(253, 35);
            label7.TabIndex = 34;
            label7.Text = "Welcome : All Posts ";
            // 
            // Btn_Edit
            // 
            Btn_Edit.Location = new Point(1016, 633);
            Btn_Edit.Name = "Btn_Edit";
            Btn_Edit.Size = new Size(111, 50);
            Btn_Edit.TabIndex = 29;
            Btn_Edit.Text = "Edit";
            Btn_Edit.UseVisualStyleBackColor = true;
            Btn_Edit.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 20F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label8.ForeColor = Color.ForestGreen;
            label8.Location = new Point(328, 488);
            label8.Name = "label8";
            label8.Size = new Size(457, 46);
            label8.TabIndex = 35;
            label8.Text = "Double Click on Post To Open";
            // 
            // AllPosts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(comb_Catalog1);
            Controls.Add(Pic_Box);
            Controls.Add(Btn_Upload);
            Controls.Add(Btn_Edit);
            Controls.Add(DataAndTime);
            Controls.Add(txt_Bref);
            Controls.Add(txt_Desc);
            Controls.Add(txt_Name);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Btn_Filter);
            Controls.Add(dgv);
            Name = "AllPosts";
            Size = new Size(1130, 691);
            Load += AllPosts_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pic_Box).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv;
        private Button Btn_Filter;
        private Label label6;
        private ComboBox comb_Catalog1;
        private PictureBox Pic_Box;
        private Button Btn_Upload;
        private DateTimePicker DataAndTime;
        private TextBox txt_Bref;
        private TextBox txt_Desc;
        private TextBox txt_Name;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private Button Btn_Edit;
        private Label label8;
    }
}
