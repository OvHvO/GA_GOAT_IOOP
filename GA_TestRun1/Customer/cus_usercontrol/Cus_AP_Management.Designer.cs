namespace GA_TestRun1.Customer.cus_usercontrol
{
    partial class Cus_AP_Management
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
            this.CusAP_LB = new System.Windows.Forms.ListBox();
            this.cus_RshAP_Btn = new System.Windows.Forms.Button();
            this.cus_CancelAP_Btn = new System.Windows.Forms.Button();
            this.CusAPDtls_LB = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(670, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "APPOINMENT MANAGEMENT";
            // 
            // CusAP_LB
            // 
            this.CusAP_LB.FormattingEnabled = true;
            this.CusAP_LB.ItemHeight = 20;
            this.CusAP_LB.Location = new System.Drawing.Point(123, 224);
            this.CusAP_LB.Name = "CusAP_LB";
            this.CusAP_LB.Size = new System.Drawing.Size(265, 264);
            this.CusAP_LB.TabIndex = 1;
            this.CusAP_LB.SelectedIndexChanged += new System.EventHandler(this.CusAP_LB_SelectedIndexChanged);
            // 
            // cus_RshAP_Btn
            // 
            this.cus_RshAP_Btn.Location = new System.Drawing.Point(485, 454);
            this.cus_RshAP_Btn.Name = "cus_RshAP_Btn";
            this.cus_RshAP_Btn.Size = new System.Drawing.Size(140, 34);
            this.cus_RshAP_Btn.TabIndex = 2;
            this.cus_RshAP_Btn.Text = "RESCHEDULE";
            this.cus_RshAP_Btn.UseVisualStyleBackColor = true;
            this.cus_RshAP_Btn.Click += new System.EventHandler(this.Cus_RSH_Btn_Click);
            // 
            // cus_CancelAP_Btn
            // 
            this.cus_CancelAP_Btn.Location = new System.Drawing.Point(652, 455);
            this.cus_CancelAP_Btn.Name = "cus_CancelAP_Btn";
            this.cus_CancelAP_Btn.Size = new System.Drawing.Size(87, 33);
            this.cus_CancelAP_Btn.TabIndex = 3;
            this.cus_CancelAP_Btn.Text = "CANCEL";
            this.cus_CancelAP_Btn.UseVisualStyleBackColor = true;
            this.cus_CancelAP_Btn.Click += new System.EventHandler(this.cus_CancelAP_Btn_Click);
            // 
            // CusAPDtls_LB
            // 
            this.CusAPDtls_LB.FormattingEnabled = true;
            this.CusAPDtls_LB.ItemHeight = 20;
            this.CusAPDtls_LB.Location = new System.Drawing.Point(485, 224);
            this.CusAPDtls_LB.Name = "CusAPDtls_LB";
            this.CusAPDtls_LB.Size = new System.Drawing.Size(254, 204);
            this.CusAPDtls_LB.TabIndex = 4;
            // 
            // Cus_AP_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CusAPDtls_LB);
            this.Controls.Add(this.cus_CancelAP_Btn);
            this.Controls.Add(this.cus_RshAP_Btn);
            this.Controls.Add(this.CusAP_LB);
            this.Controls.Add(this.label1);
            this.Name = "Cus_AP_Management";
            this.Size = new System.Drawing.Size(880, 660);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox CusAP_LB;
        private System.Windows.Forms.Button cus_RshAP_Btn;
        private System.Windows.Forms.Button cus_CancelAP_Btn;
        private System.Windows.Forms.ListBox CusAPDtls_LB;
    }
}
