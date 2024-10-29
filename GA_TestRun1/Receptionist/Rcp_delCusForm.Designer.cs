namespace GA_TestRun1.Receptionist
{
    partial class Rcp_delCusForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Cus_listBox = new System.Windows.Forms.ListBox();
            this.Cus_del = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Cus_detail_listb = new System.Windows.Forms.ListBox();
            this.ref_Rcpbtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Delete Customer";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Cus_listBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 249);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose customer ";
            // 
            // Cus_listBox
            // 
            this.Cus_listBox.FormattingEnabled = true;
            this.Cus_listBox.ItemHeight = 16;
            this.Cus_listBox.Location = new System.Drawing.Point(6, 21);
            this.Cus_listBox.Name = "Cus_listBox";
            this.Cus_listBox.Size = new System.Drawing.Size(275, 212);
            this.Cus_listBox.TabIndex = 0;
            this.Cus_listBox.SelectedIndexChanged += new System.EventHandler(this.Cus_listBox_SelectedIndexChanged);
            // 
            // Cus_del
            // 
            this.Cus_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cus_del.ForeColor = System.Drawing.Color.Red;
            this.Cus_del.Location = new System.Drawing.Point(18, 363);
            this.Cus_del.Name = "Cus_del";
            this.Cus_del.Size = new System.Drawing.Size(197, 52);
            this.Cus_del.TabIndex = 2;
            this.Cus_del.Text = "Delete Customer";
            this.Cus_del.UseVisualStyleBackColor = true;
            this.Cus_del.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Cus_detail_listb);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(396, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 249);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer Profile(Name and Contact)";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Cus_detail_listb
            // 
            this.Cus_detail_listb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cus_detail_listb.FormattingEnabled = true;
            this.Cus_detail_listb.ItemHeight = 25;
            this.Cus_detail_listb.Location = new System.Drawing.Point(50, 40);
            this.Cus_detail_listb.Name = "Cus_detail_listb";
            this.Cus_detail_listb.ScrollAlwaysVisible = true;
            this.Cus_detail_listb.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.Cus_detail_listb.Size = new System.Drawing.Size(245, 154);
            this.Cus_detail_listb.TabIndex = 0;
            // 
            // ref_Rcpbtn
            // 
            this.ref_Rcpbtn.Location = new System.Drawing.Point(320, 363);
            this.ref_Rcpbtn.Name = "ref_Rcpbtn";
            this.ref_Rcpbtn.Size = new System.Drawing.Size(173, 52);
            this.ref_Rcpbtn.TabIndex = 4;
            this.ref_Rcpbtn.Text = "Refresh";
            this.ref_Rcpbtn.UseVisualStyleBackColor = true;
            this.ref_Rcpbtn.Click += new System.EventHandler(this.ref_Rcpbtn_Click);
            // 
            // Rcp_delCusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ref_Rcpbtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Cus_del);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Rcp_delCusForm";
            this.Text = "Delete Customer";
            this.Load += new System.EventHandler(this.Rcp_delCusForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox Cus_listBox;
        private System.Windows.Forms.Button Cus_del;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox Cus_detail_listb;
        private System.Windows.Forms.Button ref_Rcpbtn;
    }
}