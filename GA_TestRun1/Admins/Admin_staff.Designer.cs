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
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NewStaffContactNumTB = new System.Windows.Forms.TextBox();
            this.NewStaffNameTB = new System.Windows.Forms.TextBox();
            this.RoleComboBox = new System.Windows.Forms.ComboBox();
            this.StaffAddBtn = new System.Windows.Forms.Button();
            this.StaffDeleteBtn = new System.Windows.Forms.Button();
            this.StaffDetailsLB = new System.Windows.Forms.ListBox();
            this.NewStaffRoleCB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.StaffDetailsGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "STAFF MANAGEMENT SYSTEM";
            // 
            // StaffListBox
            // 
            this.StaffListBox.FormattingEnabled = true;
            this.StaffListBox.ItemHeight = 16;
            this.StaffListBox.Location = new System.Drawing.Point(63, 136);
            this.StaffListBox.Margin = new System.Windows.Forms.Padding(4);
            this.StaffListBox.Name = "StaffListBox";
            this.StaffListBox.Size = new System.Drawing.Size(217, 132);
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
            this.StaffDetailsGB.Location = new System.Drawing.Point(329, 114);
            this.StaffDetailsGB.Name = "StaffDetailsGB";
            this.StaffDetailsGB.Size = new System.Drawing.Size(356, 253);
            this.StaffDetailsGB.TabIndex = 6;
            this.StaffDetailsGB.TabStop = false;
            this.StaffDetailsGB.Text = "NewStaffDetails";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(228, 40);
            this.label6.TabIndex = 7;
            this.label6.Text = "Notice!!! \r\nNew Staff Password will be set to 0000\r\nThey can change the password " +
    "after first log in";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Staff Contact Number    +60";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Staff Username";
            // 
            // NewStaffContactNumTB
            // 
            this.NewStaffContactNumTB.Location = new System.Drawing.Point(225, 101);
            this.NewStaffContactNumTB.Name = "NewStaffContactNumTB";
            this.NewStaffContactNumTB.Size = new System.Drawing.Size(109, 22);
            this.NewStaffContactNumTB.TabIndex = 2;
            // 
            // NewStaffNameTB
            // 
            this.NewStaffNameTB.Location = new System.Drawing.Point(225, 47);
            this.NewStaffNameTB.Name = "NewStaffNameTB";
            this.NewStaffNameTB.Size = new System.Drawing.Size(109, 22);
            this.NewStaffNameTB.TabIndex = 1;
            // 
            // RoleComboBox
            // 
            this.RoleComboBox.FormattingEnabled = true;
            this.RoleComboBox.Items.AddRange(new object[] {
            "Receptionist",
            "Mechanic"});
            this.RoleComboBox.Location = new System.Drawing.Point(63, 114);
            this.RoleComboBox.Name = "RoleComboBox";
            this.RoleComboBox.Size = new System.Drawing.Size(217, 24);
            this.RoleComboBox.TabIndex = 7;
            this.RoleComboBox.Text = "Roles";
            this.RoleComboBox.SelectedIndexChanged += new System.EventHandler(this.RoleComboBox_SelectedIndexChanged);
            // 
            // StaffAddBtn
            // 
            this.StaffAddBtn.Location = new System.Drawing.Point(588, 407);
            this.StaffAddBtn.Name = "StaffAddBtn";
            this.StaffAddBtn.Size = new System.Drawing.Size(97, 23);
            this.StaffAddBtn.TabIndex = 8;
            this.StaffAddBtn.Text = "ADD";
            this.StaffAddBtn.UseVisualStyleBackColor = true;
            this.StaffAddBtn.Click += new System.EventHandler(this.StaffAddBtn_Click);
            // 
            // StaffDeleteBtn
            // 
            this.StaffDeleteBtn.Location = new System.Drawing.Point(205, 407);
            this.StaffDeleteBtn.Name = "StaffDeleteBtn";
            this.StaffDeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.StaffDeleteBtn.TabIndex = 9;
            this.StaffDeleteBtn.Text = "DELETE";
            this.StaffDeleteBtn.UseVisualStyleBackColor = true;
            this.StaffDeleteBtn.Click += new System.EventHandler(this.StaffDeleteBtn_Click);
            // 
            // StaffDetailsLB
            // 
            this.StaffDetailsLB.FormattingEnabled = true;
            this.StaffDetailsLB.ItemHeight = 16;
            this.StaffDetailsLB.Location = new System.Drawing.Point(63, 283);
            this.StaffDetailsLB.Name = "StaffDetailsLB";
            this.StaffDetailsLB.Size = new System.Drawing.Size(217, 84);
            this.StaffDetailsLB.TabIndex = 10;
            // 
            // NewStaffRoleCB
            // 
            this.NewStaffRoleCB.FormattingEnabled = true;
            this.NewStaffRoleCB.Items.AddRange(new object[] {
            "Receptionist",
            "Mechanic"});
            this.NewStaffRoleCB.Location = new System.Drawing.Point(225, 154);
            this.NewStaffRoleCB.Name = "NewStaffRoleCB";
            this.NewStaffRoleCB.Size = new System.Drawing.Size(109, 24);
            this.NewStaffRoleCB.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "New Staff Role";
            // 
            // Admin_staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.Controls.Add(this.StaffDetailsLB);
            this.Controls.Add(this.StaffDeleteBtn);
            this.Controls.Add(this.StaffAddBtn);
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
