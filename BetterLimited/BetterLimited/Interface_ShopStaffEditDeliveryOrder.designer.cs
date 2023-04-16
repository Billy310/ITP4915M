namespace BetterLimited
{
    partial class Interface_ShopStaffEditDeliveryOrder
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
            this.cmb_Dstatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Deliveryorder = new System.Windows.Forms.ComboBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryStat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(569, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 18);
            this.label2.TabIndex = 97;
            this.label2.Text = "Delivery Status:";
            // 
            // cmb_Dstatus
            // 
            this.cmb_Dstatus.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Dstatus.FormattingEnabled = true;
            this.cmb_Dstatus.Items.AddRange(new object[] {
            "Not Delivered",
            "Departure Delivery",
            "Delivered",
            "Cancelled"});
            this.cmb_Dstatus.Location = new System.Drawing.Point(572, 132);
            this.cmb_Dstatus.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmb_Dstatus.Name = "cmb_Dstatus";
            this.cmb_Dstatus.Size = new System.Drawing.Size(309, 26);
            this.cmb_Dstatus.TabIndex = 95;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(572, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 18);
            this.label1.TabIndex = 107;
            this.label1.Text = "Delivery OrderID:";
            // 
            // cb_Deliveryorder
            // 
            this.cb_Deliveryorder.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Deliveryorder.FormattingEnabled = true;
            this.cb_Deliveryorder.Location = new System.Drawing.Point(572, 66);
            this.cb_Deliveryorder.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cb_Deliveryorder.Name = "cb_Deliveryorder";
            this.cb_Deliveryorder.Size = new System.Drawing.Size(309, 26);
            this.cb_Deliveryorder.TabIndex = 108;
            this.cb_Deliveryorder.SelectedIndexChanged += new System.EventHandler(this.cmb_Did_SelectedIndexChanged);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Linen;
            this.btn_update.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(572, 178);
            this.btn_update.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(309, 57);
            this.btn_update.TabIndex = 113;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(389, 396);
            this.btn_search.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(173, 61);
            this.btn_search.TabIndex = 111;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(34, 6);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(528, 372);
            this.dataGridView1.TabIndex = 131;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dID
            // 
            this.dID.HeaderText = "DeliveryOrderID";
            this.dID.Name = "dID";
            this.dID.ReadOnly = true;
            this.dID.Width = 125;
            // 
            // DeliveryDate
            // 
            this.DeliveryDate.HeaderText = "Delivery Date";
            this.DeliveryDate.Name = "DeliveryDate";
            this.DeliveryDate.ReadOnly = true;
            this.DeliveryDate.Width = 125;
            // 
            // DeliveryTime
            // 
            this.DeliveryTime.HeaderText = "Delivery Time";
            this.DeliveryTime.Name = "DeliveryTime";
            this.DeliveryTime.ReadOnly = true;
            this.DeliveryTime.Width = 125;
            // 
            // DeliveryStat
            // 
            this.DeliveryStat.HeaderText = "Delivery Status";
            this.DeliveryStat.Name = "DeliveryStat";
            this.DeliveryStat.ReadOnly = true;
            this.DeliveryStat.Width = 150;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 396);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 18);
            this.label3.TabIndex = 112;
            this.label3.Text = "Delivery Date:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(159, 396);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(15, 14, 15, 14);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 132;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // Interface_ShopStaffEditDeliveryOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 596);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.cb_Deliveryorder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_Dstatus);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Interface_ShopStaffEditDeliveryOrder";
            this.Text = "EditDeliveryOrder";
            this.Load += new System.EventHandler(this.EditDeliveryOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_Dstatus;
      //  private betterlimitedDataSetTest betterlimitedDataSetTest;
        //private betterlimitedDataSetTestTableAdapters.deliveryorderTableAdapter deliveryorderTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Deliveryorder;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryOrderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeofDeliveryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryProductID1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryProductID2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryProductID3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryProductID4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryProductID5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryProductID6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryProductID7DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryProductID8DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryProductID9DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryProductID10DataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryStat;
    }
}