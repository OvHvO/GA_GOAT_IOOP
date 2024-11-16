namespace GA_TestRun1.Mechanics.Mecha_Option
{
    partial class Mechanic_Manage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mechanic_Manage));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Customer_Show = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Reload_pic = new System.Windows.Forms.PictureBox();
            this.U_Quantity_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Update_List = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Update_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Show_taskDetail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Status_Cbo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Parts_ListB = new System.Windows.Forms.ListBox();
            this.Request_btn = new System.Windows.Forms.Button();
            this.R_Quantity_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Manage_txt = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Reload_pic)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Update Used Parts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Request Parts";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Customer_Show);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.Reload_pic);
            this.panel2.Controls.Add(this.U_Quantity_txt);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.Update_List);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.Update_btn);
            this.panel2.Location = new System.Drawing.Point(-8, 248);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(587, 141);
            this.panel2.TabIndex = 13;
            // 
            // Customer_Show
            // 
            this.Customer_Show.Enabled = false;
            this.Customer_Show.Location = new System.Drawing.Point(430, 29);
            this.Customer_Show.Name = "Customer_Show";
            this.Customer_Show.ReadOnly = true;
            this.Customer_Show.Size = new System.Drawing.Size(100, 20);
            this.Customer_Show.TabIndex = 17;
            this.Customer_Show.TextChanged += new System.EventHandler(this.Customer_Show_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Heavy", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(293, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Customer Name: ";
            // 
            // Reload_pic
            // 
            this.Reload_pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reload_pic.Image = ((System.Drawing.Image)(resources.GetObject("Reload_pic.Image")));
            this.Reload_pic.Location = new System.Drawing.Point(36, 29);
            this.Reload_pic.Margin = new System.Windows.Forms.Padding(2);
            this.Reload_pic.Name = "Reload_pic";
            this.Reload_pic.Size = new System.Drawing.Size(25, 27);
            this.Reload_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Reload_pic.TabIndex = 15;
            this.Reload_pic.TabStop = false;
            this.Reload_pic.Click += new System.EventHandler(this.Reload_pic_Click);
            // 
            // U_Quantity_txt
            // 
            this.U_Quantity_txt.Location = new System.Drawing.Point(430, 65);
            this.U_Quantity_txt.Name = "U_Quantity_txt";
            this.U_Quantity_txt.Size = new System.Drawing.Size(100, 20);
            this.U_Quantity_txt.TabIndex = 12;
            this.U_Quantity_txt.TextChanged += new System.EventHandler(this.U_Quantity_txt_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Heavy", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(306, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Used Quantity: ";
            // 
            // Update_List
            // 
            this.Update_List.FormattingEnabled = true;
            this.Update_List.Location = new System.Drawing.Point(139, 29);
            this.Update_List.Name = "Update_List";
            this.Update_List.Size = new System.Drawing.Size(120, 56);
            this.Update_List.TabIndex = 12;
            this.Update_List.SelectedIndexChanged += new System.EventHandler(this.Update_List_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Heavy", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(77, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Parts: ";
            // 
            // Update_btn
            // 
            this.Update_btn.Location = new System.Drawing.Point(243, 100);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(97, 29);
            this.Update_btn.TabIndex = 8;
            this.Update_btn.Text = "Update";
            this.Update_btn.UseVisualStyleBackColor = true;
            this.Update_btn.Click += new System.EventHandler(this.Update_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Show_taskDetail);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.Status_Cbo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Parts_ListB);
            this.panel1.Controls.Add(this.Request_btn);
            this.panel1.Controls.Add(this.R_Quantity_txt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-8, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 148);
            this.panel1.TabIndex = 11;
            // 
            // Show_taskDetail
            // 
            this.Show_taskDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Show_taskDetail.Enabled = false;
            this.Show_taskDetail.Location = new System.Drawing.Point(140, 20);
            this.Show_taskDetail.Multiline = true;
            this.Show_taskDetail.Name = "Show_taskDetail";
            this.Show_taskDetail.ReadOnly = true;
            this.Show_taskDetail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Show_taskDetail.Size = new System.Drawing.Size(119, 52);
            this.Show_taskDetail.TabIndex = 12;
            this.Show_taskDetail.TextChanged += new System.EventHandler(this.Show_taskDetail_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Franklin Gothic Heavy", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(37, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Task Detail: ";
            // 
            // Status_Cbo
            // 
            this.Status_Cbo.FormattingEnabled = true;
            this.Status_Cbo.Location = new System.Drawing.Point(391, 51);
            this.Status_Cbo.Name = "Status_Cbo";
            this.Status_Cbo.Size = new System.Drawing.Size(100, 21);
            this.Status_Cbo.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Heavy", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(321, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Status: ";
            // 
            // Parts_ListB
            // 
            this.Parts_ListB.FormattingEnabled = true;
            this.Parts_ListB.Location = new System.Drawing.Point(139, 78);
            this.Parts_ListB.Name = "Parts_ListB";
            this.Parts_ListB.Size = new System.Drawing.Size(120, 56);
            this.Parts_ListB.TabIndex = 8;
            this.Parts_ListB.SelectedIndexChanged += new System.EventHandler(this.Parts_ListB_SelectedIndexChanged);
            // 
            // Request_btn
            // 
            this.Request_btn.Location = new System.Drawing.Point(391, 96);
            this.Request_btn.Name = "Request_btn";
            this.Request_btn.Size = new System.Drawing.Size(97, 29);
            this.Request_btn.TabIndex = 7;
            this.Request_btn.Text = "Request";
            this.Request_btn.UseVisualStyleBackColor = true;
            this.Request_btn.Click += new System.EventHandler(this.Request_btn_Click);
            // 
            // R_Quantity_txt
            // 
            this.R_Quantity_txt.Location = new System.Drawing.Point(391, 19);
            this.R_Quantity_txt.Name = "R_Quantity_txt";
            this.R_Quantity_txt.Size = new System.Drawing.Size(100, 20);
            this.R_Quantity_txt.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Heavy", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(307, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quantity: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Heavy", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Parts: ";
            // 
            // Manage_txt
            // 
            this.Manage_txt.AutoSize = true;
            this.Manage_txt.Font = new System.Drawing.Font("Bauhaus 93", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Manage_txt.Location = new System.Drawing.Point(134, 10);
            this.Manage_txt.Name = "Manage_txt";
            this.Manage_txt.Size = new System.Drawing.Size(302, 30);
            this.Manage_txt.TabIndex = 10;
            this.Manage_txt.Text = "Manage Inventory Sheet";
            // 
            // Mechanic_Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 390);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Manage_txt);
            this.Name = "Mechanic_Manage";
            this.Text = "Mechanic_Man";
            this.Load += new System.EventHandler(this.Mechanic_Man_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Reload_pic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Update_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox Status_Cbo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox Parts_ListB;
        private System.Windows.Forms.Button Request_btn;
        private System.Windows.Forms.TextBox R_Quantity_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Manage_txt;
        private System.Windows.Forms.TextBox U_Quantity_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox Update_List;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox Reload_pic;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Customer_Show;
        private System.Windows.Forms.TextBox Show_taskDetail;
        private System.Windows.Forms.Label label9;
    }
}