namespace BetterLimited
{
    partial class Interface_EditStore
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
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.txt_address3 = new System.Windows.Forms.TextBox();
            this.txt_address2 = new System.Windows.Forms.TextBox();
            this.txt_address1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.combobox_storeID = new System.Windows.Forms.ComboBox();
            this.lab_search = new System.Windows.Forms.Label();
            this.btn_disable = new System.Windows.Forms.Button();
            this.lab_Thirdaddress = new System.Windows.Forms.Label();
            this.lab_Secondaddress = new System.Windows.Forms.Label();
            this.lab_FirstLine = new System.Windows.Forms.Label();
            this.checkBox_changephonenum = new System.Windows.Forms.CheckBox();
            this.cb_Regionp = new System.Windows.Forms.ComboBox();
            this.txt_pnum = new System.Windows.Forms.TextBox();
            this.txt_region = new System.Windows.Forms.TextBox();
            this.checkBox_region = new System.Windows.Forms.CheckBox();
            this.cb_regionname = new System.Windows.Forms.ComboBox();
            this.combo_Region = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.StoreID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoreName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoreManager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lab_Phonenum = new System.Windows.Forms.Label();
            this.combobox_staffID = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_managername = new System.Windows.Forms.TextBox();
            this.checkBox_storemanager = new System.Windows.Forms.CheckBox();
            this.txt_StoreName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBox_changename = new System.Windows.Forms.CheckBox();
            this.txt_newname = new System.Windows.Forms.TextBox();
            this.btn_available = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_tel
            // 
            this.txt_tel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tel.Location = new System.Drawing.Point(236, 196);
            this.txt_tel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(513, 27);
            this.txt_tel.TabIndex = 22;
            this.txt_tel.TextChanged += new System.EventHandler(this.txt_tel_TextChanged);
            // 
            // txt_address3
            // 
            this.txt_address3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address3.Location = new System.Drawing.Point(236, 336);
            this.txt_address3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_address3.Name = "txt_address3";
            this.txt_address3.Size = new System.Drawing.Size(513, 27);
            this.txt_address3.TabIndex = 20;
            this.txt_address3.TextChanged += new System.EventHandler(this.txt_address3_TextChanged);
            // 
            // txt_address2
            // 
            this.txt_address2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address2.Location = new System.Drawing.Point(236, 301);
            this.txt_address2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_address2.Name = "txt_address2";
            this.txt_address2.Size = new System.Drawing.Size(513, 27);
            this.txt_address2.TabIndex = 19;
            this.txt_address2.TextChanged += new System.EventHandler(this.txt_address2_TextChanged);
            // 
            // txt_address1
            // 
            this.txt_address1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address1.Location = new System.Drawing.Point(236, 266);
            this.txt_address1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_address1.Name = "txt_address1";
            this.txt_address1.Size = new System.Drawing.Size(513, 27);
            this.txt_address1.TabIndex = 18;
            this.txt_address1.TextChanged += new System.EventHandler(this.txt_address1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(152, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Region:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.LawnGreen;
            this.btn_save.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(503, 471);
            this.btn_save.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(246, 58);
            this.btn_save.TabIndex = 25;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.button2_Click);
            // 
            // combobox_storeID
            // 
            this.combobox_storeID.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combobox_storeID.FormattingEnabled = true;
            this.combobox_storeID.Location = new System.Drawing.Point(233, 13);
            this.combobox_storeID.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.combobox_storeID.Name = "combobox_storeID";
            this.combobox_storeID.Size = new System.Drawing.Size(516, 26);
            this.combobox_storeID.TabIndex = 29;
            this.combobox_storeID.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lab_search
            // 
            this.lab_search.AutoSize = true;
            this.lab_search.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_search.Location = new System.Drawing.Point(84, 16);
            this.lab_search.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lab_search.Name = "lab_search";
            this.lab_search.Size = new System.Drawing.Size(133, 18);
            this.lab_search.TabIndex = 30;
            this.lab_search.Text = "Select StoreID:";
            this.lab_search.Click += new System.EventHandler(this.lab_search_Click);
            // 
            // btn_disable
            // 
            this.btn_disable.BackColor = System.Drawing.Color.LightCoral;
            this.btn_disable.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_disable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_disable.Location = new System.Drawing.Point(-4, 471);
            this.btn_disable.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_disable.Name = "btn_disable";
            this.btn_disable.Size = new System.Drawing.Size(244, 58);
            this.btn_disable.TabIndex = 36;
            this.btn_disable.Text = "Disable";
            this.btn_disable.UseVisualStyleBackColor = false;
            this.btn_disable.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // lab_Thirdaddress
            // 
            this.lab_Thirdaddress.AutoSize = true;
            this.lab_Thirdaddress.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Thirdaddress.Location = new System.Drawing.Point(161, 339);
            this.lab_Thirdaddress.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lab_Thirdaddress.Name = "lab_Thirdaddress";
            this.lab_Thirdaddress.Size = new System.Drawing.Size(65, 18);
            this.lab_Thirdaddress.TabIndex = 76;
            this.lab_Thirdaddress.Text = "Street:";
            this.lab_Thirdaddress.Click += new System.EventHandler(this.lab_Thirdaddress_Click);
            // 
            // lab_Secondaddress
            // 
            this.lab_Secondaddress.AutoSize = true;
            this.lab_Secondaddress.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Secondaddress.Location = new System.Drawing.Point(145, 304);
            this.lab_Secondaddress.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lab_Secondaddress.Name = "lab_Secondaddress";
            this.lab_Secondaddress.Size = new System.Drawing.Size(81, 18);
            this.lab_Secondaddress.TabIndex = 75;
            this.lab_Secondaddress.Text = "Building:";
            // 
            // lab_FirstLine
            // 
            this.lab_FirstLine.AutoSize = true;
            this.lab_FirstLine.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_FirstLine.Location = new System.Drawing.Point(170, 274);
            this.lab_FirstLine.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lab_FirstLine.Name = "lab_FirstLine";
            this.lab_FirstLine.Size = new System.Drawing.Size(47, 18);
            this.lab_FirstLine.TabIndex = 74;
            this.lab_FirstLine.Text = "City:";
            // 
            // checkBox_changephonenum
            // 
            this.checkBox_changephonenum.AutoSize = true;
            this.checkBox_changephonenum.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_changephonenum.Location = new System.Drawing.Point(19, 234);
            this.checkBox_changephonenum.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.checkBox_changephonenum.Name = "checkBox_changephonenum";
            this.checkBox_changephonenum.Size = new System.Drawing.Size(207, 22);
            this.checkBox_changephonenum.TabIndex = 81;
            this.checkBox_changephonenum.Text = "Change PhoneNumber";
            this.checkBox_changephonenum.UseVisualStyleBackColor = true;
            this.checkBox_changephonenum.CheckedChanged += new System.EventHandler(this.checkBox_changephonenum_CheckedChanged);
            // 
            // cb_Regionp
            // 
            this.cb_Regionp.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Regionp.FormattingEnabled = true;
            this.cb_Regionp.Items.AddRange(new object[] {
            "+852",
            "+86"});
            this.cb_Regionp.Location = new System.Drawing.Point(236, 232);
            this.cb_Regionp.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cb_Regionp.Name = "cb_Regionp";
            this.cb_Regionp.Size = new System.Drawing.Size(146, 26);
            this.cb_Regionp.TabIndex = 80;
            this.cb_Regionp.SelectedIndexChanged += new System.EventHandler(this.cb_Regionp_SelectedIndexChanged);
            // 
            // txt_pnum
            // 
            this.txt_pnum.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pnum.Location = new System.Drawing.Point(392, 231);
            this.txt_pnum.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_pnum.Name = "txt_pnum";
            this.txt_pnum.Size = new System.Drawing.Size(357, 27);
            this.txt_pnum.TabIndex = 79;
            this.txt_pnum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_phonenum_keypress);
            // 
            // txt_region
            // 
            this.txt_region.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_region.Location = new System.Drawing.Point(233, 56);
            this.txt_region.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_region.Name = "txt_region";
            this.txt_region.Size = new System.Drawing.Size(516, 27);
            this.txt_region.TabIndex = 82;
            // 
            // checkBox_region
            // 
            this.checkBox_region.AutoSize = true;
            this.checkBox_region.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_region.Location = new System.Drawing.Point(73, 95);
            this.checkBox_region.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.checkBox_region.Name = "checkBox_region";
            this.checkBox_region.Size = new System.Drawing.Size(150, 22);
            this.checkBox_region.TabIndex = 85;
            this.checkBox_region.Text = "Change Region";
            this.checkBox_region.UseVisualStyleBackColor = true;
            this.checkBox_region.CheckedChanged += new System.EventHandler(this.checkBox_region_CheckedChanged);
            // 
            // cb_regionname
            // 
            this.cb_regionname.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_regionname.FormattingEnabled = true;
            this.cb_regionname.Location = new System.Drawing.Point(430, 91);
            this.cb_regionname.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cb_regionname.Name = "cb_regionname";
            this.cb_regionname.Size = new System.Drawing.Size(319, 26);
            this.cb_regionname.TabIndex = 84;
            this.cb_regionname.SelectedIndexChanged += new System.EventHandler(this.cb_regionname_SelectedIndexChanged);
            // 
            // combo_Region
            // 
            this.combo_Region.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_Region.FormattingEnabled = true;
            this.combo_Region.Items.AddRange(new object[] {
            "Hong Kong",
            "China"});
            this.combo_Region.Location = new System.Drawing.Point(236, 91);
            this.combo_Region.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.combo_Region.Name = "combo_Region";
            this.combo_Region.Size = new System.Drawing.Size(181, 26);
            this.combo_Region.TabIndex = 83;
            this.combo_Region.SelectedIndexChanged += new System.EventHandler(this.combo_Region_SelectedIndexChanged_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StoreID,
            this.StoreName,
            this.StoreManager});
            this.dataGridView1.Location = new System.Drawing.Point(783, 13);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(455, 516);
            this.dataGridView1.TabIndex = 87;
            // 
            // StoreID
            // 
            this.StoreID.HeaderText = "StoreID";
            this.StoreID.Name = "StoreID";
            this.StoreID.ReadOnly = true;
            // 
            // StoreName
            // 
            this.StoreName.HeaderText = "StoreName";
            this.StoreName.Name = "StoreName";
            this.StoreName.ReadOnly = true;
            this.StoreName.Width = 200;
            // 
            // StoreManager
            // 
            this.StoreManager.HeaderText = "Store Manager Name";
            this.StoreManager.Name = "StoreManager";
            this.StoreManager.ReadOnly = true;
            this.StoreManager.Width = 150;
            // 
            // lab_Phonenum
            // 
            this.lab_Phonenum.AutoSize = true;
            this.lab_Phonenum.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Phonenum.Location = new System.Drawing.Point(92, 199);
            this.lab_Phonenum.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lab_Phonenum.Name = "lab_Phonenum";
            this.lab_Phonenum.Size = new System.Drawing.Size(134, 18);
            this.lab_Phonenum.TabIndex = 77;
            this.lab_Phonenum.Text = "Phone Number:";
            // 
            // combobox_staffID
            // 
            this.combobox_staffID.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combobox_staffID.FormattingEnabled = true;
            this.combobox_staffID.Location = new System.Drawing.Point(236, 127);
            this.combobox_staffID.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.combobox_staffID.Name = "combobox_staffID";
            this.combobox_staffID.Size = new System.Drawing.Size(513, 26);
            this.combobox_staffID.TabIndex = 89;
            this.combobox_staffID.SelectedIndexChanged += new System.EventHandler(this.combobox_staffID_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(119, 170);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 18);
            this.label4.TabIndex = 91;
            this.label4.Text = "Staff Name:";
            // 
            // txt_managername
            // 
            this.txt_managername.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_managername.Location = new System.Drawing.Point(236, 161);
            this.txt_managername.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_managername.Name = "txt_managername";
            this.txt_managername.Size = new System.Drawing.Size(513, 27);
            this.txt_managername.TabIndex = 90;
            // 
            // checkBox_storemanager
            // 
            this.checkBox_storemanager.AutoSize = true;
            this.checkBox_storemanager.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_storemanager.Location = new System.Drawing.Point(81, 131);
            this.checkBox_storemanager.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.checkBox_storemanager.Name = "checkBox_storemanager";
            this.checkBox_storemanager.Size = new System.Drawing.Size(145, 22);
            this.checkBox_storemanager.TabIndex = 92;
            this.checkBox_storemanager.Text = "Store Manager";
            this.checkBox_storemanager.UseVisualStyleBackColor = true;
            // 
            // txt_StoreName
            // 
            this.txt_StoreName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_StoreName.Location = new System.Drawing.Point(236, 372);
            this.txt_StoreName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_StoreName.Name = "txt_StoreName";
            this.txt_StoreName.Size = new System.Drawing.Size(513, 27);
            this.txt_StoreName.TabIndex = 94;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(41, 375);
            this.label10.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(189, 18);
            this.label10.TabIndex = 93;
            this.label10.Text = "Store Name(Original):";
            // 
            // checkBox_changename
            // 
            this.checkBox_changename.AutoSize = true;
            this.checkBox_changename.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_changename.Location = new System.Drawing.Point(27, 418);
            this.checkBox_changename.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.checkBox_changename.Name = "checkBox_changename";
            this.checkBox_changename.Size = new System.Drawing.Size(190, 22);
            this.checkBox_changename.TabIndex = 95;
            this.checkBox_changename.Text = "Change Store Name";
            this.checkBox_changename.UseVisualStyleBackColor = true;
            // 
            // txt_newname
            // 
            this.txt_newname.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_newname.Location = new System.Drawing.Point(236, 416);
            this.txt_newname.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_newname.Name = "txt_newname";
            this.txt_newname.Size = new System.Drawing.Size(513, 27);
            this.txt_newname.TabIndex = 96;
            // 
            // btn_available
            // 
            this.btn_available.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_available.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_available.Location = new System.Drawing.Point(250, 471);
            this.btn_available.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_available.Name = "btn_available";
            this.btn_available.Size = new System.Drawing.Size(243, 55);
            this.btn_available.TabIndex = 97;
            this.btn_available.Text = "Make Store Available";
            this.btn_available.UseVisualStyleBackColor = false;
            this.btn_available.Click += new System.EventHandler(this.btn_available_Click);
            // 
            // EditStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 561);
            this.Controls.Add(this.btn_available);
            this.Controls.Add(this.txt_newname);
            this.Controls.Add(this.checkBox_changename);
            this.Controls.Add(this.txt_StoreName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.checkBox_storemanager);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_managername);
            this.Controls.Add(this.combobox_staffID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.checkBox_region);
            this.Controls.Add(this.cb_regionname);
            this.Controls.Add(this.combo_Region);
            this.Controls.Add(this.txt_region);
            this.Controls.Add(this.checkBox_changephonenum);
            this.Controls.Add(this.cb_Regionp);
            this.Controls.Add(this.txt_pnum);
            this.Controls.Add(this.lab_Phonenum);
            this.Controls.Add(this.lab_Thirdaddress);
            this.Controls.Add(this.lab_Secondaddress);
            this.Controls.Add(this.lab_FirstLine);
            this.Controls.Add(this.btn_disable);
            this.Controls.Add(this.lab_search);
            this.Controls.Add(this.combobox_storeID);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_tel);
            this.Controls.Add(this.txt_address3);
            this.Controls.Add(this.txt_address2);
            this.Controls.Add(this.txt_address1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "EditStore";
            this.Text = "Edit Store";
            this.Load += new System.EventHandler(this.EditStore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.TextBox txt_address3;
        private System.Windows.Forms.TextBox txt_address2;
        private System.Windows.Forms.TextBox txt_address1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_save;
        //private betterlimitedDataSetTableAdapters.storeTableAdapter storeTableAdapter;
        private System.Windows.Forms.ComboBox combobox_storeID;
        private System.Windows.Forms.Label lab_search;
  //      private betterlimitedDataSetTestTableAdapters.storeTableAdapter storeTableAdapter1;
        private System.Windows.Forms.Button btn_disable;
        private System.Windows.Forms.Label lab_Thirdaddress;
        private System.Windows.Forms.Label lab_Secondaddress;
        private System.Windows.Forms.Label lab_FirstLine;
        private System.Windows.Forms.CheckBox checkBox_changephonenum;
        private System.Windows.Forms.ComboBox cb_Regionp;
        private System.Windows.Forms.TextBox txt_pnum;
        private System.Windows.Forms.TextBox txt_region;
        private System.Windows.Forms.CheckBox checkBox_region;
        private System.Windows.Forms.ComboBox cb_regionname;
        private System.Windows.Forms.ComboBox combo_Region;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreManager;
        private System.Windows.Forms.Label lab_Phonenum;
        private System.Windows.Forms.ComboBox combobox_staffID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_managername;
        private System.Windows.Forms.CheckBox checkBox_storemanager;
        private System.Windows.Forms.TextBox txt_StoreName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBox_changename;
        private System.Windows.Forms.TextBox txt_newname;
        private System.Windows.Forms.Button btn_available;
    }
}