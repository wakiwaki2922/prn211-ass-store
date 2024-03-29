namespace SaleManagementWinApp
{
    partial class frmCustomerList
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
            dgvCustomerList = new DataGridView();
            btnNew = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClose = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvCustomerList).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCustomerList
            // 
            dgvCustomerList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomerList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomerList.Dock = DockStyle.Left;
            dgvCustomerList.Location = new Point(0, 0);
            dgvCustomerList.Name = "dgvCustomerList";
            dgvCustomerList.Size = new Size(618, 450);
            dgvCustomerList.TabIndex = 0;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(40, 34);
            btnNew.Margin = new Padding(3, 2, 3, 2);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(110, 48);
            btnNew.TabIndex = 2;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(40, 118);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(110, 48);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(40, 202);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(110, 46);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(40, 285);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(110, 52);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnNew);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(616, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(184, 450);
            panel1.TabIndex = 6;
            // 
            // frmCustomerList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(dgvCustomerList);
            Name = "frmCustomerList";
            Text = "frmCustomerList";
            ((System.ComponentModel.ISupportInitialize)dgvCustomerList).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCustomerList;
        private Button btnNew;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClose;
        private Panel panel1;
    }
}