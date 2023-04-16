namespace BetterLimited
{
    partial class Interface_HandleDefectItem
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_SelectSaleorder = new System.Windows.Forms.Button();
            this.cb_saleorder = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_storeName = new System.Windows.Forms.ComboBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btn_search = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DateOfPurchase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleOrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoreName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.lab_total = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_refundprice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_quanitiy = new System.Windows.Forms.NumericUpDown();
            this.lab_quantity = new System.Windows.Forms.Label();
            this.txt_reason = new System.Windows.Forms.RichTextBox();
            this.lab_reason = new System.Windows.Forms.Label();
            this.cb_handle = new System.Windows.Forms.ComboBox();
            this.cb_productName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lab_product = new System.Windows.Forms.Label();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.ProductIDsold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleOrder1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PerPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_quanitiy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductName,
            this.Quantity});
            this.dataGridView2.Location = new System.Drawing.Point(9, 52);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(501, 282);
            this.dataGridView2.TabIndex = 11;
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "ProductID";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "ProductName";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 300;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_SelectSaleorder);
            this.groupBox2.Controls.Add(this.cb_saleorder);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(12, 434);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(766, 362);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sale Order Product";
            // 
            // btn_SelectSaleorder
            // 
            this.btn_SelectSaleorder.Location = new System.Drawing.Point(525, 20);
            this.btn_SelectSaleorder.Name = "btn_SelectSaleorder";
            this.btn_SelectSaleorder.Size = new System.Drawing.Size(217, 58);
            this.btn_SelectSaleorder.TabIndex = 14;
            this.btn_SelectSaleorder.Text = "Select Sale Order";
            this.btn_SelectSaleorder.UseVisualStyleBackColor = true;
            this.btn_SelectSaleorder.Click += new System.EventHandler(this.btn_SelectSaleorder_Click);
            // 
            // cb_saleorder
            // 
            this.cb_saleorder.FormattingEnabled = true;
            this.cb_saleorder.Location = new System.Drawing.Point(287, 20);
            this.cb_saleorder.Name = "cb_saleorder";
            this.cb_saleorder.Size = new System.Drawing.Size(223, 26);
            this.cb_saleorder.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Select Sale Order To View";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(584, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Date Of Purchase*:";
            // 
            // cb_storeName
            // 
            this.cb_storeName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_storeName.FormattingEnabled = true;
            this.cb_storeName.Location = new System.Drawing.Point(938, 23);
            this.cb_storeName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cb_storeName.Name = "cb_storeName";
            this.cb_storeName.Size = new System.Drawing.Size(315, 26);
            this.cb_storeName.TabIndex = 7;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(587, 55);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(15, 14, 15, 14);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 5;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Chartreuse;
            this.btn_search.Location = new System.Drawing.Point(1063, 340);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(190, 47);
            this.btn_search.TabIndex = 10;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateOfPurchase,
            this.SaleOrderID,
            this.StoreName,
            this.Total});
            this.dataGridView1.Location = new System.Drawing.Point(9, 27);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(575, 360);
            this.dataGridView1.TabIndex = 0;
            // 
            // DateOfPurchase
            // 
            this.DateOfPurchase.HeaderText = "DateOfPurchase";
            this.DateOfPurchase.Name = "DateOfPurchase";
            this.DateOfPurchase.ReadOnly = true;
            this.DateOfPurchase.Width = 140;
            // 
            // SaleOrderID
            // 
            this.SaleOrderID.HeaderText = "SaleOrderID";
            this.SaleOrderID.Name = "SaleOrderID";
            this.SaleOrderID.ReadOnly = true;
            this.SaleOrderID.Width = 150;
            // 
            // StoreName
            // 
            this.StoreName.HeaderText = "StoreName";
            this.StoreName.Name = "StoreName";
            this.StoreName.ReadOnly = true;
            this.StoreName.Width = 195;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_price);
            this.groupBox1.Controls.Add(this.lab_total);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.monthCalendar1);
            this.groupBox1.Controls.Add(this.cb_storeName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1261, 416);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sale Order Search";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(810, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Store Name*:";
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(937, 103);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(316, 27);
            this.txt_price.TabIndex = 12;
            // 
            // lab_total
            // 
            this.lab_total.AutoSize = true;
            this.lab_total.Location = new System.Drawing.Point(866, 106);
            this.lab_total.Name = "lab_total";
            this.lab_total.Size = new System.Drawing.Size(65, 18);
            this.lab_total.TabIndex = 11;
            this.lab_total.Text = "Total*:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_refundprice);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.numericUpDown_quanitiy);
            this.groupBox3.Controls.Add(this.lab_quantity);
            this.groupBox3.Controls.Add(this.txt_reason);
            this.groupBox3.Controls.Add(this.lab_reason);
            this.groupBox3.Controls.Add(this.cb_handle);
            this.groupBox3.Controls.Add(this.cb_productName);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.lab_product);
            this.groupBox3.Location = new System.Drawing.Point(784, 429);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(489, 404);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Create Defect Item Record";
            // 
            // txt_refundprice
            // 
            this.txt_refundprice.Location = new System.Drawing.Point(164, 128);
            this.txt_refundprice.Name = "txt_refundprice";
            this.txt_refundprice.Size = new System.Drawing.Size(325, 27);
            this.txt_refundprice.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Amount Of Refund:";
            // 
            // numericUpDown_quanitiy
            // 
            this.numericUpDown_quanitiy.Location = new System.Drawing.Point(130, 56);
            this.numericUpDown_quanitiy.Name = "numericUpDown_quanitiy";
            this.numericUpDown_quanitiy.Size = new System.Drawing.Size(120, 27);
            this.numericUpDown_quanitiy.TabIndex = 7;
            // 
            // lab_quantity
            // 
            this.lab_quantity.AutoSize = true;
            this.lab_quantity.Location = new System.Drawing.Point(43, 58);
            this.lab_quantity.Name = "lab_quantity";
            this.lab_quantity.Size = new System.Drawing.Size(86, 18);
            this.lab_quantity.TabIndex = 6;
            this.lab_quantity.Text = "Quantity:";
            // 
            // txt_reason
            // 
            this.txt_reason.Location = new System.Drawing.Point(3, 189);
            this.txt_reason.Name = "txt_reason";
            this.txt_reason.Size = new System.Drawing.Size(475, 209);
            this.txt_reason.TabIndex = 5;
            this.txt_reason.Text = "";
            // 
            // lab_reason
            // 
            this.lab_reason.AutoSize = true;
            this.lab_reason.Location = new System.Drawing.Point(0, 168);
            this.lab_reason.Name = "lab_reason";
            this.lab_reason.Size = new System.Drawing.Size(75, 18);
            this.lab_reason.TabIndex = 4;
            this.lab_reason.Text = "Reason:";
            // 
            // cb_handle
            // 
            this.cb_handle.FormattingEnabled = true;
            this.cb_handle.Items.AddRange(new object[] {
            "Refund",
            "Exchange"});
            this.cb_handle.Location = new System.Drawing.Point(130, 89);
            this.cb_handle.Name = "cb_handle";
            this.cb_handle.Size = new System.Drawing.Size(359, 26);
            this.cb_handle.TabIndex = 3;
            // 
            // cb_productName
            // 
            this.cb_productName.FormattingEnabled = true;
            this.cb_productName.Location = new System.Drawing.Point(130, 24);
            this.cb_productName.Name = "cb_productName";
            this.cb_productName.Size = new System.Drawing.Size(359, 26);
            this.cb_productName.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-3, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Handle Method:";
            // 
            // lab_product
            // 
            this.lab_product.AutoSize = true;
            this.lab_product.Location = new System.Drawing.Point(0, 27);
            this.lab_product.Name = "lab_product";
            this.lab_product.Size = new System.Drawing.Size(129, 18);
            this.lab_product.TabIndex = 0;
            this.lab_product.Text = "Product Name:";
            // 
            // btn_confirm
            // 
            this.btn_confirm.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_confirm.Location = new System.Drawing.Point(1084, 839);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(198, 50);
            this.btn_confirm.TabIndex = 14;
            this.btn_confirm.Text = "Confirm ";
            this.btn_confirm.UseVisualStyleBackColor = false;
            this.btn_confirm.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductIDsold,
            this.SaleOrder1,
            this.PerPrice});
            this.dataGridView3.Location = new System.Drawing.Point(832, 145);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(423, 150);
            this.dataGridView3.TabIndex = 14;
            // 
            // ProductIDsold
            // 
            this.ProductIDsold.HeaderText = "ProductIDsold";
            this.ProductIDsold.Name = "ProductIDsold";
            this.ProductIDsold.ReadOnly = true;
            // 
            // SaleOrder1
            // 
            this.SaleOrder1.HeaderText = "SaleOrder";
            this.SaleOrder1.Name = "SaleOrder1";
            this.SaleOrder1.ReadOnly = true;
            // 
            // PerPrice
            // 
            this.PerPrice.HeaderText = "Priceper";
            this.PerPrice.Name = "PerPrice";
            this.PerPrice.ReadOnly = true;
            // 
            // Interface_HandleDefectItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 901);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Interface_HandleDefectItem";
            this.Text = "defectItemApply";
            this.Load += new System.EventHandler(this.defectItemApply_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_quanitiy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_saleorder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_storeName;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lab_total;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfPurchase;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleOrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Button btn_SelectSaleorder;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lab_product;
        private System.Windows.Forms.ComboBox cb_productName;
        private System.Windows.Forms.ComboBox cb_handle;
        private System.Windows.Forms.Label lab_reason;
        private System.Windows.Forms.RichTextBox txt_reason;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Label lab_quantity;
        private System.Windows.Forms.NumericUpDown numericUpDown_quanitiy;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_refundprice;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductIDsold;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleOrder1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PerPrice;
    }
}