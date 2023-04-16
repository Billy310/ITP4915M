namespace BetterLimited
{
    partial class Interface_PurchasingClerk
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_ReEdit = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(222, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 53);
            this.button1.TabIndex = 18;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Reorder Management:";
            // 
            // btn_ReEdit
            // 
            this.btn_ReEdit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ReEdit.Location = new System.Drawing.Point(366, 68);
            this.btn_ReEdit.Name = "btn_ReEdit";
            this.btn_ReEdit.Size = new System.Drawing.Size(125, 53);
            this.btn_ReEdit.TabIndex = 19;
            this.btn_ReEdit.Text = "Edit";
            this.btn_ReEdit.UseVisualStyleBackColor = true;
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.Gold;
            this.btn_logout.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.Location = new System.Drawing.Point(12, 381);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(155, 57);
            this.btn_logout.TabIndex = 29;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // Interface_PurchasingClerk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_ReEdit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Name = "Interface_PurchasingClerk";
            this.Text = "PurchasingStaff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_ReEdit;
        private System.Windows.Forms.Button btn_logout;
    }
}