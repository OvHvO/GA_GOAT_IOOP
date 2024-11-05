namespace GA_TestRun1.Admins
{
    partial class Admin_cus_FB
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.CusDetailsLB = new System.Windows.Forms.ListBox();
            this.CusFBlistBox = new System.Windows.Forms.ListBox();
            this.CusFBContentTB = new System.Windows.Forms.TextBox();
            this.CusFB_NoticeBtn = new System.Windows.Forms.Button();
            this.SelectNotice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "CUSTOMER FEEDBACK SYSTEM";
            // 
            // CusDetailsLB
            // 
            this.CusDetailsLB.FormattingEnabled = true;
            this.CusDetailsLB.ItemHeight = 16;
            this.CusDetailsLB.Location = new System.Drawing.Point(349, 143);
            this.CusDetailsLB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CusDetailsLB.Name = "CusDetailsLB";
            this.CusDetailsLB.Size = new System.Drawing.Size(263, 84);
            this.CusDetailsLB.TabIndex = 1;
            // 
            // CusFBlistBox
            // 
            this.CusFBlistBox.FormattingEnabled = true;
            this.CusFBlistBox.ItemHeight = 16;
            this.CusFBlistBox.Location = new System.Drawing.Point(73, 159);
            this.CusFBlistBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CusFBlistBox.Name = "CusFBlistBox";
            this.CusFBlistBox.Size = new System.Drawing.Size(228, 244);
            this.CusFBlistBox.TabIndex = 2;
            this.CusFBlistBox.SelectedIndexChanged += new System.EventHandler(this.CusFBlistBox_SelectedIndexChanged);
            // 
            // CusFBContentTB
            // 
            this.CusFBContentTB.Location = new System.Drawing.Point(349, 249);
            this.CusFBContentTB.Multiline = true;
            this.CusFBContentTB.Name = "CusFBContentTB";
            this.CusFBContentTB.Size = new System.Drawing.Size(263, 154);
            this.CusFBContentTB.TabIndex = 5;
            // 
            // CusFB_NoticeBtn
            // 
            this.CusFB_NoticeBtn.Location = new System.Drawing.Point(291, 451);
            this.CusFB_NoticeBtn.Name = "CusFB_NoticeBtn";
            this.CusFB_NoticeBtn.Size = new System.Drawing.Size(106, 33);
            this.CusFB_NoticeBtn.TabIndex = 6;
            this.CusFB_NoticeBtn.Text = "!!!NOTICE!!!";
            this.CusFB_NoticeBtn.UseVisualStyleBackColor = true;
            this.CusFB_NoticeBtn.Click += new System.EventHandler(this.CusFB_NoticeBtn_Click);
            // 
            // SelectNotice
            // 
            this.SelectNotice.AutoSize = true;
            this.SelectNotice.Location = new System.Drawing.Point(70, 143);
            this.SelectNotice.Name = "SelectNotice";
            this.SelectNotice.Size = new System.Drawing.Size(171, 16);
            this.SelectNotice.TabIndex = 7;
            this.SelectNotice.Text = "Please select the cusFB_ID";
            // 
            // Admin_cus_FB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.Controls.Add(this.SelectNotice);
            this.Controls.Add(this.CusFB_NoticeBtn);
            this.Controls.Add(this.CusFBContentTB);
            this.Controls.Add(this.CusFBlistBox);
            this.Controls.Add(this.CusDetailsLB);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Admin_cus_FB";
            this.Size = new System.Drawing.Size(725, 524);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox CusDetailsLB;
        private System.Windows.Forms.ListBox CusFBlistBox;
        private System.Windows.Forms.TextBox CusFBContentTB;
        private System.Windows.Forms.Button CusFB_NoticeBtn;
        private System.Windows.Forms.Label SelectNotice;
    }
}
