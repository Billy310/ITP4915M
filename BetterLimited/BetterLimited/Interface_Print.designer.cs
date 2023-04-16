namespace BetterLimited
{
    partial class Interface_Print
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
            this.RTB_view = new System.Windows.Forms.RichTextBox();
            this.btn_print = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RTB_view
            // 
            this.RTB_view.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTB_view.Location = new System.Drawing.Point(243, 12);
            this.RTB_view.Name = "RTB_view";
            this.RTB_view.Size = new System.Drawing.Size(316, 416);
            this.RTB_view.TabIndex = 0;
            this.RTB_view.Text = "";
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(632, 324);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(114, 62);
            this.btn_print.TabIndex = 1;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = true;
            // 
            // Interface_Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.RTB_view);
            this.Name = "Interface_Print";
            this.Text = "Interface_Generate";
            this.Load += new System.EventHandler(this.Interface_Generate_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox RTB_view;
        private System.Windows.Forms.Button btn_print;
    }
}