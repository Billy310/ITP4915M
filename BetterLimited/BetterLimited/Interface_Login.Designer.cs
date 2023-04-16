namespace BetterLimited
{
    partial class Interface_Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.lab_pwd = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.lab_Title = new System.Windows.Forms.Label();
            this.txt_DepartmentID = new System.Windows.Forms.TextBox();
            this.txt_DepartmentName = new System.Windows.Forms.TextBox();
            this.checkbox_Showpwd = new System.Windows.Forms.CheckBox();
            this.txt_sid = new System.Windows.Forms.TextBox();
            this.cbm_low = new System.Windows.Forms.ComboBox();
            this.txt_storeID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_username.Location = new System.Drawing.Point(130, 82);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(449, 27);
            this.txt_username.TabIndex = 1;
            this.txt_username.Text = "Enter Username";
            this.txt_username.TextChanged += new System.EventHandler(this.txt_username_TextChanged);
            this.txt_username.Enter += new System.EventHandler(this.txt_username_Enter);
            this.txt_username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_username_keypress);
            this.txt_username.Leave += new System.EventHandler(this.txt_username_Leave);
            // 
            // txt_pwd
            // 
            this.txt_pwd.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pwd.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_pwd.Location = new System.Drawing.Point(130, 128);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.Size = new System.Drawing.Size(449, 27);
            this.txt_pwd.TabIndex = 2;
            this.txt_pwd.Text = "Enter Password";
            this.txt_pwd.UseSystemPasswordChar = true;
            this.txt_pwd.Enter += new System.EventHandler(this.txt_password_Enter);
            this.txt_pwd.Leave += new System.EventHandler(this.txt_password_Leave);
            // 
            // lab_pwd
            // 
            this.lab_pwd.AutoSize = true;
            this.lab_pwd.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_pwd.Location = new System.Drawing.Point(32, 131);
            this.lab_pwd.Name = "lab_pwd";
            this.lab_pwd.Size = new System.Drawing.Size(92, 18);
            this.lab_pwd.TabIndex = 3;
            this.lab_pwd.Text = "Password:";
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.Chartreuse;
            this.btn_Login.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Location = new System.Drawing.Point(360, 228);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(219, 78);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // lab_Title
            // 
            this.lab_Title.AutoSize = true;
            this.lab_Title.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Title.Location = new System.Drawing.Point(124, 18);
            this.lab_Title.Name = "lab_Title";
            this.lab_Title.Size = new System.Drawing.Size(505, 32);
            this.lab_Title.TabIndex = 5;
            this.lab_Title.Text = "Better Limited Management System";
            // 
            // txt_DepartmentID
            // 
            this.txt_DepartmentID.Location = new System.Drawing.Point(12, 571);
            this.txt_DepartmentID.Name = "txt_DepartmentID";
            this.txt_DepartmentID.Size = new System.Drawing.Size(100, 22);
            this.txt_DepartmentID.TabIndex = 6;
            this.txt_DepartmentID.Visible = false;
            // 
            // txt_DepartmentName
            // 
            this.txt_DepartmentName.Location = new System.Drawing.Point(118, 571);
            this.txt_DepartmentName.Name = "txt_DepartmentName";
            this.txt_DepartmentName.Size = new System.Drawing.Size(100, 22);
            this.txt_DepartmentName.TabIndex = 7;
            this.txt_DepartmentName.Visible = false;
            // 
            // checkbox_Showpwd
            // 
            this.checkbox_Showpwd.AutoSize = true;
            this.checkbox_Showpwd.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox_Showpwd.Location = new System.Drawing.Point(585, 131);
            this.checkbox_Showpwd.Name = "checkbox_Showpwd";
            this.checkbox_Showpwd.Size = new System.Drawing.Size(153, 22);
            this.checkbox_Showpwd.TabIndex = 8;
            this.checkbox_Showpwd.Text = "Show Password";
            this.checkbox_Showpwd.UseVisualStyleBackColor = true;
            this.checkbox_Showpwd.CheckedChanged += new System.EventHandler(this.checkbox_Showpwd_CheckedChanged);
            // 
            // txt_sid
            // 
            this.txt_sid.Location = new System.Drawing.Point(12, 359);
            this.txt_sid.Name = "txt_sid";
            this.txt_sid.Size = new System.Drawing.Size(100, 22);
            this.txt_sid.TabIndex = 9;
            this.txt_sid.Visible = false;
            // 
            // cbm_low
            // 
            this.cbm_low.FormattingEnabled = true;
            this.cbm_low.Location = new System.Drawing.Point(118, 359);
            this.cbm_low.Name = "cbm_low";
            this.cbm_low.Size = new System.Drawing.Size(121, 20);
            this.cbm_low.TabIndex = 11;
            this.cbm_low.Visible = false;
            // 
            // txt_storeID
            // 
            this.txt_storeID.Location = new System.Drawing.Point(479, 161);
            this.txt_storeID.Name = "txt_storeID";
            this.txt_storeID.Size = new System.Drawing.Size(100, 22);
            this.txt_storeID.TabIndex = 12;
            this.txt_storeID.Visible = false;
            // 
            // Interface_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 381);
            this.Controls.Add(this.txt_storeID);
            this.Controls.Add(this.cbm_low);
            this.Controls.Add(this.txt_sid);
            this.Controls.Add(this.checkbox_Showpwd);
            this.Controls.Add(this.txt_DepartmentName);
            this.Controls.Add(this.txt_DepartmentID);
            this.Controls.Add(this.lab_Title);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.lab_pwd);
            this.Controls.Add(this.txt_pwd);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label1);
            this.Name = "Interface_Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Interface_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_pwd;
        private System.Windows.Forms.Label lab_pwd;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label lab_Title;
        private System.Windows.Forms.TextBox txt_DepartmentID;
        private System.Windows.Forms.TextBox txt_DepartmentName;
        private System.Windows.Forms.CheckBox checkbox_Showpwd;
        private System.Windows.Forms.TextBox txt_sid;
        private System.Windows.Forms.ComboBox cbm_low;
        private System.Windows.Forms.TextBox txt_storeID;
    }
}