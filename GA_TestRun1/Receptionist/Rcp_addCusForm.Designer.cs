namespace GA_TestRun1.Receptionist
{
    partial class Rcp_addCusForm
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
            this.Sup_contNum_txt = new System.Windows.Forms.TextBox();
            this.Sup_contactNumlbl = new System.Windows.Forms.Label();
            this.Sup_Cbox_role = new System.Windows.Forms.ComboBox();
            this.Sup_btn = new System.Windows.Forms.Button();
            this.Sup_roleCbolbl = new System.Windows.Forms.Label();
            this.Sup_conpwlbl = new System.Windows.Forms.Label();
            this.Sup_Cpassword_txt = new System.Windows.Forms.TextBox();
            this.Sup_password_txt = new System.Windows.Forms.TextBox();
            this.Sup_username_txt = new System.Windows.Forms.TextBox();
            this.Sup_pwlbl = new System.Windows.Forms.Label();
            this.Sup_usernamelbl = new System.Windows.Forms.Label();
            this.Sup_title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Sup_contNum_txt
            // 
            this.Sup_contNum_txt.Location = new System.Drawing.Point(647, 135);
            this.Sup_contNum_txt.Name = "Sup_contNum_txt";
            this.Sup_contNum_txt.Size = new System.Drawing.Size(126, 22);
            this.Sup_contNum_txt.TabIndex = 36;
            this.Sup_contNum_txt.TextChanged += new System.EventHandler(this.Sup_contNum_txt_TextChanged);
            // 
            // Sup_contactNumlbl
            // 
            this.Sup_contactNumlbl.AutoSize = true;
            this.Sup_contactNumlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sup_contactNumlbl.Location = new System.Drawing.Point(491, 133);
            this.Sup_contactNumlbl.Name = "Sup_contactNumlbl";
            this.Sup_contactNumlbl.Size = new System.Drawing.Size(136, 20);
            this.Sup_contactNumlbl.TabIndex = 35;
            this.Sup_contactNumlbl.Text = "Contact Number:";
            // 
            // Sup_Cbox_role
            // 
            this.Sup_Cbox_role.Enabled = false;
            this.Sup_Cbox_role.FormattingEnabled = true;
            this.Sup_Cbox_role.Items.AddRange(new object[] {
            "Customer",
            "Receptionist",
            "Mechanic"});
            this.Sup_Cbox_role.Location = new System.Drawing.Point(291, 329);
            this.Sup_Cbox_role.Name = "Sup_Cbox_role";
            this.Sup_Cbox_role.Size = new System.Drawing.Size(182, 24);
            this.Sup_Cbox_role.TabIndex = 34;
            this.Sup_Cbox_role.SelectedIndexChanged += new System.EventHandler(this.Sup_Cbox_role_SelectedIndexChanged);
            // 
            // Sup_btn
            // 
            this.Sup_btn.Location = new System.Drawing.Point(334, 367);
            this.Sup_btn.Name = "Sup_btn";
            this.Sup_btn.Size = new System.Drawing.Size(84, 42);
            this.Sup_btn.TabIndex = 33;
            this.Sup_btn.Text = "Add";
            this.Sup_btn.UseVisualStyleBackColor = true;
            this.Sup_btn.Click += new System.EventHandler(this.Sup_btn_Click);
            // 
            // Sup_roleCbolbl
            // 
            this.Sup_roleCbolbl.AutoSize = true;
            this.Sup_roleCbolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sup_roleCbolbl.Location = new System.Drawing.Point(12, 329);
            this.Sup_roleCbolbl.Name = "Sup_roleCbolbl";
            this.Sup_roleCbolbl.Size = new System.Drawing.Size(203, 18);
            this.Sup_roleCbolbl.TabIndex = 25;
            this.Sup_roleCbolbl.Text = "Please Choose Your Role";
            // 
            // Sup_conpwlbl
            // 
            this.Sup_conpwlbl.AutoSize = true;
            this.Sup_conpwlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sup_conpwlbl.Location = new System.Drawing.Point(11, 269);
            this.Sup_conpwlbl.Name = "Sup_conpwlbl";
            this.Sup_conpwlbl.Size = new System.Drawing.Size(147, 20);
            this.Sup_conpwlbl.TabIndex = 32;
            this.Sup_conpwlbl.Text = "Confirm Password";
            // 
            // Sup_Cpassword_txt
            // 
            this.Sup_Cpassword_txt.Location = new System.Drawing.Point(291, 267);
            this.Sup_Cpassword_txt.Name = "Sup_Cpassword_txt";
            this.Sup_Cpassword_txt.Size = new System.Drawing.Size(182, 22);
            this.Sup_Cpassword_txt.TabIndex = 31;
            this.Sup_Cpassword_txt.TextChanged += new System.EventHandler(this.Sup_Cpassword_txt_TextChanged);
            // 
            // Sup_password_txt
            // 
            this.Sup_password_txt.Location = new System.Drawing.Point(291, 202);
            this.Sup_password_txt.Name = "Sup_password_txt";
            this.Sup_password_txt.Size = new System.Drawing.Size(182, 22);
            this.Sup_password_txt.TabIndex = 30;
            this.Sup_password_txt.TextChanged += new System.EventHandler(this.Sup_password_txt_TextChanged);
            // 
            // Sup_username_txt
            // 
            this.Sup_username_txt.Location = new System.Drawing.Point(291, 133);
            this.Sup_username_txt.Name = "Sup_username_txt";
            this.Sup_username_txt.Size = new System.Drawing.Size(182, 22);
            this.Sup_username_txt.TabIndex = 29;
            this.Sup_username_txt.TextChanged += new System.EventHandler(this.Sup_username_txt_TextChanged);
            // 
            // Sup_pwlbl
            // 
            this.Sup_pwlbl.AutoSize = true;
            this.Sup_pwlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sup_pwlbl.Location = new System.Drawing.Point(11, 202);
            this.Sup_pwlbl.Name = "Sup_pwlbl";
            this.Sup_pwlbl.Size = new System.Drawing.Size(93, 20);
            this.Sup_pwlbl.TabIndex = 28;
            this.Sup_pwlbl.Text = "Password: ";
            // 
            // Sup_usernamelbl
            // 
            this.Sup_usernamelbl.AutoSize = true;
            this.Sup_usernamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sup_usernamelbl.Location = new System.Drawing.Point(11, 135);
            this.Sup_usernamelbl.Name = "Sup_usernamelbl";
            this.Sup_usernamelbl.Size = new System.Drawing.Size(96, 20);
            this.Sup_usernamelbl.TabIndex = 27;
            this.Sup_usernamelbl.Text = "Username: ";
            // 
            // Sup_title
            // 
            this.Sup_title.AutoSize = true;
            this.Sup_title.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sup_title.Location = new System.Drawing.Point(186, 48);
            this.Sup_title.Name = "Sup_title";
            this.Sup_title.Size = new System.Drawing.Size(378, 42);
            this.Sup_title.TabIndex = 26;
            this.Sup_title.Text = "Add New Customer!";
            // 
            // Rcp_addCusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.Controls.Add(this.Sup_contNum_txt);
            this.Controls.Add(this.Sup_contactNumlbl);
            this.Controls.Add(this.Sup_Cbox_role);
            this.Controls.Add(this.Sup_btn);
            this.Controls.Add(this.Sup_roleCbolbl);
            this.Controls.Add(this.Sup_conpwlbl);
            this.Controls.Add(this.Sup_Cpassword_txt);
            this.Controls.Add(this.Sup_password_txt);
            this.Controls.Add(this.Sup_username_txt);
            this.Controls.Add(this.Sup_pwlbl);
            this.Controls.Add(this.Sup_usernamelbl);
            this.Controls.Add(this.Sup_title);
            this.Name = "Rcp_addCusForm";
            this.Size = new System.Drawing.Size(791, 504);
            this.Load += new System.EventHandler(this.Rcp_addCusForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Sup_contNum_txt;
        private System.Windows.Forms.Label Sup_contactNumlbl;
        private System.Windows.Forms.ComboBox Sup_Cbox_role;
        private System.Windows.Forms.Button Sup_btn;
        private System.Windows.Forms.Label Sup_roleCbolbl;
        private System.Windows.Forms.Label Sup_conpwlbl;
        private System.Windows.Forms.TextBox Sup_Cpassword_txt;
        private System.Windows.Forms.TextBox Sup_password_txt;
        private System.Windows.Forms.TextBox Sup_username_txt;
        private System.Windows.Forms.Label Sup_pwlbl;
        private System.Windows.Forms.Label Sup_usernamelbl;
        private System.Windows.Forms.Label Sup_title;
    }
}
