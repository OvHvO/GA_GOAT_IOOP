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
            this.rcp_homebtn = new System.Windows.Forms.Button();
            this.rcp_srcInvbtn = new System.Windows.Forms.Button();
            this.rcp_CheckinOutbtn = new System.Windows.Forms.Button();
            this.rcp_manageAppbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rcp_calandar = new System.Windows.Forms.MonthCalendar();
            this.Rcp_Profpanel = new System.Windows.Forms.Panel();
            this.Roletxt_lbl = new System.Windows.Forms.Label();
            this.Role_lbl = new System.Windows.Forms.Label();
            this.ContactNumtxt_lbl = new System.Windows.Forms.Label();
            this.ContactNum_lbl = new System.Windows.Forms.Label();
            this.nametxt_lbl = new System.Windows.Forms.Label();
            this.namelbl = new System.Windows.Forms.Label();
            this.prof_lbl = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.nav_Bar.SuspendLayout();
            this.Rcp_Profpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Rcp_Add
            // 
            this.Rcp_Add.Location = new System.Drawing.Point(12, 81);
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
            this.Rcp_home_delCus.Location = new System.Drawing.Point(12, 22);
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
            this.Rcp_home_signOut.Location = new System.Drawing.Point(12, 435);
            this.Rcp_home_signOut.Name = "Rcp_home_signOut";
            this.Rcp_home_signOut.Size = new System.Drawing.Size(96, 50);
            this.Rcp_home_signOut.TabIndex = 3;
            this.Rcp_home_signOut.Text = "Sign Out";
            this.Rcp_home_signOut.UseVisualStyleBackColor = true;
            this.Rcp_home_signOut.Click += new System.EventHandler(this.Rcp_home_signOut_Click);
            // 
            // rcp_updateProf_btn
            // 
            this.rcp_updateProf_btn.Location = new System.Drawing.Point(12, 140);
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
            this.nav_Bar.Controls.Add(this.rcp_homebtn);
            this.nav_Bar.Controls.Add(this.rcp_srcInvbtn);
            this.nav_Bar.Controls.Add(this.rcp_CheckinOutbtn);
            this.nav_Bar.Controls.Add(this.rcp_manageAppbtn);
            this.nav_Bar.Controls.Add(this.rcp_updateProf_btn);
            this.nav_Bar.Dock = System.Windows.Forms.DockStyle.Left;
            this.nav_Bar.Location = new System.Drawing.Point(0, 0);
            this.nav_Bar.Name = "nav_Bar";
            this.nav_Bar.Size = new System.Drawing.Size(131, 504);
            this.nav_Bar.TabIndex = 5;
            // 
            // rcp_homebtn
            // 
            this.rcp_homebtn.Location = new System.Drawing.Point(12, 376);
            this.rcp_homebtn.Name = "rcp_homebtn";
            this.rcp_homebtn.Size = new System.Drawing.Size(96, 50);
            this.rcp_homebtn.TabIndex = 4;
            this.rcp_homebtn.Text = "Main Menu";
            this.rcp_homebtn.UseVisualStyleBackColor = true;
            this.rcp_homebtn.Click += new System.EventHandler(this.rcp_homebtn_btn_Click);
            // 
            // rcp_srcInvbtn
            // 
            this.rcp_srcInvbtn.Location = new System.Drawing.Point(12, 317);
            this.rcp_srcInvbtn.Name = "rcp_srcInvbtn";
            this.rcp_srcInvbtn.Size = new System.Drawing.Size(96, 50);
            this.rcp_srcInvbtn.TabIndex = 4;
            this.rcp_srcInvbtn.Text = "Search Inventory";
            this.rcp_srcInvbtn.UseVisualStyleBackColor = true;
            this.rcp_srcInvbtn.Click += new System.EventHandler(this.rcp_srcInvbtn_btn_Click);
            // 
            // rcp_CheckinOutbtn
            // 
            this.rcp_CheckinOutbtn.Location = new System.Drawing.Point(12, 258);
            this.rcp_CheckinOutbtn.Name = "rcp_CheckinOutbtn";
            this.rcp_CheckinOutbtn.Size = new System.Drawing.Size(96, 50);
            this.rcp_CheckinOutbtn.TabIndex = 4;
            this.rcp_CheckinOutbtn.Text = "Check In / Check Out ";
            this.rcp_CheckinOutbtn.UseVisualStyleBackColor = true;
            this.rcp_CheckinOutbtn.Click += new System.EventHandler(this.rcp_CheckinOutbtn_btn_Click);
            // 
            // rcp_manageAppbtn
            // 
            this.rcp_manageAppbtn.Location = new System.Drawing.Point(12, 199);
            this.rcp_manageAppbtn.Name = "rcp_manageAppbtn";
            this.rcp_manageAppbtn.Size = new System.Drawing.Size(96, 50);
            this.rcp_manageAppbtn.TabIndex = 4;
            this.rcp_manageAppbtn.Text = "Manage Appointment";
            this.rcp_manageAppbtn.UseVisualStyleBackColor = true;
            this.rcp_manageAppbtn.Click += new System.EventHandler(this.rcp_manageAppbtn_btn_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(133, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 504);
            this.panel1.TabIndex = 6;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // rcp_calandar
            // 
            this.rcp_calandar.BackColor = System.Drawing.SystemColors.Menu;
            this.rcp_calandar.Location = new System.Drawing.Point(137, 269);
            this.rcp_calandar.Name = "rcp_calandar";
            this.rcp_calandar.TabIndex = 4;
            // 
            // Rcp_Profpanel
            // 
            this.Rcp_Profpanel.Controls.Add(this.listBox1);
            this.Rcp_Profpanel.Controls.Add(this.Roletxt_lbl);
            this.Rcp_Profpanel.Controls.Add(this.Role_lbl);
            this.Rcp_Profpanel.Controls.Add(this.ContactNum_lbl);
            this.Rcp_Profpanel.Controls.Add(this.namelbl);
            this.Rcp_Profpanel.Controls.Add(this.ContactNumtxt_lbl);
            this.Rcp_Profpanel.Controls.Add(this.prof_lbl);
            this.Rcp_Profpanel.Controls.Add(this.nametxt_lbl);
            this.Rcp_Profpanel.Location = new System.Drawing.Point(529, 0);
            this.Rcp_Profpanel.Name = "Rcp_Profpanel";
            this.Rcp_Profpanel.Size = new System.Drawing.Size(391, 498);
            this.Rcp_Profpanel.TabIndex = 3;
            // 
            // Roletxt_lbl
            // 
            this.Roletxt_lbl.AutoSize = true;
            this.Roletxt_lbl.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Roletxt_lbl.Location = new System.Drawing.Point(269, 263);
            this.Roletxt_lbl.Name = "Roletxt_lbl";
            this.Roletxt_lbl.Size = new System.Drawing.Size(50, 20);
            this.Roletxt_lbl.TabIndex = 5;
            this.Roletxt_lbl.Text = "label1";
            this.Roletxt_lbl.Click += new System.EventHandler(this.Roletxt_lbl_Click);
            // 
            // Role_lbl
            // 
            this.Role_lbl.AutoSize = true;
            this.Role_lbl.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Role_lbl.Location = new System.Drawing.Point(7, 263);
            this.Role_lbl.Name = "Role_lbl";
            this.Role_lbl.Size = new System.Drawing.Size(41, 20);
            this.Role_lbl.TabIndex = 5;
            this.Role_lbl.Text = "Role";
            // 
            // ContactNumtxt_lbl
            // 
            this.ContactNumtxt_lbl.AutoSize = true;
            this.ContactNumtxt_lbl.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactNumtxt_lbl.Location = new System.Drawing.Point(269, 208);
            this.ContactNumtxt_lbl.Name = "ContactNumtxt_lbl";
            this.ContactNumtxt_lbl.Size = new System.Drawing.Size(50, 20);
            this.ContactNumtxt_lbl.TabIndex = 4;
            this.ContactNumtxt_lbl.Text = "label3";
            this.ContactNumtxt_lbl.Click += new System.EventHandler(this.ContactNumtxt_lbl_Click);
            // 
            // ContactNum_lbl
            // 
            this.ContactNum_lbl.AutoSize = true;
            this.ContactNum_lbl.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactNum_lbl.Location = new System.Drawing.Point(7, 208);
            this.ContactNum_lbl.Name = "ContactNum_lbl";
            this.ContactNum_lbl.Size = new System.Drawing.Size(121, 20);
            this.ContactNum_lbl.TabIndex = 4;
            this.ContactNum_lbl.Text = "Contact Number";
            // 
            // nametxt_lbl
            // 
            this.nametxt_lbl.AutoSize = true;
            this.nametxt_lbl.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametxt_lbl.Location = new System.Drawing.Point(269, 159);
            this.nametxt_lbl.Name = "nametxt_lbl";
            this.nametxt_lbl.Size = new System.Drawing.Size(50, 20);
            this.nametxt_lbl.TabIndex = 3;
            this.nametxt_lbl.Text = "label2";
            this.nametxt_lbl.Click += new System.EventHandler(this.nametxt_lbl_Click);
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelbl.Location = new System.Drawing.Point(7, 159);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(49, 20);
            this.namelbl.TabIndex = 3;
            this.namelbl.Text = "Name";
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
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(24, 317);
            this.listBox1.Name = "listBox1";
            this.listBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox1.Size = new System.Drawing.Size(120, 148);
            this.listBox1.TabIndex = 6;
            // 
            // Receptionist_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 504);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rcp_calandar);
            this.Controls.Add(this.nav_Bar);
            this.Controls.Add(this.Rcp_Profpanel);
            this.Controls.Add(this.Rcp_home_lbl);
            this.Name = "Receptionist_home";
            this.Text = "Receptionist Home";
            this.Load += new System.EventHandler(this.Receptionist_home_Load);
            this.nav_Bar.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Rcp_Profpanel;
        private System.Windows.Forms.Label prof_lbl;
        private System.Windows.Forms.Label ContactNum_lbl;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.Label Roletxt_lbl;
        private System.Windows.Forms.Label Role_lbl;
        private System.Windows.Forms.Label ContactNumtxt_lbl;
        private System.Windows.Forms.Label nametxt_lbl;
        private System.Windows.Forms.MonthCalendar rcp_calandar;
        private System.Windows.Forms.Button rcp_homebtn;
        private System.Windows.Forms.Button rcp_srcInvbtn;
        private System.Windows.Forms.Button rcp_CheckinOutbtn;
        private System.Windows.Forms.Button rcp_manageAppbtn;
        private System.Windows.Forms.ListBox listBox1;
    }
}