namespace GA_TestRun1
{
    partial class Login_Pages
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
            this.L_pages_title = new System.Windows.Forms.Label();
            this.Lpages_userlbl = new System.Windows.Forms.Label();
            this.Lpages_pwlbl = new System.Windows.Forms.Label();
            this.L_username_txt = new System.Windows.Forms.TextBox();
            this.L_pw_txt = new System.Windows.Forms.TextBox();
            this.L_sigin_btn = new System.Windows.Forms.Button();
            this.L_signin_lbl = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // L_pages_title
            // 
            this.L_pages_title.AutoSize = true;
            this.L_pages_title.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_pages_title.Location = new System.Drawing.Point(209, 59);
            this.L_pages_title.Name = "L_pages_title";
            this.L_pages_title.Size = new System.Drawing.Size(333, 43);
            this.L_pages_title.TabIndex = 0;
            this.L_pages_title.Text = "Welcome To xxx";
            // 
            // Lpages_userlbl
            // 
            this.Lpages_userlbl.AutoSize = true;
            this.Lpages_userlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lpages_userlbl.Location = new System.Drawing.Point(24, 137);
            this.Lpages_userlbl.Name = "Lpages_userlbl";
            this.Lpages_userlbl.Size = new System.Drawing.Size(86, 20);
            this.Lpages_userlbl.TabIndex = 1;
            this.Lpages_userlbl.Text = "Username";
            // 
            // Lpages_pwlbl
            // 
            this.Lpages_pwlbl.AutoSize = true;
            this.Lpages_pwlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lpages_pwlbl.Location = new System.Drawing.Point(25, 193);
            this.Lpages_pwlbl.Name = "Lpages_pwlbl";
            this.Lpages_pwlbl.Size = new System.Drawing.Size(83, 20);
            this.Lpages_pwlbl.TabIndex = 2;
            this.Lpages_pwlbl.Text = "Password";
            // 
            // L_username_txt
            // 
            this.L_username_txt.Location = new System.Drawing.Point(266, 137);
            this.L_username_txt.Name = "L_username_txt";
            this.L_username_txt.Size = new System.Drawing.Size(158, 22);
            this.L_username_txt.TabIndex = 3;
            this.L_username_txt.TextChanged += new System.EventHandler(this.L_username_txt_TextChanged);
            // 
            // L_pw_txt
            // 
            this.L_pw_txt.Location = new System.Drawing.Point(266, 187);
            this.L_pw_txt.Name = "L_pw_txt";
            this.L_pw_txt.Size = new System.Drawing.Size(158, 22);
            this.L_pw_txt.TabIndex = 4;
            this.L_pw_txt.TextChanged += new System.EventHandler(this.L_pw_txt_TextChanged);
            // 
            // L_sigin_btn
            // 
            this.L_sigin_btn.Location = new System.Drawing.Point(307, 280);
            this.L_sigin_btn.Name = "L_sigin_btn";
            this.L_sigin_btn.Size = new System.Drawing.Size(107, 44);
            this.L_sigin_btn.TabIndex = 5;
            this.L_sigin_btn.Text = "Sign In";
            this.L_sigin_btn.UseVisualStyleBackColor = true;
            this.L_sigin_btn.Click += new System.EventHandler(this.L_sigin_btn_Click);
            // 
            // L_signin_lbl
            // 
            this.L_signin_lbl.AutoSize = true;
            this.L_signin_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_signin_lbl.Location = new System.Drawing.Point(416, 365);
            this.L_signin_lbl.Name = "L_signin_lbl";
            this.L_signin_lbl.Size = new System.Drawing.Size(82, 25);
            this.L_signin_lbl.TabIndex = 7;
            this.L_signin_lbl.TabStop = true;
            this.L_signin_lbl.Text = "Sign Up";
            this.L_signin_lbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "New For Here ?";
            // 
            // Login_Pages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.L_signin_lbl);
            this.Controls.Add(this.L_sigin_btn);
            this.Controls.Add(this.L_pw_txt);
            this.Controls.Add(this.L_username_txt);
            this.Controls.Add(this.Lpages_pwlbl);
            this.Controls.Add(this.Lpages_userlbl);
            this.Controls.Add(this.L_pages_title);
            this.Name = "Login_Pages";
            this.Text = "Login_Pages";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_pages_title;
        private System.Windows.Forms.Label Lpages_userlbl;
        private System.Windows.Forms.Label Lpages_pwlbl;
        private System.Windows.Forms.TextBox L_username_txt;
        private System.Windows.Forms.TextBox L_pw_txt;
        private System.Windows.Forms.Button L_sigin_btn;
        private System.Windows.Forms.LinkLabel L_signin_lbl;
        private System.Windows.Forms.Label label1;
    }
}