namespace BetterLimited
{
    partial class Interface_RecoveryStockWareHouse
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_accept = new System.Windows.Forms.Button();
            this.btn_refuse = new System.Windows.Forms.Button();
            this.RecoveryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quanity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WareHouseStockLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KBstore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequestFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lab_sote = new System.Windows.Forms.Label();
            this.cb_recoveryID = new System.Windows.Forms.ComboBox();
            this.monthCalendar_recovery = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_reason = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 382);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date Of Recovery:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RecoveryID,
            this.ProductID,
            this.ProductName,
            this.Quanity,
            this.WareHouseStockLevel,
            this.KBstore,
            this.tw,
            this.RequestFrom});
            this.dataGridView1.Location = new System.Drawing.Point(17, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1304, 327);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_accept
            // 
            this.btn_accept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_accept.Location = new System.Drawing.Point(1123, 556);
            this.btn_accept.Name = "btn_accept";
            this.btn_accept.Size = new System.Drawing.Size(211, 77);
            this.btn_accept.TabIndex = 2;
            this.btn_accept.Text = "Accept";
            this.btn_accept.UseVisualStyleBackColor = false;
            this.btn_accept.Click += new System.EventHandler(this.btn_accept_Click);
            // 
            // btn_refuse
            // 
            this.btn_refuse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_refuse.Location = new System.Drawing.Point(899, 556);
            this.btn_refuse.Name = "btn_refuse";
            this.btn_refuse.Size = new System.Drawing.Size(218, 77);
            this.btn_refuse.TabIndex = 3;
            this.btn_refuse.Text = "Refuse";
            this.btn_refuse.UseVisualStyleBackColor = false;
            this.btn_refuse.Click += new System.EventHandler(this.btn_refuse_Click);
            // 
            // RecoveryID
            // 
            this.RecoveryID.HeaderText = "Recovery ID";
            this.RecoveryID.Name = "RecoveryID";
            this.RecoveryID.ReadOnly = true;
            this.RecoveryID.Width = 150;
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "ProductID";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            this.ProductID.Width = 150;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "ProductName";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 200;
            // 
            // Quanity
            // 
            this.Quanity.HeaderText = "Request Quanity";
            this.Quanity.Name = "Quanity";
            this.Quanity.ReadOnly = true;
            this.Quanity.Width = 150;
            // 
            // WareHouseStockLevel
            // 
            this.WareHouseStockLevel.HeaderText = "Ware House Stock Level";
            this.WareHouseStockLevel.Name = "WareHouseStockLevel";
            this.WareHouseStockLevel.ReadOnly = true;
            this.WareHouseStockLevel.Width = 150;
            // 
            // KBstore
            // 
            this.KBstore.HeaderText = "Kowloon Bay Store";
            this.KBstore.Name = "KBstore";
            this.KBstore.ReadOnly = true;
            this.KBstore.Width = 150;
            // 
            // tw
            // 
            this.tw.HeaderText = "Tsuen Wan Store";
            this.tw.Name = "tw";
            this.tw.ReadOnly = true;
            this.tw.Width = 150;
            // 
            // RequestFrom
            // 
            this.RequestFrom.HeaderText = "Request From";
            this.RequestFrom.Name = "RequestFrom";
            this.RequestFrom.ReadOnly = true;
            this.RequestFrom.Width = 200;
            // 
            // lab_sote
            // 
            this.lab_sote.AutoSize = true;
            this.lab_sote.Location = new System.Drawing.Point(411, 382);
            this.lab_sote.Name = "lab_sote";
            this.lab_sote.Size = new System.Drawing.Size(107, 18);
            this.lab_sote.TabIndex = 4;
            this.lab_sote.Text = "RecoveryID:";
            // 
            // cb_recoveryID
            // 
            this.cb_recoveryID.FormattingEnabled = true;
            this.cb_recoveryID.Location = new System.Drawing.Point(524, 379);
            this.cb_recoveryID.Name = "cb_recoveryID";
            this.cb_recoveryID.Size = new System.Drawing.Size(152, 26);
            this.cb_recoveryID.TabIndex = 5;
            // 
            // monthCalendar_recovery
            // 
            this.monthCalendar_recovery.Location = new System.Drawing.Point(172, 380);
            this.monthCalendar_recovery.Name = "monthCalendar_recovery";
            this.monthCalendar_recovery.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(443, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(507, 36);
            this.label2.TabIndex = 7;
            this.label2.Text = "Reason:(If You Refuse The Request,Please Provide  Reason)\r\n\r\n";
            // 
            // txt_reason
            // 
            this.txt_reason.Location = new System.Drawing.Point(446, 438);
            this.txt_reason.Name = "txt_reason";
            this.txt_reason.Size = new System.Drawing.Size(447, 195);
            this.txt_reason.TabIndex = 8;
            this.txt_reason.Text = "";
            // 
            // Interface_RecoveryStockWareHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 645);
            this.Controls.Add(this.txt_reason);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.monthCalendar_recovery);
            this.Controls.Add(this.cb_recoveryID);
            this.Controls.Add(this.lab_sote);
            this.Controls.Add(this.btn_refuse);
            this.Controls.Add(this.btn_accept);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Interface_RecoveryStockWareHouse";
            this.Text = "Interface_RecoveryStockWareHouse";
            this.Load += new System.EventHandler(this.Interface_RecoveryStockWareHouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_accept;
        private System.Windows.Forms.Button btn_refuse;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecoveryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quanity;
        private System.Windows.Forms.DataGridViewTextBoxColumn WareHouseStockLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn KBstore;
        private System.Windows.Forms.DataGridViewTextBoxColumn tw;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestFrom;
        private System.Windows.Forms.Label lab_sote;
        private System.Windows.Forms.ComboBox cb_recoveryID;
        private System.Windows.Forms.MonthCalendar monthCalendar_recovery;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txt_reason;
    }
}