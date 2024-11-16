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
            this.label_UUP = new System.Windows.Forms.Label();
            this.label_RP = new System.Windows.Forms.Label();
            this.panel_UUP = new System.Windows.Forms.Panel();
            this.Customer_Show = new System.Windows.Forms.TextBox();
            this.label_CN = new System.Windows.Forms.Label();
            this.Reload_pic = new System.Windows.Forms.PictureBox();
            this.U_Quantity_txt = new System.Windows.Forms.TextBox();
            this.label_UQ = new System.Windows.Forms.Label();
            this.Update_List = new System.Windows.Forms.ListBox();
            this.label_PTs = new System.Windows.Forms.Label();
            this.Update_btn = new System.Windows.Forms.Button();
            this.panel_RP = new System.Windows.Forms.Panel();
            this.Show_taskDetail = new System.Windows.Forms.TextBox();
            this.label_TD = new System.Windows.Forms.Label();
            this.Status_Cbo = new System.Windows.Forms.ComboBox();
            this.label_Stat = new System.Windows.Forms.Label();
            this.Parts_ListB = new System.Windows.Forms.ListBox();
            this.Request_btn = new System.Windows.Forms.Button();
            this.R_Quantity_txt = new System.Windows.Forms.TextBox();
            this.label_Quan = new System.Windows.Forms.Label();
            this.label_P = new System.Windows.Forms.Label();
            this.Manage_txt = new System.Windows.Forms.Label();
            this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            this.panel_UUP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Reload_pic)).BeginInit();
            this.panel_RP.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_UUP
            // 
            this.label_UUP.AutoSize = true;
            this.label_UUP.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UUP.Location = new System.Drawing.Point(2, 236);
            this.label_UUP.Name = "label_UUP";
            this.label_UUP.Size = new System.Drawing.Size(164, 24);
            this.label_UUP.TabIndex = 14;
            this.label_UUP.Text = "Update Used Parts";
            // 
            // label_RP
            // 
            this.label_RP.AutoSize = true;
            this.label_RP.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_RP.Location = new System.Drawing.Point(2, 65);
            this.label_RP.Name = "label_RP";
            this.label_RP.Size = new System.Drawing.Size(127, 24);
            this.label_RP.TabIndex = 12;
            this.label_RP.Text = "Request Parts";
            // 
            // panel_UUP
            // 
            this.panel_UUP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_UUP.Controls.Add(this.Customer_Show);
            this.panel_UUP.Controls.Add(this.label_CN);
            this.panel_UUP.Controls.Add(this.Reload_pic);
            this.panel_UUP.Controls.Add(this.U_Quantity_txt);
            this.panel_UUP.Controls.Add(this.label_UQ);
            this.panel_UUP.Controls.Add(this.Update_List);
            this.panel_UUP.Controls.Add(this.label_PTs);
            this.panel_UUP.Controls.Add(this.Update_btn);
            this.panel_UUP.Location = new System.Drawing.Point(-8, 248);
            this.panel_UUP.Name = "panel_UUP";
            this.panel_UUP.Size = new System.Drawing.Size(587, 141);
            this.panel_UUP.TabIndex = 13;
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
            // label_CN
            // 
            this.label_CN.AutoSize = true;
            this.label_CN.Font = new System.Drawing.Font("Franklin Gothic Heavy", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CN.Location = new System.Drawing.Point(293, 29);
            this.label_CN.Name = "label_CN";
            this.label_CN.Size = new System.Drawing.Size(131, 20);
            this.label_CN.TabIndex = 16;
            this.label_CN.Text = "Customer Name: ";
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
            // label_UQ
            // 
            this.label_UQ.AutoSize = true;
            this.label_UQ.Font = new System.Drawing.Font("Franklin Gothic Heavy", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UQ.Location = new System.Drawing.Point(306, 65);
            this.label_UQ.Name = "label_UQ";
            this.label_UQ.Size = new System.Drawing.Size(118, 20);
            this.label_UQ.TabIndex = 11;
            this.label_UQ.Text = "Used Quantity: ";
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
            // label_PTs
            // 
            this.label_PTs.AutoSize = true;
            this.label_PTs.Font = new System.Drawing.Font("Franklin Gothic Heavy", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PTs.Location = new System.Drawing.Point(77, 29);
            this.label_PTs.Name = "label_PTs";
            this.label_PTs.Size = new System.Drawing.Size(56, 20);
            this.label_PTs.TabIndex = 11;
            this.label_PTs.Text = "Parts: ";
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
            // panel_RP
            // 
            this.panel_RP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_RP.Controls.Add(this.Show_taskDetail);
            this.panel_RP.Controls.Add(this.label_TD);
            this.panel_RP.Controls.Add(this.Status_Cbo);
            this.panel_RP.Controls.Add(this.label_Stat);
            this.panel_RP.Controls.Add(this.Parts_ListB);
            this.panel_RP.Controls.Add(this.Request_btn);
            this.panel_RP.Controls.Add(this.R_Quantity_txt);
            this.panel_RP.Controls.Add(this.label_Quan);
            this.panel_RP.Controls.Add(this.label_P);
            this.panel_RP.Location = new System.Drawing.Point(-8, 77);
            this.panel_RP.Name = "panel_RP";
            this.panel_RP.Size = new System.Drawing.Size(587, 148);
            this.panel_RP.TabIndex = 11;
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
            // label_TD
            // 
            this.label_TD.AutoSize = true;
            this.label_TD.Font = new System.Drawing.Font("Franklin Gothic Heavy", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TD.Location = new System.Drawing.Point(37, 20);
            this.label_TD.Name = "label_TD";
            this.label_TD.Size = new System.Drawing.Size(96, 20);
            this.label_TD.TabIndex = 11;
            this.label_TD.Text = "Task Detail: ";
            // 
            // Status_Cbo
            // 
            this.Status_Cbo.FormattingEnabled = true;
            this.Status_Cbo.Location = new System.Drawing.Point(391, 51);
            this.Status_Cbo.Name = "Status_Cbo";
            this.Status_Cbo.Size = new System.Drawing.Size(100, 21);
            this.Status_Cbo.TabIndex = 10;
            // 
            // label_Stat
            // 
            this.label_Stat.AutoSize = true;
            this.label_Stat.Font = new System.Drawing.Font("Franklin Gothic Heavy", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Stat.Location = new System.Drawing.Point(321, 53);
            this.label_Stat.Name = "label_Stat";
            this.label_Stat.Size = new System.Drawing.Size(64, 20);
            this.label_Stat.TabIndex = 9;
            this.label_Stat.Text = "Status: ";
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
            // label_Quan
            // 
            this.label_Quan.AutoSize = true;
            this.label_Quan.Font = new System.Drawing.Font("Franklin Gothic Heavy", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Quan.Location = new System.Drawing.Point(307, 18);
            this.label_Quan.Name = "label_Quan";
            this.label_Quan.Size = new System.Drawing.Size(78, 20);
            this.label_Quan.TabIndex = 5;
            this.label_Quan.Text = "Quantity: ";
            // 
            // label_P
            // 
            this.label_P.AutoSize = true;
            this.label_P.Font = new System.Drawing.Font("Franklin Gothic Heavy", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_P.Location = new System.Drawing.Point(77, 78);
            this.label_P.Name = "label_P";
            this.label_P.Size = new System.Drawing.Size(56, 20);
            this.label_P.TabIndex = 4;
            this.label_P.Text = "Parts: ";
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
            // sqlCommand1
            // 
            this.sqlCommand1.CommandTimeout = 30;
            this.sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // Mechanic_Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 390);
            this.Controls.Add(this.label_UUP);
            this.Controls.Add(this.label_RP);
            this.Controls.Add(this.panel_UUP);
            this.Controls.Add(this.panel_RP);
            this.Controls.Add(this.Manage_txt);
            this.Name = "Mechanic_Manage";
            this.Text = "Mechanic_Man";
            this.Load += new System.EventHandler(this.Mechanic_Man_Load);
            this.panel_UUP.ResumeLayout(false);
            this.panel_UUP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Reload_pic)).EndInit();
            this.panel_RP.ResumeLayout(false);
            this.panel_RP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_UUP;
        private System.Windows.Forms.Label label_RP;
        private System.Windows.Forms.Panel panel_UUP;
        private System.Windows.Forms.Button Update_btn;
        private System.Windows.Forms.Panel panel_RP;
        private System.Windows.Forms.ComboBox Status_Cbo;
        private System.Windows.Forms.Label label_Stat;
        private System.Windows.Forms.ListBox Parts_ListB;
        private System.Windows.Forms.Button Request_btn;
        private System.Windows.Forms.TextBox R_Quantity_txt;
        private System.Windows.Forms.Label label_Quan;
        private System.Windows.Forms.Label label_P;
        private System.Windows.Forms.Label Manage_txt;
        private System.Windows.Forms.TextBox U_Quantity_txt;
        private System.Windows.Forms.Label label_UQ;
        private System.Windows.Forms.ListBox Update_List;
        private System.Windows.Forms.Label label_PTs;
        private System.Windows.Forms.PictureBox Reload_pic;
        private System.Windows.Forms.Label label_CN;
        private System.Windows.Forms.TextBox Customer_Show;
        private System.Windows.Forms.TextBox Show_taskDetail;
        private System.Windows.Forms.Label label_TD;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}