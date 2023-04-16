namespace BetterLimited
{
    partial class Interface_AccountingClerk
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
            this.btn_back = new System.Windows.Forms.Button();
            this.lab_chart = new System.Windows.Forms.Label();
            this.btn_turnover = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_approve = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Gold;
            this.btn_back.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(12, 167);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(155, 57);
            this.btn_back.TabIndex = 29;
            this.btn_back.Text = "Logout";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lab_chart
            // 
            this.lab_chart.AutoSize = true;
            this.lab_chart.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_chart.Location = new System.Drawing.Point(-1, 103);
            this.lab_chart.Name = "lab_chart";
            this.lab_chart.Size = new System.Drawing.Size(59, 18);
            this.lab_chart.TabIndex = 30;
            this.lab_chart.Text = "Chart:";
            // 
            // btn_turnover
            // 
            this.btn_turnover.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_turnover.Location = new System.Drawing.Point(64, 85);
            this.btn_turnover.Name = "btn_turnover";
            this.btn_turnover.Size = new System.Drawing.Size(173, 55);
            this.btn_turnover.TabIndex = 31;
            this.btn_turnover.Text = "View Store Turnover Chart";
            this.btn_turnover.UseVisualStyleBackColor = true;
            this.btn_turnover.Click += new System.EventHandler(this.btn_turnover_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(243, 81);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(229, 62);
            this.button8.TabIndex = 46;
            this.button8.Text = "View Product Selling Trend";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 18);
            this.label2.TabIndex = 32;
            this.label2.Text = "Approve Purchase Product:";
            // 
            // btn_approve
            // 
            this.btn_approve.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_approve.Location = new System.Drawing.Point(243, 12);
            this.btn_approve.Name = "btn_approve";
            this.btn_approve.Size = new System.Drawing.Size(155, 53);
            this.btn_approve.TabIndex = 33;
            this.btn_approve.Text = "Approve Purchase Item";
            this.btn_approve.UseVisualStyleBackColor = true;
            this.btn_approve.Click += new System.EventHandler(this.btn_approve_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(478, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 55);
            this.button1.TabIndex = 47;
            this.button1.Text = "Staff Performance";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Interface_AccountingClerk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(790, 322);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.btn_approve);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_turnover);
            this.Controls.Add(this.lab_chart);
            this.Controls.Add(this.btn_back);
            this.Name = "Interface_AccountingClerk";
            this.Text = "Interface_AccountingClerk";
            this.Load += new System.EventHandler(this.Interface_AccountingClerk_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lab_chart;
        private System.Windows.Forms.Button btn_turnover;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_approve;
        private System.Windows.Forms.Button button1;
    }
}