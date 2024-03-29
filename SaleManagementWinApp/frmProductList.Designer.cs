namespace SaleManagementWinApp
{
    partial class frmProductList
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
            dgvProductList = new DataGridView();
            pnlControl = new Panel();
            btnClose = new Button();
            btnOrder = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnNew = new Button();
            pnlSearch = new Panel();
            txtSearch = new TextBox();
            gbSearch = new GroupBox();
            rbProductName = new RadioButton();
            rbProductID = new RadioButton();
            lbSearch = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProductList).BeginInit();
            pnlControl.SuspendLayout();
            pnlSearch.SuspendLayout();
            gbSearch.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProductList
            // 
            dgvProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductList.Location = new Point(1, 0);
            dgvProductList.Name = "dgvProductList";
            dgvProductList.Size = new Size(551, 450);
            dgvProductList.TabIndex = 0;
            // 
            // pnlControl
            // 
            pnlControl.Controls.Add(btnClose);
            pnlControl.Controls.Add(btnOrder);
            pnlControl.Controls.Add(btnDelete);
            pnlControl.Controls.Add(btnUpdate);
            pnlControl.Controls.Add(btnNew);
            pnlControl.Location = new Point(558, 137);
            pnlControl.Name = "pnlControl";
            pnlControl.Size = new Size(243, 313);
            pnlControl.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(20, 184);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(199, 56);
            btnClose.TabIndex = 12;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(137, 103);
            btnOrder.Margin = new Padding(3, 2, 3, 2);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(82, 53);
            btnOrder.TabIndex = 11;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(137, 25);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 53);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(20, 103);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(82, 53);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(20, 25);
            btnNew.Margin = new Padding(3, 2, 3, 2);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(82, 53);
            btnNew.TabIndex = 7;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // pnlSearch
            // 
            pnlSearch.Controls.Add(txtSearch);
            pnlSearch.Controls.Add(gbSearch);
            pnlSearch.Controls.Add(lbSearch);
            pnlSearch.Location = new Point(558, 0);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(243, 131);
            pnlSearch.TabIndex = 2;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(48, 6);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(184, 23);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // gbSearch
            // 
            gbSearch.Controls.Add(rbProductName);
            gbSearch.Controls.Add(rbProductID);
            gbSearch.Location = new Point(3, 34);
            gbSearch.Name = "gbSearch";
            gbSearch.Size = new Size(237, 94);
            gbSearch.TabIndex = 4;
            gbSearch.TabStop = false;
            gbSearch.Text = "Choose search type";
            // 
            // rbProductName
            // 
            rbProductName.AutoSize = true;
            rbProductName.Checked = true;
            rbProductName.Location = new Point(125, 37);
            rbProductName.Margin = new Padding(3, 2, 3, 2);
            rbProductName.Name = "rbProductName";
            rbProductName.Size = new Size(102, 19);
            rbProductName.TabIndex = 4;
            rbProductName.TabStop = true;
            rbProductName.Text = "Product Name";
            rbProductName.UseVisualStyleBackColor = true;
            // 
            // rbProductID
            // 
            rbProductID.AutoSize = true;
            rbProductID.Location = new Point(6, 37);
            rbProductID.Margin = new Padding(3, 2, 3, 2);
            rbProductID.Name = "rbProductID";
            rbProductID.Size = new Size(81, 19);
            rbProductID.TabIndex = 3;
            rbProductID.TabStop = true;
            rbProductID.Text = "Product ID";
            rbProductID.UseVisualStyleBackColor = true;
            // 
            // lbSearch
            // 
            lbSearch.AutoSize = true;
            lbSearch.Location = new Point(3, 9);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new Size(42, 15);
            lbSearch.TabIndex = 1;
            lbSearch.Text = "Search";
            // 
            // frmProductList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlSearch);
            Controls.Add(pnlControl);
            Controls.Add(dgvProductList);
            Name = "frmProductList";
            Text = "frmProductList";
            Load += frmProductList_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductList).EndInit();
            pnlControl.ResumeLayout(false);
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            gbSearch.ResumeLayout(false);
            gbSearch.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProductList;
        private Panel pnlControl;
        private Panel pnlSearch;
        private Button btnClose;
        private Button btnOrder;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnNew;
        private TextBox txtSearch;
        private GroupBox gbSearch;
        private RadioButton rbProductName;
        private RadioButton rbProductID;
        private Label lbSearch;
    }
}