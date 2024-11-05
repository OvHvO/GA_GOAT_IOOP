namespace GA_TestRun1.Admins
{
    partial class Admin_Interface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Interface));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AdminProfilelistBox = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.Font = new System.Drawing.Font("Monotype Corsiva", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(37, 54);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(343, 37);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "ADMIN INTERFACE";
            // 
            // AdminProfilelistBox
            // 
            this.AdminProfilelistBox.FormattingEnabled = true;
            this.AdminProfilelistBox.ItemHeight = 16;
            this.AdminProfilelistBox.Location = new System.Drawing.Point(437, 54);
            this.AdminProfilelistBox.Margin = new System.Windows.Forms.Padding(4);
            this.AdminProfilelistBox.Name = "AdminProfilelistBox";
            this.AdminProfilelistBox.Size = new System.Drawing.Size(255, 68);
            this.AdminProfilelistBox.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(37, 156);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(343, 159);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // Admin_Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.AdminProfilelistBox);
            this.Controls.Add(this.textBox1);
            this.Name = "Admin_Interface";
            this.Size = new System.Drawing.Size(725, 524);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox AdminProfilelistBox;
        private System.Windows.Forms.TextBox textBox2;
    }
}
