namespace BetterLimited
{
    partial class Interface_InstallationManager
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
            this.btn_view = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_view
            // 
            this.btn_view.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view.Location = new System.Drawing.Point(261, 175);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(250, 105);
            this.btn_view.TabIndex = 34;
            this.btn_view.Text = "View Installation Order";
            this.btn_view.UseVisualStyleBackColor = true;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.Gold;
            this.btn_logout.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.Location = new System.Drawing.Point(5, 383);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(155, 57);
            this.btn_logout.TabIndex = 33;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(748, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 12);
            this.label1.TabIndex = 32;
            this.label1.Text = "StaffID";
            this.label1.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(261, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 105);
            this.button1.TabIndex = 31;
            this.button1.Text = "Edit Schedule";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Interface_InstallationManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Interface_InstallationManager";
            this.Text = "Interface_InstallationManager";
            this.Load += new System.EventHandler(this.Interface_InstallationManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}