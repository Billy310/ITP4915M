namespace BetterLimited
{
    partial class Interface_ScheduleDutyList_Delivery
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_dworkers = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_session = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Session = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryWorker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_DID = new System.Windows.Forms.TextBox();
            this.txt_staffID = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(971, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 12);
            this.label2.TabIndex = 101;
            this.label2.Text = "StaffID";
            this.label2.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_dworkers);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.monthCalendar1);
            this.groupBox1.Controls.Add(this.btn_Submit);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cb_session);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(427, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(583, 626);
            this.groupBox1.TabIndex = 99;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Apply ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cb_dworkers
            // 
            this.cb_dworkers.FormattingEnabled = true;
            this.cb_dworkers.Location = new System.Drawing.Point(251, 158);
            this.cb_dworkers.Name = "cb_dworkers";
            this.cb_dworkers.Size = new System.Drawing.Size(306, 26);
            this.cb_dworkers.TabIndex = 97;
            this.cb_dworkers.SelectedIndexChanged += new System.EventHandler(this.cb_dworkers_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 18);
            this.label3.TabIndex = 96;
            this.label3.Text = "Delivery Workers:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 18);
            this.label1.TabIndex = 95;
            this.label1.Text = "Apply Schedule Date:";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(12, 85);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 90;
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Submit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.Location = new System.Drawing.Point(19, 259);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(538, 56);
            this.btn_Submit.TabIndex = 94;
            this.btn_Submit.Text = "Apply For the Schedule";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(248, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 18);
            this.label5.TabIndex = 91;
            this.label5.Text = "Time Session:";
            // 
            // cb_session
            // 
            this.cb_session.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_session.FormattingEnabled = true;
            this.cb_session.Items.AddRange(new object[] {
            "Morning",
            "Afternoon",
            "Evening"});
            this.cb_session.Location = new System.Drawing.Point(251, 85);
            this.cb_session.Name = "cb_session";
            this.cb_session.Size = new System.Drawing.Size(306, 26);
            this.cb_session.TabIndex = 93;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(10, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(372, 626);
            this.groupBox2.TabIndex = 100;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Schedule";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(185, 561);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(165, 22);
            this.radioButton2.TabIndex = 97;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Show This Month";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 561);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(160, 22);
            this.radioButton1.TabIndex = 96;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Show This Week";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Session,
            this.DeliveryWorker});
            this.dataGridView1.Location = new System.Drawing.Point(6, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(360, 529);
            this.dataGridView1.TabIndex = 95;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 70;
            // 
            // Session
            // 
            this.Session.HeaderText = "Session";
            this.Session.Name = "Session";
            this.Session.ReadOnly = true;
            // 
            // DeliveryWorker
            // 
            this.DeliveryWorker.HeaderText = "Delivery Worker";
            this.DeliveryWorker.Name = "DeliveryWorker";
            this.DeliveryWorker.ReadOnly = true;
            this.DeliveryWorker.Width = 150;
            // 
            // txt_DID
            // 
            this.txt_DID.Location = new System.Drawing.Point(855, 9);
            this.txt_DID.Name = "txt_DID";
            this.txt_DID.Size = new System.Drawing.Size(100, 22);
            this.txt_DID.TabIndex = 102;
            this.txt_DID.Visible = false;
            // 
            // txt_staffID
            // 
            this.txt_staffID.Location = new System.Drawing.Point(727, 9);
            this.txt_staffID.Name = "txt_staffID";
            this.txt_staffID.Size = new System.Drawing.Size(100, 22);
            this.txt_staffID.TabIndex = 103;
            this.txt_staffID.Visible = false;
            // 
            // Interface_ScheduleDutyList_Delivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 663);
            this.Controls.Add(this.txt_staffID);
            this.Controls.Add(this.txt_DID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Interface_ScheduleDutyList_Delivery";
            this.Text = "Interface_ProvideSchedule";
            this.Load += new System.EventHandler(this.Interface_ProvideSchedule_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_session;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Session;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryWorker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_dworkers;
        private System.Windows.Forms.TextBox txt_DID;
        private System.Windows.Forms.TextBox txt_staffID;
    }
}