namespace SaleManagementWinApp
{
    partial class frmProduct
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
            lbCategoryID = new Label();
            lbName = new Label();
            txtName = new TextBox();
            lbDescription = new Label();
            txtDescription = new TextBox();
            lbUnitPrice = new Label();
            txtUnitPrice = new TextBox();
            lbUnitInStock = new Label();
            lbStatus = new Label();
            txtMorphology = new TextBox();
            btnAdd = new Button();
            btnClose = new Button();
            cbIsActive = new CheckBox();
            lbMorphology = new Label();
            lbSupplierID = new Label();
            lbProductID = new Label();
            txtProductID = new TextBox();
            cbCategoryID = new ComboBox();
            cbSupplierID = new ComboBox();
            numUnitInStock = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numUnitInStock).BeginInit();
            SuspendLayout();
            // 
            // lbCategoryID
            // 
            lbCategoryID.AutoSize = true;
            lbCategoryID.Location = new Point(33, 70);
            lbCategoryID.Name = "lbCategoryID";
            lbCategoryID.Size = new Size(69, 15);
            lbCategoryID.TabIndex = 0;
            lbCategoryID.Text = "Category ID";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(60, 103);
            lbName.Name = "lbName";
            lbName.Size = new Size(39, 15);
            lbName.TabIndex = 0;
            lbName.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(116, 98);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(238, 23);
            txtName.TabIndex = 1;
            // 
            // lbDescription
            // 
            lbDescription.AutoSize = true;
            lbDescription.Location = new Point(33, 170);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(67, 15);
            lbDescription.TabIndex = 0;
            lbDescription.Text = "Description";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(114, 170);
            txtDescription.Margin = new Padding(3, 2, 3, 2);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(588, 122);
            txtDescription.TabIndex = 1;
            // 
            // lbUnitPrice
            // 
            lbUnitPrice.AutoSize = true;
            lbUnitPrice.Location = new Point(400, 40);
            lbUnitPrice.Name = "lbUnitPrice";
            lbUnitPrice.Size = new Size(58, 15);
            lbUnitPrice.TabIndex = 0;
            lbUnitPrice.Text = "Unit Price";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(464, 37);
            txtUnitPrice.Margin = new Padding(3, 2, 3, 2);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(238, 23);
            txtUnitPrice.TabIndex = 1;
            // 
            // lbUnitInStock
            // 
            lbUnitInStock.AutoSize = true;
            lbUnitInStock.Location = new Point(385, 70);
            lbUnitInStock.Name = "lbUnitInStock";
            lbUnitInStock.Size = new Size(74, 15);
            lbUnitInStock.TabIndex = 0;
            lbUnitInStock.Text = "Unit In Stock";
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Location = new Point(419, 135);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(39, 15);
            lbStatus.TabIndex = 0;
            lbStatus.Text = "Status";
            // 
            // txtMorphology
            // 
            txtMorphology.Location = new Point(464, 95);
            txtMorphology.Margin = new Padding(3, 2, 3, 2);
            txtMorphology.Name = "txtMorphology";
            txtMorphology.Size = new Size(238, 23);
            txtMorphology.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(464, 308);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(82, 22);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Save";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(620, 308);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(82, 22);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // cbIsActive
            // 
            cbIsActive.AutoSize = true;
            cbIsActive.Location = new Point(464, 132);
            cbIsActive.Margin = new Padding(3, 2, 3, 2);
            cbIsActive.Name = "cbIsActive";
            cbIsActive.Size = new Size(59, 19);
            cbIsActive.TabIndex = 4;
            cbIsActive.Text = "Active";
            cbIsActive.UseVisualStyleBackColor = true;
            // 
            // lbMorphology
            // 
            lbMorphology.AutoSize = true;
            lbMorphology.Location = new Point(385, 101);
            lbMorphology.Name = "lbMorphology";
            lbMorphology.Size = new Size(73, 15);
            lbMorphology.TabIndex = 5;
            lbMorphology.Text = "Morphology";
            // 
            // lbSupplierID
            // 
            lbSupplierID.AutoSize = true;
            lbSupplierID.Location = new Point(38, 135);
            lbSupplierID.Name = "lbSupplierID";
            lbSupplierID.Size = new Size(64, 15);
            lbSupplierID.TabIndex = 0;
            lbSupplierID.Text = "Supplier ID";
            // 
            // lbProductID
            // 
            lbProductID.AutoSize = true;
            lbProductID.Location = new Point(39, 40);
            lbProductID.Name = "lbProductID";
            lbProductID.Size = new Size(63, 15);
            lbProductID.TabIndex = 0;
            lbProductID.Text = "Product ID";
            // 
            // txtProductID
            // 
            txtProductID.Enabled = false;
            txtProductID.Location = new Point(115, 37);
            txtProductID.Margin = new Padding(3, 2, 3, 2);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(239, 23);
            txtProductID.TabIndex = 1;
            // 
            // cbCategoryID
            // 
            cbCategoryID.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategoryID.FormattingEnabled = true;
            cbCategoryID.Location = new Point(115, 67);
            cbCategoryID.Margin = new Padding(3, 2, 3, 2);
            cbCategoryID.Name = "cbCategoryID";
            cbCategoryID.Size = new Size(238, 23);
            cbCategoryID.TabIndex = 6;
            // 
            // cbSupplierID
            // 
            cbSupplierID.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSupplierID.FormattingEnabled = true;
            cbSupplierID.Location = new Point(115, 132);
            cbSupplierID.Margin = new Padding(3, 2, 3, 2);
            cbSupplierID.Name = "cbSupplierID";
            cbSupplierID.Size = new Size(239, 23);
            cbSupplierID.TabIndex = 6;
            // 
            // numUnitInStock
            // 
            numUnitInStock.Location = new Point(464, 68);
            numUnitInStock.Margin = new Padding(3, 2, 3, 2);
            numUnitInStock.Name = "numUnitInStock";
            numUnitInStock.Size = new Size(238, 23);
            numUnitInStock.TabIndex = 7;
            // 
            // frmProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 359);
            Controls.Add(numUnitInStock);
            Controls.Add(cbSupplierID);
            Controls.Add(cbCategoryID);
            Controls.Add(lbMorphology);
            Controls.Add(cbIsActive);
            Controls.Add(btnClose);
            Controls.Add(btnAdd);
            Controls.Add(txtMorphology);
            Controls.Add(lbStatus);
            Controls.Add(lbUnitInStock);
            Controls.Add(lbSupplierID);
            Controls.Add(txtUnitPrice);
            Controls.Add(lbUnitPrice);
            Controls.Add(txtDescription);
            Controls.Add(lbDescription);
            Controls.Add(txtName);
            Controls.Add(lbName);
            Controls.Add(txtProductID);
            Controls.Add(lbProductID);
            Controls.Add(lbCategoryID);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmProduct";
            Load += frmProduct_Load;
            ((System.ComponentModel.ISupportInitialize)numUnitInStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCategoryID;
        private Label lbName;
        private TextBox txtName;
        private Label lbDescription;
        private TextBox txtDescription;
        private Label lbUnitPrice;
        private TextBox txtUnitPrice;
        private Label lbUnitInStock;
        private Label lbStatus;
        private TextBox txtMorphology;
        private Button btnAdd;
        private Button btnClose;
        private CheckBox cbIsActive;
        private Label lbMorphology;
        private Label lbSupplierID;
        private Label lbProductID;
        private TextBox txtProductID;
        private ComboBox cbCategoryID;
        private ComboBox cbSupplierID;
        private NumericUpDown numUnitInStock;
    }
}