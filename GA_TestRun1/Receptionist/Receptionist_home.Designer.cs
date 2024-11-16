using System;

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
            this.logobox = new System.Windows.Forms.PictureBox();
            this.rcp_srcInvbtn = new System.Windows.Forms.Button();
            this.rcp_CheckinOutbtn = new System.Windows.Forms.Button();
            this.rcp_manageAppbtn = new System.Windows.Forms.Button();
            this.rcp_homePanel = new System.Windows.Forms.Panel();
            this.rcp_calandar = new System.Windows.Forms.MonthCalendar();
            this.Rcp_Profpanel = new System.Windows.Forms.Panel();
            this.Rcp_rolelbl = new System.Windows.Forms.Label();
            this.rcp_homeRoles_lbl = new System.Windows.Forms.Label();
            this.Rcp_contactNumlbl = new System.Windows.Forms.Label();
            this.rcp_homeContactlbl = new System.Windows.Forms.Label();
            this.Rcp_usernamelbl = new System.Windows.Forms.Label();
            this.rcp_homeUserlbl = new System.Windows.Forms.Label();
            this.rcp_profieBox_btn = new System.Windows.Forms.Button();
            this.prof_lbl = new System.Windows.Forms.Label();
            this.nav_Bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logobox)).BeginInit();
            this.Rcp_Profpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Rcp_Add
            // 
            this.Rcp_Add.FlatAppearance.BorderSize = 0;
            this.Rcp_Add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.Rcp_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rcp_Add.Location = new System.Drawing.Point(12, 162);
            this.Rcp_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.Rcp_home_lbl.Location = new System.Drawing.Point(149, 17);
            this.Rcp_home_lbl.Name = "Rcp_home_lbl";
            this.Rcp_home_lbl.Size = new System.Drawing.Size(63, 42);
            this.Rcp_home_lbl.TabIndex = 1;
            this.Rcp_home_lbl.Text = "jjj";
            this.Rcp_home_lbl.Click += new System.EventHandler(this.Rcp_home_lbl_Click);
            // 
            // Rcp_home_delCus
            // 
            this.Rcp_home_delCus.FlatAppearance.BorderSize = 0;
            this.Rcp_home_delCus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.Rcp_home_delCus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rcp_home_delCus.Location = new System.Drawing.Point(12, 106);
            this.Rcp_home_delCus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Rcp_home_delCus.Name = "Rcp_home_delCus";
            this.Rcp_home_delCus.Size = new System.Drawing.Size(96, 50);
            this.Rcp_home_delCus.TabIndex = 2;
            this.Rcp_home_delCus.Text = "Delete Customer";
            this.Rcp_home_delCus.UseVisualStyleBackColor = true;
            this.Rcp_home_delCus.Click += new System.EventHandler(this.Rcp_home_delCus_Click);
            this.Rcp_home_delCus.MouseLeave += new System.EventHandler(this.buttonmove);
            this.Rcp_home_delCus.MouseHover += new System.EventHandler(this.buttonhover);
            // 
            // Rcp_home_signOut
            // 
            this.Rcp_home_signOut.FlatAppearance.BorderSize = 0;
            this.Rcp_home_signOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.Rcp_home_signOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rcp_home_signOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rcp_home_signOut.ForeColor = System.Drawing.Color.Red;
            this.Rcp_home_signOut.Location = new System.Drawing.Point(12, 442);
            this.Rcp_home_signOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Rcp_home_signOut.Name = "Rcp_home_signOut";
            this.Rcp_home_signOut.Size = new System.Drawing.Size(96, 50);
            this.Rcp_home_signOut.TabIndex = 3;
            this.Rcp_home_signOut.Text = "Sign Out";
            this.Rcp_home_signOut.UseVisualStyleBackColor = true;
            this.Rcp_home_signOut.Click += new System.EventHandler(this.Rcp_home_signOut_Click);
            // 
            // rcp_updateProf_btn
            // 
            this.rcp_updateProf_btn.FlatAppearance.BorderSize = 0;
            this.rcp_updateProf_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.rcp_updateProf_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rcp_updateProf_btn.Location = new System.Drawing.Point(12, 218);
            this.rcp_updateProf_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.nav_Bar.Controls.Add(this.logobox);
            this.nav_Bar.Controls.Add(this.Rcp_home_signOut);
            this.nav_Bar.Controls.Add(this.Rcp_home_delCus);
            this.nav_Bar.Controls.Add(this.Rcp_Add);
            this.nav_Bar.Controls.Add(this.rcp_srcInvbtn);
            this.nav_Bar.Controls.Add(this.rcp_CheckinOutbtn);
            this.nav_Bar.Controls.Add(this.rcp_manageAppbtn);
            this.nav_Bar.Controls.Add(this.rcp_updateProf_btn);
            this.nav_Bar.Dock = System.Windows.Forms.DockStyle.Left;
            this.nav_Bar.Location = new System.Drawing.Point(0, 0);
            this.nav_Bar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nav_Bar.Name = "nav_Bar";
            this.nav_Bar.Size = new System.Drawing.Size(131, 505);
            this.nav_Bar.TabIndex = 5;
            // 
            // logobox
            // 
            this.logobox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logobox.Image = global::GA_TestRun1.Properties.Resources.logo__4_;
            this.logobox.Location = new System.Drawing.Point(12, 2);
            this.logobox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logobox.Name = "logobox";
            this.logobox.Size = new System.Drawing.Size(100, 97);
            this.logobox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logobox.TabIndex = 5;
            this.logobox.TabStop = false;
            this.logobox.Click += new System.EventHandler(this.logobox_Click);
            // 
            // rcp_srcInvbtn
            // 
            this.rcp_srcInvbtn.FlatAppearance.BorderSize = 0;
            this.rcp_srcInvbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.rcp_srcInvbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rcp_srcInvbtn.Location = new System.Drawing.Point(12, 386);
            this.rcp_srcInvbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rcp_srcInvbtn.Name = "rcp_srcInvbtn";
            this.rcp_srcInvbtn.Size = new System.Drawing.Size(96, 50);
            this.rcp_srcInvbtn.TabIndex = 4;
            this.rcp_srcInvbtn.Text = "Manage Request";
            this.rcp_srcInvbtn.UseVisualStyleBackColor = true;
            this.rcp_srcInvbtn.Click += new System.EventHandler(this.rcp_srcInvbtn_btn_Click);
            // 
            // rcp_CheckinOutbtn
            // 
            this.rcp_CheckinOutbtn.FlatAppearance.BorderSize = 0;
            this.rcp_CheckinOutbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.rcp_CheckinOutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rcp_CheckinOutbtn.Location = new System.Drawing.Point(12, 330);
            this.rcp_CheckinOutbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rcp_CheckinOutbtn.Name = "rcp_CheckinOutbtn";
            this.rcp_CheckinOutbtn.Size = new System.Drawing.Size(96, 50);
            this.rcp_CheckinOutbtn.TabIndex = 4;
            this.rcp_CheckinOutbtn.Text = "Check In / Check Out ";
            this.rcp_CheckinOutbtn.UseVisualStyleBackColor = true;
            this.rcp_CheckinOutbtn.Click += new System.EventHandler(this.rcp_CheckinOutbtn_btn_Click);
            // 
            // rcp_manageAppbtn
            // 
            this.rcp_manageAppbtn.FlatAppearance.BorderSize = 0;
            this.rcp_manageAppbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.rcp_manageAppbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rcp_manageAppbtn.Location = new System.Drawing.Point(12, 274);
            this.rcp_manageAppbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rcp_manageAppbtn.Name = "rcp_manageAppbtn";
            this.rcp_manageAppbtn.Size = new System.Drawing.Size(96, 50);
            this.rcp_manageAppbtn.TabIndex = 4;
            this.rcp_manageAppbtn.Text = "Manage Appointment";
            this.rcp_manageAppbtn.UseVisualStyleBackColor = true;
            this.rcp_manageAppbtn.Click += new System.EventHandler(this.rcp_manageAppbtn_btn_Click);
            // 
            // rcp_homePanel
            // 
            this.rcp_homePanel.Location = new System.Drawing.Point(133, 2);
            this.rcp_homePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rcp_homePanel.Name = "rcp_homePanel";
            this.rcp_homePanel.Size = new System.Drawing.Size(787, 501);
            this.rcp_homePanel.TabIndex = 6;
            this.rcp_homePanel.Visible = false;
            this.rcp_homePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // rcp_calandar
            // 
            this.rcp_calandar.BackColor = System.Drawing.SystemColors.Menu;
            this.rcp_calandar.Location = new System.Drawing.Point(137, 270);
            this.rcp_calandar.Name = "rcp_calandar";
            this.rcp_calandar.TabIndex = 4;
            // 
            // Rcp_Profpanel
            // 
            this.Rcp_Profpanel.Controls.Add(this.Rcp_rolelbl);
            this.Rcp_Profpanel.Controls.Add(this.rcp_homeRoles_lbl);
            this.Rcp_Profpanel.Controls.Add(this.Rcp_contactNumlbl);
            this.Rcp_Profpanel.Controls.Add(this.rcp_homeContactlbl);
            this.Rcp_Profpanel.Controls.Add(this.Rcp_usernamelbl);
            this.Rcp_Profpanel.Controls.Add(this.rcp_homeUserlbl);
            this.Rcp_Profpanel.Controls.Add(this.rcp_profieBox_btn);
            this.Rcp_Profpanel.Controls.Add(this.prof_lbl);
            this.Rcp_Profpanel.Location = new System.Drawing.Point(529, 0);
            this.Rcp_Profpanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Rcp_Profpanel.Name = "Rcp_Profpanel";
            this.Rcp_Profpanel.Size = new System.Drawing.Size(391, 498);
            this.Rcp_Profpanel.TabIndex = 3;
            // 
            // Rcp_rolelbl
            // 
            this.Rcp_rolelbl.AutoSize = true;
            this.Rcp_rolelbl.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rcp_rolelbl.Location = new System.Drawing.Point(277, 254);
            this.Rcp_rolelbl.Name = "Rcp_rolelbl";
            this.Rcp_rolelbl.Size = new System.Drawing.Size(56, 23);
            this.Rcp_rolelbl.TabIndex = 8;
            this.Rcp_rolelbl.Text = "label1";
            this.Rcp_rolelbl.Click += new System.EventHandler(this.Rcp_rolelbl_Click);
            // 
            // rcp_homeRoles_lbl
            // 
            this.rcp_homeRoles_lbl.AutoSize = true;
            this.rcp_homeRoles_lbl.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rcp_homeRoles_lbl.Location = new System.Drawing.Point(29, 254);
            this.rcp_homeRoles_lbl.Name = "rcp_homeRoles_lbl";
            this.rcp_homeRoles_lbl.Size = new System.Drawing.Size(115, 23);
            this.rcp_homeRoles_lbl.TabIndex = 8;
            this.rcp_homeRoles_lbl.Text = "Current Role: ";
            // 
            // Rcp_contactNumlbl
            // 
            this.Rcp_contactNumlbl.AutoSize = true;
            this.Rcp_contactNumlbl.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rcp_contactNumlbl.Location = new System.Drawing.Point(277, 199);
            this.Rcp_contactNumlbl.Name = "Rcp_contactNumlbl";
            this.Rcp_contactNumlbl.Size = new System.Drawing.Size(56, 23);
            this.Rcp_contactNumlbl.TabIndex = 8;
            this.Rcp_contactNumlbl.Text = "label1";
            this.Rcp_contactNumlbl.Click += new System.EventHandler(this.Rcp_contactNumlbl_Click);
            // 
            // rcp_homeContactlbl
            // 
            this.rcp_homeContactlbl.AutoSize = true;
            this.rcp_homeContactlbl.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rcp_homeContactlbl.Location = new System.Drawing.Point(29, 199);
            this.rcp_homeContactlbl.Name = "rcp_homeContactlbl";
            this.rcp_homeContactlbl.Size = new System.Drawing.Size(146, 23);
            this.rcp_homeContactlbl.TabIndex = 8;
            this.rcp_homeContactlbl.Text = "Contact Number: ";
            // 
            // Rcp_usernamelbl
            // 
            this.Rcp_usernamelbl.AutoSize = true;
            this.Rcp_usernamelbl.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rcp_usernamelbl.Location = new System.Drawing.Point(277, 140);
            this.Rcp_usernamelbl.Name = "Rcp_usernamelbl";
            this.Rcp_usernamelbl.Size = new System.Drawing.Size(56, 23);
            this.Rcp_usernamelbl.TabIndex = 8;
            this.Rcp_usernamelbl.Text = "label1";
            this.Rcp_usernamelbl.Click += new System.EventHandler(this.Rcp_usernamelbl_Click);
            // 
            // rcp_homeUserlbl
            // 
            this.rcp_homeUserlbl.AutoSize = true;
            this.rcp_homeUserlbl.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rcp_homeUserlbl.Location = new System.Drawing.Point(29, 140);
            this.rcp_homeUserlbl.Name = "rcp_homeUserlbl";
            this.rcp_homeUserlbl.Size = new System.Drawing.Size(96, 23);
            this.rcp_homeUserlbl.TabIndex = 8;
            this.rcp_homeUserlbl.Text = "Username: ";
            // 
            // rcp_profieBox_btn
            // 
            this.rcp_profieBox_btn.Location = new System.Drawing.Point(29, 441);
            this.rcp_profieBox_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rcp_profieBox_btn.Name = "rcp_profieBox_btn";
            this.rcp_profieBox_btn.Size = new System.Drawing.Size(87, 41);
            this.rcp_profieBox_btn.TabIndex = 7;
            this.rcp_profieBox_btn.Text = "Refresh";
            this.rcp_profieBox_btn.UseVisualStyleBackColor = true;
            this.rcp_profieBox_btn.Click += new System.EventHandler(this.rcp_profieBox_btn_Click);
            // 
            // prof_lbl
            // 
            this.prof_lbl.AutoSize = true;
            this.prof_lbl.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prof_lbl.Location = new System.Drawing.Point(4, 9);
            this.prof_lbl.Name = "prof_lbl";
            this.prof_lbl.Size = new System.Drawing.Size(202, 40);
            this.prof_lbl.TabIndex = 2;
            this.prof_lbl.Text = "Your Profile";
            // 
            // Receptionist_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 505);
            this.Controls.Add(this.rcp_homePanel);
            this.Controls.Add(this.rcp_calandar);
            this.Controls.Add(this.nav_Bar);
            this.Controls.Add(this.Rcp_Profpanel);
            this.Controls.Add(this.Rcp_home_lbl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Receptionist_home";
            this.Text = "Receptionist Home";
            this.Load += new System.EventHandler(this.Receptionist_home_Load);
            this.nav_Bar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logobox)).EndInit();
            this.Rcp_Profpanel.ResumeLayout(false);
            this.Rcp_Profpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        





        #endregion

        private System.Windows.Forms.Button Rcp_Add;
        private System.Windows.Forms.Label Rcp_home_lbl;
        private System.Windows.Forms.Button Rcp_home_delCus;
        private System.Windows.Forms.Button Rcp_home_signOut;
        private System.Windows.Forms.Button rcp_updateProf_btn;
        private System.Windows.Forms.Panel nav_Bar;
        private System.Windows.Forms.Panel rcp_homePanel;
        private System.Windows.Forms.Panel Rcp_Profpanel;
        private System.Windows.Forms.Label prof_lbl;
        private System.Windows.Forms.MonthCalendar rcp_calandar;
        private System.Windows.Forms.Button rcp_srcInvbtn;
        private System.Windows.Forms.Button rcp_CheckinOutbtn;
        private System.Windows.Forms.Button rcp_manageAppbtn;
        private System.Windows.Forms.Button rcp_profieBox_btn;
        private System.Windows.Forms.Label Rcp_rolelbl;
        private System.Windows.Forms.Label rcp_homeRoles_lbl;
        private System.Windows.Forms.Label Rcp_contactNumlbl;
        private System.Windows.Forms.Label rcp_homeContactlbl;
        private System.Windows.Forms.Label Rcp_usernamelbl;
        private System.Windows.Forms.Label rcp_homeUserlbl;
        private System.Windows.Forms.PictureBox logobox;
    }
}