namespace GA_TestRun1.Mechanics
{
    partial class Mechanic_home
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
            this.OptionPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.U_Profile_btn = new System.Windows.Forms.Button();
            this.V_ServiceTask_btn = new System.Windows.Forms.Button();
            this.M_Inventory_btn = new System.Windows.Forms.Button();
            this.R_Service_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OptionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // OptionPanel
            // 
            this.OptionPanel.Controls.Add(this.pictureBox1);
            this.OptionPanel.Controls.Add(this.panel1);
            this.OptionPanel.Controls.Add(this.U_Profile_btn);
            this.OptionPanel.Controls.Add(this.V_ServiceTask_btn);
            this.OptionPanel.Controls.Add(this.M_Inventory_btn);
            this.OptionPanel.Controls.Add(this.R_Service_btn);
            this.OptionPanel.Location = new System.Drawing.Point(0, -5);
            this.OptionPanel.Name = "OptionPanel";
            this.OptionPanel.Size = new System.Drawing.Size(107, 429);
            this.OptionPanel.TabIndex = 0;
            this.OptionPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.OptionPanel_Paint);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(110, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 431);
            this.panel1.TabIndex = 1;
            // 
            // U_Profile_btn
            // 
            this.U_Profile_btn.FlatAppearance.BorderSize = 0;
            this.U_Profile_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.U_Profile_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.U_Profile_btn.Location = new System.Drawing.Point(3, 338);
            this.U_Profile_btn.Name = "U_Profile_btn";
            this.U_Profile_btn.Size = new System.Drawing.Size(101, 52);
            this.U_Profile_btn.TabIndex = 3;
            this.U_Profile_btn.Text = "Update Profile";
            this.U_Profile_btn.UseVisualStyleBackColor = true;
            this.U_Profile_btn.Click += new System.EventHandler(this.U_Profile_btn_Click);
            // 
            // V_ServiceTask_btn
            // 
            this.V_ServiceTask_btn.FlatAppearance.BorderSize = 0;
            this.V_ServiceTask_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.V_ServiceTask_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V_ServiceTask_btn.Location = new System.Drawing.Point(3, 103);
            this.V_ServiceTask_btn.Name = "V_ServiceTask_btn";
            this.V_ServiceTask_btn.Size = new System.Drawing.Size(101, 52);
            this.V_ServiceTask_btn.TabIndex = 2;
            this.V_ServiceTask_btn.Text = "View Service Task";
            this.V_ServiceTask_btn.UseVisualStyleBackColor = true;
            this.V_ServiceTask_btn.Click += new System.EventHandler(this.V_ServiceTask_btn_Click);
            // 
            // M_Inventory_btn
            // 
            this.M_Inventory_btn.FlatAppearance.BorderSize = 0;
            this.M_Inventory_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.M_Inventory_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M_Inventory_btn.Location = new System.Drawing.Point(3, 263);
            this.M_Inventory_btn.Name = "M_Inventory_btn";
            this.M_Inventory_btn.Size = new System.Drawing.Size(101, 52);
            this.M_Inventory_btn.TabIndex = 1;
            this.M_Inventory_btn.Text = "Manage Inventory";
            this.M_Inventory_btn.UseVisualStyleBackColor = true;
            this.M_Inventory_btn.Click += new System.EventHandler(this.M_Inventory_btn_Click);
            // 
            // R_Service_btn
            // 
            this.R_Service_btn.FlatAppearance.BorderSize = 0;
            this.R_Service_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.R_Service_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R_Service_btn.Location = new System.Drawing.Point(3, 185);
            this.R_Service_btn.Name = "R_Service_btn";
            this.R_Service_btn.Size = new System.Drawing.Size(101, 52);
            this.R_Service_btn.TabIndex = 0;
            this.R_Service_btn.Text = "Record Service";
            this.R_Service_btn.UseVisualStyleBackColor = true;
            this.R_Service_btn.Click += new System.EventHandler(this.R_Service_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GA_TestRun1.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(8, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Mechanic_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(694, 421);
            this.Controls.Add(this.OptionPanel);
            this.Name = "Mechanic_home";
            this.Text = "Mechanic_home";
            this.Load += new System.EventHandler(this.Mechanic_home_Load);
            this.OptionPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel OptionPanel;
        private System.Windows.Forms.Button R_Service_btn;
        private System.Windows.Forms.Button M_Inventory_btn;
        private System.Windows.Forms.Button V_ServiceTask_btn;
        private System.Windows.Forms.Button U_Profile_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}