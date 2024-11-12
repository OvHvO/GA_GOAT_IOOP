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
            this.tasknamelbl = new System.Windows.Forms.Label();
            this.lbl_ContactN = new System.Windows.Forms.Label();
            this.lbl_Vehicle = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.task_nametxtb = new System.Windows.Forms.TextBox();
            this.ContactNum_txtb = new System.Windows.Forms.TextBox();
            this.Vehicle_txtb = new System.Windows.Forms.TextBox();
            this.Name_txtb = new System.Windows.Forms.TextBox();
            this.task_btn = new System.Windows.Forms.Button();
            this.Mec_namelistb = new System.Windows.Forms.ListBox();
            this.serviceDateTimepick = new System.Windows.Forms.DateTimePicker();
            this.ServiceTimelbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tasknamelbl
            // 
            this.tasknamelbl.AutoSize = true;
            this.tasknamelbl.Location = new System.Drawing.Point(12, 452);
            this.tasknamelbl.Name = "tasknamelbl";
            this.tasknamelbl.Size = new System.Drawing.Size(84, 16);
            this.tasknamelbl.TabIndex = 10;
            this.tasknamelbl.Text = "Task Name: ";
            // 
            // lbl_ContactN
            // 
            this.lbl_ContactN.AutoSize = true;
            this.lbl_ContactN.Location = new System.Drawing.Point(12, 379);
            this.lbl_ContactN.Name = "lbl_ContactN";
            this.lbl_ContactN.Size = new System.Drawing.Size(109, 16);
            this.lbl_ContactN.TabIndex = 11;
            this.lbl_ContactN.Text = "Contact Number: ";
            // 
            // lbl_Vehicle
            // 
            this.lbl_Vehicle.AutoSize = true;
            this.lbl_Vehicle.Location = new System.Drawing.Point(12, 319);
            this.lbl_Vehicle.Name = "lbl_Vehicle";
            this.lbl_Vehicle.Size = new System.Drawing.Size(86, 16);
            this.lbl_Vehicle.TabIndex = 12;
            this.lbl_Vehicle.Text = "Vehicle Num:";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(12, 257);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(110, 16);
            this.lbl_Name.TabIndex = 13;
            this.lbl_Name.Text = "Cusotmer Name: ";
            // 
            // task_nametxtb
            // 
            this.task_nametxtb.Location = new System.Drawing.Point(151, 446);
            this.task_nametxtb.Name = "task_nametxtb";
            this.task_nametxtb.Size = new System.Drawing.Size(268, 22);
            this.task_nametxtb.TabIndex = 6;
            // 
            // ContactNum_txtb
            // 
            this.ContactNum_txtb.Location = new System.Drawing.Point(151, 376);
            this.ContactNum_txtb.Name = "ContactNum_txtb";
            this.ContactNum_txtb.ReadOnly = true;
            this.ContactNum_txtb.Size = new System.Drawing.Size(268, 22);
            this.ContactNum_txtb.TabIndex = 7;
            // 
            // Vehicle_txtb
            // 
            this.Vehicle_txtb.Location = new System.Drawing.Point(151, 316);
            this.Vehicle_txtb.Name = "Vehicle_txtb";
            this.Vehicle_txtb.ReadOnly = true;
            this.Vehicle_txtb.Size = new System.Drawing.Size(268, 22);
            this.Vehicle_txtb.TabIndex = 8;
            // 
            // Name_txtb
            // 
            this.Name_txtb.Location = new System.Drawing.Point(151, 257);
            this.Name_txtb.Name = "Name_txtb";
            this.Name_txtb.ReadOnly = true;
            this.Name_txtb.Size = new System.Drawing.Size(268, 22);
            this.Name_txtb.TabIndex = 9;
            // 
            // task_btn
            // 
            this.task_btn.Location = new System.Drawing.Point(161, 551);
            this.task_btn.Name = "task_btn";
            this.task_btn.Size = new System.Drawing.Size(108, 53);
            this.task_btn.TabIndex = 5;
            this.task_btn.Text = "Assign";
            this.task_btn.UseVisualStyleBackColor = true;
            this.task_btn.Click += new System.EventHandler(this.task_btn_Click_1);
            // 
            // Mec_namelistb
            // 
            this.Mec_namelistb.FormattingEnabled = true;
            this.Mec_namelistb.ItemHeight = 16;
            this.Mec_namelistb.Location = new System.Drawing.Point(79, 12);
            this.Mec_namelistb.Name = "Mec_namelistb";
            this.Mec_namelistb.Size = new System.Drawing.Size(303, 212);
            this.Mec_namelistb.TabIndex = 4;
            this.Mec_namelistb.SelectedIndexChanged += new System.EventHandler(this.Mec_namelistb_SelectedIndexChanged);
            // 
            // serviceDateTimepick
            // 
            this.serviceDateTimepick.CustomFormat = "";
            this.serviceDateTimepick.Location = new System.Drawing.Point(151, 501);
            this.serviceDateTimepick.Name = "serviceDateTimepick";
            this.serviceDateTimepick.Size = new System.Drawing.Size(268, 22);
            this.serviceDateTimepick.TabIndex = 14;
            this.serviceDateTimepick.ValueChanged += new System.EventHandler(this.serviceDateTimepick_ValueChanged);
            // 
            // ServiceTimelbl
            // 
            this.ServiceTimelbl.AutoSize = true;
            this.ServiceTimelbl.Location = new System.Drawing.Point(12, 507);
            this.ServiceTimelbl.Name = "ServiceTimelbl";
            this.ServiceTimelbl.Size = new System.Drawing.Size(93, 16);
            this.ServiceTimelbl.TabIndex = 15;
            this.ServiceTimelbl.Text = "Service Time: ";
            // 
            // Assign_task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(463, 616);
            this.Controls.Add(this.ServiceTimelbl);
            this.Controls.Add(this.serviceDateTimepick);
            this.Controls.Add(this.tasknamelbl);
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
            this.Text = "Assign_";
            this.Load += new System.EventHandler(this.Assign_task_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tasknamelbl;
        private System.Windows.Forms.Label lbl_ContactN;
        private System.Windows.Forms.Label lbl_Vehicle;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox task_nametxtb;
        private System.Windows.Forms.TextBox ContactNum_txtb;
        private System.Windows.Forms.TextBox Vehicle_txtb;
        private System.Windows.Forms.TextBox Name_txtb;
        private System.Windows.Forms.Button task_btn;
        private System.Windows.Forms.ListBox Mec_namelistb;
        private System.Windows.Forms.DateTimePicker serviceDateTimepick;
        private System.Windows.Forms.Label ServiceTimelbl;
    }
}