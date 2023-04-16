namespace BetterLimited
{
    partial class Interface_RecoverStock
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
            this.label_storeID = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoreStockLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WareHouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lab_pid = new System.Windows.Forms.Label();
            this.cb_pid = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lab_storeName = new System.Windows.Forms.Label();
            this.btn_recovery = new System.Windows.Forms.Button();
            this.numericUpDown_Quantity = new System.Windows.Forms.NumericUpDown();
            this.lab_quantity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // label_storeID
            // 
            this.label_storeID.AutoSize = true;
            this.label_storeID.Location = new System.Drawing.Point(1017, 9);
            this.label_storeID.Name = "label_storeID";
            this.label_storeID.Size = new System.Drawing.Size(70, 18);
            this.label_storeID.TabIndex = 0;
            this.label_storeID.Text = "StoreID";
            this.label_storeID.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductName,
            this.StoreStockLevel,
            this.WareHouse});
            this.dataGridView1.Location = new System.Drawing.Point(15, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(804, 327);
            this.dataGridView1.TabIndex = 1;
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "Product ID";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            this.ProductID.Width = 150;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 250;
            // 
            // StoreStockLevel
            // 
            this.StoreStockLevel.HeaderText = "Store Stock Level";
            this.StoreStockLevel.Name = "StoreStockLevel";
            this.StoreStockLevel.ReadOnly = true;
            this.StoreStockLevel.Width = 150;
            // 
            // WareHouse
            // 
            this.WareHouse.HeaderText = "WareHouse Stock Level";
            this.WareHouse.Name = "WareHouse";
            this.WareHouse.ReadOnly = true;
            this.WareHouse.Width = 250;
            // 
            // lab_pid
            // 
            this.lab_pid.AutoSize = true;
            this.lab_pid.Location = new System.Drawing.Point(24, 379);
            this.lab_pid.Name = "lab_pid";
            this.lab_pid.Size = new System.Drawing.Size(95, 18);
            this.lab_pid.TabIndex = 2;
            this.lab_pid.Text = "ProductID:";
            // 
            // cb_pid
            // 
            this.cb_pid.FormattingEnabled = true;
            this.cb_pid.Location = new System.Drawing.Point(116, 376);
            this.cb_pid.Name = "cb_pid";
            this.cb_pid.Size = new System.Drawing.Size(121, 26);
            this.cb_pid.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Store Name:";
            // 
            // lab_storeName
            // 
            this.lab_storeName.AutoSize = true;
            this.lab_storeName.Location = new System.Drawing.Point(122, 9);
            this.lab_storeName.Name = "lab_storeName";
            this.lab_storeName.Size = new System.Drawing.Size(96, 18);
            this.lab_storeName.TabIndex = 5;
            this.lab_storeName.Text = "Storename";
            // 
            // btn_recovery
            // 
            this.btn_recovery.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_recovery.Location = new System.Drawing.Point(648, 376);
            this.btn_recovery.Name = "btn_recovery";
            this.btn_recovery.Size = new System.Drawing.Size(171, 58);
            this.btn_recovery.TabIndex = 6;
            this.btn_recovery.Text = "Ask For Recovery";
            this.btn_recovery.UseVisualStyleBackColor = false;
            this.btn_recovery.Click += new System.EventHandler(this.btn_recovery_Click);
            // 
            // numericUpDown_Quantity
            // 
            this.numericUpDown_Quantity.Location = new System.Drawing.Point(377, 377);
            this.numericUpDown_Quantity.Name = "numericUpDown_Quantity";
            this.numericUpDown_Quantity.Size = new System.Drawing.Size(120, 27);
            this.numericUpDown_Quantity.TabIndex = 7;
            // 
            // lab_quantity
            // 
            this.lab_quantity.AutoSize = true;
            this.lab_quantity.Location = new System.Drawing.Point(285, 379);
            this.lab_quantity.Name = "lab_quantity";
            this.lab_quantity.Size = new System.Drawing.Size(86, 18);
            this.lab_quantity.TabIndex = 8;
            this.lab_quantity.Text = "Quantity:";
            // 
            // Interface_RecoverStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 457);
            this.Controls.Add(this.lab_quantity);
            this.Controls.Add(this.numericUpDown_Quantity);
            this.Controls.Add(this.btn_recovery);
            this.Controls.Add(this.lab_storeName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_pid);
            this.Controls.Add(this.lab_pid);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label_storeID);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Interface_RecoverStock";
            this.Text = "Interface_RecoverStock";
            this.Load += new System.EventHandler(this.Interface_RecoverStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_storeID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lab_pid;
        private System.Windows.Forms.ComboBox cb_pid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreStockLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn WareHouse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lab_storeName;
        private System.Windows.Forms.Button btn_recovery;
        private System.Windows.Forms.NumericUpDown numericUpDown_Quantity;
        private System.Windows.Forms.Label lab_quantity;
    }
}