namespace BetterLimited
{
    partial class CreateReorder
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ProductID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_additem = new System.Windows.Forms.Button();
            this.lb_reorderlist = new System.Windows.Forms.ListBox();
            this.lb_searchresult = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_add2reorder = new System.Windows.Forms.Button();
            this.btn_Create = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(356, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reorder Create";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search Product:";
            // 
            // txt_ProductID
            // 
            this.txt_ProductID.Location = new System.Drawing.Point(154, 82);
            this.txt_ProductID.Name = "txt_ProductID";
            this.txt_ProductID.Size = new System.Drawing.Size(230, 27);
            this.txt_ProductID.TabIndex = 2;
            this.txt_ProductID.TextChanged += new System.EventHandler(this.txt_ProductID_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(581, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Reorder List";
            // 
            // btn_additem
            // 
            this.btn_additem.Location = new System.Drawing.Point(404, 83);
            this.btn_additem.Name = "btn_additem";
            this.btn_additem.Size = new System.Drawing.Size(135, 26);
            this.btn_additem.TabIndex = 4;
            this.btn_additem.Text = "Search";
            this.btn_additem.UseVisualStyleBackColor = true;
            this.btn_additem.Click += new System.EventHandler(this.btn_additem_Click);
            // 
            // lb_reorderlist
            // 
            this.lb_reorderlist.FormattingEnabled = true;
            this.lb_reorderlist.ItemHeight = 18;
            this.lb_reorderlist.Location = new System.Drawing.Point(584, 157);
            this.lb_reorderlist.Name = "lb_reorderlist";
            this.lb_reorderlist.Size = new System.Drawing.Size(289, 310);
            this.lb_reorderlist.TabIndex = 5;
            this.lb_reorderlist.SelectedIndexChanged += new System.EventHandler(this.lb_reorderlist_SelectedIndexChanged);
            // 
            // lb_searchresult
            // 
            this.lb_searchresult.FormattingEnabled = true;
            this.lb_searchresult.ItemHeight = 18;
            this.lb_searchresult.Location = new System.Drawing.Point(77, 157);
            this.lb_searchresult.Name = "lb_searchresult";
            this.lb_searchresult.Size = new System.Drawing.Size(289, 310);
            this.lb_searchresult.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Searched Result";
            // 
            // btn_add2reorder
            // 
            this.btn_add2reorder.Location = new System.Drawing.Point(372, 277);
            this.btn_add2reorder.Name = "btn_add2reorder";
            this.btn_add2reorder.Size = new System.Drawing.Size(206, 30);
            this.btn_add2reorder.TabIndex = 8;
            this.btn_add2reorder.Text = "Add to Reorder List";
            this.btn_add2reorder.UseVisualStyleBackColor = true;
            this.btn_add2reorder.Click += new System.EventHandler(this.btn_add2reorder_Click);
            // 
            // btn_Create
            // 
            this.btn_Create.Location = new System.Drawing.Point(884, 565);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(101, 30);
            this.btn_Create.TabIndex = 9;
            this.btn_Create.Text = "Create";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.button1_Click);
            // 
            // CreateReorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 607);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.btn_add2reorder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_searchresult);
            this.Controls.Add(this.lb_reorderlist);
            this.Controls.Add(this.btn_additem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_ProductID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "CreateReorder";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ProductID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_additem;
        private System.Windows.Forms.ListBox lb_reorderlist;
        private System.Windows.Forms.ListBox lb_searchresult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_add2reorder;
        private System.Windows.Forms.Button btn_Create;
    }
}