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
            this.label5 = new System.Windows.Forms.Label();
            this.NewStaffRoleCB = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NewStaffContactNumTB = new System.Windows.Forms.TextBox();
            this.NewStaffNameTB = new System.Windows.Forms.TextBox();
            this.RoleComboBox = new System.Windows.Forms.ComboBox();
            this.StaffAddBtn = new System.Windows.Forms.Button();
            this.StaffDeleteBtn = new System.Windows.Forms.Button();
            this.StaffDetailsLB = new System.Windows.Forms.ListBox();
            this.StaffDetailsGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "STAFF MANAGEMENT SYSTEM";
            // 
            // StaffListBox
            // 
            this.StaffListBox.FormattingEnabled = true;
            this.StaffListBox.Location = new System.Drawing.Point(47, 110);
            this.StaffListBox.Name = "StaffListBox";
            this.StaffListBox.Size = new System.Drawing.Size(164, 108);
            this.StaffListBox.TabIndex = 5;
            this.StaffListBox.SelectedIndexChanged += new System.EventHandler(this.StaffListBox_SelectedIndexChanged);
            // 
            // StaffDetailsGB
            // 
            this.StaffDetailsGB.Controls.Add(this.label5);
            this.StaffDetailsGB.Controls.Add(this.NewStaffRoleCB);
            this.StaffDetailsGB.Controls.Add(this.label6);
            this.StaffDetailsGB.Controls.Add(this.label4);
            this.StaffDetailsGB.Controls.Add(this.label3);
            this.StaffDetailsGB.Controls.Add(this.NewStaffContactNumTB);
            this.StaffDetailsGB.Controls.Add(this.NewStaffNameTB);
            this.StaffDetailsGB.Location = new System.Drawing.Point(247, 93);
            this.StaffDetailsGB.Margin = new System.Windows.Forms.Padding(2);
            this.StaffDetailsGB.Name = "StaffDetailsGB";
            this.StaffDetailsGB.Padding = new System.Windows.Forms.Padding(2);
            this.StaffDetailsGB.Size = new System.Drawing.Size(267, 206);
            this.StaffDetailsGB.TabIndex = 6;
            this.StaffDetailsGB.TabStop = false;
            this.StaffDetailsGB.Text = "NewStaffDetails";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 128);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "New Staff Role";
            // 
            // NewStaffRoleCB
            // 
            this.NewStaffRoleCB.FormattingEnabled = true;
            this.NewStaffRoleCB.Items.AddRange(new object[] {
            "Receptionist",
            "Mechanic"});
            this.NewStaffRoleCB.Location = new System.Drawing.Point(169, 125);
            this.NewStaffRoleCB.Margin = new System.Windows.Forms.Padding(2);
            this.NewStaffRoleCB.Name = "NewStaffRoleCB";
            this.NewStaffRoleCB.Size = new System.Drawing.Size(83, 21);
            this.NewStaffRoleCB.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 161);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 32);
            this.label6.TabIndex = 7;
            this.label6.Text = "Notice!!! \r\nNew Staff Password will be set to 0000\r\nThey can change the password " +
    "after first log in";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Staff Contact Number    +60";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Staff Username";
            // 
            // NewStaffContactNumTB
            // 
            this.NewStaffContactNumTB.Location = new System.Drawing.Point(169, 82);
            this.NewStaffContactNumTB.Margin = new System.Windows.Forms.Padding(2);
            this.NewStaffContactNumTB.Name = "NewStaffContactNumTB";
            this.NewStaffContactNumTB.Size = new System.Drawing.Size(83, 20);
            this.NewStaffContactNumTB.TabIndex = 2;
            // 
            // NewStaffNameTB
            // 
            this.NewStaffNameTB.Location = new System.Drawing.Point(169, 38);
            this.NewStaffNameTB.Margin = new System.Windows.Forms.Padding(2);
            this.NewStaffNameTB.Name = "NewStaffNameTB";
            this.NewStaffNameTB.Size = new System.Drawing.Size(83, 20);
            this.NewStaffNameTB.TabIndex = 1;
            // 
            // RoleComboBox
            // 
            this.RoleComboBox.FormattingEnabled = true;
            this.RoleComboBox.Items.AddRange(new object[] {
            "Receptionist",
            "Mechanic"});
            this.RoleComboBox.Location = new System.Drawing.Point(47, 93);
            this.RoleComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.RoleComboBox.Name = "RoleComboBox";
            this.RoleComboBox.Size = new System.Drawing.Size(164, 21);
            this.RoleComboBox.TabIndex = 7;
            this.RoleComboBox.Text = "Roles";
            this.RoleComboBox.SelectedIndexChanged += new System.EventHandler(this.RoleComboBox_SelectedIndexChanged);
            // 
            // StaffAddBtn
            // 
            this.StaffAddBtn.Location = new System.Drawing.Point(441, 331);
            this.StaffAddBtn.Margin = new System.Windows.Forms.Padding(2);
            this.StaffAddBtn.Name = "StaffAddBtn";
            this.StaffAddBtn.Size = new System.Drawing.Size(73, 19);
            this.StaffAddBtn.TabIndex = 8;
            this.StaffAddBtn.Text = "ADD";
            this.StaffAddBtn.UseVisualStyleBackColor = true;
            this.StaffAddBtn.Click += new System.EventHandler(this.StaffAddBtn_Click);
            // 
            // StaffDeleteBtn
            // 
            this.StaffDeleteBtn.Location = new System.Drawing.Point(154, 331);
            this.StaffDeleteBtn.Margin = new System.Windows.Forms.Padding(2);
            this.StaffDeleteBtn.Name = "StaffDeleteBtn";
            this.StaffDeleteBtn.Size = new System.Drawing.Size(56, 19);
            this.StaffDeleteBtn.TabIndex = 9;
            this.StaffDeleteBtn.Text = "DELETE";
            this.StaffDeleteBtn.UseVisualStyleBackColor = true;
            this.StaffDeleteBtn.Click += new System.EventHandler(this.StaffDeleteBtn_Click);
            // 
            // StaffDetailsLB
            // 
            this.StaffDetailsLB.FormattingEnabled = true;
            this.StaffDetailsLB.Location = new System.Drawing.Point(47, 230);
            this.StaffDetailsLB.Margin = new System.Windows.Forms.Padding(2);
            this.StaffDetailsLB.Name = "StaffDetailsLB";
            this.StaffDetailsLB.Size = new System.Drawing.Size(164, 69);
            this.StaffDetailsLB.TabIndex = 10;
            // 
            // Admin_staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.Controls.Add(this.StaffDetailsLB);
            this.Controls.Add(this.StaffDeleteBtn);
            this.Controls.Add(this.StaffAddBtn);
            this.Controls.Add(this.RoleComboBox);
            this.Controls.Add(this.StaffDetailsGB);
            this.Controls.Add(this.StaffListBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Admin_staff";
            this.Size = new System.Drawing.Size(544, 400);
            this.StaffDetailsGB.ResumeLayout(false);
            this.StaffDetailsGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox StaffListBox;
        private System.Windows.Forms.GroupBox StaffDetailsGB;
        private System.Windows.Forms.ComboBox RoleComboBox;
        private System.Windows.Forms.TextBox NewStaffNameTB;
        private System.Windows.Forms.TextBox NewStaffContactNumTB;
        private System.Windows.Forms.Button StaffAddBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button StaffDeleteBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox StaffDetailsLB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox NewStaffRoleCB;
    }
}
