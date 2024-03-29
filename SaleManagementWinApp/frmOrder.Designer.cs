namespace SaleManagementWinApp
{
    partial class frmOrder
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
            lbOrderID = new Label();
            txtOrderID = new TextBox();
            lbCustomerID = new Label();
            txtCustomerID = new TextBox();
            lbOrderDate = new Label();
            lbShippedDate = new Label();
            lbTotal = new Label();
            txtTotal = new TextBox();
            lbOrderStatus = new Label();
            dtpOrderDate = new DateTimePicker();
            dtpShippedDate = new DateTimePicker();
            cbOrderStatus = new CheckBox();
            btnSave = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lbOrderID
            // 
            lbOrderID.AutoSize = true;
            lbOrderID.Location = new Point(47, 36);
            lbOrderID.Name = "lbOrderID";
            lbOrderID.Size = new Size(51, 15);
            lbOrderID.TabIndex = 0;
            lbOrderID.Text = "Order ID";
            // 
            // txtOrderID
            // 
            txtOrderID.Enabled = false;
            txtOrderID.Location = new Point(110, 34);
            txtOrderID.Margin = new Padding(3, 2, 3, 2);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new Size(175, 23);
            txtOrderID.TabIndex = 1;
            // 
            // lbCustomerID
            // 
            lbCustomerID.AutoSize = true;
            lbCustomerID.Location = new Point(25, 64);
            lbCustomerID.Name = "lbCustomerID";
            lbCustomerID.Size = new Size(73, 15);
            lbCustomerID.TabIndex = 0;
            lbCustomerID.Text = "Customer ID";
            // 
            // txtCustomerID
            // 
            txtCustomerID.Enabled = false;
            txtCustomerID.Location = new Point(110, 61);
            txtCustomerID.Margin = new Padding(3, 2, 3, 2);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(175, 23);
            txtCustomerID.TabIndex = 1;
            // 
            // lbOrderDate
            // 
            lbOrderDate.AutoSize = true;
            lbOrderDate.Location = new Point(34, 88);
            lbOrderDate.Name = "lbOrderDate";
            lbOrderDate.Size = new Size(64, 15);
            lbOrderDate.TabIndex = 0;
            lbOrderDate.Text = "Order Date";
            // 
            // lbShippedDate
            // 
            lbShippedDate.AutoSize = true;
            lbShippedDate.Location = new Point(21, 115);
            lbShippedDate.Name = "lbShippedDate";
            lbShippedDate.Size = new Size(77, 15);
            lbShippedDate.TabIndex = 0;
            lbShippedDate.Text = "Shipped Date";
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Location = new Point(342, 37);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(32, 15);
            lbTotal.TabIndex = 0;
            lbTotal.Text = "Total";
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Location = new Point(380, 34);
            txtTotal.Margin = new Padding(3, 2, 3, 2);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(175, 23);
            txtTotal.TabIndex = 1;
            // 
            // lbOrderStatus
            // 
            lbOrderStatus.AutoSize = true;
            lbOrderStatus.Location = new Point(302, 64);
            lbOrderStatus.Name = "lbOrderStatus";
            lbOrderStatus.Size = new Size(72, 15);
            lbOrderStatus.TabIndex = 0;
            lbOrderStatus.Text = "Order Status";
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.Enabled = false;
            dtpOrderDate.Location = new Point(110, 88);
            dtpOrderDate.Margin = new Padding(3, 2, 3, 2);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(175, 23);
            dtpOrderDate.TabIndex = 2;
            // 
            // dtpShippedDate
            // 
            dtpShippedDate.Location = new Point(111, 115);
            dtpShippedDate.Margin = new Padding(3, 2, 3, 2);
            dtpShippedDate.Name = "dtpShippedDate";
            dtpShippedDate.Size = new Size(174, 23);
            dtpShippedDate.TabIndex = 2;
            // 
            // cbOrderStatus
            // 
            cbOrderStatus.AutoSize = true;
            cbOrderStatus.Location = new Point(380, 65);
            cbOrderStatus.Margin = new Padding(3, 2, 3, 2);
            cbOrderStatus.Name = "cbOrderStatus";
            cbOrderStatus.Size = new Size(86, 19);
            cbOrderStatus.TabIndex = 3;
            cbOrderStatus.Text = "is Delivered";
            cbOrderStatus.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(380, 90);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(82, 40);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(473, 90);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(82, 40);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 164);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(cbOrderStatus);
            Controls.Add(dtpShippedDate);
            Controls.Add(dtpOrderDate);
            Controls.Add(lbOrderStatus);
            Controls.Add(txtTotal);
            Controls.Add(lbTotal);
            Controls.Add(lbShippedDate);
            Controls.Add(lbOrderDate);
            Controls.Add(txtCustomerID);
            Controls.Add(lbCustomerID);
            Controls.Add(txtOrderID);
            Controls.Add(lbOrderID);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmOrder";
            Load += frmOrder_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbOrderID;
        private TextBox txtOrderID;
        private Label lbCustomerID;
        private TextBox txtCustomerID;
        private Label lbOrderDate;
        private Label lbShippedDate;
        private Label lbTotal;
        private TextBox txtTotal;
        private Label lbOrderStatus;
        private DateTimePicker dtpOrderDate;
        private DateTimePicker dtpShippedDate;
        private CheckBox cbOrderStatus;
        private Button btnSave;
        private Button btnClose;
    }
}