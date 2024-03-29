namespace SaleManagementWinApp
{
    partial class frmCategory
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
            lbCategoryId = new Label();
            lbCategoryName = new Label();
            txtCategoryId = new TextBox();
            txtCategoryName = new TextBox();
            lbCategoryDescription = new Label();
            txtCategoryDescription = new TextBox();
            lbCategoryNote = new Label();
            txtCategoryNote = new TextBox();
            btnSave = new Button();
            btnClose = new Button();
            numCategoryID = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numCategoryID).BeginInit();
            SuspendLayout();
            // 
            // lbCategoryId
            // 
            lbCategoryId.AutoSize = true;
            lbCategoryId.Location = new Point(33, 40);
            lbCategoryId.Name = "lbCategoryId";
            lbCategoryId.Size = new Size(69, 15);
            lbCategoryId.TabIndex = 0;
            lbCategoryId.Text = "Category ID";
            // 
            // lbCategoryName
            // 
            lbCategoryName.AutoSize = true;
            lbCategoryName.Location = new Point(60, 80);
            lbCategoryName.Name = "lbCategoryName";
            lbCategoryName.Size = new Size(39, 15);
            lbCategoryName.TabIndex = 1;
            lbCategoryName.Text = "Name";
            // 
            // txtCategoryId
            // 
            txtCategoryId.Enabled = false;
            txtCategoryId.Location = new Point(116, 37);
            txtCategoryId.Name = "txtCategoryId";
            txtCategoryId.Size = new Size(238, 23);
            txtCategoryId.TabIndex = 2;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(116, 77);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(238, 23);
            txtCategoryName.TabIndex = 3;
            // 
            // lbCategoryDescription
            // 
            lbCategoryDescription.AutoSize = true;
            lbCategoryDescription.Location = new Point(33, 120);
            lbCategoryDescription.Name = "lbCategoryDescription";
            lbCategoryDescription.Size = new Size(71, 15);
            lbCategoryDescription.TabIndex = 4;
            lbCategoryDescription.Text = "Description";
            // 
            // txtCategoryDescription
            // 
            txtCategoryDescription.Location = new Point(116, 117);
            txtCategoryDescription.Multiline = true;
            txtCategoryDescription.Name = "txtCategoryDescription";
            txtCategoryDescription.Size = new Size(238, 90);
            txtCategoryDescription.TabIndex = 5;
            // 
            // lbCategoryNote
            // 
            lbCategoryNote.AutoSize = true;
            lbCategoryNote.Location = new Point(33, 230);
            lbCategoryNote.Name = "lbCategoryNote";
            lbCategoryNote.Size = new Size(33, 15);
            lbCategoryNote.TabIndex = 6;
            lbCategoryNote.Text = "Note";
            // 
            // txtCategoryNote
            // 
            txtCategoryNote.Location = new Point(116, 227);
            txtCategoryNote.Multiline = true;
            txtCategoryNote.Name = "txtCategoryNote";
            txtCategoryNote.Size = new Size(238, 90);
            txtCategoryNote.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(116, 340);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(197, 340);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 9;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 381);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(txtCategoryNote);
            Controls.Add(lbCategoryNote);
            Controls.Add(txtCategoryDescription);
            Controls.Add(lbCategoryDescription);
            Controls.Add(txtCategoryName);
            Controls.Add(lbCategoryName);
            Controls.Add(txtCategoryId);
            Controls.Add(lbCategoryId);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmCategory";
            Load += frmCategory_Load;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCategory";
            ((System.ComponentModel.ISupportInitialize)numCategoryID).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Label lbCategoryId;
        private Label lbCategoryName;
        private TextBox txtCategoryId;
        private TextBox txtCategoryName;
        private Label lbCategoryDescription;
        private TextBox txtCategoryDescription;
        private Label lbCategoryNote;
        private TextBox txtCategoryNote;
        private Button btnSave;
        private Button btnClose;
        private NumericUpDown numCategoryID;
    }
}
