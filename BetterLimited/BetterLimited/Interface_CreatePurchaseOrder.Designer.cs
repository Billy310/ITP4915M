namespace BetterLimited
{
    partial class Interface_CreatePurchaseOrder
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
            this.ReorderCreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReorderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lab_OrdertID = new System.Windows.Forms.Label();
            this.lb_Qty = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_items = new System.Windows.Forms.ListBox();
            this.btn_Create = new System.Windows.Forms.Button();
            this.cb_OrderID = new System.Windows.Forms.ComboBox();
            this.btn_Ordsearch = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_additem = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lab_rid = new System.Windows.Forms.Label();
            this.numericUpDown_item = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lb_Price = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lab_from = new System.Windows.Forms.Label();
            this.lab_to = new System.Windows.Forms.Label();
            this.dayFrom = new System.Windows.Forms.MonthCalendar();
            this.dayTo = new System.Windows.Forms.MonthCalendar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_purorderID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Region = new System.Windows.Forms.TextBox();
            this.txt_street = new System.Windows.Forms.TextBox();
            this.txt_city = new System.Windows.Forms.TextBox();
            this.txt_building = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lab_sup = new System.Windows.Forms.Label();
            this.txt_sname = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_pnum = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_item)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReorderCreatedDate,
            this.ReorderID,
            this.Status});
            this.dataGridView1.Location = new System.Drawing.Point(12, 35);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(437, 225);
            this.dataGridView1.TabIndex = 153;
            // 
            // ReorderCreatedDate
            // 
            this.ReorderCreatedDate.HeaderText = "ReorderCreatedDate";
            this.ReorderCreatedDate.Name = "ReorderCreatedDate";
            this.ReorderCreatedDate.ReadOnly = true;
            this.ReorderCreatedDate.Width = 180;
            // 
            // ReorderID
            // 
            this.ReorderID.HeaderText = "ReorderID";
            this.ReorderID.Name = "ReorderID";
            this.ReorderID.ReadOnly = true;
            this.ReorderID.Width = 120;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 130;
            // 
            // lab_OrdertID
            // 
            this.lab_OrdertID.AutoSize = true;
            this.lab_OrdertID.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_OrdertID.Location = new System.Drawing.Point(581, 82);
            this.lab_OrdertID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lab_OrdertID.Name = "lab_OrdertID";
            this.lab_OrdertID.Size = new System.Drawing.Size(43, 23);
            this.lab_OrdertID.TabIndex = 170;
            this.lab_OrdertID.Text = "Qty";
            // 
            // lb_Qty
            // 
            this.lb_Qty.Font = new System.Drawing.Font("Verdana", 12F);
            this.lb_Qty.FormattingEnabled = true;
            this.lb_Qty.ItemHeight = 18;
            this.lb_Qty.Location = new System.Drawing.Point(585, 107);
            this.lb_Qty.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lb_Qty.Name = "lb_Qty";
            this.lb_Qty.Size = new System.Drawing.Size(98, 382);
            this.lb_Qty.TabIndex = 169;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 23);
            this.label4.TabIndex = 166;
            this.label4.Text = "Purchase Order Item";
            // 
            // lb_items
            // 
            this.lb_items.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_items.FormattingEnabled = true;
            this.lb_items.ItemHeight = 18;
            this.lb_items.Location = new System.Drawing.Point(23, 107);
            this.lb_items.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lb_items.Name = "lb_items";
            this.lb_items.Size = new System.Drawing.Size(563, 382);
            this.lb_items.TabIndex = 165;
            // 
            // btn_Create
            // 
            this.btn_Create.BackColor = System.Drawing.Color.LawnGreen;
            this.btn_Create.Location = new System.Drawing.Point(708, 885);
            this.btn_Create.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(367, 58);
            this.btn_Create.TabIndex = 172;
            this.btn_Create.Text = "Create Purchase Order";
            this.btn_Create.UseVisualStyleBackColor = false;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // cb_OrderID
            // 
            this.cb_OrderID.FormattingEnabled = true;
            this.cb_OrderID.Location = new System.Drawing.Point(137, 18);
            this.cb_OrderID.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cb_OrderID.Name = "cb_OrderID";
            this.cb_OrderID.Size = new System.Drawing.Size(84, 26);
            this.cb_OrderID.TabIndex = 174;
            this.cb_OrderID.SelectedIndexChanged += new System.EventHandler(this.cb_OrderID_SelectedIndexChanged);
            // 
            // btn_Ordsearch
            // 
            this.btn_Ordsearch.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_Ordsearch.Location = new System.Drawing.Point(761, 231);
            this.btn_Ordsearch.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_Ordsearch.Name = "btn_Ordsearch";
            this.btn_Ordsearch.Size = new System.Drawing.Size(280, 54);
            this.btn_Ordsearch.TabIndex = 197;
            this.btn_Ordsearch.Text = "Search Order";
            this.btn_Ordsearch.UseVisualStyleBackColor = false;
            this.btn_Ordsearch.Click += new System.EventHandler(this.btn_Ordsearch_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(664, -21);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 18);
            this.label8.TabIndex = 200;
            this.label8.Text = "Create Date From :";
            // 
            // cb_additem
            // 
            this.cb_additem.FormattingEnabled = true;
            this.cb_additem.Location = new System.Drawing.Point(70, 51);
            this.cb_additem.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cb_additem.Name = "cb_additem";
            this.cb_additem.Size = new System.Drawing.Size(421, 26);
            this.cb_additem.TabIndex = 204;
            this.cb_additem.SelectedIndexChanged += new System.EventHandler(this.cmb_qty_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F);
            this.label5.Location = new System.Drawing.Point(596, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 14);
            this.label5.TabIndex = 206;
            this.label5.Text = "Item Qty :";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.LawnGreen;
            this.btn_add.Location = new System.Drawing.Point(803, 26);
            this.btn_add.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(215, 52);
            this.btn_add.TabIndex = 207;
            this.btn_add.Text = "Edit Quantity";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F);
            this.label1.Location = new System.Drawing.Point(20, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 14);
            this.label1.TabIndex = 208;
            this.label1.Text = "Item :";
            // 
            // lab_rid
            // 
            this.lab_rid.AutoSize = true;
            this.lab_rid.Font = new System.Drawing.Font("Verdana", 9F);
            this.lab_rid.Location = new System.Drawing.Point(30, 24);
            this.lab_rid.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lab_rid.Name = "lab_rid";
            this.lab_rid.Size = new System.Drawing.Size(106, 14);
            this.lab_rid.TabIndex = 209;
            this.lab_rid.Text = "Reorder List ID:";
            // 
            // numericUpDown_item
            // 
            this.numericUpDown_item.Location = new System.Drawing.Point(675, 26);
            this.numericUpDown_item.Name = "numericUpDown_item";
            this.numericUpDown_item.Size = new System.Drawing.Size(120, 27);
            this.numericUpDown_item.TabIndex = 210;
            this.numericUpDown_item.ValueChanged += new System.EventHandler(this.numericUpDown_item_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_price);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.lb_Price);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Controls.Add(this.numericUpDown_item);
            this.groupBox1.Controls.Add(this.lb_Qty);
            this.groupBox1.Controls.Add(this.cb_OrderID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lab_OrdertID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lb_items);
            this.groupBox1.Controls.Add(this.lab_rid);
            this.groupBox1.Controls.Add(this.cb_additem);
            this.groupBox1.Location = new System.Drawing.Point(35, 352);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1018, 511);
            this.groupBox1.TabIndex = 211;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Purchase Order Management";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(673, 58);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(122, 27);
            this.txt_price.TabIndex = 216;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(524, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(143, 18);
            this.label13.TabIndex = 215;
            this.label13.Text = "Price(Per Piece):";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(672, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 18);
            this.label12.TabIndex = 214;
            this.label12.Text = "Price (Per Piece)";
            // 
            // lb_Price
            // 
            this.lb_Price.Font = new System.Drawing.Font("Verdana", 12F);
            this.lb_Price.FormattingEnabled = true;
            this.lb_Price.ItemHeight = 18;
            this.lb_Price.Location = new System.Drawing.Point(675, 107);
            this.lb_Price.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lb_Price.Name = "lb_Price";
            this.lb_Price.Size = new System.Drawing.Size(98, 382);
            this.lb_Price.TabIndex = 213;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(537, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(483, 18);
            this.label3.TabIndex = 212;
            this.label3.Text = "(If The Quantity is \"0\", The Item Would Not Be Purchase)";
            // 
            // lab_from
            // 
            this.lab_from.AutoSize = true;
            this.lab_from.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_from.Location = new System.Drawing.Point(459, 35);
            this.lab_from.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lab_from.Name = "lab_from";
            this.lab_from.Size = new System.Drawing.Size(55, 18);
            this.lab_from.TabIndex = 212;
            this.lab_from.Text = "From:";
            // 
            // lab_to
            // 
            this.lab_to.AutoSize = true;
            this.lab_to.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_to.Location = new System.Drawing.Point(758, 35);
            this.lab_to.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lab_to.Name = "lab_to";
            this.lab_to.Size = new System.Drawing.Size(33, 18);
            this.lab_to.TabIndex = 213;
            this.lab_to.Text = "To:";
            // 
            // dayFrom
            // 
            this.dayFrom.Location = new System.Drawing.Point(517, 32);
            this.dayFrom.Name = "dayFrom";
            this.dayFrom.TabIndex = 214;
            // 
            // dayTo
            // 
            this.dayTo.Location = new System.Drawing.Point(804, 35);
            this.dayTo.Name = "dayTo";
            this.dayTo.TabIndex = 215;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_purorderID);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.dayTo);
            this.groupBox2.Controls.Add(this.btn_Ordsearch);
            this.groupBox2.Controls.Add(this.lab_to);
            this.groupBox2.Controls.Add(this.lab_from);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.dayFrom);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1043, 292);
            this.groupBox2.TabIndex = 216;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Reorder";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txt_purorderID
            // 
            this.txt_purorderID.Enabled = false;
            this.txt_purorderID.Location = new System.Drawing.Point(943, 0);
            this.txt_purorderID.Name = "txt_purorderID";
            this.txt_purorderID.Size = new System.Drawing.Size(100, 27);
            this.txt_purorderID.TabIndex = 216;
            this.txt_purorderID.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Salmon;
            this.button1.Location = new System.Drawing.Point(12, 896);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(367, 58);
            this.button1.TabIndex = 217;
            this.button1.Text = "Return Reorder List";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(9, 874);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(533, 18);
            this.label2.TabIndex = 218;
            this.label2.Text = "(If All The Product Can Not Purchased, Return The Reorder List)";
            this.label2.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txt_Region);
            this.groupBox3.Controls.Add(this.txt_street);
            this.groupBox3.Controls.Add(this.txt_city);
            this.groupBox3.Controls.Add(this.txt_building);
            this.groupBox3.Location = new System.Drawing.Point(1121, 109);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(554, 217);
            this.groupBox3.TabIndex = 219;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Address:";
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
            this.label7.Location = new System.Drawing.Point(166, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "Street:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(150, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 18);
            this.label9.TabIndex = 16;
            this.label9.Text = "Building:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(184, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 18);
            this.label10.TabIndex = 15;
            this.label10.Text = "City:";
            // 
            // txt_Region
            // 
            this.txt_Region.Enabled = false;
            this.txt_Region.Location = new System.Drawing.Point(237, 169);
            this.txt_Region.Name = "txt_Region";
            this.txt_Region.Size = new System.Drawing.Size(311, 27);
            this.txt_Region.TabIndex = 14;
            // 
            // txt_street
            // 
            this.txt_street.Enabled = false;
            this.txt_street.Location = new System.Drawing.Point(237, 120);
            this.txt_street.Name = "txt_street";
            this.txt_street.Size = new System.Drawing.Size(311, 27);
            this.txt_street.TabIndex = 13;
            // 
            // txt_city
            // 
            this.txt_city.Enabled = false;
            this.txt_city.Location = new System.Drawing.Point(237, 26);
            this.txt_city.Name = "txt_city";
            this.txt_city.Size = new System.Drawing.Size(311, 27);
            this.txt_city.TabIndex = 11;
            // 
            // txt_building
            // 
            this.txt_building.Enabled = false;
            this.txt_building.Location = new System.Drawing.Point(237, 71);
            this.txt_building.Name = "txt_building";
            this.txt_building.Size = new System.Drawing.Size(311, 27);
            this.txt_building.TabIndex = 12;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lab_sup);
            this.groupBox4.Controls.Add(this.txt_sname);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.txt_pnum);
            this.groupBox4.Location = new System.Drawing.Point(1121, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(554, 91);
            this.groupBox4.TabIndex = 220;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Supplier Information";
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
            this.txt_sname.Enabled = false;
            this.txt_sname.Location = new System.Drawing.Point(237, 20);
            this.txt_sname.Name = "txt_sname";
            this.txt_sname.Size = new System.Drawing.Size(311, 27);
            this.txt_sname.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(206, 18);
            this.label11.TabIndex = 8;
            this.label11.Text = "Supplier Phone Number:";
            // 
            // txt_pnum
            // 
            this.txt_pnum.Enabled = false;
            this.txt_pnum.Location = new System.Drawing.Point(237, 54);
            this.txt_pnum.Name = "txt_pnum";
            this.txt_pnum.Size = new System.Drawing.Size(311, 27);
            this.txt_pnum.TabIndex = 10;
            // 
            // Interface_CreatePurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1687, 956);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Interface_CreatePurchaseOrder";
            this.Text = "CreatePurchaseOrder";
            this.Load += new System.EventHandler(this.CreatePurchaseOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_item)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        //   private betterlimitedDataSet220528TableAdapters.reorderTableAdapter reorderTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn reorderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn approveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn product1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn product2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn product3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn product4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn product5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn product6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn product7DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn product8DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn product9DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn product10DataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lab_OrdertID;
        private System.Windows.Forms.ListBox lb_Qty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lb_items;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.ComboBox cb_OrderID;
        private System.Windows.Forms.Button btn_Ordsearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_additem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lab_rid;
        private System.Windows.Forms.NumericUpDown numericUpDown_item;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lab_from;
        private System.Windows.Forms.Label lab_to;
        private System.Windows.Forms.MonthCalendar dayFrom;
        private System.Windows.Forms.MonthCalendar dayTo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReorderCreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReorderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.TextBox txt_purorderID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_Region;
        private System.Windows.Forms.TextBox txt_street;
        private System.Windows.Forms.TextBox txt_city;
        private System.Windows.Forms.TextBox txt_building;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lab_sup;
        private System.Windows.Forms.TextBox txt_sname;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_pnum;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox lb_Price;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_price;
    }
}