namespace BetterLimited
{
    partial class Interface_EditType
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
            this.btn_Create = new System.Windows.Forms.Button();
            this.txt_Typename = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_selectype = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TID = new System.Windows.Forms.TextBox();
            this.TypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LowStockLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Create
            // 
            this.btn_Create.BackColor = System.Drawing.Color.LawnGreen;
            this.btn_Create.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Create.Location = new System.Drawing.Point(326, 122);
            this.btn_Create.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(202, 50);
            this.btn_Create.TabIndex = 30;
            this.btn_Create.Text = "Save";
            this.btn_Create.UseVisualStyleBackColor = false;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // txt_Typename
            // 
            this.txt_Typename.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Typename.Location = new System.Drawing.Point(213, 48);
            this.txt_Typename.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_Typename.Name = "txt_Typename";
            this.txt_Typename.Size = new System.Drawing.Size(315, 27);
            this.txt_Typename.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 18);
            this.label3.TabIndex = 28;
            this.label3.Text = "Type Name*:";
            // 
            // cb_selectype
            // 
            this.cb_selectype.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_selectype.FormattingEnabled = true;
            this.cb_selectype.Location = new System.Drawing.Point(213, 14);
            this.cb_selectype.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cb_selectype.Name = "cb_selectype";
            this.cb_selectype.Size = new System.Drawing.Size(315, 26);
            this.cb_selectype.TabIndex = 33;
            this.cb_selectype.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TypeID,
            this.TypeName,
            this.LowStockLevel});
            this.dataGridView1.Location = new System.Drawing.Point(558, 13);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(454, 320);
            this.dataGridView1.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 18);
            this.label2.TabIndex = 35;
            this.label2.Text = "Select Type For Editing:";
            // 
            // txt_TID
            // 
            this.txt_TID.Location = new System.Drawing.Point(1298, 598);
            this.txt_TID.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_TID.Name = "txt_TID";
            this.txt_TID.Size = new System.Drawing.Size(164, 27);
            this.txt_TID.TabIndex = 36;
            // 
            // TypeID
            // 
            this.TypeID.HeaderText = "TypeID";
            this.TypeID.Name = "TypeID";
            this.TypeID.ReadOnly = true;
            this.TypeID.Width = 150;
            // 
            // TypeName
            // 
            this.TypeName.HeaderText = "TypeName";
            this.TypeName.Name = "TypeName";
            this.TypeName.ReadOnly = true;
            this.TypeName.Width = 150;
            // 
            // LowStockLevel
            // 
            this.LowStockLevel.HeaderText = "Low Stock Level";
            this.LowStockLevel.Name = "LowStockLevel";
            this.LowStockLevel.ReadOnly = true;
            this.LowStockLevel.Width = 150;
            // 
            // EditType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 365);
            this.Controls.Add(this.txt_TID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cb_selectype);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.txt_Typename);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "EditType";
            this.Text = "EditType";
            this.Load += new System.EventHandler(this.EditType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.TextBox txt_Typename;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_selectype;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_TID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LowStockLevel;
    }
}