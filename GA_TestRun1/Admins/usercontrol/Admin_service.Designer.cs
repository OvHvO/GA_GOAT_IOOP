namespace GA_TestRun1.Admins
{
    partial class Admin_service
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
            this.components = new System.ComponentModel.Container();
            this.adminServiceAddbtn = new System.Windows.Forms.Button();
            this.adminServiceEditbtn = new System.Windows.Forms.Button();
            this.adminServiceDeletebtn = new System.Windows.Forms.Button();
            this.ServiceListBox = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ServiceDetailslistB = new System.Windows.Forms.ListBox();
            this.admin_service_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PartBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.admin_service_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminServiceAddbtn
            // 
            this.adminServiceAddbtn.Location = new System.Drawing.Point(617, 426);
            this.adminServiceAddbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adminServiceAddbtn.Name = "adminServiceAddbtn";
            this.adminServiceAddbtn.Size = new System.Drawing.Size(100, 28);
            this.adminServiceAddbtn.TabIndex = 1;
            this.adminServiceAddbtn.Text = "ADD";
            this.adminServiceAddbtn.UseVisualStyleBackColor = true;
            this.adminServiceAddbtn.Click += new System.EventHandler(this.adminServiceAddbtn_Click);
            // 
            // adminServiceEditbtn
            // 
            this.adminServiceEditbtn.Location = new System.Drawing.Point(371, 426);
            this.adminServiceEditbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adminServiceEditbtn.Name = "adminServiceEditbtn";
            this.adminServiceEditbtn.Size = new System.Drawing.Size(100, 28);
            this.adminServiceEditbtn.TabIndex = 2;
            this.adminServiceEditbtn.Text = "EDIT";
            this.adminServiceEditbtn.UseVisualStyleBackColor = true;
            this.adminServiceEditbtn.Click += new System.EventHandler(this.adminServiceEditbtn_Click);
            // 
            // adminServiceDeletebtn
            // 
            this.adminServiceDeletebtn.Location = new System.Drawing.Point(107, 426);
            this.adminServiceDeletebtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adminServiceDeletebtn.Name = "adminServiceDeletebtn";
            this.adminServiceDeletebtn.Size = new System.Drawing.Size(100, 28);
            this.adminServiceDeletebtn.TabIndex = 3;
            this.adminServiceDeletebtn.Text = "DELETE";
            this.adminServiceDeletebtn.UseVisualStyleBackColor = true;
            this.adminServiceDeletebtn.Click += new System.EventHandler(this.adminServiceDeletebtn_Click);
            // 
            // ServiceListBox
            // 
            this.ServiceListBox.FormattingEnabled = true;
            this.ServiceListBox.ItemHeight = 16;
            this.ServiceListBox.Location = new System.Drawing.Point(107, 159);
            this.ServiceListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ServiceListBox.Name = "ServiceListBox";
            this.ServiceListBox.Size = new System.Drawing.Size(195, 164);
            this.ServiceListBox.TabIndex = 4;
            this.ServiceListBox.SelectedIndexChanged += new System.EventHandler(this.ServiceListBox_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ServiceDetailslistB
            // 
            this.ServiceDetailslistB.FormattingEnabled = true;
            this.ServiceDetailslistB.ItemHeight = 16;
            this.ServiceDetailslistB.Location = new System.Drawing.Point(432, 159);
            this.ServiceDetailslistB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ServiceDetailslistB.Name = "ServiceDetailslistB";
            this.ServiceDetailslistB.Size = new System.Drawing.Size(285, 164);
            this.ServiceDetailslistB.TabIndex = 5;
            // 
            // admin_service_panel
            // 
            this.admin_service_panel.Controls.Add(this.label1);
            this.admin_service_panel.Controls.Add(this.PartBtn);
            this.admin_service_panel.Controls.Add(this.ServiceListBox);
            this.admin_service_panel.Controls.Add(this.adminServiceDeletebtn);
            this.admin_service_panel.Controls.Add(this.ServiceDetailslistB);
            this.admin_service_panel.Controls.Add(this.adminServiceEditbtn);
            this.admin_service_panel.Controls.Add(this.adminServiceAddbtn);
            this.admin_service_panel.Location = new System.Drawing.Point(0, 0);
            this.admin_service_panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.admin_service_panel.Name = "admin_service_panel";
            this.admin_service_panel.Size = new System.Drawing.Size(783, 492);
            this.admin_service_panel.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "SERVICE MANAGEMENT SYSTEM";
            // 
            // PartBtn
            // 
            this.PartBtn.Location = new System.Drawing.Point(107, 331);
            this.PartBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PartBtn.Name = "PartBtn";
            this.PartBtn.Size = new System.Drawing.Size(100, 28);
            this.PartBtn.TabIndex = 6;
            this.PartBtn.Text = "PART";
            this.PartBtn.UseVisualStyleBackColor = true;
            this.PartBtn.Click += new System.EventHandler(this.PartBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(619, 485);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(100, 28);
            this.cancelBtn.TabIndex = 7;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // Admin_service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.admin_service_panel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Admin_service";
            this.Size = new System.Drawing.Size(783, 528);
            this.admin_service_panel.ResumeLayout(false);
            this.admin_service_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button adminServiceAddbtn;
        private System.Windows.Forms.Button adminServiceEditbtn;
        private System.Windows.Forms.Button adminServiceDeletebtn;
        private System.Windows.Forms.ListBox ServiceListBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ListBox ServiceDetailslistB;
        private System.Windows.Forms.Panel admin_service_panel;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button PartBtn;
        private System.Windows.Forms.Label label1;
    }
}
