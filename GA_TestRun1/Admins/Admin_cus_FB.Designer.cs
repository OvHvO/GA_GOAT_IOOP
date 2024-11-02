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
            this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            this.CusDetailsLB = new System.Windows.Forms.ListBox();
            this.CusFBlistBox = new System.Windows.Forms.ListBox();
            this.CusFBContentLB = new System.Windows.Forms.ListBox();
            this.CusFBClearBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "CUSTOMER FEEDBACK SYSTEM";
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandTimeout = 30;
            this.sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // CusDetailsLB
            // 
            this.CusDetailsLB.FormattingEnabled = true;
            this.CusDetailsLB.ItemHeight = 16;
            this.CusDetailsLB.Location = new System.Drawing.Point(73, 143);
            this.CusDetailsLB.Name = "CusDetailsLB";
            this.CusDetailsLB.Size = new System.Drawing.Size(263, 84);
            this.CusDetailsLB.TabIndex = 1;
            // 
            // CusFBlistBox
            // 
            this.CusFBlistBox.FormattingEnabled = true;
            this.CusFBlistBox.ItemHeight = 16;
            this.CusFBlistBox.Location = new System.Drawing.Point(394, 143);
            this.CusFBlistBox.Name = "CusFBlistBox";
            this.CusFBlistBox.Size = new System.Drawing.Size(228, 260);
            this.CusFBlistBox.TabIndex = 2;
            // 
            // CusFBContentLB
            // 
            this.CusFBContentLB.FormattingEnabled = true;
            this.CusFBContentLB.ItemHeight = 16;
            this.CusFBContentLB.Location = new System.Drawing.Point(73, 255);
            this.CusFBContentLB.Name = "CusFBContentLB";
            this.CusFBContentLB.Size = new System.Drawing.Size(263, 148);
            this.CusFBContentLB.TabIndex = 3;
            // 
            // CusFBClearBtn
            // 
            this.CusFBClearBtn.Location = new System.Drawing.Point(531, 439);
            this.CusFBClearBtn.Name = "CusFBClearBtn";
            this.CusFBClearBtn.Size = new System.Drawing.Size(82, 30);
            this.CusFBClearBtn.TabIndex = 4;
            this.CusFBClearBtn.Text = "CLEAR";
            this.CusFBClearBtn.UseVisualStyleBackColor = true;
            // 
            // Admin_cus_FB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.Controls.Add(this.CusFBClearBtn);
            this.Controls.Add(this.CusFBContentLB);
            this.Controls.Add(this.CusFBlistBox);
            this.Controls.Add(this.CusDetailsLB);
            this.Controls.Add(this.label1);
            this.Name = "Admin_cus_FB";
            this.Size = new System.Drawing.Size(726, 524);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.ListBox CusDetailsLB;
        private System.Windows.Forms.ListBox CusFBlistBox;
        private System.Windows.Forms.ListBox CusFBContentLB;
        private System.Windows.Forms.Button CusFBClearBtn;
    }
}
