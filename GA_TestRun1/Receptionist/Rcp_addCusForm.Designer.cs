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
            this.label6 = new System.Windows.Forms.Label();
            this.Sup_Cbox_role = new System.Windows.Forms.ComboBox();
            this.Sup_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Sup_Cpassword_txt = new System.Windows.Forms.TextBox();
            this.Sup_password_txt = new System.Windows.Forms.TextBox();
            this.Sup_username_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(491, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 20);
            this.label6.TabIndex = 35;
            this.label6.Text = "Contact Number:";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 18);
            this.label5.TabIndex = 25;
            this.label5.Text = "Please Choose Your Role";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Confirm Password";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Password: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Username: ";
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
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Sup_Cbox_role);
            this.Controls.Add(this.Sup_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Sup_Cpassword_txt);
            this.Controls.Add(this.Sup_password_txt);
            this.Controls.Add(this.Sup_username_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sup_title);
            this.Name = "Rcp_addCusForm";
            this.Size = new System.Drawing.Size(791, 504);
            this.Load += new System.EventHandler(this.Rcp_addCusForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Sup_contNum_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Sup_Cbox_role;
        private System.Windows.Forms.Button Sup_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Sup_Cpassword_txt;
        private System.Windows.Forms.TextBox Sup_password_txt;
        private System.Windows.Forms.TextBox Sup_username_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Sup_title;
    }
}
