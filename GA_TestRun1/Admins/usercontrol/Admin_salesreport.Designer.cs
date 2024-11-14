namespace GA_TestRun1.Admins
{
    partial class Admin_salesreport
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
            this.SP_label = new System.Windows.Forms.Label();
            this.SR_Month_CB = new System.Windows.Forms.ComboBox();
            this.SR_Generate_Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SP_label
            // 
            this.SP_label.AutoSize = true;
            this.SP_label.Font = new System.Drawing.Font("Monotype Corsiva", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SP_label.Location = new System.Drawing.Point(159, 42);
            this.SP_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SP_label.Name = "SP_label";
            this.SP_label.Size = new System.Drawing.Size(223, 37);
            this.SP_label.TabIndex = 0;
            this.SP_label.Text = "SALES REPORT";
            // 
            // SR_Month_CB
            // 
            this.SR_Month_CB.FormattingEnabled = true;
            this.SR_Month_CB.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.SR_Month_CB.Location = new System.Drawing.Point(152, 198);
            this.SR_Month_CB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SR_Month_CB.Name = "SR_Month_CB";
            this.SR_Month_CB.Size = new System.Drawing.Size(230, 21);
            this.SR_Month_CB.TabIndex = 1;
            this.SR_Month_CB.Text = "Month";
            this.SR_Month_CB.SelectedIndexChanged += new System.EventHandler(this.SR_Month_CB_SelectedIndexChanged);
            // 
            // SR_Generate_Btn
            // 
            this.SR_Generate_Btn.Location = new System.Drawing.Point(220, 285);
            this.SR_Generate_Btn.Name = "SR_Generate_Btn";
            this.SR_Generate_Btn.Size = new System.Drawing.Size(98, 36);
            this.SR_Generate_Btn.TabIndex = 9;
            this.SR_Generate_Btn.Text = "GENERATE";
            this.SR_Generate_Btn.UseVisualStyleBackColor = true;
            this.SR_Generate_Btn.Click += new System.EventHandler(this.SR_Generate_Btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Please Choose a month.";
            // 
            // Admin_salesreport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SR_Generate_Btn);
            this.Controls.Add(this.SR_Month_CB);
            this.Controls.Add(this.SP_label);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Admin_salesreport";
            this.Size = new System.Drawing.Size(545, 426);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SP_label;
        private System.Windows.Forms.ComboBox SR_Month_CB;
        private System.Windows.Forms.Button SR_Generate_Btn;
        private System.Windows.Forms.Label label1;
    }
}
