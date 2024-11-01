namespace GA_TestRun1.Receptionist
{
    partial class Cus_deleteForm
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
            this.ref_Rcpbtn = new System.Windows.Forms.Button();
            this.Rcp_delCusProf_Gpbox = new System.Windows.Forms.GroupBox();
            this.Cus_detail_listb = new System.Windows.Forms.ListBox();
            this.Cus_del = new System.Windows.Forms.Button();
            this.rcp_delCusGpbox = new System.Windows.Forms.GroupBox();
            this.Cus_listBox = new System.Windows.Forms.ListBox();
            this.Rcp_delCus_lbltxt = new System.Windows.Forms.Label();
            this.Rcp_delCusProf_Gpbox.SuspendLayout();
            this.rcp_delCusGpbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ref_Rcpbtn
            // 
            this.ref_Rcpbtn.Location = new System.Drawing.Point(502, 379);
            this.ref_Rcpbtn.Name = "ref_Rcpbtn";
            this.ref_Rcpbtn.Size = new System.Drawing.Size(111, 49);
            this.ref_Rcpbtn.TabIndex = 14;
            this.ref_Rcpbtn.Text = "Refresh";
            this.ref_Rcpbtn.UseVisualStyleBackColor = true;
            this.ref_Rcpbtn.Click += new System.EventHandler(this.ref_Rcpbtn_Click);
            // 
            // Rcp_delCusProf_Gpbox
            // 
            this.Rcp_delCusProf_Gpbox.Controls.Add(this.Cus_detail_listb);
            this.Rcp_delCusProf_Gpbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rcp_delCusProf_Gpbox.Location = new System.Drawing.Point(338, 152);
            this.Rcp_delCusProf_Gpbox.Name = "Rcp_delCusProf_Gpbox";
            this.Rcp_delCusProf_Gpbox.Size = new System.Drawing.Size(310, 203);
            this.Rcp_delCusProf_Gpbox.TabIndex = 13;
            this.Rcp_delCusProf_Gpbox.TabStop = false;
            this.Rcp_delCusProf_Gpbox.Text = "Customer Profile(Name and Contact)";
            // 
            // Cus_detail_listb
            // 
            this.Cus_detail_listb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cus_detail_listb.FormattingEnabled = true;
            this.Cus_detail_listb.ItemHeight = 25;
            this.Cus_detail_listb.Location = new System.Drawing.Point(80, 40);
            this.Cus_detail_listb.Name = "Cus_detail_listb";
            this.Cus_detail_listb.ScrollAlwaysVisible = true;
            this.Cus_detail_listb.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.Cus_detail_listb.Size = new System.Drawing.Size(211, 129);
            this.Cus_detail_listb.TabIndex = 0;
            this.Cus_detail_listb.SelectedIndexChanged += new System.EventHandler(this.Cus_detail_listb_SelectedIndexChanged);
            // 
            // Cus_del
            // 
            this.Cus_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cus_del.ForeColor = System.Drawing.Color.Red;
            this.Cus_del.Location = new System.Drawing.Point(122, 371);
            this.Cus_del.Name = "Cus_del";
            this.Cus_del.Size = new System.Drawing.Size(136, 57);
            this.Cus_del.TabIndex = 12;
            this.Cus_del.Text = "Delete Customer";
            this.Cus_del.UseVisualStyleBackColor = true;
            this.Cus_del.Click += new System.EventHandler(this.Cus_del_Click);
            // 
            // rcp_delCusGpbox
            // 
            this.rcp_delCusGpbox.Controls.Add(this.Cus_listBox);
            this.rcp_delCusGpbox.Location = new System.Drawing.Point(75, 152);
            this.rcp_delCusGpbox.Name = "rcp_delCusGpbox";
            this.rcp_delCusGpbox.Size = new System.Drawing.Size(223, 203);
            this.rcp_delCusGpbox.TabIndex = 11;
            this.rcp_delCusGpbox.TabStop = false;
            this.rcp_delCusGpbox.Text = "Choose customer ";
            // 
            // Cus_listBox
            // 
            this.Cus_listBox.FormattingEnabled = true;
            this.Cus_listBox.ItemHeight = 16;
            this.Cus_listBox.Location = new System.Drawing.Point(19, 40);
            this.Cus_listBox.Name = "Cus_listBox";
            this.Cus_listBox.Size = new System.Drawing.Size(164, 132);
            this.Cus_listBox.TabIndex = 0;
            this.Cus_listBox.SelectedIndexChanged += new System.EventHandler(this.Cus_listBox_SelectedIndexChanged);
            // 
            // Rcp_delCus_lbltxt
            // 
            this.Rcp_delCus_lbltxt.AutoSize = true;
            this.Rcp_delCus_lbltxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rcp_delCus_lbltxt.Location = new System.Drawing.Point(234, 81);
            this.Rcp_delCus_lbltxt.Name = "Rcp_delCus_lbltxt";
            this.Rcp_delCus_lbltxt.Size = new System.Drawing.Size(218, 29);
            this.Rcp_delCus_lbltxt.TabIndex = 10;
            this.Rcp_delCus_lbltxt.Text = "Delete Customer";
            // 
            // Cus_deleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.Controls.Add(this.ref_Rcpbtn);
            this.Controls.Add(this.Rcp_delCusProf_Gpbox);
            this.Controls.Add(this.Cus_del);
            this.Controls.Add(this.rcp_delCusGpbox);
            this.Controls.Add(this.Rcp_delCus_lbltxt);
            this.Name = "Cus_deleteForm";
            this.Size = new System.Drawing.Size(791, 504);
            this.Load += new System.EventHandler(this.Cus_deleteForm_Load);
            this.Rcp_delCusProf_Gpbox.ResumeLayout(false);
            this.rcp_delCusGpbox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ref_Rcpbtn;
        private System.Windows.Forms.GroupBox Rcp_delCusProf_Gpbox;
        private System.Windows.Forms.ListBox Cus_detail_listb;
        private System.Windows.Forms.Button Cus_del;
        private System.Windows.Forms.GroupBox rcp_delCusGpbox;
        private System.Windows.Forms.ListBox Cus_listBox;
        private System.Windows.Forms.Label Rcp_delCus_lbltxt;
    }
}
