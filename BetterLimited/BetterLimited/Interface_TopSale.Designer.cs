namespace BetterLimited
{
    partial class Interface_TopSale
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.dataGridView_staff = new System.Windows.Forms.DataGridView();
            this.StaffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView_saleorder = new System.Windows.Forms.DataGridView();
            this.SaleorderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView_stafftw = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_staff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_saleorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_stafftw)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_staff
            // 
            this.dataGridView_staff.AllowUserToAddRows = false;
            this.dataGridView_staff.AllowUserToDeleteRows = false;
            this.dataGridView_staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_staff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StaffID,
            this.Firstname});
            this.dataGridView_staff.Location = new System.Drawing.Point(35, 18);
            this.dataGridView_staff.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGridView_staff.Name = "dataGridView_staff";
            this.dataGridView_staff.ReadOnly = true;
            this.dataGridView_staff.RowTemplate.Height = 24;
            this.dataGridView_staff.Size = new System.Drawing.Size(243, 340);
            this.dataGridView_staff.TabIndex = 0;
            this.dataGridView_staff.Visible = false;
            // 
            // StaffID
            // 
            this.StaffID.HeaderText = "StaffID";
            this.StaffID.Name = "StaffID";
            this.StaffID.ReadOnly = true;
            // 
            // Firstname
            // 
            this.Firstname.HeaderText = "Firstname";
            this.Firstname.Name = "Firstname";
            this.Firstname.ReadOnly = true;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(91, 43);
            this.chart1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Kowloon Bay Store";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(560, 349);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            title1.Name = "Hi";
            title1.Text = "Kowloon Bay Store Staff ( Order Count )";
            this.chart1.Titles.Add(title1);
            // 
            // dataGridView_saleorder
            // 
            this.dataGridView_saleorder.AllowUserToAddRows = false;
            this.dataGridView_saleorder.AllowUserToDeleteRows = false;
            this.dataGridView_saleorder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_saleorder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SaleorderID,
            this.Total});
            this.dataGridView_saleorder.Location = new System.Drawing.Point(1037, 254);
            this.dataGridView_saleorder.Name = "dataGridView_saleorder";
            this.dataGridView_saleorder.ReadOnly = true;
            this.dataGridView_saleorder.RowTemplate.Height = 24;
            this.dataGridView_saleorder.Size = new System.Drawing.Size(243, 340);
            this.dataGridView_saleorder.TabIndex = 2;
            this.dataGridView_saleorder.Visible = false;
            // 
            // SaleorderID
            // 
            this.SaleorderID.HeaderText = "SaleorderID";
            this.SaleorderID.Name = "SaleorderID";
            this.SaleorderID.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.chart2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(695, 43);
            this.chart2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Kowloon Bay Store";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(560, 349);
            this.chart2.TabIndex = 3;
            this.chart2.Text = "chart2";
            title2.Name = "Hi";
            title2.Text = "Kowloon Bay Store Staff (Selling Total) ";
            this.chart2.Titles.Add(title2);
            // 
            // chart3
            // 
            this.chart3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.chart3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            chartArea3.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart3.Legends.Add(legend3);
            this.chart3.Location = new System.Drawing.Point(45, 436);
            this.chart3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.chart3.Name = "chart3";
            this.chart3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Tsuen Wan Store";
            this.chart3.Series.Add(series3);
            this.chart3.Size = new System.Drawing.Size(560, 349);
            this.chart3.TabIndex = 4;
            this.chart3.Text = "chart3";
            title3.Name = "Hi";
            title3.Text = "Tsuen Wan Store Staff(Order Count)";
            this.chart3.Titles.Add(title3);
            // 
            // chart4
            // 
            this.chart4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.chart4.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            chartArea4.Name = "ChartArea1";
            this.chart4.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart4.Legends.Add(legend4);
            this.chart4.Location = new System.Drawing.Point(695, 436);
            this.chart4.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.chart4.Name = "chart4";
            this.chart4.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Tsuen Wan Store";
            this.chart4.Series.Add(series4);
            this.chart4.Size = new System.Drawing.Size(560, 349);
            this.chart4.TabIndex = 5;
            this.chart4.Text = "chart4";
            title4.Name = "Hi";
            title4.Text = "Tsuen Wan Store Staff(Selling Total)";
            this.chart4.Titles.Add(title4);
            // 
            // dataGridView_stafftw
            // 
            this.dataGridView_stafftw.AllowUserToAddRows = false;
            this.dataGridView_stafftw.AllowUserToDeleteRows = false;
            this.dataGridView_stafftw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_stafftw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView_stafftw.Location = new System.Drawing.Point(533, 400);
            this.dataGridView_stafftw.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGridView_stafftw.Name = "dataGridView_stafftw";
            this.dataGridView_stafftw.ReadOnly = true;
            this.dataGridView_stafftw.RowTemplate.Height = 24;
            this.dataGridView_stafftw.Size = new System.Drawing.Size(243, 340);
            this.dataGridView_stafftw.TabIndex = 6;
            this.dataGridView_stafftw.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "StaffID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Firstname";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Interface_TopSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 789);
            this.Controls.Add(this.dataGridView_stafftw);
            this.Controls.Add(this.dataGridView_saleorder);
            this.Controls.Add(this.dataGridView_staff);
            this.Controls.Add(this.chart4);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Interface_TopSale";
            this.Text = "Interface_TopSale";
            this.Load += new System.EventHandler(this.Interface_TopSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_staff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_saleorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_stafftw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_staff;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Firstname;
        private System.Windows.Forms.DataGridView dataGridView_saleorder;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleorderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
        private System.Windows.Forms.DataGridView dataGridView_stafftw;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}