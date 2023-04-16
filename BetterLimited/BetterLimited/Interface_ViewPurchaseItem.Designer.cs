namespace BetterLimited
{
    partial class Interface_ViewPurchaseItem
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
            this.cb_pID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_PurID = new System.Windows.Forms.ComboBox();
            this.lab_sup = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_sname = new System.Windows.Forms.TextBox();
            this.txt_pnum = new System.Windows.Forms.TextBox();
            this.txt_city = new System.Windows.Forms.TextBox();
            this.txt_building = new System.Windows.Forms.TextBox();
            this.txt_street = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Region = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.btn_status = new System.Windows.Forms.Button();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchasingOrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.PurchaseQuantity,
            this.PurchasingOrderID});
            this.dataGridView1.Location = new System.Drawing.Point(14, 2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(554, 225);
            this.dataGridView1.TabIndex = 0;
            // 
            // cb_pID
            // 
            this.cb_pID.FormattingEnabled = true;
            this.cb_pID.Location = new System.Drawing.Point(169, 244);
            this.cb_pID.Name = "cb_pID";
            this.cb_pID.Size = new System.Drawing.Size(121, 26);
            this.cb_pID.TabIndex = 1;
            this.cb_pID.SelectedIndexChanged += new System.EventHandler(this.cb_pID_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select ProductID:";
            // 
            // cb_PurID
            // 
            this.cb_PurID.FormattingEnabled = true;
            this.cb_PurID.Location = new System.Drawing.Point(296, 244);
            this.cb_PurID.Name = "cb_PurID";
            this.cb_PurID.Size = new System.Drawing.Size(121, 26);
            this.cb_PurID.TabIndex = 6;
            this.cb_PurID.Visible = false;
            // 
            // lab_sup
            // 
            this.lab_sup.AutoSize = true;
            this.lab_sup.Location = new System.Drawing.Point(97, 23);
            this.lab_sup.Name = "lab_sup";
            this.lab_sup.Size = new System.Drawing.Size(134, 18);
            this.lab_sup.TabIndex = 7;
            this.lab_sup.Text = "Supplier Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Supplier Phone Number:";
            // 
            // txt_sname
            // 
            this.txt_sname.Location = new System.Drawing.Point(237, 20);
            this.txt_sname.Name = "txt_sname";
            this.txt_sname.Size = new System.Drawing.Size(311, 27);
            this.txt_sname.TabIndex = 9;
            // 
            // txt_pnum
            // 
            this.txt_pnum.Location = new System.Drawing.Point(237, 54);
            this.txt_pnum.Name = "txt_pnum";
            this.txt_pnum.Size = new System.Drawing.Size(311, 27);
            this.txt_pnum.TabIndex = 10;
            // 
            // txt_city
            // 
            this.txt_city.Location = new System.Drawing.Point(237, 26);
            this.txt_city.Name = "txt_city";
            this.txt_city.Size = new System.Drawing.Size(311, 27);
            this.txt_city.TabIndex = 11;
            // 
            // txt_building
            // 
            this.txt_building.Location = new System.Drawing.Point(237, 71);
            this.txt_building.Name = "txt_building";
            this.txt_building.Size = new System.Drawing.Size(311, 27);
            this.txt_building.TabIndex = 12;
            // 
            // txt_street
            // 
            this.txt_street.Location = new System.Drawing.Point(237, 120);
            this.txt_street.Name = "txt_street";
            this.txt_street.Size = new System.Drawing.Size(311, 27);
            this.txt_street.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lab_sup);
            this.groupBox1.Controls.Add(this.txt_sname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_pnum);
            this.groupBox1.Location = new System.Drawing.Point(593, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(554, 91);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Supplier Information";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_Region);
            this.groupBox2.Controls.Add(this.txt_street);
            this.groupBox2.Controls.Add(this.txt_city);
            this.groupBox2.Controls.Add(this.txt_building);
            this.groupBox2.Location = new System.Drawing.Point(593, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(554, 217);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Address:";
            // 
            // txt_Region
            // 
            this.txt_Region.Location = new System.Drawing.Point(237, 169);
            this.txt_Region.Name = "txt_Region";
            this.txt_Region.Size = new System.Drawing.Size(311, 27);
            this.txt_Region.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "City:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "Building:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(166, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 18);
            this.label5.TabIndex = 17;
            this.label5.Text = "Street:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(160, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "Region:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 402);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Update Status:";
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Items.AddRange(new object[] {
            "Purchasing",
            "Delivering",
            "Nobody Answer",
            "Finish"});
            this.cb_status.Location = new System.Drawing.Point(151, 399);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(266, 26);
            this.cb_status.TabIndex = 16;
            // 
            // btn_status
            // 
            this.btn_status.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_status.Location = new System.Drawing.Point(14, 456);
            this.btn_status.Name = "btn_status";
            this.btn_status.Size = new System.Drawing.Size(233, 75);
            this.btn_status.TabIndex = 17;
            this.btn_status.Text = "Update Status";
            this.btn_status.UseVisualStyleBackColor = false;
            this.btn_status.Click += new System.EventHandler(this.btn_status_Click);
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "ProductID";
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
            // PurchaseQuantity
            // 
            this.PurchaseQuantity.HeaderText = "Purchase Quantity";
            this.PurchaseQuantity.Name = "PurchaseQuantity";
            this.PurchaseQuantity.ReadOnly = true;
            this.PurchaseQuantity.Width = 150;
            // 
            // PurchasingOrderID
            // 
            this.PurchasingOrderID.HeaderText = "PurchasingOrderID";
            this.PurchasingOrderID.Name = "PurchasingOrderID";
            this.PurchasingOrderID.ReadOnly = true;
            this.PurchasingOrderID.Visible = false;
            // 
            // Interface_ViewPurchaseItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 543);
            this.Controls.Add(this.btn_status);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_PurID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cb_pID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Interface_ViewPurchaseItem";
            this.Text = "Interface_ViewPurchaseItem";
            this.Load += new System.EventHandler(this.Interface_ViewPurchaseItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cb_pID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_PurID;
        private System.Windows.Forms.Label lab_sup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_sname;
        private System.Windows.Forms.TextBox txt_pnum;
        private System.Windows.Forms.TextBox txt_city;
        private System.Windows.Forms.TextBox txt_building;
        private System.Windows.Forms.TextBox txt_street;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_Region;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.Button btn_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchasingOrderID;
    }
}