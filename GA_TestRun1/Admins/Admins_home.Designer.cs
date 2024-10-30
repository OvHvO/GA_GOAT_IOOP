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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.FeatureBox = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.service_MNG = new System.Windows.Forms.Button();
            this.staff_MNG = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.AdminProfilelistBox = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.FeatureBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Monotype Corsiva", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(130, 21);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(258, 37);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "ADMIN INTERFACE";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-2, -1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(655, 429);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.PeachPuff;
            this.tabPage1.Controls.Add(this.AdminProfilelistBox);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.FeatureBox);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(647, 403);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FeatureBox
            // 
            this.FeatureBox.BackColor = System.Drawing.Color.RosyBrown;
            this.FeatureBox.Controls.Add(this.button4);
            this.FeatureBox.Controls.Add(this.button3);
            this.FeatureBox.Controls.Add(this.service_MNG);
            this.FeatureBox.Controls.Add(this.staff_MNG);
            this.FeatureBox.Location = new System.Drawing.Point(0, 0);
            this.FeatureBox.Margin = new System.Windows.Forms.Padding(2);
            this.FeatureBox.Name = "FeatureBox";
            this.FeatureBox.Padding = new System.Windows.Forms.Padding(2);
            this.FeatureBox.Size = new System.Drawing.Size(102, 403);
            this.FeatureBox.TabIndex = 1;
            this.FeatureBox.TabStop = false;
            this.FeatureBox.Text = "Features Box";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(9, 311);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 35);
            this.button4.TabIndex = 3;
            this.button4.Text = "Customer Feedback";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(9, 221);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 35);
            this.button3.TabIndex = 2;
            this.button3.Text = "Sales Report";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // service_MNG
            // 
            this.service_MNG.Location = new System.Drawing.Point(9, 136);
            this.service_MNG.Margin = new System.Windows.Forms.Padding(2);
            this.service_MNG.Name = "service_MNG";
            this.service_MNG.Size = new System.Drawing.Size(83, 35);
            this.service_MNG.TabIndex = 1;
            this.service_MNG.Text = "Service Management";
            this.service_MNG.UseVisualStyleBackColor = true;
            this.service_MNG.Click += new System.EventHandler(this.service_MNG_Click);
            // 
            // staff_MNG
            // 
            this.staff_MNG.Location = new System.Drawing.Point(9, 61);
            this.staff_MNG.Margin = new System.Windows.Forms.Padding(2);
            this.staff_MNG.Name = "staff_MNG";
            this.staff_MNG.Size = new System.Drawing.Size(83, 35);
            this.staff_MNG.TabIndex = 0;
            this.staff_MNG.Text = "Staff Management";
            this.staff_MNG.UseVisualStyleBackColor = true;
            this.staff_MNG.Click += new System.EventHandler(this.staff_MNG_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(647, 403);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(130, 107);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(258, 130);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // AdminProfilelistBox
            // 
            this.AdminProfilelistBox.FormattingEnabled = true;
            this.AdminProfilelistBox.Location = new System.Drawing.Point(443, 21);
            this.AdminProfilelistBox.Name = "AdminProfilelistBox";
            this.AdminProfilelistBox.Size = new System.Drawing.Size(177, 56);
            this.AdminProfilelistBox.TabIndex = 4;
            // 
            // Admins_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 426);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Admins_home";
            this.Text = "Admins_home";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.FeatureBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox FeatureBox;
        private System.Windows.Forms.Button staff_MNG;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button service_MNG;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListBox AdminProfilelistBox;
    }
}