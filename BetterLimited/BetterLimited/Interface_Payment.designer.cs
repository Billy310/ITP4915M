namespace BetterLimited
{
    partial class Interface_Payment
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
            this.label20 = new System.Windows.Forms.Label();
            this.txt_orderid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_pay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_out = new System.Windows.Forms.TextBox();
            this.btn_cal = new System.Windows.Forms.Button();
            this.btn_gen = new System.Windows.Forms.Button();
            this.txt_cardnum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_namecard = new System.Windows.Forms.TextBox();
            this.txt_Edate = new System.Windows.Forms.TextBox();
            this.txt_Scode = new System.Windows.Forms.TextBox();
            this.txt_cardpay = new System.Windows.Forms.TextBox();
            this.btn_pay = new System.Windows.Forms.Button();
            this.lb_receipt = new System.Windows.Forms.ListBox();
            this.cmb_card = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(47, 200);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(115, 19);
            this.label20.TabIndex = 70;
            this.label20.Text = "SaleOrder ID :";
            // 
            // txt_orderid
            // 
            this.txt_orderid.Enabled = false;
            this.txt_orderid.Location = new System.Drawing.Point(164, 200);
            this.txt_orderid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_orderid.Name = "txt_orderid";
            this.txt_orderid.Size = new System.Drawing.Size(81, 21);
            this.txt_orderid.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 19);
            this.label1.TabIndex = 72;
            this.label1.Text = "Pay Amount :";
            // 
            // txt_total
            // 
            this.txt_total.Enabled = false;
            this.txt_total.Location = new System.Drawing.Point(164, 236);
            this.txt_total.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(81, 21);
            this.txt_total.TabIndex = 71;
            this.txt_total.TextChanged += new System.EventHandler(this.txt_total_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 19);
            this.label2.TabIndex = 74;
            this.label2.Text = "Payment Amount :";
            // 
            // txt_pay
            // 
            this.txt_pay.Location = new System.Drawing.Point(164, 299);
            this.txt_pay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_pay.Name = "txt_pay";
            this.txt_pay.Size = new System.Drawing.Size(81, 21);
            this.txt_pay.TabIndex = 73;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-4, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 19);
            this.label3.TabIndex = 76;
            this.label3.Text = "Outstanding Amount :";
            // 
            // txt_out
            // 
            this.txt_out.Enabled = false;
            this.txt_out.Location = new System.Drawing.Point(178, 344);
            this.txt_out.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_out.Name = "txt_out";
            this.txt_out.Size = new System.Drawing.Size(81, 21);
            this.txt_out.TabIndex = 75;
            // 
            // btn_cal
            // 
            this.btn_cal.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cal.Location = new System.Drawing.Point(251, 291);
            this.btn_cal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_cal.Name = "btn_cal";
            this.btn_cal.Size = new System.Drawing.Size(93, 38);
            this.btn_cal.TabIndex = 77;
            this.btn_cal.Text = "Full Payment";
            this.btn_cal.UseVisualStyleBackColor = true;
            this.btn_cal.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_gen
            // 
            this.btn_gen.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gen.Location = new System.Drawing.Point(12, 538);
            this.btn_gen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_gen.Name = "btn_gen";
            this.btn_gen.Size = new System.Drawing.Size(132, 49);
            this.btn_gen.TabIndex = 79;
            this.btn_gen.Text = "Print";
            this.btn_gen.UseVisualStyleBackColor = true;
            this.btn_gen.Click += new System.EventHandler(this.btn_gen_Click);
            // 
            // txt_cardnum
            // 
            this.txt_cardnum.Location = new System.Drawing.Point(356, 173);
            this.txt_cardnum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_cardnum.Name = "txt_cardnum";
            this.txt_cardnum.Size = new System.Drawing.Size(313, 21);
            this.txt_cardnum.TabIndex = 80;
            this.txt_cardnum.Text = "0000 0000 0000 0000";
            this.txt_cardnum.TextChanged += new System.EventHandler(this.txt_cardnum_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(351, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 19);
            this.label4.TabIndex = 81;
            this.label4.Text = "Card Number :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(351, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 19);
            this.label5.TabIndex = 82;
            this.label5.Text = "Name on Card :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(351, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 19);
            this.label6.TabIndex = 83;
            this.label6.Text = "Expiry Date :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(350, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 19);
            this.label7.TabIndex = 84;
            this.label7.Text = "Security Code:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(350, 395);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 19);
            this.label8.TabIndex = 85;
            this.label8.Text = "Payment Amount :";
            // 
            // txt_namecard
            // 
            this.txt_namecard.Location = new System.Drawing.Point(356, 236);
            this.txt_namecard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_namecard.Name = "txt_namecard";
            this.txt_namecard.Size = new System.Drawing.Size(313, 21);
            this.txt_namecard.TabIndex = 86;
            // 
            // txt_Edate
            // 
            this.txt_Edate.Location = new System.Drawing.Point(356, 299);
            this.txt_Edate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Edate.Name = "txt_Edate";
            this.txt_Edate.Size = new System.Drawing.Size(117, 21);
            this.txt_Edate.TabIndex = 87;
            this.txt_Edate.Text = "00/00";
            this.txt_Edate.TextChanged += new System.EventHandler(this.txt_Edate_TextChanged);
            // 
            // txt_Scode
            // 
            this.txt_Scode.Location = new System.Drawing.Point(355, 361);
            this.txt_Scode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Scode.Name = "txt_Scode";
            this.txt_Scode.Size = new System.Drawing.Size(135, 21);
            this.txt_Scode.TabIndex = 88;
            this.txt_Scode.Text = "000";
            this.txt_Scode.TextChanged += new System.EventHandler(this.txt_Scode_TextChanged);
            // 
            // txt_cardpay
            // 
            this.txt_cardpay.Location = new System.Drawing.Point(355, 424);
            this.txt_cardpay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_cardpay.Name = "txt_cardpay";
            this.txt_cardpay.Size = new System.Drawing.Size(168, 21);
            this.txt_cardpay.TabIndex = 89;
            // 
            // btn_pay
            // 
            this.btn_pay.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pay.Location = new System.Drawing.Point(582, 424);
            this.btn_pay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.Size = new System.Drawing.Size(87, 29);
            this.btn_pay.TabIndex = 90;
            this.btn_pay.Text = "Pay";
            this.btn_pay.UseVisualStyleBackColor = true;
            this.btn_pay.Click += new System.EventHandler(this.btn_pay_Click);
            // 
            // lb_receipt
            // 
            this.lb_receipt.FormattingEnabled = true;
            this.lb_receipt.ItemHeight = 15;
            this.lb_receipt.Location = new System.Drawing.Point(696, 211);
            this.lb_receipt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lb_receipt.Name = "lb_receipt";
            this.lb_receipt.Size = new System.Drawing.Size(202, 244);
            this.lb_receipt.TabIndex = 91;
            // 
            // cmb_card
            // 
            this.cmb_card.FormattingEnabled = true;
            this.cmb_card.Items.AddRange(new object[] {
            "VISA",
            "MasterCard"});
            this.cmb_card.Location = new System.Drawing.Point(696, 173);
            this.cmb_card.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_card.Name = "cmb_card";
            this.cmb_card.Size = new System.Drawing.Size(87, 23);
            this.cmb_card.TabIndex = 92;
            this.cmb_card.SelectedIndexChanged += new System.EventHandler(this.cmb_card_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Cash",
            "Credit Card"});
            this.comboBox1.Location = new System.Drawing.Point(29, 173);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(129, 23);
            this.comboBox1.TabIndex = 93;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(192, 19);
            this.label9.TabIndex = 94;
            this.label9.Text = "Select Payment Method ";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(692, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 19);
            this.label10.TabIndex = 95;
            this.label10.Text = "Card Type :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(850, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 15);
            this.label11.TabIndex = 96;
            this.label11.Text = "label11";
            this.label11.Visible = false;
            // 
            // Interface_Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 600);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cmb_card);
            this.Controls.Add(this.lb_receipt);
            this.Controls.Add(this.btn_pay);
            this.Controls.Add(this.txt_cardpay);
            this.Controls.Add(this.txt_Scode);
            this.Controls.Add(this.txt_Edate);
            this.Controls.Add(this.txt_namecard);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_cardnum);
            this.Controls.Add(this.btn_gen);
            this.Controls.Add(this.btn_cal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_out);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_pay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txt_orderid);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Interface_Payment";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txt_orderid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_pay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_out;
        private System.Windows.Forms.Button btn_cal;
        private System.Windows.Forms.Button btn_gen;
        private System.Windows.Forms.TextBox txt_cardnum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_namecard;
        private System.Windows.Forms.TextBox txt_Edate;
        private System.Windows.Forms.TextBox txt_Scode;
        private System.Windows.Forms.TextBox txt_cardpay;
        private System.Windows.Forms.Button btn_pay;
        private System.Windows.Forms.ListBox lb_receipt;
        private System.Windows.Forms.ComboBox cmb_card;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}