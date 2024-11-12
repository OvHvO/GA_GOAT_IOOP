namespace GA_TestRun1.Customer
{
    partial class Customer_home
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Cus_FeatureBox = new System.Windows.Forms.GroupBox();
            this.appManagementBtn = new System.Windows.Forms.Button();
            this.feedbackBtn = new System.Windows.Forms.Button();
            this.updateProfileBtn = new System.Windows.Forms.Button();
            this.serviceViewBtn = new System.Windows.Forms.Button();
            this.cus_Panel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.Cus_FeatureBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Cus_FeatureBox);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(107, 424);
            this.panel1.TabIndex = 0;
            // 
            // Cus_FeatureBox
            // 
            this.Cus_FeatureBox.BackColor = System.Drawing.Color.Gray;
            this.Cus_FeatureBox.Controls.Add(this.pictureBox1);
            this.Cus_FeatureBox.Controls.Add(this.appManagementBtn);
            this.Cus_FeatureBox.Controls.Add(this.feedbackBtn);
            this.Cus_FeatureBox.Controls.Add(this.updateProfileBtn);
            this.Cus_FeatureBox.Controls.Add(this.serviceViewBtn);
            this.Cus_FeatureBox.ForeColor = System.Drawing.SystemColors.Control;
            this.Cus_FeatureBox.Location = new System.Drawing.Point(0, -8);
            this.Cus_FeatureBox.Name = "Cus_FeatureBox";
            this.Cus_FeatureBox.Size = new System.Drawing.Size(107, 437);
            this.Cus_FeatureBox.TabIndex = 0;
            this.Cus_FeatureBox.TabStop = false;
            // 
            // appManagementBtn
            // 
            this.appManagementBtn.FlatAppearance.BorderSize = 0;
            this.appManagementBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.appManagementBtn.Location = new System.Drawing.Point(6, 179);
            this.appManagementBtn.Name = "appManagementBtn";
            this.appManagementBtn.Size = new System.Drawing.Size(94, 55);
            this.appManagementBtn.TabIndex = 7;
            this.appManagementBtn.Text = "APPOINMENT MANAGEMENT";
            this.appManagementBtn.UseVisualStyleBackColor = true;
            // 
            // feedbackBtn
            // 
            this.feedbackBtn.FlatAppearance.BorderSize = 0;
            this.feedbackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.feedbackBtn.Location = new System.Drawing.Point(16, 267);
            this.feedbackBtn.Name = "feedbackBtn";
            this.feedbackBtn.Size = new System.Drawing.Size(75, 23);
            this.feedbackBtn.TabIndex = 6;
            this.feedbackBtn.Text = "FEEDBACK";
            this.feedbackBtn.UseVisualStyleBackColor = true;
            this.feedbackBtn.Click += new System.EventHandler(this.feedbackBtn_Click);
            // 
            // updateProfileBtn
            // 
            this.updateProfileBtn.FlatAppearance.BorderSize = 0;
            this.updateProfileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateProfileBtn.Location = new System.Drawing.Point(16, 323);
            this.updateProfileBtn.Name = "updateProfileBtn";
            this.updateProfileBtn.Size = new System.Drawing.Size(75, 47);
            this.updateProfileBtn.TabIndex = 8;
            this.updateProfileBtn.Text = "UPDATE PROFILE";
            this.updateProfileBtn.UseVisualStyleBackColor = true;
            this.updateProfileBtn.Click += new System.EventHandler(this.updateProfileBtn_Click);
            // 
            // serviceViewBtn
            // 
            this.serviceViewBtn.FlatAppearance.BorderSize = 0;
            this.serviceViewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.serviceViewBtn.Location = new System.Drawing.Point(16, 139);
            this.serviceViewBtn.Name = "serviceViewBtn";
            this.serviceViewBtn.Size = new System.Drawing.Size(75, 23);
            this.serviceViewBtn.TabIndex = 9;
            this.serviceViewBtn.Text = "SERVICE";
            this.serviceViewBtn.UseVisualStyleBackColor = true;
            this.serviceViewBtn.Click += new System.EventHandler(this.serviceViewBtn_Click);
            // 
            // cus_Panel
            // 
            this.cus_Panel.Location = new System.Drawing.Point(107, 1);
            this.cus_Panel.Name = "cus_Panel";
            this.cus_Panel.Size = new System.Drawing.Size(587, 429);
            this.cus_Panel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GA_TestRun1.Properties.Resources.logo__4_;
            this.pictureBox1.Location = new System.Drawing.Point(10, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Customer_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 421);
            this.Controls.Add(this.cus_Panel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Customer_home";
            this.Text = "Customer_home";
            this.panel1.ResumeLayout(false);
            this.Cus_FeatureBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel cus_Panel;
        private System.Windows.Forms.GroupBox Cus_FeatureBox;
        private System.Windows.Forms.Button appManagementBtn;
        private System.Windows.Forms.Button feedbackBtn;
        private System.Windows.Forms.Button updateProfileBtn;
        private System.Windows.Forms.Button serviceViewBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}