namespace BetterLimited
{
    partial class Interface_ViewResultOfRequest
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
            this.RequestID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfCreate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb_recoverID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lab_storeID = new System.Windows.Forms.Label();
            this.lab_result = new System.Windows.Forms.Label();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.btn_getdata = new System.Windows.Forms.Button();
            this.lab_r = new System.Windows.Forms.Label();
            this.txt_reason = new System.Windows.Forms.RichTextBox();
            this.dateTimePicker_recoverdata = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RequestID,
            this.DateOfCreate,
            this.ProductID,
            this.ProductName,
            this.Quantity});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(715, 388);
            this.dataGridView1.TabIndex = 0;
            // 
            // RequestID
            // 
            this.RequestID.HeaderText = "RequestID";
            this.RequestID.Name = "RequestID";
            this.RequestID.ReadOnly = true;
            // 
            // DateOfCreate
            // 
            this.DateOfCreate.HeaderText = "Date Of Create";
            this.DateOfCreate.Name = "DateOfCreate";
            this.DateOfCreate.ReadOnly = true;
            this.DateOfCreate.Width = 120;
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "Product ID";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            this.ProductID.Width = 120;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 250;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 120;
            // 
            // cb_recoverID
            // 
            this.cb_recoverID.FormattingEnabled = true;
            this.cb_recoverID.Location = new System.Drawing.Point(141, 406);
            this.cb_recoverID.Name = "cb_recoverID";
            this.cb_recoverID.Size = new System.Drawing.Size(121, 26);
            this.cb_recoverID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Recovery ID:";
            // 
            // lab_storeID
            // 
            this.lab_storeID.AutoSize = true;
            this.lab_storeID.Location = new System.Drawing.Point(984, 9);
            this.lab_storeID.Name = "lab_storeID";
            this.lab_storeID.Size = new System.Drawing.Size(69, 18);
            this.lab_storeID.TabIndex = 3;
            this.lab_storeID.Text = "storeID";
            this.lab_storeID.Visible = false;
            // 
            // lab_result
            // 
            this.lab_result.AutoSize = true;
            this.lab_result.Location = new System.Drawing.Point(68, 449);
            this.lab_result.Name = "lab_result";
            this.lab_result.Size = new System.Drawing.Size(67, 18);
            this.lab_result.TabIndex = 4;
            this.lab_result.Text = "Result:";
            // 
            // txt_result
            // 
            this.txt_result.Enabled = false;
            this.txt_result.Location = new System.Drawing.Point(141, 446);
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(289, 27);
            this.txt_result.TabIndex = 5;
            // 
            // btn_getdata
            // 
            this.btn_getdata.Location = new System.Drawing.Point(268, 406);
            this.btn_getdata.Name = "btn_getdata";
            this.btn_getdata.Size = new System.Drawing.Size(228, 33);
            this.btn_getdata.TabIndex = 6;
            this.btn_getdata.Text = "More Information";
            this.btn_getdata.UseVisualStyleBackColor = true;
            this.btn_getdata.Click += new System.EventHandler(this.btn_getdata_Click);
            // 
            // lab_r
            // 
            this.lab_r.AutoSize = true;
            this.lab_r.Location = new System.Drawing.Point(60, 487);
            this.lab_r.Name = "lab_r";
            this.lab_r.Size = new System.Drawing.Size(75, 18);
            this.lab_r.TabIndex = 7;
            this.lab_r.Text = "Reason:";
            // 
            // txt_reason
            // 
            this.txt_reason.Enabled = false;
            this.txt_reason.Location = new System.Drawing.Point(141, 484);
            this.txt_reason.Name = "txt_reason";
            this.txt_reason.Size = new System.Drawing.Size(570, 247);
            this.txt_reason.TabIndex = 8;
            this.txt_reason.Text = "";
            // 
            // dateTimePicker_recoverdata
            // 
            this.dateTimePicker_recoverdata.CustomFormat = "yyyy/MM/dd";
            this.dateTimePicker_recoverdata.Enabled = false;
            this.dateTimePicker_recoverdata.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_recoverdata.Location = new System.Drawing.Point(717, 409);
            this.dateTimePicker_recoverdata.Name = "dateTimePicker_recoverdata";
            this.dateTimePicker_recoverdata.Size = new System.Drawing.Size(200, 27);
            this.dateTimePicker_recoverdata.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(553, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Date Of Recovery:";
            // 
            // Interface_ViewResultOfRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 823);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker_recoverdata);
            this.Controls.Add(this.txt_reason);
            this.Controls.Add(this.lab_r);
            this.Controls.Add(this.btn_getdata);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.lab_result);
            this.Controls.Add(this.lab_storeID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_recoverID);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Interface_ViewResultOfRequest";
            this.Text = "Interface_ViewResultOfRequest";
            this.Load += new System.EventHandler(this.Interface_ViewResultOfRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cb_recoverID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lab_storeID;
        private System.Windows.Forms.Label lab_result;
        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.Button btn_getdata;
        private System.Windows.Forms.Label lab_r;
        private System.Windows.Forms.RichTextBox txt_reason;
        private System.Windows.Forms.DateTimePicker dateTimePicker_recoverdata;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfCreate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
    }
}