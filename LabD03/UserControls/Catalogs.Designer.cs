namespace LabD03.UserControls
{
    partial class Catalogs
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
            txt_Description = new TextBox();
            label3 = new Label();
            dgv = new DataGridView();
            txt_Name = new TextBox();
            Btn_Edit = new Button();
            Btn_Add = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // txt_Description
            // 
            txt_Description.Location = new Point(213, 408);
            txt_Description.Name = "txt_Description";
            txt_Description.Size = new Size(288, 27);
            txt_Description.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(26, 58);
            label3.Name = "label3";
            label3.Size = new Size(195, 57);
            label3.TabIndex = 15;
            label3.Text = "Catalogs";
            // 
            // dgv
            // 
            dgv.BackgroundColor = SystemColors.ControlLight;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(635, 231);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.RowTemplate.Height = 29;
            dgv.Size = new Size(429, 204);
            dgv.TabIndex = 14;
            dgv.RowHeaderMouseDoubleClick += dgv_RowHeaderMouseDoubleClick;
            // 
            // txt_Name
            // 
            txt_Name.Location = new Point(213, 238);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(288, 27);
            txt_Name.TabIndex = 13;
            // 
            // Btn_Edit
            // 
            Btn_Edit.BackColor = Color.Goldenrod;
            Btn_Edit.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_Edit.Location = new Point(513, 508);
            Btn_Edit.Name = "Btn_Edit";
            Btn_Edit.Size = new Size(132, 57);
            Btn_Edit.TabIndex = 12;
            Btn_Edit.Text = "Edit";
            Btn_Edit.UseVisualStyleBackColor = false;
            Btn_Edit.Click += Btn_Edit_Click;
            // 
            // Btn_Add
            // 
            Btn_Add.BackColor = Color.LimeGreen;
            Btn_Add.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_Add.Location = new Point(513, 508);
            Btn_Add.Name = "Btn_Add";
            Btn_Add.Size = new Size(132, 57);
            Btn_Add.TabIndex = 11;
            Btn_Add.Text = "Add";
            Btn_Add.UseVisualStyleBackColor = false;
            Btn_Add.Click += Btn_Add_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 245);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 17;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 415);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 18;
            label2.Text = "Description";
            // 
            // Catalogs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_Description);
            Controls.Add(label3);
            Controls.Add(dgv);
            Controls.Add(txt_Name);
            Controls.Add(Btn_Edit);
            Controls.Add(Btn_Add);
            Name = "Catalogs";
            Size = new Size(1130, 691);
            Load += Catalogs_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Description;
        private Label label3;
        private DataGridView dgv;
        private TextBox txt_Name;
        private Button Btn_Edit;
        private Button Btn_Add;
        private Label label1;
        private Label label2;
    }
}
