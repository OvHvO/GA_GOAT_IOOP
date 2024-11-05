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
            this.PartDeleteBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PartSaveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PartManagement
            // 
            this.PartManagement.AutoSize = true;
            this.PartManagement.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartManagement.Location = new System.Drawing.Point(231, 37);
            this.PartManagement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PartManagement.Name = "PartManagement";
            this.PartManagement.Size = new System.Drawing.Size(266, 33);
            this.PartManagement.TabIndex = 0;
            this.PartManagement.Text = "PART MANAGEMENT";
            // 
            // PartListBox
            // 
            this.PartListBox.FormattingEnabled = true;
            this.PartListBox.ItemHeight = 16;
            this.PartListBox.Location = new System.Drawing.Point(268, 101);
            this.PartListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PartListBox.Name = "PartListBox";
            this.PartListBox.Size = new System.Drawing.Size(195, 164);
            this.PartListBox.TabIndex = 7;
            this.PartListBox.SelectedIndexChanged += new System.EventHandler(this.PartListBox_SelectedIndexChanged);
            // 
            // PartIDTB
            // 
            this.PartIDTB.Location = new System.Drawing.Point(152, 364);
            this.PartIDTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PartIDTB.Name = "PartIDTB";
            this.PartIDTB.Size = new System.Drawing.Size(132, 22);
            this.PartIDTB.TabIndex = 8;
            // 
            // PartQuantityTB
            // 
            this.PartQuantityTB.Location = new System.Drawing.Point(509, 364);
            this.PartQuantityTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PartQuantityTB.Name = "PartQuantityTB";
            this.PartQuantityTB.Size = new System.Drawing.Size(132, 22);
            this.PartQuantityTB.TabIndex = 10;
            // 
            // PartNameTB
            // 
            this.PartNameTB.Location = new System.Drawing.Point(152, 431);
            this.PartNameTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PartNameTB.Name = "PartNameTB";
            this.PartNameTB.Size = new System.Drawing.Size(132, 22);
            this.PartNameTB.TabIndex = 11;
            // 
            // PartPriceTB
            // 
            this.PartPriceTB.Location = new System.Drawing.Point(509, 431);
            this.PartPriceTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PartPriceTB.Name = "PartPriceTB";
            this.PartPriceTB.Size = new System.Drawing.Size(132, 22);
            this.PartPriceTB.TabIndex = 12;
            // 
            // PartDeleteBtn
            // 
            this.PartDeleteBtn.Location = new System.Drawing.Point(427, 298);
            this.PartDeleteBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PartDeleteBtn.Name = "PartDeleteBtn";
            this.PartDeleteBtn.Size = new System.Drawing.Size(100, 28);
            this.PartDeleteBtn.TabIndex = 14;
            this.PartDeleteBtn.Text = "DELETE";
            this.PartDeleteBtn.UseVisualStyleBackColor = true;
            this.PartDeleteBtn.Click += new System.EventHandler(this.PartDeleteBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 364);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Part ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 434);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Part Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 368);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Qauntity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(423, 434);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Price";
            // 
            // PartSaveBtn
            // 
            this.PartSaveBtn.Location = new System.Drawing.Point(185, 298);
            this.PartSaveBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PartSaveBtn.Name = "PartSaveBtn";
            this.PartSaveBtn.Size = new System.Drawing.Size(100, 28);
            this.PartSaveBtn.TabIndex = 19;
            this.PartSaveBtn.Text = "SAVE";
            this.PartSaveBtn.UseVisualStyleBackColor = true;
            this.PartSaveBtn.Click += new System.EventHandler(this.PartSaveBtn_Click);
            // 
            // Admin_part
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.Controls.Add(this.PartSaveBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PartDeleteBtn);
            this.Controls.Add(this.PartPriceTB);
            this.Controls.Add(this.PartNameTB);
            this.Controls.Add(this.PartQuantityTB);
            this.Controls.Add(this.PartIDTB);
            this.Controls.Add(this.PartListBox);
            this.Controls.Add(this.PartManagement);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Admin_part";
            this.Size = new System.Drawing.Size(725, 492);
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
        private System.Windows.Forms.Button PartDeleteBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button PartSaveBtn;
    }
}
