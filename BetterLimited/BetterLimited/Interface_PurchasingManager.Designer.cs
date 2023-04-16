namespace BetterLimited
{
    partial class Interface_PurchasingManager
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
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_createpurchase = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCoral;
            this.button2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(210, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 53);
            this.button2.TabIndex = 18;
            this.button2.Text = "Approve";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Reorder Management:";
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.Gold;
            this.btn_logout.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.Location = new System.Drawing.Point(15, 192);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(155, 57);
            this.btn_logout.TabIndex = 29;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 18);
            this.label1.TabIndex = 30;
            this.label1.Text = "Purchase Order:";
            // 
            // btn_createpurchase
            // 
            this.btn_createpurchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_createpurchase.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_createpurchase.Location = new System.Drawing.Point(210, 114);
            this.btn_createpurchase.Name = "btn_createpurchase";
            this.btn_createpurchase.Size = new System.Drawing.Size(125, 53);
            this.btn_createpurchase.TabIndex = 31;
            this.btn_createpurchase.Text = "Create";
            this.btn_createpurchase.UseVisualStyleBackColor = false;
            this.btn_createpurchase.Click += new System.EventHandler(this.btn_createpurchase_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_edit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Location = new System.Drawing.Point(359, 114);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(166, 53);
            this.btn_edit.TabIndex = 32;
            this.btn_edit.Text = "Update Status";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // Interface_PurchasingManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 292);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_createpurchase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Name = "Interface_PurchasingManager";
            this.Text = "Purchasing Department Interface";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_createpurchase;
        private System.Windows.Forms.Button btn_edit;
    }
}