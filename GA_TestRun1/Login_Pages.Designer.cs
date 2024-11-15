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
            this.Lpages_showpw = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // L_pages_title
            // 
            this.L_pages_title.AutoSize = true;
            this.L_pages_title.Font = new System.Drawing.Font("Bauhaus 93", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_pages_title.Location = new System.Drawing.Point(112, 58);
            this.L_pages_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.L_pages_title.Name = "L_pages_title";
            this.L_pages_title.Size = new System.Drawing.Size(369, 39);
            this.L_pages_title.TabIndex = 0;
            this.L_pages_title.Text = "Welcome To CarCare";
            // 
            // Lpages_userlbl
            // 
            this.Lpages_userlbl.AutoSize = true;
            this.Lpages_userlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lpages_userlbl.Location = new System.Drawing.Point(182, 141);
            this.Lpages_userlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lpages_userlbl.Name = "Lpages_userlbl";
            this.Lpages_userlbl.Size = new System.Drawing.Size(73, 17);
            this.Lpages_userlbl.TabIndex = 1;
            this.Lpages_userlbl.Text = "Username";
            // 
            // Lpages_pwlbl
            // 
            this.Lpages_pwlbl.AutoSize = true;
            this.Lpages_pwlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lpages_pwlbl.Location = new System.Drawing.Point(182, 187);
            this.Lpages_pwlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lpages_pwlbl.Name = "Lpages_pwlbl";
            this.Lpages_pwlbl.Size = new System.Drawing.Size(69, 17);
            this.Lpages_pwlbl.TabIndex = 2;
            this.Lpages_pwlbl.Text = "Password";
            // 
            // L_username_txt
            // 
            this.L_username_txt.Location = new System.Drawing.Point(303, 141);
            this.L_username_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.L_username_txt.Name = "L_username_txt";
            this.L_username_txt.Size = new System.Drawing.Size(120, 20);
            this.L_username_txt.TabIndex = 3;
            this.L_username_txt.TextChanged += new System.EventHandler(this.L_username_txt_TextChanged);
            // 
            // L_pw_txt
            // 
            this.L_pw_txt.Location = new System.Drawing.Point(303, 186);
            this.L_pw_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.L_pw_txt.Name = "L_pw_txt";
            this.L_pw_txt.PasswordChar = '*';
            this.L_pw_txt.Size = new System.Drawing.Size(120, 20);
            this.L_pw_txt.TabIndex = 4;
            this.L_pw_txt.TextChanged += new System.EventHandler(this.L_pw_txt_TextChanged);
            // 
            // L_sigin_btn
            // 
            this.L_sigin_btn.Location = new System.Drawing.Point(251, 278);
            this.L_sigin_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.L_sigin_btn.Name = "L_sigin_btn";
            this.L_sigin_btn.Size = new System.Drawing.Size(80, 36);
            this.L_sigin_btn.TabIndex = 5;
            this.L_sigin_btn.Text = "Sign In";
            this.L_sigin_btn.UseVisualStyleBackColor = true;
            this.L_sigin_btn.Click += new System.EventHandler(this.L_sigin_btn_Click);
            // 
            // Lpages_showpw
            // 
            this.Lpages_showpw.AutoSize = true;
            this.Lpages_showpw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lpages_showpw.Location = new System.Drawing.Point(232, 253);
            this.Lpages_showpw.Margin = new System.Windows.Forms.Padding(2);
            this.Lpages_showpw.Name = "Lpages_showpw";
            this.Lpages_showpw.Size = new System.Drawing.Size(126, 21);
            this.Lpages_showpw.TabIndex = 9;
            this.Lpages_showpw.Text = "Show Password";
            this.Lpages_showpw.UseVisualStyleBackColor = true;
            this.Lpages_showpw.CheckedChanged += new System.EventHandler(this.Lpages_showpw_CheckedChanged);
            // 
            // Login_Pages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.Lpages_showpw);
            this.Controls.Add(this.L_sigin_btn);
            this.Controls.Add(this.L_pw_txt);
            this.Controls.Add(this.L_username_txt);
            this.Controls.Add(this.Lpages_pwlbl);
            this.Controls.Add(this.Lpages_userlbl);
            this.Controls.Add(this.L_pages_title);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Login_Pages";
            this.Text = "Login_Pages";
            this.Load += new System.EventHandler(this.Login_Pages_Load);
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
        private System.Windows.Forms.CheckBox Lpages_showpw;
    }
}