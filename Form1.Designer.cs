namespace dbms
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridClients1;
        private System.Windows.Forms.DataGridView dataGridPurchaseOrders1;
        private System.Windows.Forms.TextBox purchaseOrderProductNameTextBox1;
        private System.Windows.Forms.TextBox purchaseOrderDetailsTextBox1;
        private System.Windows.Forms.Label orderDateLabel1;
        private System.Windows.Forms.TextBox orderDateTextBox1;
        private System.Windows.Forms.Label staffIDLabel1;
        private System.Windows.Forms.TextBox staffIDTextBox1;
        private System.Windows.Forms.Label vendorIDLabel1;
        private System.Windows.Forms.TextBox vendorIDTextBox1;

        private void InitializeComponent()
        {
            this.dataGridClients1 = new System.Windows.Forms.DataGridView();
            this.dataGridPurchaseOrders1 = new System.Windows.Forms.DataGridView();
            this.purchaseOrderProductNameTextBox1 = new System.Windows.Forms.TextBox();
            this.purchaseOrderDetailsTextBox1 = new System.Windows.Forms.TextBox();
            this.loadClientsButton1 = new System.Windows.Forms.Button();
            this.testConnectionButton1 = new System.Windows.Forms.Button();
            this.deleteChildRowButton1 = new System.Windows.Forms.Button();
            this.updateChildRowButton1 = new System.Windows.Forms.Button();
            this.orderDateLabel1 = new System.Windows.Forms.Label();
            this.orderDateTextBox1 = new System.Windows.Forms.TextBox();
            this.staffIDLabel1 = new System.Windows.Forms.Label();
            this.staffIDTextBox1 = new System.Windows.Forms.TextBox();
            this.vendorIDLabel1 = new System.Windows.Forms.Label();
            this.vendorIDTextBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClients1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPurchaseOrders1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridClients1
            // 
            this.dataGridClients1.ColumnHeadersHeight = 29;
            this.dataGridClients1.Location = new System.Drawing.Point(12, 150);
            this.dataGridClients1.Name = "dataGridClients1";
            this.dataGridClients1.RowHeadersWidth = 51;
            this.dataGridClients1.Size = new System.Drawing.Size(500, 300);
            this.dataGridClients1.TabIndex = 2;
            this.dataGridClients1.SelectionChanged += new System.EventHandler(this.dataGridClients1SelectionChanged);
            // 
            // dataGridPurchaseOrders1
            // 
            this.dataGridPurchaseOrders1.ColumnHeadersHeight = 29;
            this.dataGridPurchaseOrders1.Location = new System.Drawing.Point(550, 150);
            this.dataGridPurchaseOrders1.Name = "dataGridPurchaseOrders1";
            this.dataGridPurchaseOrders1.RowHeadersWidth = 51;
            this.dataGridPurchaseOrders1.Size = new System.Drawing.Size(500, 300);
            this.dataGridPurchaseOrders1.TabIndex = 3;
            // 
            // purchaseOrderProductNameTextBox1
            // 
            this.purchaseOrderProductNameTextBox1.Location = new System.Drawing.Point(550, 500);
            this.purchaseOrderProductNameTextBox1.Name = "purchaseOrderProductNameTextBox1";
            this.purchaseOrderProductNameTextBox1.Size = new System.Drawing.Size(100, 22);
            this.purchaseOrderProductNameTextBox1.TabIndex = 10;
            this.purchaseOrderProductNameTextBox1.Text = "Product name:";
            // 
            // purchaseOrderDetailsTextBox1
            // 
            this.purchaseOrderDetailsTextBox1.Location = new System.Drawing.Point(550, 550);
            this.purchaseOrderDetailsTextBox1.Name = "purchaseOrderDetailsTextBox1";
            this.purchaseOrderDetailsTextBox1.Size = new System.Drawing.Size(131, 22);
            this.purchaseOrderDetailsTextBox1.TabIndex = 11;
            this.purchaseOrderDetailsTextBox1.Text = "Order details:";
            // 
            // loadClientsButton1
            // 
            this.loadClientsButton1.Location = new System.Drawing.Point(1243, 262);
            this.loadClientsButton1.Name = "loadClientsButton1";
            this.loadClientsButton1.Size = new System.Drawing.Size(210, 125);
            this.loadClientsButton1.TabIndex = 1;
            this.loadClientsButton1.Text = "Load Clients";
            this.loadClientsButton1.UseVisualStyleBackColor = true;
            this.loadClientsButton1.Click += new System.EventHandler(this.LoadClientsButtonClick);
            // 
            // testConnectionButton1
            // 
            this.testConnectionButton1.Location = new System.Drawing.Point(1243, 150);
            this.testConnectionButton1.Name = "testConnectionButton1";
            this.testConnectionButton1.Size = new System.Drawing.Size(210, 125);
            this.testConnectionButton1.TabIndex = 0;
            this.testConnectionButton1.Text = "Test Connection";
            this.testConnectionButton1.UseVisualStyleBackColor = true;
            this.testConnectionButton1.Click += new System.EventHandler(this.TestConnectionButtonClick);
            // 
            // deleteChildRowButton1
            // 
            this.deleteChildRowButton1.Location = new System.Drawing.Point(642, 419);
            this.deleteChildRowButton1.Name = "deleteChildRowButton1";
            this.deleteChildRowButton1.Size = new System.Drawing.Size(210, 125);
            this.deleteChildRowButton1.TabIndex = 5;
            this.deleteChildRowButton1.Text = "Delete Order";
            this.deleteChildRowButton1.UseVisualStyleBackColor = true;
            this.deleteChildRowButton1.Click += new System.EventHandler(this.DeleteChildRowButtonClick);
            // 
            // updateChildRowButton1
            // 
            this.updateChildRowButton1.Location = new System.Drawing.Point(1228, 460);
            this.updateChildRowButton1.Name = "updateChildRowButton1";
            this.updateChildRowButton1.Size = new System.Drawing.Size(210, 125);
            this.updateChildRowButton1.TabIndex = 6;
            this.updateChildRowButton1.Text = "Update Order";
            this.updateChildRowButton1.UseVisualStyleBackColor = true;
            this.updateChildRowButton1.Click += new System.EventHandler(this.UpdateButtonClick);
            // 
            // orderDateLabel1
            // 
            this.orderDateLabel1.Location = new System.Drawing.Point(550, 500);
            this.orderDateLabel1.Name = "orderDateLabel1";
            this.orderDateLabel1.Size = new System.Drawing.Size(100, 26);
            this.orderDateLabel1.TabIndex = 10;
            this.orderDateLabel1.Text = "Order Date:";
            // 
            // orderDateTextBox1
            // 
            this.orderDateTextBox1.Location = new System.Drawing.Point(650, 500);
            this.orderDateTextBox1.Name = "orderDateTextBox1";
            this.orderDateTextBox1.Size = new System.Drawing.Size(100, 22);
            this.orderDateTextBox1.TabIndex = 11;
            // 
            // staffIDLabel1
            // 
            this.staffIDLabel1.Location = new System.Drawing.Point(550, 540);
            this.staffIDLabel1.Name = "staffIDLabel1";
            this.staffIDLabel1.Size = new System.Drawing.Size(100, 26);
            this.staffIDLabel1.TabIndex = 12;
            this.staffIDLabel1.Text = "Staff ID:";
            // 
            // staffIDTextBox1
            // 
            this.staffIDTextBox1.Location = new System.Drawing.Point(650, 540);
            this.staffIDTextBox1.Name = "staffIDTextBox1";
            this.staffIDTextBox1.Size = new System.Drawing.Size(100, 22);
            this.staffIDTextBox1.TabIndex = 13;
            // 
            // vendorIDLabel1
            // 
            this.vendorIDLabel1.Location = new System.Drawing.Point(550, 580);
            this.vendorIDLabel1.Name = "vendorIDLabel1";
            this.vendorIDLabel1.Size = new System.Drawing.Size(100, 26);
            this.vendorIDLabel1.TabIndex = 14;
            this.vendorIDLabel1.Text = "Vendor ID:";
            // 
            // vendorIDTextBox1
            // 
            this.vendorIDTextBox1.Location = new System.Drawing.Point(650, 580);
            this.vendorIDTextBox1.Name = "vendorIDTextBox1";
            this.vendorIDTextBox1.Size = new System.Drawing.Size(100, 22);
            this.vendorIDTextBox1.TabIndex = 15;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1496, 600);
            this.Controls.Add(this.testConnectionButton1);
            this.Controls.Add(this.loadClientsButton1);
            this.Controls.Add(this.dataGridClients1);
            this.Controls.Add(this.dataGridPurchaseOrders1);
            this.Controls.Add(this.purchaseOrderProductNameTextBox1);
            this.Controls.Add(this.purchaseOrderDetailsTextBox1);
            this.Controls.Add(this.deleteChildRowButton1);
            this.Controls.Add(this.updateChildRowButton1);
            this.Controls.Add(this.orderDateLabel1);
            this.Controls.Add(this.orderDateTextBox1);
            this.Controls.Add(this.staffIDLabel1);
            this.Controls.Add(this.staffIDTextBox1);
            this.Controls.Add(this.vendorIDLabel1);
            this.Controls.Add(this.vendorIDTextBox1);
            this.Name = "Form1";
            this.Text = "Purchase Orders Management System";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClients1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPurchaseOrders1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button loadClientsButton1;
        private System.Windows.Forms.Button testConnectionButton1;
        private System.Windows.Forms.Button deleteChildRowButton1;
        private System.Windows.Forms.Button updateChildRowButton1;
    }
}
