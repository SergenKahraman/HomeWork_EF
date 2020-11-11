namespace HOmeWork06112020.EF
{
    partial class frmOrders
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
            this.components = new System.ComponentModel.Container();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.customerOrderDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerOrderMappingDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requiredDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Details = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerOrderDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerOrderMappingDtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.AutoGenerateColumns = false;
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderCodeDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.requiredDateDataGridViewTextBoxColumn,
            this.employeeNameDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn,
            this.Details});
            this.dgvOrders.DataSource = this.customerOrderMappingDtoBindingSource;
            this.dgvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrders.Location = new System.Drawing.Point(0, 0);
            this.dgvOrders.MultiSelect = false;
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.RowHeadersWidth = 51;
            this.dgvOrders.RowTemplate.Height = 24;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(991, 595);
            this.dgvOrders.TabIndex = 0;
            this.dgvOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrders_CellContentClick);
            // 
            // customerOrderDtoBindingSource
            // 
            this.customerOrderDtoBindingSource.DataSource = typeof(HOmeWork06112020.EF.Models.CustomerOrderDto);
            // 
            // customerOrderMappingDtoBindingSource
            // 
            this.customerOrderMappingDtoBindingSource.DataSource = typeof(HOmeWork06112020.EF.Models.CustomerOrderMappingDto);
            // 
            // orderCodeDataGridViewTextBoxColumn
            // 
            this.orderCodeDataGridViewTextBoxColumn.DataPropertyName = "OrderCode";
            this.orderCodeDataGridViewTextBoxColumn.HeaderText = "OrderCode";
            this.orderCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderCodeDataGridViewTextBoxColumn.Name = "orderCodeDataGridViewTextBoxColumn";
            this.orderCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            this.orderDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // requiredDateDataGridViewTextBoxColumn
            // 
            this.requiredDateDataGridViewTextBoxColumn.DataPropertyName = "RequiredDate";
            this.requiredDateDataGridViewTextBoxColumn.HeaderText = "RequiredDate";
            this.requiredDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.requiredDateDataGridViewTextBoxColumn.Name = "requiredDateDataGridViewTextBoxColumn";
            this.requiredDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeNameDataGridViewTextBoxColumn
            // 
            this.employeeNameDataGridViewTextBoxColumn.DataPropertyName = "EmployeeName";
            this.employeeNameDataGridViewTextBoxColumn.HeaderText = "EmployeeName";
            this.employeeNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeeNameDataGridViewTextBoxColumn.Name = "employeeNameDataGridViewTextBoxColumn";
            this.employeeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            this.totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Details
            // 
            this.Details.HeaderText = "View Details";
            this.Details.MinimumWidth = 6;
            this.Details.Name = "Details";
            this.Details.ReadOnly = true;
            this.Details.Text = "GO";
            this.Details.UseColumnTextForButtonValue = true;
            // 
            // frmOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 595);
            this.Controls.Add(this.dgvOrders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.frmOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerOrderDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerOrderMappingDtoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.BindingSource customerOrderDtoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requiredDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Details;
        private System.Windows.Forms.BindingSource customerOrderMappingDtoBindingSource;
    }
}