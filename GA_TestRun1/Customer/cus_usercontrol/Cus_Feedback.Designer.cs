namespace GA_TestRun1.Customer.cus_usercontrol
{
    partial class Cus_Feedback
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
            this.ServiceAP_LB = new System.Windows.Forms.ListBox();
            this.Cus_FeedBack_TB = new System.Windows.Forms.TextBox();
            this.ServiceAPDtls_LB = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "FEEDBACK";
            // 
            // ServiceAP_LB
            // 
            this.ServiceAP_LB.FormattingEnabled = true;
            this.ServiceAP_LB.ItemHeight = 20;
            this.ServiceAP_LB.Location = new System.Drawing.Point(151, 189);
            this.ServiceAP_LB.Name = "ServiceAP_LB";
            this.ServiceAP_LB.Size = new System.Drawing.Size(226, 304);
            this.ServiceAP_LB.TabIndex = 1;
            this.ServiceAP_LB.SelectedIndexChanged += new System.EventHandler(this.ServiceAP_LB_SelectedIndexChanged);
            // 
            // Cus_FeedBack_TB
            // 
            this.Cus_FeedBack_TB.Location = new System.Drawing.Point(494, 338);
            this.Cus_FeedBack_TB.Multiline = true;
            this.Cus_FeedBack_TB.Name = "Cus_FeedBack_TB";
            this.Cus_FeedBack_TB.Size = new System.Drawing.Size(242, 155);
            this.Cus_FeedBack_TB.TabIndex = 2;
            // 
            // ServiceAPDtls_LB
            // 
            this.ServiceAPDtls_LB.FormattingEnabled = true;
            this.ServiceAPDtls_LB.ItemHeight = 20;
            this.ServiceAPDtls_LB.Location = new System.Drawing.Point(494, 189);
            this.ServiceAPDtls_LB.Name = "ServiceAPDtls_LB";
            this.ServiceAPDtls_LB.Size = new System.Drawing.Size(242, 104);
            this.ServiceAPDtls_LB.TabIndex = 3;
            // 
            // Cus_Feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ServiceAPDtls_LB);
            this.Controls.Add(this.Cus_FeedBack_TB);
            this.Controls.Add(this.ServiceAP_LB);
            this.Controls.Add(this.label1);
            this.Name = "Cus_Feedback";
            this.Size = new System.Drawing.Size(880, 660);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ServiceAP_LB;
        private System.Windows.Forms.TextBox Cus_FeedBack_TB;
        private System.Windows.Forms.ListBox ServiceAPDtls_LB;
    }
}
