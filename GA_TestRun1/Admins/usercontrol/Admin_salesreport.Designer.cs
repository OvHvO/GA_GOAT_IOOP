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
            this.SR_GrossProfit_LB = new System.Windows.Forms.ListBox();
            this.SR_TotalExpenses_LB = new System.Windows.Forms.ListBox();
            this.SR_NetProfit_TB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SR_totalGrossProfit_TB = new System.Windows.Forms.TextBox();
            this.SR_TotalExpenses_TB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SP_label
            // 
            this.SP_label.AutoSize = true;
            this.SP_label.Font = new System.Drawing.Font("Monotype Corsiva", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SP_label.Location = new System.Drawing.Point(239, 65);
            this.SP_label.Name = "SP_label";
            this.SP_label.Size = new System.Drawing.Size(316, 53);
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
            this.SR_Month_CB.Location = new System.Drawing.Point(248, 156);
            this.SR_Month_CB.Name = "SR_Month_CB";
            this.SR_Month_CB.Size = new System.Drawing.Size(316, 28);
            this.SR_Month_CB.TabIndex = 1;
            this.SR_Month_CB.Text = "Month";
            this.SR_Month_CB.SelectedIndexChanged += new System.EventHandler(this.SR_Month_CB_SelectedIndexChanged);
            // 
            // SR_GrossProfit_LB
            // 
            this.SR_GrossProfit_LB.FormattingEnabled = true;
            this.SR_GrossProfit_LB.ItemHeight = 20;
            this.SR_GrossProfit_LB.Location = new System.Drawing.Point(248, 181);
            this.SR_GrossProfit_LB.Name = "SR_GrossProfit_LB";
            this.SR_GrossProfit_LB.Size = new System.Drawing.Size(316, 144);
            this.SR_GrossProfit_LB.TabIndex = 2;
            // 
            // SR_TotalExpenses_LB
            // 
            this.SR_TotalExpenses_LB.FormattingEnabled = true;
            this.SR_TotalExpenses_LB.ItemHeight = 20;
            this.SR_TotalExpenses_LB.Location = new System.Drawing.Point(248, 363);
            this.SR_TotalExpenses_LB.Name = "SR_TotalExpenses_LB";
            this.SR_TotalExpenses_LB.Size = new System.Drawing.Size(316, 144);
            this.SR_TotalExpenses_LB.TabIndex = 3;
            // 
            // SR_NetProfit_TB
            // 
            this.SR_NetProfit_TB.Location = new System.Drawing.Point(248, 545);
            this.SR_NetProfit_TB.Name = "SR_NetProfit_TB";
            this.SR_NetProfit_TB.ReadOnly = true;
            this.SR_NetProfit_TB.Size = new System.Drawing.Size(316, 26);
            this.SR_NetProfit_TB.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(349, 596);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 44);
            this.button1.TabIndex = 5;
            this.button1.Text = "!!!NOTICE!!!";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SR_totalGrossProfit_TB
            // 
            this.SR_totalGrossProfit_TB.Location = new System.Drawing.Point(248, 331);
            this.SR_totalGrossProfit_TB.Name = "SR_totalGrossProfit_TB";
            this.SR_totalGrossProfit_TB.ReadOnly = true;
            this.SR_totalGrossProfit_TB.Size = new System.Drawing.Size(316, 26);
            this.SR_totalGrossProfit_TB.TabIndex = 7;
            // 
            // SR_TotalExpenses_TB
            // 
            this.SR_TotalExpenses_TB.Location = new System.Drawing.Point(248, 513);
            this.SR_TotalExpenses_TB.Name = "SR_TotalExpenses_TB";
            this.SR_TotalExpenses_TB.ReadOnly = true;
            this.SR_TotalExpenses_TB.Size = new System.Drawing.Size(316, 26);
            this.SR_TotalExpenses_TB.TabIndex = 8;
            // 
            // Admin_salesreport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.Controls.Add(this.SR_TotalExpenses_TB);
            this.Controls.Add(this.SR_totalGrossProfit_TB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SR_NetProfit_TB);
            this.Controls.Add(this.SR_TotalExpenses_LB);
            this.Controls.Add(this.SR_GrossProfit_LB);
            this.Controls.Add(this.SR_Month_CB);
            this.Controls.Add(this.SP_label);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Admin_salesreport";
            this.Size = new System.Drawing.Size(817, 655);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SP_label;
        private System.Windows.Forms.ComboBox SR_Month_CB;
        private System.Windows.Forms.ListBox SR_GrossProfit_LB;
        private System.Windows.Forms.ListBox SR_TotalExpenses_LB;
        private System.Windows.Forms.TextBox SR_NetProfit_TB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox SR_totalGrossProfit_TB;
        private System.Windows.Forms.TextBox SR_TotalExpenses_TB;
    }
}
