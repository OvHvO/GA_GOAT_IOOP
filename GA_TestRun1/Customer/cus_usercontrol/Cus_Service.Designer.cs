namespace GA_TestRun1.Customer.cus_usercontrol
{
    partial class Cus_Service
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
            this.Cus_Service_LB = new System.Windows.Forms.ListBox();
            this.Cus_ServiceDtls_LB = new System.Windows.Forms.ListBox();
            this.appointmentConfirmBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ServiceAppoinmentGB = new System.Windows.Forms.GroupBox();
            this.MechanicCB = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Cus_Service_carVersion = new System.Windows.Forms.TextBox();
            this.Cus_Service_carNum = new System.Windows.Forms.TextBox();
            this.Cus_Service_cusID = new System.Windows.Forms.TextBox();
            this.ServiceAppoinmentGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "SERVICE";
            // 
            // Cus_Service_LB
            // 
            this.Cus_Service_LB.FormattingEnabled = true;
            this.Cus_Service_LB.Location = new System.Drawing.Point(68, 112);
            this.Cus_Service_LB.Name = "Cus_Service_LB";
            this.Cus_Service_LB.Size = new System.Drawing.Size(177, 95);
            this.Cus_Service_LB.TabIndex = 1;
            this.Cus_Service_LB.SelectedIndexChanged += new System.EventHandler(this.Cus_Service_LB_SelectedIndexChanged);
            // 
            // Cus_ServiceDtls_LB
            // 
            this.Cus_ServiceDtls_LB.FormattingEnabled = true;
            this.Cus_ServiceDtls_LB.Location = new System.Drawing.Point(300, 112);
            this.Cus_ServiceDtls_LB.Name = "Cus_ServiceDtls_LB";
            this.Cus_ServiceDtls_LB.Size = new System.Drawing.Size(181, 95);
            this.Cus_ServiceDtls_LB.TabIndex = 2;
            // 
            // appointmentConfirmBtn
            // 
            this.appointmentConfirmBtn.BackColor = System.Drawing.Color.LightCoral;
            this.appointmentConfirmBtn.FlatAppearance.BorderSize = 0;
            this.appointmentConfirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.appointmentConfirmBtn.Location = new System.Drawing.Point(319, 128);
            this.appointmentConfirmBtn.Name = "appointmentConfirmBtn";
            this.appointmentConfirmBtn.Size = new System.Drawing.Size(75, 23);
            this.appointmentConfirmBtn.TabIndex = 3;
            this.appointmentConfirmBtn.Text = "CONFIRM";
            this.appointmentConfirmBtn.UseVisualStyleBackColor = false;
            this.appointmentConfirmBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Service";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Service Details";
            // 
            // ServiceAppoinmentGB
            // 
            this.ServiceAppoinmentGB.Controls.Add(this.MechanicCB);
            this.ServiceAppoinmentGB.Controls.Add(this.label7);
            this.ServiceAppoinmentGB.Controls.Add(this.label6);
            this.ServiceAppoinmentGB.Controls.Add(this.label5);
            this.ServiceAppoinmentGB.Controls.Add(this.label4);
            this.ServiceAppoinmentGB.Controls.Add(this.Cus_Service_carVersion);
            this.ServiceAppoinmentGB.Controls.Add(this.Cus_Service_carNum);
            this.ServiceAppoinmentGB.Controls.Add(this.Cus_Service_cusID);
            this.ServiceAppoinmentGB.Controls.Add(this.appointmentConfirmBtn);
            this.ServiceAppoinmentGB.Location = new System.Drawing.Point(68, 233);
            this.ServiceAppoinmentGB.Name = "ServiceAppoinmentGB";
            this.ServiceAppoinmentGB.Size = new System.Drawing.Size(413, 157);
            this.ServiceAppoinmentGB.TabIndex = 6;
            this.ServiceAppoinmentGB.TabStop = false;
            this.ServiceAppoinmentGB.Text = "Service Appoinment";
            // 
            // MechanicCB
            // 
            this.MechanicCB.FormattingEnabled = true;
            this.MechanicCB.Location = new System.Drawing.Point(294, 94);
            this.MechanicCB.Name = "MechanicCB";
            this.MechanicCB.Size = new System.Drawing.Size(100, 21);
            this.MechanicCB.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(227, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Mechanic";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Car Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Car Version";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cus_ID";
            // 
            // Cus_Service_carVersion
            // 
            this.Cus_Service_carVersion.Location = new System.Drawing.Point(294, 46);
            this.Cus_Service_carVersion.Name = "Cus_Service_carVersion";
            this.Cus_Service_carVersion.Size = new System.Drawing.Size(100, 20);
            this.Cus_Service_carVersion.TabIndex = 7;
            // 
            // Cus_Service_carNum
            // 
            this.Cus_Service_carNum.Location = new System.Drawing.Point(96, 94);
            this.Cus_Service_carNum.Name = "Cus_Service_carNum";
            this.Cus_Service_carNum.Size = new System.Drawing.Size(100, 20);
            this.Cus_Service_carNum.TabIndex = 5;
            // 
            // Cus_Service_cusID
            // 
            this.Cus_Service_cusID.Location = new System.Drawing.Point(96, 46);
            this.Cus_Service_cusID.Name = "Cus_Service_cusID";
            this.Cus_Service_cusID.Size = new System.Drawing.Size(100, 20);
            this.Cus_Service_cusID.TabIndex = 4;
            // 
            // Cus_Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ServiceAppoinmentGB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cus_ServiceDtls_LB);
            this.Controls.Add(this.Cus_Service_LB);
            this.Controls.Add(this.label1);
            this.Name = "Cus_Service";
            this.Size = new System.Drawing.Size(544, 426);
            this.ServiceAppoinmentGB.ResumeLayout(false);
            this.ServiceAppoinmentGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Cus_Service_LB;
        private System.Windows.Forms.ListBox Cus_ServiceDtls_LB;
        private System.Windows.Forms.Button appointmentConfirmBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox ServiceAppoinmentGB;
        private System.Windows.Forms.TextBox Cus_Service_carVersion;
        private System.Windows.Forms.TextBox Cus_Service_carNum;
        private System.Windows.Forms.TextBox Cus_Service_cusID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox MechanicCB;
    }
}
