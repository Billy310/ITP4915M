namespace BetterLimited
{
    partial class Interface_ReceiveStock
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
            this.combo_pID = new System.Windows.Forms.ComboBox();
            this.combo_PurID = new System.Windows.Forms.ComboBox();
            this.lab_PurID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_completereceive = new System.Windows.Forms.Button();
            this.checkBox_receivewithspecficnum = new System.Windows.Forms.CheckBox();
            this.numericUpDown_item = new System.Windows.Forms.NumericUpDown();
            this.PurchaseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quanity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_item)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PurchaseID,
            this.ProductID,
            this.ProductName,
            this.Quanity});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.MenuBar;
            this.dataGridView1.Location = new System.Drawing.Point(20, 18);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(554, 348);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // combo_pID
            // 
            this.combo_pID.FormattingEnabled = true;
            this.combo_pID.Location = new System.Drawing.Point(1015, 18);
            this.combo_pID.Name = "combo_pID";
            this.combo_pID.Size = new System.Drawing.Size(121, 26);
            this.combo_pID.TabIndex = 1;
            this.combo_pID.SelectedIndexChanged += new System.EventHandler(this.combo_pID_SelectedIndexChanged);
            // 
            // combo_PurID
            // 
            this.combo_PurID.FormattingEnabled = true;
            this.combo_PurID.Location = new System.Drawing.Point(771, 18);
            this.combo_PurID.Name = "combo_PurID";
            this.combo_PurID.Size = new System.Drawing.Size(137, 26);
            this.combo_PurID.TabIndex = 2;
            this.combo_PurID.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // lab_PurID
            // 
            this.lab_PurID.AutoSize = true;
            this.lab_PurID.Location = new System.Drawing.Point(601, 21);
            this.lab_PurID.Name = "lab_PurID";
            this.lab_PurID.Size = new System.Drawing.Size(164, 18);
            this.lab_PurID.TabIndex = 3;
            this.lab_PurID.Text = "Purchase Order ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(914, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "ProductID:";
            // 
            // btn_completereceive
            // 
            this.btn_completereceive.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_completereceive.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_completereceive.Location = new System.Drawing.Point(604, 92);
            this.btn_completereceive.Name = "btn_completereceive";
            this.btn_completereceive.Size = new System.Drawing.Size(202, 57);
            this.btn_completereceive.TabIndex = 5;
            this.btn_completereceive.Text = "Confirm Stock Received";
            this.btn_completereceive.UseVisualStyleBackColor = false;
            this.btn_completereceive.Click += new System.EventHandler(this.btn_completereceive_Click);
            // 
            // checkBox_receivewithspecficnum
            // 
            this.checkBox_receivewithspecficnum.AutoSize = true;
            this.checkBox_receivewithspecficnum.Location = new System.Drawing.Point(604, 50);
            this.checkBox_receivewithspecficnum.Name = "checkBox_receivewithspecficnum";
            this.checkBox_receivewithspecficnum.Size = new System.Drawing.Size(230, 22);
            this.checkBox_receivewithspecficnum.TabIndex = 6;
            this.checkBox_receivewithspecficnum.Text = "Specific Number of Stock";
            this.checkBox_receivewithspecficnum.UseVisualStyleBackColor = true;
            this.checkBox_receivewithspecficnum.CheckedChanged += new System.EventHandler(this.checkBox_receivewithspecficnum_CheckedChanged);
            // 
            // numericUpDown_item
            // 
            this.numericUpDown_item.Location = new System.Drawing.Point(831, 49);
            this.numericUpDown_item.Name = "numericUpDown_item";
            this.numericUpDown_item.Size = new System.Drawing.Size(120, 27);
            this.numericUpDown_item.TabIndex = 7;
            // 
            // PurchaseID
            // 
            this.PurchaseID.HeaderText = "PurchaseOrderID";
            this.PurchaseID.Name = "PurchaseID";
            this.PurchaseID.ReadOnly = true;
            this.PurchaseID.Width = 150;
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "ProductID";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
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
            this.Quanity.HeaderText = "Purchase Quanity";
            this.Quanity.Name = "Quanity";
            this.Quanity.ReadOnly = true;
            // 
            // Interface_GetStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1442, 400);
            this.Controls.Add(this.numericUpDown_item);
            this.Controls.Add(this.checkBox_receivewithspecficnum);
            this.Controls.Add(this.btn_completereceive);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lab_PurID);
            this.Controls.Add(this.combo_PurID);
            this.Controls.Add(this.combo_pID);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Interface_GetStock";
            this.Text = "Interface_GetStock";
            this.Load += new System.EventHandler(this.Interface_GetStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_item)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox combo_pID;
        private System.Windows.Forms.ComboBox combo_PurID;
        private System.Windows.Forms.Label lab_PurID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_completereceive;
        private System.Windows.Forms.CheckBox checkBox_receivewithspecficnum;
        private System.Windows.Forms.NumericUpDown numericUpDown_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quanity;
    }
}