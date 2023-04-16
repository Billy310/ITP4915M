namespace BetterLimited
{
    partial class aCreate
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
            this.lab_username = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.lab_pwd = new System.Windows.Forms.Label();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.btn_create = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lab_gender = new System.Windows.Forms.Label();
            this.btn_edit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.combo_access = new System.Windows.Forms.ComboBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.cb_gender = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lab_username
            // 
            this.lab_username.AutoSize = true;
            this.lab_username.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_username.Location = new System.Drawing.Point(23, 77);
            this.lab_username.Name = "lab_username";
            this.lab_username.Size = new System.Drawing.Size(97, 18);
            this.lab_username.TabIndex = 0;
            this.lab_username.Text = "Username:";
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(126, 73);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(119, 27);
            this.txt_username.TabIndex = 1;
            this.txt_username.TextChanged += new System.EventHandler(this.txt_username_TextChanged);
            // 
            // lab_pwd
            // 
            this.lab_pwd.AutoSize = true;
            this.lab_pwd.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_pwd.Location = new System.Drawing.Point(26, 109);
            this.lab_pwd.Name = "lab_pwd";
            this.lab_pwd.Size = new System.Drawing.Size(92, 18);
            this.lab_pwd.TabIndex = 2;
            this.lab_pwd.Text = "Password:";
            // 
            // txt_pwd
            // 
            this.txt_pwd.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pwd.Location = new System.Drawing.Point(126, 106);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.Size = new System.Drawing.Size(119, 27);
            this.txt_pwd.TabIndex = 3;
            this.txt_pwd.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btn_create
            // 
            this.btn_create.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create.Location = new System.Drawing.Point(678, 402);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(110, 36);
            this.btn_create.TabIndex = 4;
            this.btn_create.Text = "Create";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Create Account";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lab_gender
            // 
            this.lab_gender.AutoSize = true;
            this.lab_gender.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_gender.Location = new System.Drawing.Point(45, 142);
            this.lab_gender.Name = "lab_gender";
            this.lab_gender.Size = new System.Drawing.Size(73, 18);
            this.lab_gender.TabIndex = 6;
            this.lab_gender.Text = "Gender:";
            // 
            // btn_edit
            // 
            this.btn_edit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Location = new System.Drawing.Point(633, 12);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(155, 39);
            this.btn_edit.TabIndex = 8;
            this.btn_edit.Text = "Edit Account ";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Department:";
            // 
            // combo_access
            // 
            this.combo_access.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_access.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_access.FormattingEnabled = true;
            this.combo_access.Items.AddRange(new object[] {
            "Select Access ",
            "0",
            "1"});
            this.combo_access.Location = new System.Drawing.Point(124, 172);
            this.combo_access.Name = "combo_access";
            this.combo_access.Size = new System.Drawing.Size(121, 26);
            this.combo_access.TabIndex = 10;
            this.combo_access.SelectedIndexChanged += new System.EventHandler(this.combo_access_SelectedIndexChanged);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(633, 57);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(155, 39);
            this.btn_Delete.TabIndex = 11;
            this.btn_Delete.Text = "Delete Account ";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // cb_gender
            // 
            this.cb_gender.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_gender.FormattingEnabled = true;
            this.cb_gender.Items.AddRange(new object[] {
            "Select Your Gender",
            "M",
            "F"});
            this.cb_gender.Location = new System.Drawing.Point(124, 139);
            this.cb_gender.Name = "cb_gender";
            this.cb_gender.Size = new System.Drawing.Size(121, 26);
            this.cb_gender.TabIndex = 12;
            // 
            // aCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cb_gender);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.combo_access);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.lab_gender);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.txt_pwd);
            this.Controls.Add(this.lab_pwd);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.lab_username);
            this.Name = "aCreate";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_username;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label lab_pwd;
        private System.Windows.Forms.TextBox txt_pwd;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lab_gender;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combo_access;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.ComboBox cb_gender;
    }
}

