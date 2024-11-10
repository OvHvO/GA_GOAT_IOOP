namespace GA_TestRun1.Receptionist
{
    partial class Assign_task
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
            this.Mec_namelistb = new System.Windows.Forms.ListBox();
            this.task_btn = new System.Windows.Forms.Button();
            this.Name_txtb = new System.Windows.Forms.TextBox();
            this.Vehicle_txtb = new System.Windows.Forms.TextBox();
            this.ContactNum_txtb = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Vehicle = new System.Windows.Forms.Label();
            this.lbl_ContactN = new System.Windows.Forms.Label();
            this.task_nametxtb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Mec_namelistb
            // 
            this.Mec_namelistb.FormattingEnabled = true;
            this.Mec_namelistb.ItemHeight = 16;
            this.Mec_namelistb.Location = new System.Drawing.Point(59, 24);
            this.Mec_namelistb.Name = "Mec_namelistb";
            this.Mec_namelistb.Size = new System.Drawing.Size(303, 212);
            this.Mec_namelistb.TabIndex = 0;
            this.Mec_namelistb.SelectedIndexChanged += new System.EventHandler(this.Mec_namelistb_SelectedIndexChanged);
            // 
            // task_btn
            // 
            this.task_btn.Location = new System.Drawing.Point(166, 551);
            this.task_btn.Name = "task_btn";
            this.task_btn.Size = new System.Drawing.Size(108, 53);
            this.task_btn.TabIndex = 1;
            this.task_btn.Text = "button1";
            this.task_btn.UseVisualStyleBackColor = true;
            this.task_btn.Click += new System.EventHandler(this.task_btn_Click);
            // 
            // Name_txtb
            // 
            this.Name_txtb.Location = new System.Drawing.Point(133, 289);
            this.Name_txtb.Name = "Name_txtb";
            this.Name_txtb.ReadOnly = true;
            this.Name_txtb.Size = new System.Drawing.Size(268, 22);
            this.Name_txtb.TabIndex = 2;
            // 
            // Vehicle_txtb
            // 
            this.Vehicle_txtb.Location = new System.Drawing.Point(133, 348);
            this.Vehicle_txtb.Name = "Vehicle_txtb";
            this.Vehicle_txtb.ReadOnly = true;
            this.Vehicle_txtb.Size = new System.Drawing.Size(268, 22);
            this.Vehicle_txtb.TabIndex = 2;
            // 
            // ContactNum_txtb
            // 
            this.ContactNum_txtb.Location = new System.Drawing.Point(133, 408);
            this.ContactNum_txtb.Name = "ContactNum_txtb";
            this.ContactNum_txtb.ReadOnly = true;
            this.ContactNum_txtb.Size = new System.Drawing.Size(268, 22);
            this.ContactNum_txtb.TabIndex = 2;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(36, 289);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(44, 16);
            this.lbl_Name.TabIndex = 3;
            this.lbl_Name.Text = "label1";
            // 
            // lbl_Vehicle
            // 
            this.lbl_Vehicle.AutoSize = true;
            this.lbl_Vehicle.Location = new System.Drawing.Point(36, 348);
            this.lbl_Vehicle.Name = "lbl_Vehicle";
            this.lbl_Vehicle.Size = new System.Drawing.Size(44, 16);
            this.lbl_Vehicle.TabIndex = 3;
            this.lbl_Vehicle.Text = "label1";
            // 
            // lbl_ContactN
            // 
            this.lbl_ContactN.AutoSize = true;
            this.lbl_ContactN.Location = new System.Drawing.Point(36, 411);
            this.lbl_ContactN.Name = "lbl_ContactN";
            this.lbl_ContactN.Size = new System.Drawing.Size(44, 16);
            this.lbl_ContactN.TabIndex = 3;
            this.lbl_ContactN.Text = "label1";
            // 
            // task_nametxtb
            // 
            this.task_nametxtb.Location = new System.Drawing.Point(133, 478);
            this.task_nametxtb.Name = "task_nametxtb";
            this.task_nametxtb.Size = new System.Drawing.Size(268, 22);
            this.task_nametxtb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 484);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // Assign_task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(463, 616);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_ContactN);
            this.Controls.Add(this.lbl_Vehicle);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.task_nametxtb);
            this.Controls.Add(this.ContactNum_txtb);
            this.Controls.Add(this.Vehicle_txtb);
            this.Controls.Add(this.Name_txtb);
            this.Controls.Add(this.task_btn);
            this.Controls.Add(this.Mec_namelistb);
            this.Name = "Assign_task";
            this.Text = "Asigning_";
            this.Load += new System.EventHandler(this.Assign_task_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Mec_namelistb;
        private System.Windows.Forms.Button task_btn;
        private System.Windows.Forms.TextBox Name_txtb;
        private System.Windows.Forms.TextBox Vehicle_txtb;
        private System.Windows.Forms.TextBox ContactNum_txtb;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Vehicle;
        private System.Windows.Forms.Label lbl_ContactN;
        private System.Windows.Forms.TextBox task_nametxtb;
        private System.Windows.Forms.Label label1;
    }
}