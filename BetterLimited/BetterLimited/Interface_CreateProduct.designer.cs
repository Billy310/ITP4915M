namespace BetterLimited
{
    partial class Interface_CreateProduct
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
            this.lab_name = new System.Windows.Forms.Label();
            this.txt_Productname = new System.Windows.Forms.TextBox();
            this.lab_serialnumber = new System.Windows.Forms.Label();
            this.txt_snum = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Create = new System.Windows.Forms.Button();
            this.lab_Supplier = new System.Windows.Forms.Label();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.cb_supplierID = new System.Windows.Forms.ComboBox();
            this.txt_SupplierID = new System.Windows.Forms.TextBox();
            this.lab_type = new System.Windows.Forms.Label();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.txt_typeID = new System.Windows.Forms.TextBox();
            this.btn_CreateSupplier = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numericAmount = new System.Windows.Forms.NumericUpDown();
            this.btn_CreateType = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.txt_available = new System.Windows.Forms.TextBox();
            this.lowstocklevel_count = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown_kb = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_tw = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericAmount)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lowstocklevel_count)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_kb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_tw)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_name
            // 
            this.lab_name.AutoSize = true;
            this.lab_name.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_name.Location = new System.Drawing.Point(88, 45);
            this.lab_name.Name = "lab_name";
            this.lab_name.Size = new System.Drawing.Size(139, 18);
            this.lab_name.TabIndex = 1;
            this.lab_name.Text = "Product Name*:";
            // 
            // txt_Productname
            // 
            this.txt_Productname.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Productname.Location = new System.Drawing.Point(233, 42);
            this.txt_Productname.Name = "txt_Productname";
            this.txt_Productname.Size = new System.Drawing.Size(402, 27);
            this.txt_Productname.TabIndex = 2;
            this.txt_Productname.TextChanged += new System.EventHandler(this.txt_Productname_TextChanged);
            // 
            // lab_serialnumber
            // 
            this.lab_serialnumber.AutoSize = true;
            this.lab_serialnumber.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_serialnumber.Location = new System.Drawing.Point(30, 12);
            this.lab_serialnumber.Name = "lab_serialnumber";
            this.lab_serialnumber.Size = new System.Drawing.Size(197, 18);
            this.lab_serialnumber.TabIndex = 3;
            this.lab_serialnumber.Text = "Product Serial Number:";
            // 
            // txt_snum
            // 
            this.txt_snum.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_snum.Location = new System.Drawing.Point(233, 9);
            this.txt_snum.Name = "txt_snum";
            this.txt_snum.Size = new System.Drawing.Size(402, 27);
            this.txt_snum.TabIndex = 4;
            this.txt_snum.TextChanged += new System.EventHandler(this.txt_snum_TextChanged);
            // 
            // txt_price
            // 
            this.txt_price.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price.Location = new System.Drawing.Point(233, 75);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(402, 27);
            this.txt_price.TabIndex = 7;
            this.txt_price.TextChanged += new System.EventHandler(this.txt_price_TextChanged);
            this.txt_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_price_keypress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Product Price(HKD)*:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_Create
            // 
            this.btn_Create.BackColor = System.Drawing.Color.Chartreuse;
            this.btn_Create.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Create.Location = new System.Drawing.Point(233, 398);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(195, 69);
            this.btn_Create.TabIndex = 9;
            this.btn_Create.Text = "Create";
            this.btn_Create.UseVisualStyleBackColor = false;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // lab_Supplier
            // 
            this.lab_Supplier.AutoSize = true;
            this.lab_Supplier.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Supplier.Location = new System.Drawing.Point(136, 111);
            this.lab_Supplier.Name = "lab_Supplier";
            this.lab_Supplier.Size = new System.Drawing.Size(91, 18);
            this.lab_Supplier.TabIndex = 11;
            this.lab_Supplier.Text = "Supplier*:";
            // 
            // btn_Edit
            // 
            this.btn_Edit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.Location = new System.Drawing.Point(856, 119);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(149, 47);
            this.btn_Edit.TabIndex = 12;
            this.btn_Edit.Text = "Edit Product";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_supplierID
            // 
            this.cb_supplierID.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_supplierID.FormattingEnabled = true;
            this.cb_supplierID.Location = new System.Drawing.Point(233, 108);
            this.cb_supplierID.Name = "cb_supplierID";
            this.cb_supplierID.Size = new System.Drawing.Size(121, 26);
            this.cb_supplierID.TabIndex = 13;
            this.cb_supplierID.SelectedIndexChanged += new System.EventHandler(this.cb_supplierID_SelectedIndexChanged);
            // 
            // txt_SupplierID
            // 
            this.txt_SupplierID.Location = new System.Drawing.Point(12, 583);
            this.txt_SupplierID.Name = "txt_SupplierID";
            this.txt_SupplierID.Size = new System.Drawing.Size(100, 22);
            this.txt_SupplierID.TabIndex = 14;
            this.txt_SupplierID.Visible = false;
            // 
            // lab_type
            // 
            this.lab_type.AutoSize = true;
            this.lab_type.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_type.Location = new System.Drawing.Point(165, 143);
            this.lab_type.Name = "lab_type";
            this.lab_type.Size = new System.Drawing.Size(62, 18);
            this.lab_type.TabIndex = 15;
            this.lab_type.Text = "Type*:";
            // 
            // cb_type
            // 
            this.cb_type.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Location = new System.Drawing.Point(233, 140);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(121, 26);
            this.cb_type.TabIndex = 16;
            this.cb_type.SelectedIndexChanged += new System.EventHandler(this.cb_type_SelectedIndexChanged);
            // 
            // txt_typeID
            // 
            this.txt_typeID.Location = new System.Drawing.Point(118, 583);
            this.txt_typeID.Name = "txt_typeID";
            this.txt_typeID.Size = new System.Drawing.Size(100, 22);
            this.txt_typeID.TabIndex = 19;
            this.txt_typeID.Visible = false;
            this.txt_typeID.TextChanged += new System.EventHandler(this.txt_typeID_TextChanged);
            // 
            // btn_CreateSupplier
            // 
            this.btn_CreateSupplier.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CreateSupplier.Location = new System.Drawing.Point(856, 64);
            this.btn_CreateSupplier.Name = "btn_CreateSupplier";
            this.btn_CreateSupplier.Size = new System.Drawing.Size(149, 47);
            this.btn_CreateSupplier.TabIndex = 20;
            this.btn_CreateSupplier.Text = "Create Supplier";
            this.btn_CreateSupplier.UseVisualStyleBackColor = true;
            this.btn_CreateSupplier.Click += new System.EventHandler(this.btn_CreateSupplier_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(295, 18);
            this.label4.TabIndex = 24;
            this.label4.Text = "Total Received Amount Of Product:";
            // 
            // numericAmount
            // 
            this.numericAmount.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericAmount.Location = new System.Drawing.Point(310, 216);
            this.numericAmount.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericAmount.Name = "numericAmount";
            this.numericAmount.Size = new System.Drawing.Size(120, 27);
            this.numericAmount.TabIndex = 25;
            this.numericAmount.ValueChanged += new System.EventHandler(this.numericAmount_ValueChanged);
            // 
            // btn_CreateType
            // 
            this.btn_CreateType.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CreateType.Location = new System.Drawing.Point(856, 9);
            this.btn_CreateType.Name = "btn_CreateType";
            this.btn_CreateType.Size = new System.Drawing.Size(149, 47);
            this.btn_CreateType.TabIndex = 28;
            this.btn_CreateType.Text = "Create Type";
            this.btn_CreateType.UseVisualStyleBackColor = true;
            this.btn_CreateType.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Reset.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Reset.Location = new System.Drawing.Point(12, 398);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(195, 69);
            this.btn_Reset.TabIndex = 29;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 18);
            this.label3.TabIndex = 30;
            this.label3.Text = "Available*:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(119, 337);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 55);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(141, 21);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(117, 22);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Inavailable";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(5, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(101, 22);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Available";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // txt_available
            // 
            this.txt_available.Location = new System.Drawing.Point(905, 177);
            this.txt_available.Name = "txt_available";
            this.txt_available.Size = new System.Drawing.Size(100, 22);
            this.txt_available.TabIndex = 32;
            this.txt_available.Visible = false;
            // 
            // lowstocklevel_count
            // 
            this.lowstocklevel_count.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowstocklevel_count.Location = new System.Drawing.Point(234, 177);
            this.lowstocklevel_count.Name = "lowstocklevel_count";
            this.lowstocklevel_count.Size = new System.Drawing.Size(120, 27);
            this.lowstocklevel_count.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 18);
            this.label2.TabIndex = 36;
            this.label2.Text = "Low Stock Level*:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(267, 18);
            this.label5.TabIndex = 38;
            this.label5.Text = "Kowloon Bay Store Stock Level:\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(253, 18);
            this.label6.TabIndex = 39;
            this.label6.Text = "Tsuen Wan Store Stock Level:";
            // 
            // numericUpDown_kb
            // 
            this.numericUpDown_kb.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_kb.Location = new System.Drawing.Point(310, 249);
            this.numericUpDown_kb.Name = "numericUpDown_kb";
            this.numericUpDown_kb.Size = new System.Drawing.Size(120, 27);
            this.numericUpDown_kb.TabIndex = 40;
            // 
            // numericUpDown_tw
            // 
            this.numericUpDown_tw.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_tw.Location = new System.Drawing.Point(310, 283);
            this.numericUpDown_tw.Name = "numericUpDown_tw";
            this.numericUpDown_tw.Size = new System.Drawing.Size(120, 27);
            this.numericUpDown_tw.TabIndex = 41;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(849, 417);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 50);
            this.button2.TabIndex = 35;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Interface_CreateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 479);
            this.Controls.Add(this.numericUpDown_tw);
            this.Controls.Add(this.numericUpDown_kb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lowstocklevel_count);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_available);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_CreateType);
            this.Controls.Add(this.numericAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_CreateSupplier);
            this.Controls.Add(this.txt_typeID);
            this.Controls.Add(this.cb_type);
            this.Controls.Add(this.lab_type);
            this.Controls.Add(this.txt_SupplierID);
            this.Controls.Add(this.cb_supplierID);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.lab_Supplier);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_snum);
            this.Controls.Add(this.lab_serialnumber);
            this.Controls.Add(this.txt_Productname);
            this.Controls.Add(this.lab_name);
            this.Name = "Interface_CreateProduct";
            this.Text = "Create Product";
            this.Load += new System.EventHandler(this.CreateProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericAmount)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lowstocklevel_count)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_kb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_tw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lab_name;
        private System.Windows.Forms.TextBox txt_Productname;
        private System.Windows.Forms.Label lab_serialnumber;
        private System.Windows.Forms.TextBox txt_snum;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.Label lab_Supplier;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.ComboBox cb_supplierID;
        private System.Windows.Forms.TextBox txt_SupplierID;
        private System.Windows.Forms.Label lab_type;
        private System.Windows.Forms.ComboBox cb_type;
        private System.Windows.Forms.TextBox txt_typeID;
        private System.Windows.Forms.Button btn_CreateSupplier;
   //     private betterlimitedDataSet betterlimitedDataSet1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericAmount;
        private System.Windows.Forms.Button btn_CreateType;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox txt_available;
        private System.Windows.Forms.NumericUpDown lowstocklevel_count;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown_kb;
        private System.Windows.Forms.NumericUpDown numericUpDown_tw;
        private System.Windows.Forms.Button button2;
    }
}