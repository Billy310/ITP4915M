namespace BetterLimited
{
    partial class Interface_EditInstallationOrder
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
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_Istatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_installationorder = new System.Windows.Forms.ComboBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryStat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(738, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 18);
            this.label3.TabIndex = 103;
            this.label3.Text = "Installation Status:";
            // 
            // cmb_Istatus
            // 
            this.cmb_Istatus.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Istatus.FormattingEnabled = true;
            this.cmb_Istatus.Items.AddRange(new object[] {
            "Not Installed",
            "Departure Installation",
            "Installed",
            "Cancelled"});
            this.cmb_Istatus.Location = new System.Drawing.Point(732, 105);
            this.cmb_Istatus.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmb_Istatus.Name = "cmb_Istatus";
            this.cmb_Istatus.Size = new System.Drawing.Size(309, 26);
            this.cmb_Istatus.TabIndex = 101;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(727, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 18);
            this.label1.TabIndex = 105;
            this.label1.Text = "Installation OrderID:";
            // 
            // cb_installationorder
            // 
            this.cb_installationorder.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_installationorder.FormattingEnabled = true;
            this.cb_installationorder.Location = new System.Drawing.Point(732, 40);
            this.cb_installationorder.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cb_installationorder.Name = "cb_installationorder";
            this.cb_installationorder.Size = new System.Drawing.Size(309, 26);
            this.cb_installationorder.TabIndex = 106;
            this.cb_installationorder.SelectedIndexChanged += new System.EventHandler(this.cmb_Lid_SelectedIndexChanged);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(732, 152);
            this.btn_update.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(303, 60);
            this.btn_update.TabIndex = 127;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(165, 399);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(15, 14, 15, 14);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 136;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dID,
            this.DeliveryDate,
            this.DeliveryTime,
            this.DeliveryStat});
            this.dataGridView1.Location = new System.Drawing.Point(14, 9);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(554, 372);
            this.dataGridView1.TabIndex = 135;
            // 
            // dID
            // 
            this.dID.HeaderText = "InstallationOrderID";
            this.dID.Name = "dID";
            this.dID.ReadOnly = true;
            this.dID.Width = 150;
            // 
            // DeliveryDate
            // 
            this.DeliveryDate.HeaderText = "Installation Date";
            this.DeliveryDate.Name = "DeliveryDate";
            this.DeliveryDate.ReadOnly = true;
            this.DeliveryDate.Width = 125;
            // 
            // DeliveryTime
            // 
            this.DeliveryTime.HeaderText = "Installation Time";
            this.DeliveryTime.Name = "DeliveryTime";
            this.DeliveryTime.ReadOnly = true;
            this.DeliveryTime.Width = 125;
            // 
            // DeliveryStat
            // 
            this.DeliveryStat.HeaderText = "Installation Status";
            this.DeliveryStat.Name = "DeliveryStat";
            this.DeliveryStat.ReadOnly = true;
            this.DeliveryStat.Width = 150;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 399);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 18);
            this.label2.TabIndex = 134;
            this.label2.Text = "Installation Date:";
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(395, 399);
            this.btn_search.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(173, 61);
            this.btn_search.TabIndex = 133;
            this.btn_search.Text = "Search Order";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click_1);
            // 
            // Interface_EditInstallationOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 571);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.cb_installationorder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_Istatus);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Interface_EditInstallationOrder";
            this.Text = "EditInstallation";
            this.Load += new System.EventHandler(this.EditInstallation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_Istatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleordersDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_installationorder;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridViewTextBoxColumn dID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryStat;
    }
}