namespace BetterLimited
{
    partial class Interface_CreateType
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
            this.txt_Typename = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Create = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lowstocklevel_count = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.lowstocklevel_count)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Typename
            // 
            this.txt_Typename.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Typename.Location = new System.Drawing.Point(122, 36);
            this.txt_Typename.Name = "txt_Typename";
            this.txt_Typename.Size = new System.Drawing.Size(402, 27);
            this.txt_Typename.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 18);
            this.label3.TabIndex = 23;
            this.label3.Text = "Type Name*:";
            // 
            // btn_Create
            // 
            this.btn_Create.BackColor = System.Drawing.Color.LawnGreen;
            this.btn_Create.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Create.Location = new System.Drawing.Point(306, 119);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(203, 60);
            this.btn_Create.TabIndex = 25;
            this.btn_Create.Text = "Create";
            this.btn_Create.UseVisualStyleBackColor = false;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "Low Stock Level*:";
            this.label1.Visible = false;
            // 
            // lowstocklevel_count
            // 
            this.lowstocklevel_count.Enabled = false;
            this.lowstocklevel_count.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowstocklevel_count.Location = new System.Drawing.Point(163, 69);
            this.lowstocklevel_count.Name = "lowstocklevel_count";
            this.lowstocklevel_count.Size = new System.Drawing.Size(120, 27);
            this.lowstocklevel_count.TabIndex = 27;
            this.lowstocklevel_count.Visible = false;
            // 
            // CreateType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 191);
            this.Controls.Add(this.lowstocklevel_count);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.txt_Typename);
            this.Controls.Add(this.label3);
            this.Name = "CreateType";
            this.Text = "CreateType";
            this.Load += new System.EventHandler(this.CreateType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lowstocklevel_count)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Typename;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown lowstocklevel_count;
    }
}