namespace GA_TestRun1
{
    partial class Update_profile
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
            this.updateProf_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.updateProf_usern_txt = new System.Windows.Forms.TextBox();
            this.updateProf_pw_txt = new System.Windows.Forms.TextBox();
            this.updateProf_cpw_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.updateProf_btn = new System.Windows.Forms.Button();
            this.updateProf_showpw_checkb = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // updateProf_lbl
            // 
            this.updateProf_lbl.AutoSize = true;
            this.updateProf_lbl.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateProf_lbl.Location = new System.Drawing.Point(249, 43);
            this.updateProf_lbl.Name = "updateProf_lbl";
            this.updateProf_lbl.Size = new System.Drawing.Size(286, 42);
            this.updateProf_lbl.TabIndex = 0;
            this.updateProf_lbl.Text = "Update Profile";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "New Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "New Password: ";
            // 
            // updateProf_usern_txt
            // 
            this.updateProf_usern_txt.Location = new System.Drawing.Point(257, 134);
            this.updateProf_usern_txt.Name = "updateProf_usern_txt";
            this.updateProf_usern_txt.Size = new System.Drawing.Size(211, 22);
            this.updateProf_usern_txt.TabIndex = 3;
            this.updateProf_usern_txt.TextChanged += new System.EventHandler(this.updateProf_usern_txt_TextChanged);
            // 
            // updateProf_pw_txt
            // 
            this.updateProf_pw_txt.Location = new System.Drawing.Point(257, 218);
            this.updateProf_pw_txt.Name = "updateProf_pw_txt";
            this.updateProf_pw_txt.PasswordChar = '*';
            this.updateProf_pw_txt.Size = new System.Drawing.Size(211, 22);
            this.updateProf_pw_txt.TabIndex = 4;
            this.updateProf_pw_txt.TextChanged += new System.EventHandler(this.updateProf_pw_txt_TextChanged);
            // 
            // updateProf_cpw_txt
            // 
            this.updateProf_cpw_txt.Location = new System.Drawing.Point(257, 302);
            this.updateProf_cpw_txt.Name = "updateProf_cpw_txt";
            this.updateProf_cpw_txt.PasswordChar = '*';
            this.updateProf_cpw_txt.Size = new System.Drawing.Size(211, 22);
            this.updateProf_cpw_txt.TabIndex = 5;
            this.updateProf_cpw_txt.TextChanged += new System.EventHandler(this.updateProf_cpw_txt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Confirm Password: ";
            // 
            // updateProf_btn
            // 
            this.updateProf_btn.Location = new System.Drawing.Point(307, 368);
            this.updateProf_btn.Name = "updateProf_btn";
            this.updateProf_btn.Size = new System.Drawing.Size(106, 39);
            this.updateProf_btn.TabIndex = 7;
            this.updateProf_btn.Text = "Update";
            this.updateProf_btn.UseVisualStyleBackColor = true;
            this.updateProf_btn.Click += new System.EventHandler(this.updateProf_btn_Click);
            // 
            // updateProf_showpw_checkb
            // 
            this.updateProf_showpw_checkb.AutoSize = true;
            this.updateProf_showpw_checkb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateProf_showpw_checkb.Location = new System.Drawing.Point(578, 303);
            this.updateProf_showpw_checkb.Name = "updateProf_showpw_checkb";
            this.updateProf_showpw_checkb.Size = new System.Drawing.Size(151, 24);
            this.updateProf_showpw_checkb.TabIndex = 8;
            this.updateProf_showpw_checkb.Text = "Show Password";
            this.updateProf_showpw_checkb.UseVisualStyleBackColor = true;
            this.updateProf_showpw_checkb.CheckedChanged += new System.EventHandler(this.updateProf_showpw_checkb_CheckedChanged);
            // 
            // Update_profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.updateProf_showpw_checkb);
            this.Controls.Add(this.updateProf_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.updateProf_cpw_txt);
            this.Controls.Add(this.updateProf_pw_txt);
            this.Controls.Add(this.updateProf_usern_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updateProf_lbl);
            this.Name = "Update_profile";
            this.Text = "Update Profile";
            this.Load += new System.EventHandler(this.Update_profile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label updateProf_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox updateProf_usern_txt;
        private System.Windows.Forms.TextBox updateProf_pw_txt;
        private System.Windows.Forms.TextBox updateProf_cpw_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button updateProf_btn;
        private System.Windows.Forms.CheckBox updateProf_showpw_checkb;
    }
}