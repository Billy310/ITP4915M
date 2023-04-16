namespace BetterLimited
{
    partial class Interface_ApproveReorder
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
            this.label4 = new System.Windows.Forms.Label();
            this.txt_prod = new System.Windows.Forms.TextBox();
            this.Rbtn_Prod = new System.Windows.Forms.RadioButton();
            this.Rbtn_Appr = new System.Windows.Forms.RadioButton();
            this.cmb_prod = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_approve = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Ordsearch = new System.Windows.Forms.Button();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.cb_reorderID = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_status = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ReorderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10F);
            this.label4.Location = new System.Drawing.Point(528, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 204;
            this.label4.Text = "ID:";
            this.label4.Visible = false;
            // 
            // txt_prod
            // 
            this.txt_prod.Font = new System.Drawing.Font("Verdana", 9F);
            this.txt_prod.Location = new System.Drawing.Point(564, 275);
            this.txt_prod.Name = "txt_prod";
            this.txt_prod.Size = new System.Drawing.Size(121, 22);
            this.txt_prod.TabIndex = 203;
            this.txt_prod.Visible = false;
            // 
            // Rbtn_Prod
            // 
            this.Rbtn_Prod.AutoSize = true;
            this.Rbtn_Prod.Location = new System.Drawing.Point(20, 240);
            this.Rbtn_Prod.Name = "Rbtn_Prod";
            this.Rbtn_Prod.Size = new System.Drawing.Size(261, 22);
            this.Rbtn_Prod.TabIndex = 201;
            this.Rbtn_Prod.TabStop = true;
            this.Rbtn_Prod.Text = "Check Order By Product Only";
            this.Rbtn_Prod.UseVisualStyleBackColor = true;
            // 
            // Rbtn_Appr
            // 
            this.Rbtn_Appr.AutoSize = true;
            this.Rbtn_Appr.Location = new System.Drawing.Point(20, 204);
            this.Rbtn_Appr.Name = "Rbtn_Appr";
            this.Rbtn_Appr.Size = new System.Drawing.Size(266, 22);
            this.Rbtn_Appr.TabIndex = 200;
            this.Rbtn_Appr.TabStop = true;
            this.Rbtn_Appr.Text = "Check Order By Approve Only";
            this.Rbtn_Appr.UseVisualStyleBackColor = true;
            // 
            // cmb_prod
            // 
            this.cmb_prod.Font = new System.Drawing.Font("Verdana", 12F);
            this.cmb_prod.FormattingEnabled = true;
            this.cmb_prod.Location = new System.Drawing.Point(471, 238);
            this.cmb_prod.Name = "cmb_prod";
            this.cmb_prod.Size = new System.Drawing.Size(250, 26);
            this.cmb_prod.TabIndex = 199;
            this.cmb_prod.SelectedIndexChanged += new System.EventHandler(this.cmb_prod_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReorderID,
            this.Status});
            this.dataGridView1.Location = new System.Drawing.Point(106, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(404, 148);
            this.dataGridView1.TabIndex = 194;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(383, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 18);
            this.label8.TabIndex = 193;
            this.label8.Text = "Product :";
            // 
            // cmb_approve
            // 
            this.cmb_approve.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_approve.FormattingEnabled = true;
            this.cmb_approve.Items.AddRange(new object[] {
            "Waiting Approve",
            "Returned"});
            this.cmb_approve.Location = new System.Drawing.Point(471, 206);
            this.cmb_approve.Name = "cmb_approve";
            this.cmb_approve.Size = new System.Drawing.Size(250, 26);
            this.cmb_approve.TabIndex = 192;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(319, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 18);
            this.label1.TabIndex = 191;
            this.label1.Text = "Approve Status :";
            // 
            // btn_Ordsearch
            // 
            this.btn_Ordsearch.Location = new System.Drawing.Point(727, 204);
            this.btn_Ordsearch.Name = "btn_Ordsearch";
            this.btn_Ordsearch.Size = new System.Drawing.Size(191, 94);
            this.btn_Ordsearch.TabIndex = 190;
            this.btn_Ordsearch.Text = "Search Order";
            this.btn_Ordsearch.UseVisualStyleBackColor = true;
            this.btn_Ordsearch.Click += new System.EventHandler(this.btn_Ordsearch_Click);
            // 
            // btn_confirm
            // 
            this.btn_confirm.BackColor = System.Drawing.Color.Chartreuse;
            this.btn_confirm.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirm.Location = new System.Drawing.Point(1286, 239);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(175, 72);
            this.btn_confirm.TabIndex = 213;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.UseVisualStyleBackColor = false;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // cb_reorderID
            // 
            this.cb_reorderID.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_reorderID.FormattingEnabled = true;
            this.cb_reorderID.Location = new System.Drawing.Point(1070, 239);
            this.cb_reorderID.Name = "cb_reorderID";
            this.cb_reorderID.Size = new System.Drawing.Size(210, 26);
            this.cb_reorderID.TabIndex = 211;
            this.cb_reorderID.SelectedIndexChanged += new System.EventHandler(this.cmb_EditID_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(973, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 18);
            this.label9.TabIndex = 210;
            this.label9.Text = "Order ID :";
            // 
            // cmb_status
            // 
            this.cmb_status.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_status.FormattingEnabled = true;
            this.cmb_status.Items.AddRange(new object[] {
            "Returned",
            "Approve"});
            this.cmb_status.Location = new System.Drawing.Point(1070, 271);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(210, 26);
            this.cmb_status.TabIndex = 214;
            this.cmb_status.SelectedIndexChanged += new System.EventHandler(this.cmb_status_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(924, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 18);
            this.label5.TabIndex = 215;
            this.label5.Text = "Approve Status:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmb_approve);
            this.groupBox2.Controls.Add(this.txt_prod);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.cmb_prod);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btn_confirm);
            this.groupBox2.Controls.Add(this.cmb_status);
            this.groupBox2.Controls.Add(this.Rbtn_Prod);
            this.groupBox2.Controls.Add(this.cb_reorderID);
            this.groupBox2.Controls.Add(this.Rbtn_Appr);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btn_Ordsearch);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1551, 311);
            this.groupBox2.TabIndex = 217;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reorder List";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductName,
            this.Type,
            this.Supplier,
            this.StockLevel});
            this.dataGridView2.Location = new System.Drawing.Point(553, 24);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(908, 150);
            this.dataGridView2.TabIndex = 216;
            // 
            // ReorderID
            // 
            this.ReorderID.HeaderText = "ReorderID";
            this.ReorderID.Name = "ReorderID";
            this.ReorderID.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 300;
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
            this.ProductName.Width = 300;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 130;
            // 
            // Supplier
            // 
            this.Supplier.HeaderText = "Supplier";
            this.Supplier.Name = "Supplier";
            this.Supplier.ReadOnly = true;
            this.Supplier.Width = 130;
            // 
            // StockLevel
            // 
            this.StockLevel.HeaderText = "StockLevel(WareHouse)";
            this.StockLevel.Name = "StockLevel";
            this.StockLevel.ReadOnly = true;
            this.StockLevel.Width = 200;
            // 
            // Interface_ApproveReorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1572, 335);
            this.Controls.Add(this.groupBox2);
            this.Name = "Interface_ApproveReorder";
            this.Text = "ApproveReorder";
            this.Load += new System.EventHandler(this.ApproveReorder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_prod;
        private System.Windows.Forms.RadioButton Rbtn_Prod;
        private System.Windows.Forms.RadioButton Rbtn_Appr;
        private System.Windows.Forms.ComboBox cmb_prod;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_approve;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Ordsearch;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.ComboBox cb_reorderID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmb_status;
        private System.Windows.Forms.Label label5;
      //  private betterlimitedDataSet220528TableAdapters.reorderTableAdapter reorderTableAdapter;
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
       // private Test20220525TableAdapters.productTableAdapter productTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn availableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requireInstallDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReorderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockLevel;
    }
}