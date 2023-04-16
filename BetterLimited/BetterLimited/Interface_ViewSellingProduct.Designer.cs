namespace BetterLimited
{
    partial class Interface_ViewSellingProduct
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_pname = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lab_from = new System.Windows.Forms.Label();
            this.lab_to = new System.Windows.Forms.Label();
            this.dayFrom = new System.Windows.Forms.MonthCalendar();
            this.dayTo = new System.Windows.Forms.MonthCalendar();
            this.btn_search = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SaleOrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.ProductID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.lab_todayquantity = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lab_total = new System.Windows.Forms.Label();
            this.lab_amount = new System.Windows.Forms.Label();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lab_kbtotaL = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lab_TWtotal = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_pname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.lab_from);
            this.groupBox1.Controls.Add(this.lab_to);
            this.groupBox1.Controls.Add(this.dayFrom);
            this.groupBox1.Controls.Add(this.dayTo);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Location = new System.Drawing.Point(10, 165);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(1223, 286);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cb_pname
            // 
            this.cb_pname.FormattingEnabled = true;
            this.cb_pname.Location = new System.Drawing.Point(916, 74);
            this.cb_pname.Name = "cb_pname";
            this.cb_pname.Size = new System.Drawing.Size(297, 26);
            this.cb_pname.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(781, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Product Name:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(916, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(297, 26);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Visible = false;
            // 
            // lab_from
            // 
            this.lab_from.AutoSize = true;
            this.lab_from.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_from.Location = new System.Drawing.Point(0, 34);
            this.lab_from.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lab_from.Name = "lab_from";
            this.lab_from.Size = new System.Drawing.Size(55, 18);
            this.lab_from.TabIndex = 3;
            this.lab_from.Text = "From:";
            // 
            // lab_to
            // 
            this.lab_to.AutoSize = true;
            this.lab_to.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_to.Location = new System.Drawing.Point(340, 34);
            this.lab_to.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lab_to.Name = "lab_to";
            this.lab_to.Size = new System.Drawing.Size(33, 18);
            this.lab_to.TabIndex = 4;
            this.lab_to.Text = "To:";
            // 
            // dayFrom
            // 
            this.dayFrom.Location = new System.Drawing.Point(90, 34);
            this.dayFrom.Margin = new System.Windows.Forms.Padding(15, 14, 15, 14);
            this.dayFrom.Name = "dayFrom";
            this.dayFrom.TabIndex = 7;
            // 
            // dayTo
            // 
            this.dayTo.Location = new System.Drawing.Point(396, 34);
            this.dayTo.Margin = new System.Windows.Forms.Padding(15, 14, 15, 14);
            this.dayTo.Name = "dayTo";
            this.dayTo.TabIndex = 8;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Azure;
            this.btn_search.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(991, 188);
            this.btn_search.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(222, 69);
            this.btn_search.TabIndex = 5;
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
            this.SaleOrderID});
            this.dataGridView1.Location = new System.Drawing.Point(191, 9);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(515, 253);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.Visible = false;
            // 
            // SaleOrderID
            // 
            this.SaleOrderID.HeaderText = "SaleOrderID";
            this.SaleOrderID.Name = "SaleOrderID";
            this.SaleOrderID.ReadOnly = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID});
            this.dataGridView2.Location = new System.Drawing.Point(716, 10);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(143, 253);
            this.dataGridView2.TabIndex = 13;
            this.dataGridView2.Visible = false;
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "ProductID";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1853, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "label1";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID1,
            this.Quantity,
            this.Price});
            this.dataGridView3.Location = new System.Drawing.Point(877, 9);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(509, 253);
            this.dataGridView3.TabIndex = 16;
            this.dataGridView3.Visible = false;
            // 
            // ProductID1
            // 
            this.ProductID1.HeaderText = "ProductID";
            this.ProductID1.Name = "ProductID1";
            this.ProductID1.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Total Selling Quantity:";
            // 
            // lab_todayquantity
            // 
            this.lab_todayquantity.AutoSize = true;
            this.lab_todayquantity.Location = new System.Drawing.Point(518, 19);
            this.lab_todayquantity.Name = "lab_todayquantity";
            this.lab_todayquantity.Size = new System.Drawing.Size(58, 18);
            this.lab_todayquantity.TabIndex = 18;
            this.lab_todayquantity.Text = "label4";
            this.lab_todayquantity.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "Store (Kowloon Bay Store):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(301, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 18);
            this.label5.TabIndex = 20;
            this.label5.Text = "Store(Tsuen Wan Store):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(518, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 18);
            this.label6.TabIndex = 21;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(518, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 18);
            this.label7.TabIndex = 22;
            this.label7.Text = "label7";
            this.label7.Visible = false;
            // 
            // lab_total
            // 
            this.lab_total.AutoSize = true;
            this.lab_total.Location = new System.Drawing.Point(636, 19);
            this.lab_total.Name = "lab_total";
            this.lab_total.Size = new System.Drawing.Size(55, 18);
            this.lab_total.TabIndex = 23;
            this.lab_total.Text = "Total:";
            // 
            // lab_amount
            // 
            this.lab_amount.AutoSize = true;
            this.lab_amount.Location = new System.Drawing.Point(697, 19);
            this.lab_amount.Name = "lab_amount";
            this.lab_amount.Size = new System.Drawing.Size(58, 18);
            this.lab_amount.TabIndex = 24;
            this.lab_amount.Text = "label8";
            this.lab_amount.Visible = false;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView4.Location = new System.Drawing.Point(350, 10);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(509, 253);
            this.dataGridView4.TabIndex = 25;
            this.dataGridView4.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ProductID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Price";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // lab_kbtotaL
            // 
            this.lab_kbtotaL.AutoSize = true;
            this.lab_kbtotaL.Location = new System.Drawing.Point(633, 50);
            this.lab_kbtotaL.Name = "lab_kbtotaL";
            this.lab_kbtotaL.Size = new System.Drawing.Size(55, 18);
            this.lab_kbtotaL.TabIndex = 26;
            this.lab_kbtotaL.Text = "Total:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(694, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 18);
            this.label8.TabIndex = 27;
            this.label8.Text = "label8";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(636, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 18);
            this.label9.TabIndex = 28;
            this.label9.Text = "Total:";
            // 
            // lab_TWtotal
            // 
            this.lab_TWtotal.AutoSize = true;
            this.lab_TWtotal.Location = new System.Drawing.Point(694, 82);
            this.lab_TWtotal.Name = "lab_TWtotal";
            this.lab_TWtotal.Size = new System.Drawing.Size(68, 18);
            this.lab_TWtotal.TabIndex = 29;
            this.lab_TWtotal.Text = "label10";
            this.lab_TWtotal.Visible = false;
            // 
            // Interface_ViewSellingProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 473);
            this.Controls.Add(this.lab_TWtotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lab_kbtotaL);
            this.Controls.Add(this.lab_amount);
            this.Controls.Add(this.lab_total);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lab_todayquantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Interface_ViewSellingProduct";
            this.Text = "Interface_ViewSellingProduct";
            this.Load += new System.EventHandler(this.Interface_ViewSellingProduct_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lab_from;
        private System.Windows.Forms.Label lab_to;
        private System.Windows.Forms.MonthCalendar dayFrom;
        private System.Windows.Forms.MonthCalendar dayTo;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleOrderID;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lab_todayquantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_pname;
        private System.Windows.Forms.Label lab_total;
        private System.Windows.Forms.Label lab_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label lab_kbtotaL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lab_TWtotal;
    }
}