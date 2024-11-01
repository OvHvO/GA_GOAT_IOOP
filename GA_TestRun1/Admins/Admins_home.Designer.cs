namespace GA_TestRun1.Admins
{
    partial class Admins_home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admins_home));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AdminProfilelistBox = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.FeatureBox = new System.Windows.Forms.GroupBox();
            this.btn_cus_FB = new System.Windows.Forms.Button();
            this.btn_sales_Report = new System.Windows.Forms.Button();
            this.btn_service_MNG = new System.Windows.Forms.Button();
            this.btn_staff_MNG = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.admin_Panel = new System.Windows.Forms.Panel();
            this.FeatureBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.admin_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.Font = new System.Drawing.Font("Monotype Corsiva", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(28, 16);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(258, 37);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "ADMIN INTERFACE";
            // 
            // AdminProfilelistBox
            // 
            this.AdminProfilelistBox.FormattingEnabled = true;
            this.AdminProfilelistBox.Location = new System.Drawing.Point(340, 16);
            this.AdminProfilelistBox.Name = "AdminProfilelistBox";
            this.AdminProfilelistBox.Size = new System.Drawing.Size(177, 56);
            this.AdminProfilelistBox.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(28, 115);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(258, 130);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // FeatureBox
            // 
            this.FeatureBox.BackColor = System.Drawing.Color.RosyBrown;
            this.FeatureBox.Controls.Add(this.btn_cus_FB);
            this.FeatureBox.Controls.Add(this.btn_sales_Report);
            this.FeatureBox.Controls.Add(this.btn_service_MNG);
            this.FeatureBox.Controls.Add(this.btn_staff_MNG);
            this.FeatureBox.Location = new System.Drawing.Point(0, 2);
            this.FeatureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FeatureBox.Name = "FeatureBox";
            this.FeatureBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FeatureBox.Size = new System.Drawing.Size(102, 424);
            this.FeatureBox.TabIndex = 1;
            this.FeatureBox.TabStop = false;
            this.FeatureBox.Text = "Features Box";
            // 
            // btn_cus_FB
            // 
            this.btn_cus_FB.Location = new System.Drawing.Point(9, 311);
            this.btn_cus_FB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_cus_FB.Name = "btn_cus_FB";
            this.btn_cus_FB.Size = new System.Drawing.Size(83, 35);
            this.btn_cus_FB.TabIndex = 3;
            this.btn_cus_FB.Text = "Customer Feedback";
            this.btn_cus_FB.UseVisualStyleBackColor = true;
            this.btn_cus_FB.Click += new System.EventHandler(this.btn_cus_FB_Click);
            // 
            // btn_sales_Report
            // 
            this.btn_sales_Report.Location = new System.Drawing.Point(9, 221);
            this.btn_sales_Report.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_sales_Report.Name = "btn_sales_Report";
            this.btn_sales_Report.Size = new System.Drawing.Size(83, 35);
            this.btn_sales_Report.TabIndex = 2;
            this.btn_sales_Report.Text = "Sales Report";
            this.btn_sales_Report.UseVisualStyleBackColor = true;
            this.btn_sales_Report.Click += new System.EventHandler(this.btn_sales_Report_Click);
            // 
            // btn_service_MNG
            // 
            this.btn_service_MNG.Location = new System.Drawing.Point(9, 136);
            this.btn_service_MNG.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_service_MNG.Name = "btn_service_MNG";
            this.btn_service_MNG.Size = new System.Drawing.Size(83, 35);
            this.btn_service_MNG.TabIndex = 1;
            this.btn_service_MNG.Text = "Service Management";
            this.btn_service_MNG.UseVisualStyleBackColor = true;
            this.btn_service_MNG.Click += new System.EventHandler(this.service_MNG_Click);
            // 
            // btn_staff_MNG
            // 
            this.btn_staff_MNG.Location = new System.Drawing.Point(8, 58);
            this.btn_staff_MNG.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_staff_MNG.Name = "btn_staff_MNG";
            this.btn_staff_MNG.Size = new System.Drawing.Size(83, 35);
            this.btn_staff_MNG.TabIndex = 0;
            this.btn_staff_MNG.Text = "Staff Management";
            this.btn_staff_MNG.UseVisualStyleBackColor = true;
            this.btn_staff_MNG.Click += new System.EventHandler(this.staff_MNG_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.FeatureBox);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(107, 427);
            this.panel1.TabIndex = 5;
            // 
            // admin_Panel
            // 
            this.admin_Panel.BackColor = System.Drawing.Color.Salmon;
            this.admin_Panel.Controls.Add(this.AdminProfilelistBox);
            this.admin_Panel.Controls.Add(this.textBox2);
            this.admin_Panel.Controls.Add(this.textBox1);
            this.admin_Panel.Location = new System.Drawing.Point(107, 0);
            this.admin_Panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.admin_Panel.Name = "admin_Panel";
            this.admin_Panel.Size = new System.Drawing.Size(544, 426);
            this.admin_Panel.TabIndex = 5;
            // 
            // Admins_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 426);
            this.Controls.Add(this.admin_Panel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Admins_home";
            this.Text = "Admins_home";
            this.FeatureBox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.admin_Panel.ResumeLayout(false);
            this.admin_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox FeatureBox;
        private System.Windows.Forms.Button btn_staff_MNG;
        private System.Windows.Forms.Button btn_cus_FB;
        private System.Windows.Forms.Button btn_sales_Report;
        private System.Windows.Forms.Button btn_service_MNG;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListBox AdminProfilelistBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel admin_Panel;
    }
}