namespace BetterLimited
{
    partial class Interface_ViewDefectRecordList
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
            this.label1 = new System.Windows.Forms.Label();
            this.cb_deID = new System.Windows.Forms.ComboBox();
            this.lab_pname = new System.Windows.Forms.Label();
            this.txt_pname = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Region = new System.Windows.Forms.TextBox();
            this.txt_street = new System.Windows.Forms.TextBox();
            this.txt_city = new System.Windows.Forms.TextBox();
            this.txt_building = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lab_sup = new System.Windows.Forms.Label();
            this.txt_sname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_pnum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_supplierreply = new System.Windows.Forms.RichTextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.DefectItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfReturn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleOrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HandleMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoreID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Refund = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DefectItemID,
            this.DateOfReturn,
            this.SaleOrderID,
            this.HandleMethod,
            this.ProductID,
            this.ProductName,
            this.Quantity,
            this.StoreID,
            this.Refund});
            this.dataGridView1.Location = new System.Drawing.Point(24, 10);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1553, 387);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "View Defect Item Record:";
            // 
            // cb_deID
            // 
            this.cb_deID.FormattingEnabled = true;
            this.cb_deID.Location = new System.Drawing.Point(360, 419);
            this.cb_deID.Name = "cb_deID";
            this.cb_deID.Size = new System.Drawing.Size(429, 26);
            this.cb_deID.TabIndex = 2;
            this.cb_deID.SelectedIndexChanged += new System.EventHandler(this.cb_deID_SelectedIndexChanged);
            // 
            // lab_pname
            // 
            this.lab_pname.AutoSize = true;
            this.lab_pname.Location = new System.Drawing.Point(225, 461);
            this.lab_pname.Name = "lab_pname";
            this.lab_pname.Size = new System.Drawing.Size(129, 18);
            this.lab_pname.TabIndex = 3;
            this.lab_pname.Text = "Product Name:";
            // 
            // txt_pname
            // 
            this.txt_pname.Location = new System.Drawing.Point(360, 458);
            this.txt_pname.Name = "txt_pname";
            this.txt_pname.Size = new System.Drawing.Size(429, 27);
            this.txt_pname.TabIndex = 5;
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
            this.groupBox2.Location = new System.Drawing.Point(795, 501);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(554, 217);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Address:";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(166, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 18);
            this.label5.TabIndex = 17;
            this.label5.Text = "Street:";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "City:";
            // 
            // txt_Region
            // 
            this.txt_Region.Location = new System.Drawing.Point(237, 169);
            this.txt_Region.Name = "txt_Region";
            this.txt_Region.Size = new System.Drawing.Size(311, 27);
            this.txt_Region.TabIndex = 14;
            // 
            // txt_street
            // 
            this.txt_street.Location = new System.Drawing.Point(237, 120);
            this.txt_street.Name = "txt_street";
            this.txt_street.Size = new System.Drawing.Size(311, 27);
            this.txt_street.TabIndex = 13;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lab_sup);
            this.groupBox1.Controls.Add(this.txt_sname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_pnum);
            this.groupBox1.Location = new System.Drawing.Point(795, 404);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(554, 91);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Supplier Information";
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
            // txt_sname
            // 
            this.txt_sname.Location = new System.Drawing.Point(237, 20);
            this.txt_sname.Name = "txt_sname";
            this.txt_sname.Size = new System.Drawing.Size(311, 27);
            this.txt_sname.TabIndex = 9;
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
            // txt_pnum
            // 
            this.txt_pnum.Location = new System.Drawing.Point(237, 54);
            this.txt_pnum.Name = "txt_pnum";
            this.txt_pnum.Size = new System.Drawing.Size(311, 27);
            this.txt_pnum.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(208, 533);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "Supplier Answer:";
            // 
            // txt_supplierreply
            // 
            this.txt_supplierreply.Location = new System.Drawing.Point(360, 530);
            this.txt_supplierreply.Name = "txt_supplierreply";
            this.txt_supplierreply.Size = new System.Drawing.Size(429, 221);
            this.txt_supplierreply.TabIndex = 18;
            this.txt_supplierreply.Text = "";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_save.Location = new System.Drawing.Point(360, 767);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(429, 82);
            this.btn_save.TabIndex = 19;
            this.btn_save.Text = "Confirm";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // DefectItemID
            // 
            this.DefectItemID.HeaderText = "DefectItemID";
            this.DefectItemID.Name = "DefectItemID";
            this.DefectItemID.ReadOnly = true;
            this.DefectItemID.Width = 150;
            // 
            // DateOfReturn
            // 
            this.DateOfReturn.HeaderText = "DateOfReturn";
            this.DateOfReturn.Name = "DateOfReturn";
            this.DateOfReturn.ReadOnly = true;
            this.DateOfReturn.Width = 150;
            // 
            // SaleOrderID
            // 
            this.SaleOrderID.HeaderText = "SaleOrderID";
            this.SaleOrderID.Name = "SaleOrderID";
            this.SaleOrderID.ReadOnly = true;
            this.SaleOrderID.Width = 150;
            // 
            // HandleMethod
            // 
            this.HandleMethod.HeaderText = "Handle Method";
            this.HandleMethod.Name = "HandleMethod";
            this.HandleMethod.ReadOnly = true;
            this.HandleMethod.Width = 200;
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
            this.ProductName.Width = 250;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 150;
            // 
            // StoreID
            // 
            this.StoreID.HeaderText = "StoreName";
            this.StoreID.Name = "StoreID";
            this.StoreID.ReadOnly = true;
            this.StoreID.Width = 250;
            // 
            // Refund
            // 
            this.Refund.HeaderText = "Refund Amount";
            this.Refund.Name = "Refund";
            this.Refund.ReadOnly = true;
            this.Refund.Width = 150;
            // 
            // Interface_ViewDefectRecordList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1604, 877);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_supplierreply);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_pname);
            this.Controls.Add(this.lab_pname);
            this.Controls.Add(this.cb_deID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Interface_ViewDefectRecordList";
            this.Text = "Interface_ViewDefectRecordList";
            this.Load += new System.EventHandler(this.Interface_ViewDefectRecordList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_deID;
        private System.Windows.Forms.Label lab_pname;
        private System.Windows.Forms.TextBox txt_pname;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Region;
        private System.Windows.Forms.TextBox txt_street;
        private System.Windows.Forms.TextBox txt_city;
        private System.Windows.Forms.TextBox txt_building;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lab_sup;
        private System.Windows.Forms.TextBox txt_sname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_pnum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox txt_supplierreply;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DataGridViewTextBoxColumn DefectItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleOrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HandleMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Refund;
    }
}