namespace GA_TestRun1.Receptionist
{
    partial class Receptionist_home
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
            this.Rcp_Add = new System.Windows.Forms.Button();
            this.Rcp_home_lbl = new System.Windows.Forms.Label();
            this.Rcp_home_delCus = new System.Windows.Forms.Button();
            this.Rcp_home_signOut = new System.Windows.Forms.Button();
            this.rcp_updateProf_btn = new System.Windows.Forms.Button();
            this.nav_Bar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nav_Bar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Rcp_Add
            // 
            this.Rcp_Add.Location = new System.Drawing.Point(12, 145);
            this.Rcp_Add.Name = "Rcp_Add";
            this.Rcp_Add.Size = new System.Drawing.Size(96, 50);
            this.Rcp_Add.TabIndex = 0;
            this.Rcp_Add.Text = "Add Customer";
            this.Rcp_Add.UseVisualStyleBackColor = true;
            this.Rcp_Add.Click += new System.EventHandler(this.Rcp_Add_Click);
            // 
            // Rcp_home_lbl
            // 
            this.Rcp_home_lbl.AutoSize = true;
            this.Rcp_home_lbl.BackColor = System.Drawing.SystemColors.Info;
            this.Rcp_home_lbl.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rcp_home_lbl.Location = new System.Drawing.Point(294, 22);
            this.Rcp_home_lbl.Name = "Rcp_home_lbl";
            this.Rcp_home_lbl.Size = new System.Drawing.Size(63, 42);
            this.Rcp_home_lbl.TabIndex = 1;
            this.Rcp_home_lbl.Text = "jjj";
            this.Rcp_home_lbl.Click += new System.EventHandler(this.Rcp_home_lbl_Click);
            // 
            // Rcp_home_delCus
            // 
            this.Rcp_home_delCus.Location = new System.Drawing.Point(12, 60);
            this.Rcp_home_delCus.Name = "Rcp_home_delCus";
            this.Rcp_home_delCus.Size = new System.Drawing.Size(96, 50);
            this.Rcp_home_delCus.TabIndex = 2;
            this.Rcp_home_delCus.Text = "Delete Customer";
            this.Rcp_home_delCus.UseVisualStyleBackColor = true;
            this.Rcp_home_delCus.Click += new System.EventHandler(this.Rcp_home_delCus_Click);
            // 
            // Rcp_home_signOut
            // 
            this.Rcp_home_signOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rcp_home_signOut.ForeColor = System.Drawing.Color.Red;
            this.Rcp_home_signOut.Location = new System.Drawing.Point(12, 388);
            this.Rcp_home_signOut.Name = "Rcp_home_signOut";
            this.Rcp_home_signOut.Size = new System.Drawing.Size(96, 50);
            this.Rcp_home_signOut.TabIndex = 3;
            this.Rcp_home_signOut.Text = "Sign Out";
            this.Rcp_home_signOut.UseVisualStyleBackColor = true;
            this.Rcp_home_signOut.Click += new System.EventHandler(this.Rcp_home_signOut_Click);
            // 
            // rcp_updateProf_btn
            // 
            this.rcp_updateProf_btn.Location = new System.Drawing.Point(12, 233);
            this.rcp_updateProf_btn.Name = "rcp_updateProf_btn";
            this.rcp_updateProf_btn.Size = new System.Drawing.Size(96, 50);
            this.rcp_updateProf_btn.TabIndex = 4;
            this.rcp_updateProf_btn.Text = "Update Profile";
            this.rcp_updateProf_btn.UseVisualStyleBackColor = true;
            this.rcp_updateProf_btn.Click += new System.EventHandler(this.rcp_updateProf_btn_Click);
            // 
            // nav_Bar
            // 
            this.nav_Bar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.nav_Bar.Controls.Add(this.Rcp_home_signOut);
            this.nav_Bar.Controls.Add(this.Rcp_home_delCus);
            this.nav_Bar.Controls.Add(this.Rcp_Add);
            this.nav_Bar.Controls.Add(this.rcp_updateProf_btn);
            this.nav_Bar.Dock = System.Windows.Forms.DockStyle.Left;
            this.nav_Bar.Location = new System.Drawing.Point(0, 0);
            this.nav_Bar.Name = "nav_Bar";
            this.nav_Bar.Size = new System.Drawing.Size(131, 504);
            this.nav_Bar.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Rcp_home_lbl);
            this.panel1.Location = new System.Drawing.Point(137, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 504);
            this.panel1.TabIndex = 6;
            // 
            // Receptionist_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 504);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nav_Bar);
            this.Name = "Receptionist_home";
            this.Text = "Receptionist Home";
            this.Load += new System.EventHandler(this.Receptionist_home_Load);
            this.nav_Bar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Rcp_Add;
        private System.Windows.Forms.Label Rcp_home_lbl;
        private System.Windows.Forms.Button Rcp_home_delCus;
        private System.Windows.Forms.Button Rcp_home_signOut;
        private System.Windows.Forms.Button rcp_updateProf_btn;
        private System.Windows.Forms.Panel nav_Bar;
        private System.Windows.Forms.Panel panel1;
    }
}