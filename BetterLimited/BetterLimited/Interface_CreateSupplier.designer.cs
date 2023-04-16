namespace BetterLimited
{
    partial class CreateSupplier
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
            this.lab_adress1 = new System.Windows.Forms.Label();
            this.lab_adress2 = new System.Windows.Forms.Label();
            this.lab_Phonenum = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_pnum = new System.Windows.Forms.TextBox();
            this.txt_address1 = new System.Windows.Forms.TextBox();
            this.txt_address2 = new System.Windows.Forms.TextBox();
            this.btn_Create = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.txt_address3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_RegionPhone = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.combo_Region = new System.Windows.Forms.ComboBox();
            this.cb_regionname = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lab_name
            // 
            this.lab_name.AutoSize = true;
            this.lab_name.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_name.Location = new System.Drawing.Point(12, 72);
            this.lab_name.Name = "lab_name";
            this.lab_name.Size = new System.Drawing.Size(134, 18);
            this.lab_name.TabIndex = 1;
            this.lab_name.Text = "Supplier Name:";
            this.lab_name.Click += new System.EventHandler(this.lab_name_Click);
            // 
            // lab_adress1
            // 
            this.lab_adress1.AutoSize = true;
            this.lab_adress1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_adress1.Location = new System.Drawing.Point(92, 185);
            this.lab_adress1.Name = "lab_adress1";
            this.lab_adress1.Size = new System.Drawing.Size(47, 18);
            this.lab_adress1.TabIndex = 2;
            this.lab_adress1.Text = "City:";
            this.lab_adress1.Click += new System.EventHandler(this.lab_adress1_Click);
            // 
            // lab_adress2
            // 
            this.lab_adress2.AutoSize = true;
            this.lab_adress2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_adress2.Location = new System.Drawing.Point(58, 218);
            this.lab_adress2.Name = "lab_adress2";
            this.lab_adress2.Size = new System.Drawing.Size(81, 18);
            this.lab_adress2.TabIndex = 3;
            this.lab_adress2.Text = "Building:";
            this.lab_adress2.Click += new System.EventHandler(this.lab_adress2_Click);
            // 
            // lab_Phonenum
            // 
            this.lab_Phonenum.AutoSize = true;
            this.lab_Phonenum.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Phonenum.Location = new System.Drawing.Point(12, 111);
            this.lab_Phonenum.Name = "lab_Phonenum";
            this.lab_Phonenum.Size = new System.Drawing.Size(134, 18);
            this.lab_Phonenum.TabIndex = 5;
            this.lab_Phonenum.Text = "Phone Number:";
            this.lab_Phonenum.Click += new System.EventHandler(this.lab_Phonenum_Click);
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(145, 69);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(380, 27);
            this.txt_name.TabIndex = 6;
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            // 
            // txt_pnum
            // 
            this.txt_pnum.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pnum.Location = new System.Drawing.Point(269, 107);
            this.txt_pnum.Name = "txt_pnum";
            this.txt_pnum.Size = new System.Drawing.Size(256, 27);
            this.txt_pnum.TabIndex = 7;
            this.txt_pnum.TextChanged += new System.EventHandler(this.txt_pnum_TextChanged);
            this.txt_pnum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tel_keypress);
            // 
            // txt_address1
            // 
            this.txt_address1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address1.Location = new System.Drawing.Point(145, 182);
            this.txt_address1.Name = "txt_address1";
            this.txt_address1.Size = new System.Drawing.Size(380, 27);
            this.txt_address1.TabIndex = 8;
            this.txt_address1.TextChanged += new System.EventHandler(this.txt_address1_TextChanged);
            // 
            // txt_address2
            // 
            this.txt_address2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address2.Location = new System.Drawing.Point(145, 215);
            this.txt_address2.Name = "txt_address2";
            this.txt_address2.Size = new System.Drawing.Size(380, 27);
            this.txt_address2.TabIndex = 9;
            this.txt_address2.TextChanged += new System.EventHandler(this.txt_address2_TextChanged);
            // 
            // btn_Create
            // 
            this.btn_Create.BackColor = System.Drawing.Color.Orange;
            this.btn_Create.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Create.Location = new System.Drawing.Point(352, 450);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(193, 78);
            this.btn_Create.TabIndex = 11;
            this.btn_Create.Text = "Create";
            this.btn_Create.UseVisualStyleBackColor = false;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.Location = new System.Drawing.Point(1288, 8);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(145, 44);
            this.btn_Edit.TabIndex = 12;
            this.btn_Edit.Text = "Edit Supplier";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // txt_address3
            // 
            this.txt_address3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address3.Location = new System.Drawing.Point(145, 248);
            this.txt_address3.Name = "txt_address3";
            this.txt_address3.Size = new System.Drawing.Size(380, 27);
            this.txt_address3.TabIndex = 14;
            this.txt_address3.TextChanged += new System.EventHandler(this.txt_address3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Street:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Region:";
            // 
            // cb_RegionPhone
            // 
            this.cb_RegionPhone.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_RegionPhone.FormattingEnabled = true;
            this.cb_RegionPhone.Items.AddRange(new object[] {
            "+852",
            "+86"});
            this.cb_RegionPhone.Location = new System.Drawing.Point(152, 108);
            this.cb_RegionPhone.Name = "cb_RegionPhone";
            this.cb_RegionPhone.Size = new System.Drawing.Size(100, 26);
            this.cb_RegionPhone.TabIndex = 20;
            this.cb_RegionPhone.SelectedIndexChanged += new System.EventHandler(this.cb_RegionPhone_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(55, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 78);
            this.button1.TabIndex = 21;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(615, 69);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(818, 667);
            this.webBrowser1.TabIndex = 22;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // combo_Region
            // 
            this.combo_Region.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_Region.FormattingEnabled = true;
            this.combo_Region.Items.AddRange(new object[] {
            "Hong Kong",
            "China"});
            this.combo_Region.Location = new System.Drawing.Point(136, 8);
            this.combo_Region.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.combo_Region.Name = "combo_Region";
            this.combo_Region.Size = new System.Drawing.Size(158, 26);
            this.combo_Region.TabIndex = 36;
            this.combo_Region.SelectedIndexChanged += new System.EventHandler(this.combo_Region_SelectedIndexChanged);
            // 
            // cb_regionname
            // 
            this.cb_regionname.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_regionname.FormattingEnabled = true;
            this.cb_regionname.Location = new System.Drawing.Point(302, 8);
            this.cb_regionname.Name = "cb_regionname";
            this.cb_regionname.Size = new System.Drawing.Size(166, 26);
            this.cb_regionname.TabIndex = 37;
            this.cb_regionname.SelectedIndexChanged += new System.EventHandler(this.cb_regionname_SelectedIndexChanged);
            // 
            // CreateSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1445, 734);
            this.Controls.Add(this.cb_regionname);
            this.Controls.Add(this.combo_Region);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_RegionPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_address3);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.txt_address2);
            this.Controls.Add(this.txt_address1);
            this.Controls.Add(this.txt_pnum);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lab_Phonenum);
            this.Controls.Add(this.lab_adress2);
            this.Controls.Add(this.lab_adress1);
            this.Controls.Add(this.lab_name);
            this.Name = "CreateSupplier";
            this.Text = "Create Supplier";
            this.Load += new System.EventHandler(this.CreateSupplier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lab_name;
        private System.Windows.Forms.Label lab_adress1;
        private System.Windows.Forms.Label lab_adress2;
        private System.Windows.Forms.Label lab_Phonenum;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_pnum;
        private System.Windows.Forms.TextBox txt_address1;
        private System.Windows.Forms.TextBox txt_address2;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.TextBox txt_address3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_RegionPhone;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ComboBox combo_Region;
        private System.Windows.Forms.ComboBox cb_regionname;
    }
}