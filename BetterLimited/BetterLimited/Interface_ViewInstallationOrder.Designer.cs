namespace BetterLimited
{
    partial class Interface_ViewInstallationOrder
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
            this.lab_to = new System.Windows.Forms.Label();
            this.lab_from = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.OrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayTo = new System.Windows.Forms.MonthCalendar();
            this.dayFrom = new System.Windows.Forms.MonthCalendar();
            this.checkBox_Today = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_mydeliveryOrder = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lab_CountNum = new System.Windows.Forms.Label();
            this.lab_Count = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_deliverystatus = new System.Windows.Forms.TextBox();
            this.lab_deliveryStat = new System.Windows.Forms.Label();
            this.lab_Quantity = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_productname = new System.Windows.Forms.ListBox();
            this.lb_qty = new System.Windows.Forms.ListBox();
            this.txt_phone2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_cnum = new System.Windows.Forms.TextBox();
            this.txt_cname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lab_cname = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Region = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_street = new System.Windows.Forms.TextBox();
            this.txt_building = new System.Windows.Forms.TextBox();
            this.txt_city = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.lab_Order = new System.Windows.Forms.Label();
            this.cb_OrderID = new System.Windows.Forms.ComboBox();
            this.dataGridView_item = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_item)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_to
            // 
            this.lab_to.AutoSize = true;
            this.lab_to.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_to.Location = new System.Drawing.Point(265, 24);
            this.lab_to.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lab_to.Name = "lab_to";
            this.lab_to.Size = new System.Drawing.Size(33, 18);
            this.lab_to.TabIndex = 15;
            this.lab_to.Text = "To:";
            // 
            // lab_from
            // 
            this.lab_from.AutoSize = true;
            this.lab_from.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_from.Location = new System.Drawing.Point(13, 24);
            this.lab_from.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lab_from.Name = "lab_from";
            this.lab_from.Size = new System.Drawing.Size(55, 18);
            this.lab_from.TabIndex = 14;
            this.lab_from.Text = "From:";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(572, 24);
            this.btn_search.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(338, 69);
            this.btn_search.TabIndex = 5;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderID,
            this.Date});
            this.dataGridView1.Location = new System.Drawing.Point(8, 17);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(267, 478);
            this.dataGridView1.TabIndex = 16;
            // 
            // OrderID
            // 
            this.OrderID.HeaderText = "OrderID";
            this.OrderID.Name = "OrderID";
            this.OrderID.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 125;
            // 
            // dayTo
            // 
            this.dayTo.Location = new System.Drawing.Point(302, 56);
            this.dayTo.Margin = new System.Windows.Forms.Padding(15, 14, 15, 14);
            this.dayTo.Name = "dayTo";
            this.dayTo.TabIndex = 18;
            // 
            // dayFrom
            // 
            this.dayFrom.Location = new System.Drawing.Point(16, 56);
            this.dayFrom.Margin = new System.Windows.Forms.Padding(15, 14, 15, 14);
            this.dayFrom.Name = "dayFrom";
            this.dayFrom.TabIndex = 17;
            // 
            // checkBox_Today
            // 
            this.checkBox_Today.AutoSize = true;
            this.checkBox_Today.Location = new System.Drawing.Point(572, 101);
            this.checkBox_Today.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.checkBox_Today.Name = "checkBox_Today";
            this.checkBox_Today.Size = new System.Drawing.Size(226, 22);
            this.checkBox_Today.TabIndex = 9;
            this.checkBox_Today.Text = "Today Installation Order";
            this.checkBox_Today.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lab_to);
            this.groupBox1.Controls.Add(this.dayTo);
            this.groupBox1.Controls.Add(this.checkBox_mydeliveryOrder);
            this.groupBox1.Controls.Add(this.lab_from);
            this.groupBox1.Controls.Add(this.checkBox_Today);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.dayFrom);
            this.groupBox1.Location = new System.Drawing.Point(4, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(953, 237);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // checkBox_mydeliveryOrder
            // 
            this.checkBox_mydeliveryOrder.AutoSize = true;
            this.checkBox_mydeliveryOrder.Location = new System.Drawing.Point(572, 131);
            this.checkBox_mydeliveryOrder.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.checkBox_mydeliveryOrder.Name = "checkBox_mydeliveryOrder";
            this.checkBox_mydeliveryOrder.Size = new System.Drawing.Size(246, 22);
            this.checkBox_mydeliveryOrder.TabIndex = 0;
            this.checkBox_mydeliveryOrder.Text = "View My Installation Order";
            this.checkBox_mydeliveryOrder.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1418, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "staffID";
            this.label1.Visible = false;
            // 
            // lab_CountNum
            // 
            this.lab_CountNum.AutoSize = true;
            this.lab_CountNum.Location = new System.Drawing.Point(575, 1125);
            this.lab_CountNum.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lab_CountNum.Name = "lab_CountNum";
            this.lab_CountNum.Size = new System.Drawing.Size(56, 18);
            this.lab_CountNum.TabIndex = 21;
            this.lab_CountNum.Text = "Count";
            // 
            // lab_Count
            // 
            this.lab_Count.AutoSize = true;
            this.lab_Count.Location = new System.Drawing.Point(137, 1125);
            this.lab_Count.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lab_Count.Name = "lab_Count";
            this.lab_Count.Size = new System.Drawing.Size(257, 18);
            this.lab_Count.TabIndex = 20;
            this.lab_Count.Text = "Total Count Of Delivery Order:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_deliverystatus);
            this.groupBox2.Controls.Add(this.lab_deliveryStat);
            this.groupBox2.Controls.Add(this.lab_Quantity);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lb_productname);
            this.groupBox2.Controls.Add(this.lb_qty);
            this.groupBox2.Controls.Add(this.txt_phone2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_cnum);
            this.groupBox2.Controls.Add(this.txt_cname);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lab_cname);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.btn_Edit);
            this.groupBox2.Controls.Add(this.lab_Order);
            this.groupBox2.Controls.Add(this.cb_OrderID);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(4, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1530, 558);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delivery Order List";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txt_deliverystatus
            // 
            this.txt_deliverystatus.Enabled = false;
            this.txt_deliverystatus.Location = new System.Drawing.Point(508, 76);
            this.txt_deliverystatus.Name = "txt_deliverystatus";
            this.txt_deliverystatus.Size = new System.Drawing.Size(402, 27);
            this.txt_deliverystatus.TabIndex = 43;
            // 
            // lab_deliveryStat
            // 
            this.lab_deliveryStat.AutoSize = true;
            this.lab_deliveryStat.Location = new System.Drawing.Point(362, 79);
            this.lab_deliveryStat.Name = "lab_deliveryStat";
            this.lab_deliveryStat.Size = new System.Drawing.Size(140, 18);
            this.lab_deliveryStat.TabIndex = 42;
            this.lab_deliveryStat.Text = "Delivery Status:";
            // 
            // lab_Quantity
            // 
            this.lab_Quantity.AutoSize = true;
            this.lab_Quantity.Location = new System.Drawing.Point(801, 108);
            this.lab_Quantity.Name = "lab_Quantity";
            this.lab_Quantity.Size = new System.Drawing.Size(79, 18);
            this.lab_Quantity.TabIndex = 41;
            this.lab_Quantity.Text = "Quantity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(334, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(230, 18);
            this.label8.TabIndex = 40;
            this.label8.Text = "Installation Product Name:";
            // 
            // lb_productname
            // 
            this.lb_productname.Enabled = false;
            this.lb_productname.FormattingEnabled = true;
            this.lb_productname.ItemHeight = 18;
            this.lb_productname.Location = new System.Drawing.Point(337, 130);
            this.lb_productname.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lb_productname.Name = "lb_productname";
            this.lb_productname.Size = new System.Drawing.Size(468, 454);
            this.lb_productname.TabIndex = 38;
            // 
            // lb_qty
            // 
            this.lb_qty.Enabled = false;
            this.lb_qty.FormattingEnabled = true;
            this.lb_qty.ItemHeight = 18;
            this.lb_qty.Location = new System.Drawing.Point(804, 130);
            this.lb_qty.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lb_qty.Name = "lb_qty";
            this.lb_qty.Size = new System.Drawing.Size(106, 454);
            this.lb_qty.TabIndex = 39;
            // 
            // txt_phone2
            // 
            this.txt_phone2.Enabled = false;
            this.txt_phone2.Location = new System.Drawing.Point(1317, 97);
            this.txt_phone2.Name = "txt_phone2";
            this.txt_phone2.Size = new System.Drawing.Size(207, 27);
            this.txt_phone2.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1058, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(251, 18);
            this.label7.TabIndex = 36;
            this.label7.Text = "Contact Number(Alternative):";
            // 
            // txt_cnum
            // 
            this.txt_cnum.Enabled = false;
            this.txt_cnum.Location = new System.Drawing.Point(1211, 60);
            this.txt_cnum.Name = "txt_cnum";
            this.txt_cnum.Size = new System.Drawing.Size(313, 27);
            this.txt_cnum.TabIndex = 35;
            // 
            // txt_cname
            // 
            this.txt_cname.Enabled = false;
            this.txt_cname.Location = new System.Drawing.Point(1211, 27);
            this.txt_cname.Name = "txt_cname";
            this.txt_cname.Size = new System.Drawing.Size(313, 27);
            this.txt_cname.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1058, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 18);
            this.label2.TabIndex = 33;
            this.label2.Text = "Contact Number:";
            // 
            // lab_cname
            // 
            this.lab_cname.AutoSize = true;
            this.lab_cname.Location = new System.Drawing.Point(1059, 30);
            this.lab_cname.Name = "lab_cname";
            this.lab_cname.Size = new System.Drawing.Size(146, 18);
            this.lab_cname.TabIndex = 32;
            this.lab_cname.Text = "Customer Name:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txt_Region);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txt_street);
            this.groupBox3.Controls.Add(this.txt_building);
            this.groupBox3.Controls.Add(this.txt_city);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(1061, 130);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(472, 490);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 18);
            this.label6.TabIndex = 33;
            this.label6.Text = "Region:";
            // 
            // txt_Region
            // 
            this.txt_Region.Enabled = false;
            this.txt_Region.Location = new System.Drawing.Point(98, 119);
            this.txt_Region.Name = "txt_Region";
            this.txt_Region.Size = new System.Drawing.Size(368, 27);
            this.txt_Region.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 18);
            this.label5.TabIndex = 31;
            this.label5.Text = "Street:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 18);
            this.label4.TabIndex = 30;
            this.label4.Text = "Building:";
            // 
            // txt_street
            // 
            this.txt_street.Enabled = false;
            this.txt_street.Location = new System.Drawing.Point(98, 86);
            this.txt_street.Name = "txt_street";
            this.txt_street.Size = new System.Drawing.Size(368, 27);
            this.txt_street.TabIndex = 29;
            // 
            // txt_building
            // 
            this.txt_building.Enabled = false;
            this.txt_building.Location = new System.Drawing.Point(98, 53);
            this.txt_building.Name = "txt_building";
            this.txt_building.Size = new System.Drawing.Size(368, 27);
            this.txt_building.TabIndex = 28;
            // 
            // txt_city
            // 
            this.txt_city.Enabled = false;
            this.txt_city.Location = new System.Drawing.Point(98, 20);
            this.txt_city.Name = "txt_city";
            this.txt_city.Size = new System.Drawing.Size(368, 27);
            this.txt_city.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 18);
            this.label3.TabIndex = 26;
            this.label3.Text = "City:";
            // 
            // btn_Edit
            // 
            this.btn_Edit.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_Edit.Location = new System.Drawing.Point(661, 17);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(259, 44);
            this.btn_Edit.TabIndex = 19;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = false;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // lab_Order
            // 
            this.lab_Order.AutoSize = true;
            this.lab_Order.Location = new System.Drawing.Point(343, 30);
            this.lab_Order.Name = "lab_Order";
            this.lab_Order.Size = new System.Drawing.Size(186, 18);
            this.lab_Order.TabIndex = 18;
            this.lab_Order.Text = "Installation Order ID:";
            // 
            // cb_OrderID
            // 
            this.cb_OrderID.FormattingEnabled = true;
            this.cb_OrderID.Location = new System.Drawing.Point(531, 26);
            this.cb_OrderID.Name = "cb_OrderID";
            this.cb_OrderID.Size = new System.Drawing.Size(102, 26);
            this.cb_OrderID.TabIndex = 17;
            this.cb_OrderID.SelectedIndexChanged += new System.EventHandler(this.cb_OrderID_SelectedIndexChanged);
            // 
            // dataGridView_item
            // 
            this.dataGridView_item.AllowUserToAddRows = false;
            this.dataGridView_item.AllowUserToDeleteRows = false;
            this.dataGridView_item.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_item.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.Quantity});
            this.dataGridView_item.Location = new System.Drawing.Point(1065, 51);
            this.dataGridView_item.Name = "dataGridView_item";
            this.dataGridView_item.ReadOnly = true;
            this.dataGridView_item.RowTemplate.Height = 24;
            this.dataGridView_item.Size = new System.Drawing.Size(240, 150);
            this.dataGridView_item.TabIndex = 44;
            this.dataGridView_item.Visible = false;
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "ProductID";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Interface_ViewInstallationOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1546, 837);
            this.Controls.Add(this.dataGridView_item);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lab_CountNum);
            this.Controls.Add(this.lab_Count);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Interface_ViewInstallationOrder";
            this.Text = "Interface_ViewInstallationOrder";
            this.Load += new System.EventHandler(this.Interface_ViewInstallationOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_item)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_to;
        private System.Windows.Forms.Label lab_from;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.MonthCalendar dayTo;
        private System.Windows.Forms.MonthCalendar dayFrom;
        private System.Windows.Forms.CheckBox checkBox_Today;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox_mydeliveryOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lab_CountNum;
        private System.Windows.Forms.Label lab_Count;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cb_OrderID;
        private System.Windows.Forms.Label lab_Order;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Region;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_street;
        private System.Windows.Forms.TextBox txt_building;
        private System.Windows.Forms.TextBox txt_city;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_phone2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_cnum;
        private System.Windows.Forms.TextBox txt_cname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lab_cname;
        private System.Windows.Forms.Label lab_Quantity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lb_productname;
        private System.Windows.Forms.ListBox lb_qty;
        private System.Windows.Forms.Label lab_deliveryStat;
        private System.Windows.Forms.TextBox txt_deliverystatus;
        private System.Windows.Forms.DataGridView dataGridView_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
    }
}