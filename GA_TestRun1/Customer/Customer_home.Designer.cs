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
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.updateProfileBtn = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.serviceViewBtn = new System.Windows.Forms.Button();
            this.cus_Panel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.Cus_FeatureBox.SuspendLayout();
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
            this.Cus_FeatureBox.BackColor = System.Drawing.Color.Firebrick;
            this.Cus_FeatureBox.Controls.Add(this.button8);
            this.Cus_FeatureBox.Controls.Add(this.button7);
            this.Cus_FeatureBox.Controls.Add(this.updateProfileBtn);
            this.Cus_FeatureBox.Controls.Add(this.button5);
            this.Cus_FeatureBox.Controls.Add(this.serviceViewBtn);
            this.Cus_FeatureBox.ForeColor = System.Drawing.SystemColors.Control;
            this.Cus_FeatureBox.Location = new System.Drawing.Point(0, 0);
            this.Cus_FeatureBox.Name = "Cus_FeatureBox";
            this.Cus_FeatureBox.Size = new System.Drawing.Size(107, 424);
            this.Cus_FeatureBox.TabIndex = 0;
            this.Cus_FeatureBox.TabStop = false;
            this.Cus_FeatureBox.Text = "FeatureBox";
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(16, 206);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 7;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(16, 131);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 6;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // updateProfileBtn
            // 
            this.updateProfileBtn.FlatAppearance.BorderSize = 0;
            this.updateProfileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateProfileBtn.Location = new System.Drawing.Point(16, 344);
            this.updateProfileBtn.Name = "updateProfileBtn";
            this.updateProfileBtn.Size = new System.Drawing.Size(75, 47);
            this.updateProfileBtn.TabIndex = 8;
            this.updateProfileBtn.Text = "UPDATE PROFILE";
            this.updateProfileBtn.UseVisualStyleBackColor = true;
            this.updateProfileBtn.Click += new System.EventHandler(this.updateProfileBtn_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(16, 54);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // serviceViewBtn
            // 
            this.serviceViewBtn.FlatAppearance.BorderSize = 0;
            this.serviceViewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.serviceViewBtn.Location = new System.Drawing.Point(16, 281);
            this.serviceViewBtn.Name = "serviceViewBtn";
            this.serviceViewBtn.Size = new System.Drawing.Size(75, 23);
            this.serviceViewBtn.TabIndex = 9;
            this.serviceViewBtn.Text = "SERVICE";
            this.serviceViewBtn.UseVisualStyleBackColor = true;
            // 
            // cus_Panel
            // 
            this.cus_Panel.Location = new System.Drawing.Point(107, 1);
            this.cus_Panel.Name = "cus_Panel";
            this.cus_Panel.Size = new System.Drawing.Size(544, 426);
            this.cus_Panel.TabIndex = 1;
            // 
            // Customer_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 426);
            this.Controls.Add(this.cus_Panel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Customer_home";
            this.Text = "Customer_home";
            this.panel1.ResumeLayout(false);
            this.Cus_FeatureBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel cus_Panel;
        private System.Windows.Forms.GroupBox Cus_FeatureBox;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button updateProfileBtn;
        private System.Windows.Forms.Button serviceViewBtn;
    }
}