namespace BetterLimited
{
    partial class Interface_EditSupplier
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
            this.lab_city = new System.Windows.Forms.Label();
            this.txt_address3 = new System.Windows.Forms.TextBox();
            this.btn_Create = new System.Windows.Forms.Button();
            this.txt_address2 = new System.Windows.Forms.TextBox();
            this.txt_address1 = new System.Windows.Forms.TextBox();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lab_Phonenum = new System.Windows.Forms.Label();
            this.lab_adress2 = new System.Windows.Forms.Label();
            this.lab_adress1 = new System.Windows.Forms.Label();
            this.lab_name = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_region = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SupplierID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb_suppliername = new System.Windows.Forms.ComboBox();
            this.txt_supid = new System.Windows.Forms.TextBox();
            this.cb_Regionp = new System.Windows.Forms.ComboBox();
            this.txt_pum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox_changephonenum = new System.Windows.Forms.CheckBox();
            this.cb_regionname = new System.Windows.Forms.ComboBox();
            this.combo_Region = new System.Windows.Forms.ComboBox();
            this.checkBox_region = new System.Windows.Forms.CheckBox();
            this.label_region = new System.Windows.Forms.Label();
            this.btn_available = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_city
            // 
            this.lab_city.AutoSize = true;
            this.lab_city.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_city.Location = new System.Drawing.Point(180, 273);
            this.lab_city.Name = "lab_city";
            this.lab_city.Size = new System.Drawing.Size(71, 18);
            this.lab_city.TabIndex = 27;
            this.lab_city.Text = "Street :";
            this.lab_city.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_address3
            // 
            this.txt_address3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address3.Location = new System.Drawing.Point(257, 270);
            this.txt_address3.Name = "txt_address3";
            this.txt_address3.Size = new System.Drawing.Size(427, 27);
            this.txt_address3.TabIndex = 26;
            this.txt_address3.TextChanged += new System.EventHandler(this.txt_address3_TextChanged);
            // 
            // btn_Create
            // 
            this.btn_Create.BackColor = System.Drawing.Color.LawnGreen;
            this.btn_Create.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Create.Location = new System.Drawing.Point(499, 418);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(185, 60);
            this.btn_Create.TabIndex = 25;
            this.btn_Create.Text = "Save";
            this.btn_Create.UseVisualStyleBackColor = false;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // txt_address2
            // 
            this.txt_address2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address2.Location = new System.Drawing.Point(257, 237);
            this.txt_address2.Name = "txt_address2";
            this.txt_address2.Size = new System.Drawing.Size(427, 27);
            this.txt_address2.TabIndex = 24;
            this.txt_address2.TextChanged += new System.EventHandler(this.txt_address2_TextChanged);
            // 
            // txt_address1
            // 
            this.txt_address1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address1.Location = new System.Drawing.Point(257, 200);
            this.txt_address1.Name = "txt_address1";
            this.txt_address1.Size = new System.Drawing.Size(427, 27);
            this.txt_address1.TabIndex = 23;
            this.txt_address1.TextChanged += new System.EventHandler(this.txt_address1_TextChanged);
            // 
            // txt_tel
            // 
            this.txt_tel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tel.Location = new System.Drawing.Point(416, 163);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(268, 27);
            this.txt_tel.TabIndex = 22;
            this.txt_tel.TextChanged += new System.EventHandler(this.txt_pnum_TextChanged);
            this.txt_tel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tel_keypress);
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(257, 71);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(427, 27);
            this.txt_name.TabIndex = 21;
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            // 
            // lab_Phonenum
            // 
            this.lab_Phonenum.AutoSize = true;
            this.lab_Phonenum.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Phonenum.Location = new System.Drawing.Point(123, 167);
            this.lab_Phonenum.Name = "lab_Phonenum";
            this.lab_Phonenum.Size = new System.Drawing.Size(134, 18);
            this.lab_Phonenum.TabIndex = 20;
            this.lab_Phonenum.Text = "Phone Number:";
            this.lab_Phonenum.Click += new System.EventHandler(this.lab_Phonenum_Click);
            // 
            // lab_adress2
            // 
            this.lab_adress2.AutoSize = true;
            this.lab_adress2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_adress2.Location = new System.Drawing.Point(167, 240);
            this.lab_adress2.Name = "lab_adress2";
            this.lab_adress2.Size = new System.Drawing.Size(87, 18);
            this.lab_adress2.TabIndex = 19;
            this.lab_adress2.Text = "Building :";
            this.lab_adress2.Click += new System.EventHandler(this.lab_adress2_Click);
            // 
            // lab_adress1
            // 
            this.lab_adress1.AutoSize = true;
            this.lab_adress1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_adress1.Location = new System.Drawing.Point(198, 203);
            this.lab_adress1.Name = "lab_adress1";
            this.lab_adress1.Size = new System.Drawing.Size(53, 18);
            this.lab_adress1.TabIndex = 18;
            this.lab_adress1.Text = "City :";
            this.lab_adress1.Click += new System.EventHandler(this.lab_adress1_Click);
            // 
            // lab_name
            // 
            this.lab_name.AutoSize = true;
            this.lab_name.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_name.Location = new System.Drawing.Point(123, 74);
            this.lab_name.Name = "lab_name";
            this.lab_name.Size = new System.Drawing.Size(134, 18);
            this.lab_name.TabIndex = 17;
            this.lab_name.Text = "Supplier Name:";
            this.lab_name.Click += new System.EventHandler(this.lab_name_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(960, 12);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(145, 44);
            this.btn_Search.TabIndex = 28;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(670, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 18);
            this.label3.TabIndex = 32;
            this.label3.Text = "Supplier Name:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(183, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 34;
            this.label4.Text = "Region:";
            // 
            // txt_region
            // 
            this.txt_region.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_region.Location = new System.Drawing.Point(257, 306);
            this.txt_region.Name = "txt_region";
            this.txt_region.Size = new System.Drawing.Size(427, 27);
            this.txt_region.TabIndex = 33;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(117, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 60);
            this.button1.TabIndex = 35;
            this.button1.Text = "Make Supplier Unavailable";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SupplierID,
            this.SupplierName,
            this.PhoneNumber});
            this.dataGridView1.Location = new System.Drawing.Point(727, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(339, 417);
            this.dataGridView1.TabIndex = 36;
            // 
            // SupplierID
            // 
            this.SupplierID.HeaderText = "SupplierID";
            this.SupplierID.Name = "SupplierID";
            this.SupplierID.ReadOnly = true;
            // 
            // SupplierName
            // 
            this.SupplierName.HeaderText = "Supplier Name";
            this.SupplierName.Name = "SupplierName";
            this.SupplierName.ReadOnly = true;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.HeaderText = "PhoneNumber";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            // 
            // cb_suppliername
            // 
            this.cb_suppliername.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_suppliername.FormattingEnabled = true;
            this.cb_suppliername.Location = new System.Drawing.Point(810, 22);
            this.cb_suppliername.Name = "cb_suppliername";
            this.cb_suppliername.Size = new System.Drawing.Size(144, 26);
            this.cb_suppliername.TabIndex = 37;
            this.cb_suppliername.SelectedIndexChanged += new System.EventHandler(this.cb_suppliername_SelectedIndexChanged);
            // 
            // txt_supid
            // 
            this.txt_supid.Location = new System.Drawing.Point(846, -6);
            this.txt_supid.Name = "txt_supid";
            this.txt_supid.Size = new System.Drawing.Size(100, 22);
            this.txt_supid.TabIndex = 38;
            this.txt_supid.Visible = false;
            // 
            // cb_Regionp
            // 
            this.cb_Regionp.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Regionp.FormattingEnabled = true;
            this.cb_Regionp.Items.AddRange(new object[] {
            "+852",
            "+86"});
            this.cb_Regionp.Location = new System.Drawing.Point(257, 164);
            this.cb_Regionp.Name = "cb_Regionp";
            this.cb_Regionp.Size = new System.Drawing.Size(153, 26);
            this.cb_Regionp.TabIndex = 64;
            this.cb_Regionp.SelectedIndexChanged += new System.EventHandler(this.cb_Regionp_SelectedIndexChanged);
            // 
            // txt_pum
            // 
            this.txt_pum.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pum.Location = new System.Drawing.Point(257, 104);
            this.txt_pum.Name = "txt_pum";
            this.txt_pum.Size = new System.Drawing.Size(427, 27);
            this.txt_pum.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 18);
            this.label2.TabIndex = 66;
            this.label2.Text = "Phone Number:";
            // 
            // checkBox_changephonenum
            // 
            this.checkBox_changephonenum.AutoSize = true;
            this.checkBox_changephonenum.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_changephonenum.Location = new System.Drawing.Point(126, 136);
            this.checkBox_changephonenum.Name = "checkBox_changephonenum";
            this.checkBox_changephonenum.Size = new System.Drawing.Size(207, 22);
            this.checkBox_changephonenum.TabIndex = 67;
            this.checkBox_changephonenum.Text = "Change PhoneNumber";
            this.checkBox_changephonenum.UseVisualStyleBackColor = true;
            this.checkBox_changephonenum.CheckedChanged += new System.EventHandler(this.checkBox_changephonenum_CheckedChanged);
            // 
            // cb_regionname
            // 
            this.cb_regionname.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_regionname.FormattingEnabled = true;
            this.cb_regionname.Location = new System.Drawing.Point(416, 364);
            this.cb_regionname.Name = "cb_regionname";
            this.cb_regionname.Size = new System.Drawing.Size(268, 26);
            this.cb_regionname.TabIndex = 69;
            this.cb_regionname.SelectedIndexChanged += new System.EventHandler(this.cb_regionname_SelectedIndexChanged);
            // 
            // combo_Region
            // 
            this.combo_Region.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_Region.FormattingEnabled = true;
            this.combo_Region.Items.AddRange(new object[] {
            "Hong Kong",
            "China"});
            this.combo_Region.Location = new System.Drawing.Point(250, 364);
            this.combo_Region.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.combo_Region.Name = "combo_Region";
            this.combo_Region.Size = new System.Drawing.Size(158, 26);
            this.combo_Region.TabIndex = 68;
            this.combo_Region.SelectedIndexChanged += new System.EventHandler(this.combo_Region_SelectedIndexChanged);
            // 
            // checkBox_region
            // 
            this.checkBox_region.AutoSize = true;
            this.checkBox_region.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_region.Location = new System.Drawing.Point(126, 334);
            this.checkBox_region.Name = "checkBox_region";
            this.checkBox_region.Size = new System.Drawing.Size(150, 22);
            this.checkBox_region.TabIndex = 70;
            this.checkBox_region.Text = "Change Region";
            this.checkBox_region.UseVisualStyleBackColor = true;
            this.checkBox_region.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label_region
            // 
            this.label_region.AutoSize = true;
            this.label_region.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_region.Location = new System.Drawing.Point(100, 367);
            this.label_region.Name = "label_region";
            this.label_region.Size = new System.Drawing.Size(142, 18);
            this.label_region.TabIndex = 71;
            this.label_region.Text = "Update Region :";
            // 
            // btn_available
            // 
            this.btn_available.BackColor = System.Drawing.Color.LawnGreen;
            this.btn_available.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_available.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_available.Location = new System.Drawing.Point(308, 418);
            this.btn_available.Name = "btn_available";
            this.btn_available.Size = new System.Drawing.Size(185, 60);
            this.btn_available.TabIndex = 73;
            this.btn_available.Text = "Make Supplier Available";
            this.btn_available.UseVisualStyleBackColor = false;
            this.btn_available.Click += new System.EventHandler(this.btn_available_Click);
            // 
            // EditSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 521);
            this.Controls.Add(this.btn_available);
            this.Controls.Add(this.label_region);
            this.Controls.Add(this.checkBox_region);
            this.Controls.Add(this.cb_regionname);
            this.Controls.Add(this.combo_Region);
            this.Controls.Add(this.checkBox_changephonenum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_pum);
            this.Controls.Add(this.cb_Regionp);
            this.Controls.Add(this.txt_supid);
            this.Controls.Add(this.cb_suppliername);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_region);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.lab_city);
            this.Controls.Add(this.txt_address3);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.txt_address2);
            this.Controls.Add(this.txt_address1);
            this.Controls.Add(this.txt_tel);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lab_Phonenum);
            this.Controls.Add(this.lab_adress2);
            this.Controls.Add(this.lab_adress1);
            this.Controls.Add(this.lab_name);
            this.Name = "EditSupplier";
            this.Text = "Edit Supplier";
            this.Load += new System.EventHandler(this.EditSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_city;
        private System.Windows.Forms.TextBox txt_address3;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.TextBox txt_address2;
        private System.Windows.Forms.TextBox txt_address1;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lab_Phonenum;
        private System.Windows.Forms.Label lab_adress2;
        private System.Windows.Forms.Label lab_adress1;
        private System.Windows.Forms.Label lab_name;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_region;
        private System.Windows.Forms.Button button1;
        //private betterlimitedDataSetTestTableAdapters.supplierTableAdapter supplierTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.ComboBox cb_suppliername;
        private System.Windows.Forms.TextBox txt_supid;
        private System.Windows.Forms.ComboBox cb_Regionp;
        private System.Windows.Forms.TextBox txt_pum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox_changephonenum;
        private System.Windows.Forms.ComboBox cb_regionname;
        private System.Windows.Forms.ComboBox combo_Region;
        private System.Windows.Forms.CheckBox checkBox_region;
        private System.Windows.Forms.Label label_region;
        private System.Windows.Forms.Button btn_available;
    }
}