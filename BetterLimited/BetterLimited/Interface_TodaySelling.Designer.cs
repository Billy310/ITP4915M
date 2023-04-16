namespace BetterLimited
{
    partial class Interface_TodaySelling
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
            this.lab_Title = new System.Windows.Forms.Label();
            this.lab_shop = new System.Windows.Forms.Label();
            this.dataGridView_todaySaleorder = new System.Windows.Forms.DataGridView();
            this.lab_deposit = new System.Windows.Forms.Label();
            this.lab_saleorder = new System.Windows.Forms.Label();
            this.lab_countd = new System.Windows.Forms.Label();
            this.lab_counts = new System.Windows.Forms.Label();
            this.label_storeID = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdditionCharge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deposit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lab_ttt = new System.Windows.Forms.Label();
            this.lab_total = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_todaySaleorder)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_Title
            // 
            this.lab_Title.AutoSize = true;
            this.lab_Title.Location = new System.Drawing.Point(14, 9);
            this.lab_Title.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lab_Title.Name = "lab_Title";
            this.lab_Title.Size = new System.Drawing.Size(55, 18);
            this.lab_Title.TabIndex = 0;
            this.lab_Title.Text = "Shop:";
            // 
            // lab_shop
            // 
            this.lab_shop.AutoSize = true;
            this.lab_shop.Location = new System.Drawing.Point(66, 9);
            this.lab_shop.Name = "lab_shop";
            this.lab_shop.Size = new System.Drawing.Size(101, 18);
            this.lab_shop.TabIndex = 1;
            this.lab_shop.Text = "Shop Name";
            // 
            // dataGridView_todaySaleorder
            // 
            this.dataGridView_todaySaleorder.AllowUserToAddRows = false;
            this.dataGridView_todaySaleorder.AllowUserToDeleteRows = false;
            this.dataGridView_todaySaleorder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_todaySaleorder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.SaleOrder,
            this.OrderType,
            this.Total,
            this.AdditionCharge,
            this.Deposit});
            this.dataGridView_todaySaleorder.Location = new System.Drawing.Point(17, 30);
            this.dataGridView_todaySaleorder.Name = "dataGridView_todaySaleorder";
            this.dataGridView_todaySaleorder.ReadOnly = true;
            this.dataGridView_todaySaleorder.RowHeadersVisible = false;
            this.dataGridView_todaySaleorder.RowTemplate.Height = 24;
            this.dataGridView_todaySaleorder.Size = new System.Drawing.Size(905, 385);
            this.dataGridView_todaySaleorder.TabIndex = 2;
            // 
            // lab_deposit
            // 
            this.lab_deposit.AutoSize = true;
            this.lab_deposit.Location = new System.Drawing.Point(14, 432);
            this.lab_deposit.Name = "lab_deposit";
            this.lab_deposit.Size = new System.Drawing.Size(208, 18);
            this.lab_deposit.TabIndex = 5;
            this.lab_deposit.Text = "Count Of Deposit Order:";
            // 
            // lab_saleorder
            // 
            this.lab_saleorder.AutoSize = true;
            this.lab_saleorder.Location = new System.Drawing.Point(42, 464);
            this.lab_saleorder.Name = "lab_saleorder";
            this.lab_saleorder.Size = new System.Drawing.Size(180, 18);
            this.lab_saleorder.TabIndex = 6;
            this.lab_saleorder.Text = "Count Of Sale Order:";
            // 
            // lab_countd
            // 
            this.lab_countd.AutoSize = true;
            this.lab_countd.Location = new System.Drawing.Point(228, 432);
            this.lab_countd.Name = "lab_countd";
            this.lab_countd.Size = new System.Drawing.Size(63, 18);
            this.lab_countd.TabIndex = 7;
            this.lab_countd.Text = "dcount";
            // 
            // lab_counts
            // 
            this.lab_counts.AutoSize = true;
            this.lab_counts.Location = new System.Drawing.Point(228, 464);
            this.lab_counts.Name = "lab_counts";
            this.lab_counts.Size = new System.Drawing.Size(62, 18);
            this.lab_counts.TabIndex = 8;
            this.lab_counts.Text = "scount";
            // 
            // label_storeID
            // 
            this.label_storeID.AutoSize = true;
            this.label_storeID.Location = new System.Drawing.Point(1190, 9);
            this.label_storeID.Name = "label_storeID";
            this.label_storeID.Size = new System.Drawing.Size(70, 18);
            this.label_storeID.TabIndex = 9;
            this.label_storeID.Text = "StoreID";
            this.label_storeID.Visible = false;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 150;
            // 
            // SaleOrder
            // 
            this.SaleOrder.HeaderText = "Sale Order";
            this.SaleOrder.Name = "SaleOrder";
            this.SaleOrder.ReadOnly = true;
            this.SaleOrder.Width = 120;
            // 
            // OrderType
            // 
            this.OrderType.HeaderText = "Order Type";
            this.OrderType.Name = "OrderType";
            this.OrderType.ReadOnly = true;
            this.OrderType.Width = 200;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 130;
            // 
            // AdditionCharge
            // 
            this.AdditionCharge.HeaderText = "Addition Charge";
            this.AdditionCharge.Name = "AdditionCharge";
            this.AdditionCharge.ReadOnly = true;
            this.AdditionCharge.Width = 150;
            // 
            // Deposit
            // 
            this.Deposit.HeaderText = "Deposit";
            this.Deposit.Name = "Deposit";
            this.Deposit.ReadOnly = true;
            this.Deposit.Width = 150;
            // 
            // lab_ttt
            // 
            this.lab_ttt.AutoSize = true;
            this.lab_ttt.Location = new System.Drawing.Point(39, 493);
            this.lab_ttt.Name = "lab_ttt";
            this.lab_ttt.Size = new System.Drawing.Size(183, 18);
            this.lab_ttt.TabIndex = 10;
            this.lab_ttt.Text = "Today Total Turnover:";
            // 
            // lab_total
            // 
            this.lab_total.AutoSize = true;
            this.lab_total.Location = new System.Drawing.Point(228, 493);
            this.lab_total.Name = "lab_total";
            this.lab_total.Size = new System.Drawing.Size(58, 18);
            this.lab_total.TabIndex = 11;
            this.lab_total.Text = "label2";
            // 
            // TopSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 539);
            this.Controls.Add(this.lab_total);
            this.Controls.Add(this.lab_ttt);
            this.Controls.Add(this.label_storeID);
            this.Controls.Add(this.lab_counts);
            this.Controls.Add(this.lab_countd);
            this.Controls.Add(this.lab_saleorder);
            this.Controls.Add(this.lab_deposit);
            this.Controls.Add(this.dataGridView_todaySaleorder);
            this.Controls.Add(this.lab_shop);
            this.Controls.Add(this.lab_Title);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "TopSell";
            this.Text = "TopSell";
            this.Load += new System.EventHandler(this.TopSell_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_todaySaleorder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_Title;
        private System.Windows.Forms.Label lab_shop;
        private System.Windows.Forms.DataGridView dataGridView_todaySaleorder;
        private System.Windows.Forms.Label lab_deposit;
        private System.Windows.Forms.Label lab_saleorder;
        private System.Windows.Forms.Label lab_countd;
        private System.Windows.Forms.Label lab_counts;
        private System.Windows.Forms.Label label_storeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdditionCharge;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deposit;
        private System.Windows.Forms.Label lab_ttt;
        private System.Windows.Forms.Label lab_total;
    }
}