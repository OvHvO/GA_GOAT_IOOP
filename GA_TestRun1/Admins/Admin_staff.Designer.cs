namespace GA_TestRun1.Admins
{
    partial class Admin_staff
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
            this.label1 = new System.Windows.Forms.Label();
            this.StaffListBox = new System.Windows.Forms.ListBox();
            this.StaffDetailsGB = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.RoleComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.StaffDetailsGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "STAFF MANAGEMENT SYSTEM";
            // 
            // StaffListBox
            // 
            this.StaffListBox.FormattingEnabled = true;
            this.StaffListBox.ItemHeight = 16;
            this.StaffListBox.Location = new System.Drawing.Point(78, 136);
            this.StaffListBox.Margin = new System.Windows.Forms.Padding(4);
            this.StaffListBox.Name = "StaffListBox";
            this.StaffListBox.Size = new System.Drawing.Size(195, 196);
            this.StaffListBox.TabIndex = 5;
            // 
            // StaffDetailsGB
            // 
            this.StaffDetailsGB.Controls.Add(this.textBox3);
            this.StaffDetailsGB.Controls.Add(this.textBox2);
            this.StaffDetailsGB.Controls.Add(this.textBox1);
            this.StaffDetailsGB.Location = new System.Drawing.Point(387, 114);
            this.StaffDetailsGB.Name = "StaffDetailsGB";
            this.StaffDetailsGB.Size = new System.Drawing.Size(246, 218);
            this.StaffDetailsGB.TabIndex = 6;
            this.StaffDetailsGB.TabStop = false;
            this.StaffDetailsGB.Text = "groupBox1";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(128, 134);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(128, 93);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            // 
            // RoleComboBox
            // 
            this.RoleComboBox.FormattingEnabled = true;
            this.RoleComboBox.Items.AddRange(new object[] {
            "Receptionist",
            "Mechanic"});
            this.RoleComboBox.Location = new System.Drawing.Point(78, 114);
            this.RoleComboBox.Name = "RoleComboBox";
            this.RoleComboBox.Size = new System.Drawing.Size(195, 24);
            this.RoleComboBox.TabIndex = 7;
            this.RoleComboBox.Text = "Roles";
            this.RoleComboBox.SelectedIndexChanged += new System.EventHandler(this.RoleComboBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(558, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Admin_staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RoleComboBox);
            this.Controls.Add(this.StaffDetailsGB);
            this.Controls.Add(this.StaffListBox);
            this.Controls.Add(this.label1);
            this.Name = "Admin_staff";
            this.Size = new System.Drawing.Size(725, 492);
            this.StaffDetailsGB.ResumeLayout(false);
            this.StaffDetailsGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox StaffListBox;
        private System.Windows.Forms.GroupBox StaffDetailsGB;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox RoleComboBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
    }
}
