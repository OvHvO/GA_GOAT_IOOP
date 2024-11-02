namespace GA_TestRun1.Admins
{
    partial class Admin_part
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
            this.PartManagement = new System.Windows.Forms.Label();
            this.PartListBox = new System.Windows.Forms.ListBox();
            this.PartIDTB = new System.Windows.Forms.TextBox();
            this.PartQuantityTB = new System.Windows.Forms.TextBox();
            this.PartNameTB = new System.Windows.Forms.TextBox();
            this.PartPriceTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PartManagement
            // 
            this.PartManagement.AutoSize = true;
            this.PartManagement.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartManagement.Location = new System.Drawing.Point(123, 48);
            this.PartManagement.Name = "PartManagement";
            this.PartManagement.Size = new System.Drawing.Size(266, 33);
            this.PartManagement.TabIndex = 0;
            this.PartManagement.Text = "PART MANAGEMENT";
            // 
            // PartListBox
            // 
            this.PartListBox.FormattingEnabled = true;
            this.PartListBox.Location = new System.Drawing.Point(188, 96);
            this.PartListBox.Name = "PartListBox";
            this.PartListBox.Size = new System.Drawing.Size(147, 134);
            this.PartListBox.TabIndex = 7;
            this.PartListBox.SelectedIndexChanged += new System.EventHandler(this.PartListBox_SelectedIndexChanged);
            // 
            // PartIDTB
            // 
            this.PartIDTB.Location = new System.Drawing.Point(91, 271);
            this.PartIDTB.Name = "PartIDTB";
            this.PartIDTB.Size = new System.Drawing.Size(100, 20);
            this.PartIDTB.TabIndex = 8;
            // 
            // PartQuantityTB
            // 
            this.PartQuantityTB.Location = new System.Drawing.Point(340, 271);
            this.PartQuantityTB.Name = "PartQuantityTB";
            this.PartQuantityTB.Size = new System.Drawing.Size(100, 20);
            this.PartQuantityTB.TabIndex = 10;
            // 
            // PartNameTB
            // 
            this.PartNameTB.Location = new System.Drawing.Point(91, 314);
            this.PartNameTB.Name = "PartNameTB";
            this.PartNameTB.Size = new System.Drawing.Size(100, 20);
            this.PartNameTB.TabIndex = 11;
            // 
            // PartPriceTB
            // 
            this.PartPriceTB.Location = new System.Drawing.Point(340, 314);
            this.PartPriceTB.Name = "PartPriceTB";
            this.PartPriceTB.Size = new System.Drawing.Size(100, 20);
            this.PartPriceTB.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(142, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(314, 379);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Admin_part
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PartPriceTB);
            this.Controls.Add(this.PartNameTB);
            this.Controls.Add(this.PartQuantityTB);
            this.Controls.Add(this.PartIDTB);
            this.Controls.Add(this.PartListBox);
            this.Controls.Add(this.PartManagement);
            this.Name = "Admin_part";
            this.Size = new System.Drawing.Size(544, 426);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PartManagement;
        private System.Windows.Forms.ListBox PartListBox;
        private System.Windows.Forms.TextBox PartIDTB;
        private System.Windows.Forms.TextBox PartQuantityTB;
        private System.Windows.Forms.TextBox PartNameTB;
        private System.Windows.Forms.TextBox PartPriceTB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
