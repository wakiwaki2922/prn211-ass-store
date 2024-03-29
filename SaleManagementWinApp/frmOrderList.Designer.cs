namespace SaleManagementWinApp
{
    partial class frmOrderList
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
            dgvOrder = new DataGridView();
            pnlSearchByDate = new Panel();
            btnClear = new Button();
            btnReport = new Button();
            dtpEndDate = new DateTimePicker();
            dtpStartDate = new DateTimePicker();
            lbEndDate = new Label();
            lbStartDate = new Label();
            lbOrder = new Label();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            pnlSearchByDate.SuspendLayout();
            SuspendLayout();
            // 
            // dgvOrder
            // 
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Location = new Point(32, 49);
            dgvOrder.MultiSelect = false;
            dgvOrder.Name = "dgvOrder";
            dgvOrder.ReadOnly = true;
            dgvOrder.RowHeadersWidth = 51;
            dgvOrder.RowTemplate.Height = 24;
            dgvOrder.Size = new Size(470, 564);
            dgvOrder.TabIndex = 0;
            dgvOrder.CellClick += dgvOrder_CellClick;
            // 
            // pnlSearchByDate
            // 
            pnlSearchByDate.Controls.Add(btnClear);
            pnlSearchByDate.Controls.Add(btnReport);
            pnlSearchByDate.Controls.Add(dtpEndDate);
            pnlSearchByDate.Controls.Add(dtpStartDate);
            pnlSearchByDate.Controls.Add(lbEndDate);
            pnlSearchByDate.Controls.Add(lbStartDate);
            pnlSearchByDate.Location = new Point(539, 253);
            pnlSearchByDate.Name = "pnlSearchByDate";
            pnlSearchByDate.Size = new Size(434, 141);
            pnlSearchByDate.TabIndex = 2;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(289, 73);
            btnClear.Margin = new Padding(3, 2, 3, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(109, 43);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnReport
            // 
            btnReport.Location = new Point(289, 14);
            btnReport.Margin = new Padding(3, 2, 3, 2);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(109, 43);
            btnReport.TabIndex = 8;
            btnReport.Text = "Report";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(97, 81);
            dtpEndDate.Margin = new Padding(3, 2, 3, 2);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(154, 23);
            dtpEndDate.TabIndex = 7;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(97, 22);
            dtpStartDate.Margin = new Padding(3, 2, 3, 2);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(154, 23);
            dtpStartDate.TabIndex = 6;
            // 
            // lbEndDate
            // 
            lbEndDate.AutoSize = true;
            lbEndDate.Location = new Point(37, 81);
            lbEndDate.Name = "lbEndDate";
            lbEndDate.Size = new Size(54, 15);
            lbEndDate.TabIndex = 5;
            lbEndDate.Text = "End Date";
            // 
            // lbStartDate
            // 
            lbStartDate.AutoSize = true;
            lbStartDate.Location = new Point(33, 22);
            lbStartDate.Name = "lbStartDate";
            lbStartDate.Size = new Size(58, 15);
            lbStartDate.TabIndex = 4;
            lbStartDate.Text = "Start Date";
            // 
            // lbOrder
            // 
            lbOrder.AutoSize = true;
            lbOrder.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbOrder.Location = new Point(32, 9);
            lbOrder.Name = "lbOrder";
            lbOrder.Size = new Size(91, 37);
            lbOrder.TabIndex = 4;
            lbOrder.Text = "Order";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(521, 85);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(180, 48);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update Order";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(521, 23);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(180, 48);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete Order";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(733, 23);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(180, 48);
            btnClose.TabIndex = 8;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmOrderList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(972, 646);
            Controls.Add(btnClose);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(lbOrder);
            Controls.Add(pnlSearchByDate);
            Controls.Add(dgvOrder);
            Name = "frmOrderList";
            Text = "frmOrderList";
            Load += frmOrder_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            pnlSearchByDate.ResumeLayout(false);
            pnlSearchByDate.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvOrder;
        private Panel pnlSearchByDate;
        private Label lbOrder;
        private Button btnClear;
        private Button btnReport;
        private DateTimePicker dtpEndDate;
        private DateTimePicker dtpStartDate;
        private Label lbEndDate;
        private Label lbStartDate;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClose;
    }
}