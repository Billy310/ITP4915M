namespace BetterLimited
{
    partial class Interface_ApprovePurchaseItem
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cb_PID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_refuse = new System.Windows.Forms.Button();
            this.btn_accept = new System.Windows.Forms.Button();
            this.cb_PurID = new System.Windows.Forms.ComboBox();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WareHouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchasingOrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductName,
            this.Quantity,
            this.Total,
            this.WareHouse,
            this.PurchasingOrderID});
            this.dataGridView1.Location = new System.Drawing.Point(14, 13);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1053, 345);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cb_PID
            // 
            this.cb_PID.FormattingEnabled = true;
            this.cb_PID.Location = new System.Drawing.Point(258, 367);
            this.cb_PID.Name = "cb_PID";
            this.cb_PID.Size = new System.Drawing.Size(197, 26);
            this.cb_PID.TabIndex = 1;
            this.cb_PID.SelectedIndexChanged += new System.EventHandler(this.cb_PID_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Purchase ProductID:";
            // 
            // btn_refuse
            // 
            this.btn_refuse.BackColor = System.Drawing.Color.LightCoral;
            this.btn_refuse.Location = new System.Drawing.Point(55, 440);
            this.btn_refuse.Name = "btn_refuse";
            this.btn_refuse.Size = new System.Drawing.Size(197, 55);
            this.btn_refuse.TabIndex = 3;
            this.btn_refuse.Text = "Refuse";
            this.btn_refuse.UseVisualStyleBackColor = false;
            this.btn_refuse.Click += new System.EventHandler(this.btn_refuse_Click);
            // 
            // btn_accept
            // 
            this.btn_accept.BackColor = System.Drawing.Color.LightGreen;
            this.btn_accept.Location = new System.Drawing.Point(385, 440);
            this.btn_accept.Name = "btn_accept";
            this.btn_accept.Size = new System.Drawing.Size(197, 55);
            this.btn_accept.TabIndex = 4;
            this.btn_accept.Text = "Accept";
            this.btn_accept.UseVisualStyleBackColor = false;
            this.btn_accept.Click += new System.EventHandler(this.btn_accept_Click);
            // 
            // cb_PurID
            // 
            this.cb_PurID.FormattingEnabled = true;
            this.cb_PurID.Location = new System.Drawing.Point(461, 367);
            this.cb_PurID.Name = "cb_PurID";
            this.cb_PurID.Size = new System.Drawing.Size(121, 26);
            this.cb_PurID.TabIndex = 5;
            this.cb_PurID.Visible = false;
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "ProductID";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            this.ProductID.Width = 200;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "ProductName";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 200;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Purchase Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 200;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total Purchase Price (HKD)";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 250;
            // 
            // WareHouse
            // 
            this.WareHouse.HeaderText = "Ware House Quantity";
            this.WareHouse.Name = "WareHouse";
            this.WareHouse.ReadOnly = true;
            this.WareHouse.Width = 200;
            // 
            // PurchasingOrderID
            // 
            this.PurchasingOrderID.HeaderText = "Purchasing Order ID";
            this.PurchasingOrderID.Name = "PurchasingOrderID";
            this.PurchasingOrderID.ReadOnly = true;
            this.PurchasingOrderID.Visible = false;
            // 
            // Interface_ApprovePurchaseItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 538);
            this.Controls.Add(this.cb_PurID);
            this.Controls.Add(this.btn_accept);
            this.Controls.Add(this.btn_refuse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_PID);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Interface_ApprovePurchaseItem";
            this.Text = "Accounting Department Approve Purchase Item";
            this.Load += new System.EventHandler(this.Interface_ApprovePurchaseItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cb_PID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_refuse;
        private System.Windows.Forms.Button btn_accept;
        private System.Windows.Forms.ComboBox cb_PurID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn WareHouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchasingOrderID;
    }
}