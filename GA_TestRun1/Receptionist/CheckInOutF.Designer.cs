namespace GA_TestRun1.Receptionist
{
    partial class CheckInOutF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckInOutF));
            this.checkin_rightPanel = new System.Windows.Forms.Panel();
            this.reload_pict = new System.Windows.Forms.PictureBox();
            this.checkin_Billbtn = new System.Windows.Forms.Button();
            this.checkin_Upbtn = new System.Windows.Forms.Button();
            this.checkin_Statuslbl = new System.Windows.Forms.Label();
            this.checkin_carVer = new System.Windows.Forms.Label();
            this.checkin_carnumlbl = new System.Windows.Forms.Label();
            this.checkin_cusNamelbl = new System.Windows.Forms.Label();
            this.checkin_carVertxt = new System.Windows.Forms.TextBox();
            this.checkin_cbo = new System.Windows.Forms.ComboBox();
            this.checkin_Carnumtxt = new System.Windows.Forms.TextBox();
            this.checkin_Cusnametxt = new System.Windows.Forms.TextBox();
            this.checkin_leftPanel = new System.Windows.Forms.Panel();
            this.checkin_dataView = new System.Windows.Forms.DataGridView();
            this.Cus_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carVer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Service_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Service_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkin_rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reload_pict)).BeginInit();
            this.checkin_leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkin_dataView)).BeginInit();
            this.SuspendLayout();
            // 
            // checkin_rightPanel
            // 
            this.checkin_rightPanel.Controls.Add(this.reload_pict);
            this.checkin_rightPanel.Controls.Add(this.checkin_Billbtn);
            this.checkin_rightPanel.Controls.Add(this.checkin_Upbtn);
            this.checkin_rightPanel.Controls.Add(this.checkin_Statuslbl);
            this.checkin_rightPanel.Controls.Add(this.checkin_carVer);
            this.checkin_rightPanel.Controls.Add(this.checkin_carnumlbl);
            this.checkin_rightPanel.Controls.Add(this.checkin_cusNamelbl);
            this.checkin_rightPanel.Controls.Add(this.checkin_carVertxt);
            this.checkin_rightPanel.Controls.Add(this.checkin_cbo);
            this.checkin_rightPanel.Controls.Add(this.checkin_Carnumtxt);
            this.checkin_rightPanel.Controls.Add(this.checkin_Cusnametxt);
            this.checkin_rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkin_rightPanel.Location = new System.Drawing.Point(542, 0);
            this.checkin_rightPanel.Name = "checkin_rightPanel";
            this.checkin_rightPanel.Size = new System.Drawing.Size(405, 519);
            this.checkin_rightPanel.TabIndex = 0;
            // 
            // reload_pict
            // 
            this.reload_pict.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reload_pict.Image = ((System.Drawing.Image)(resources.GetObject("reload_pict.Image")));
            this.reload_pict.Location = new System.Drawing.Point(12, 12);
            this.reload_pict.Name = "reload_pict";
            this.reload_pict.Size = new System.Drawing.Size(33, 33);
            this.reload_pict.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.reload_pict.TabIndex = 6;
            this.reload_pict.TabStop = false;
            this.reload_pict.Click += new System.EventHandler(this.reload_pict_Click);
            // 
            // checkin_Billbtn
            // 
            this.checkin_Billbtn.Enabled = false;
            this.checkin_Billbtn.Location = new System.Drawing.Point(280, 377);
            this.checkin_Billbtn.Name = "checkin_Billbtn";
            this.checkin_Billbtn.Size = new System.Drawing.Size(87, 43);
            this.checkin_Billbtn.TabIndex = 7;
            this.checkin_Billbtn.Text = "Generate Bill";
            this.checkin_Billbtn.UseVisualStyleBackColor = true;
            this.checkin_Billbtn.Click += new System.EventHandler(this.checkin_Billbtn_Click);
            // 
            // checkin_Upbtn
            // 
            this.checkin_Upbtn.Location = new System.Drawing.Point(58, 377);
            this.checkin_Upbtn.Name = "checkin_Upbtn";
            this.checkin_Upbtn.Size = new System.Drawing.Size(87, 43);
            this.checkin_Upbtn.TabIndex = 6;
            this.checkin_Upbtn.Text = "Update";
            this.checkin_Upbtn.UseVisualStyleBackColor = true;
            this.checkin_Upbtn.Click += new System.EventHandler(this.checkin_Upbtn_Click);
            // 
            // checkin_Statuslbl
            // 
            this.checkin_Statuslbl.AutoSize = true;
            this.checkin_Statuslbl.Location = new System.Drawing.Point(46, 272);
            this.checkin_Statuslbl.Name = "checkin_Statuslbl";
            this.checkin_Statuslbl.Size = new System.Drawing.Size(44, 16);
            this.checkin_Statuslbl.TabIndex = 5;
            this.checkin_Statuslbl.Text = "Status";
            // 
            // checkin_carVer
            // 
            this.checkin_carVer.AutoSize = true;
            this.checkin_carVer.Location = new System.Drawing.Point(46, 211);
            this.checkin_carVer.Name = "checkin_carVer";
            this.checkin_carVer.Size = new System.Drawing.Size(83, 16);
            this.checkin_carVer.TabIndex = 4;
            this.checkin_carVer.Text = "Car Version: ";
            // 
            // checkin_carnumlbl
            // 
            this.checkin_carnumlbl.AutoSize = true;
            this.checkin_carnumlbl.Location = new System.Drawing.Point(46, 155);
            this.checkin_carnumlbl.Name = "checkin_carnumlbl";
            this.checkin_carnumlbl.Size = new System.Drawing.Size(119, 16);
            this.checkin_carnumlbl.TabIndex = 4;
            this.checkin_carnumlbl.Text = "Car Plate Number: ";
            // 
            // checkin_cusNamelbl
            // 
            this.checkin_cusNamelbl.AutoSize = true;
            this.checkin_cusNamelbl.Location = new System.Drawing.Point(46, 93);
            this.checkin_cusNamelbl.Name = "checkin_cusNamelbl";
            this.checkin_cusNamelbl.Size = new System.Drawing.Size(104, 16);
            this.checkin_cusNamelbl.TabIndex = 3;
            this.checkin_cusNamelbl.Text = "Customer Name";
            // 
            // checkin_carVertxt
            // 
            this.checkin_carVertxt.Location = new System.Drawing.Point(187, 205);
            this.checkin_carVertxt.Name = "checkin_carVertxt";
            this.checkin_carVertxt.Size = new System.Drawing.Size(180, 22);
            this.checkin_carVertxt.TabIndex = 1;
            // 
            // checkin_cbo
            // 
            this.checkin_cbo.FormattingEnabled = true;
            this.checkin_cbo.Items.AddRange(new object[] {
            "Check-In",
            "Check-Out"});
            this.checkin_cbo.Location = new System.Drawing.Point(187, 265);
            this.checkin_cbo.Name = "checkin_cbo";
            this.checkin_cbo.Size = new System.Drawing.Size(180, 24);
            this.checkin_cbo.TabIndex = 2;
            // 
            // checkin_Carnumtxt
            // 
            this.checkin_Carnumtxt.Location = new System.Drawing.Point(187, 149);
            this.checkin_Carnumtxt.Name = "checkin_Carnumtxt";
            this.checkin_Carnumtxt.Size = new System.Drawing.Size(180, 22);
            this.checkin_Carnumtxt.TabIndex = 1;
            // 
            // checkin_Cusnametxt
            // 
            this.checkin_Cusnametxt.Location = new System.Drawing.Point(187, 93);
            this.checkin_Cusnametxt.Name = "checkin_Cusnametxt";
            this.checkin_Cusnametxt.ReadOnly = true;
            this.checkin_Cusnametxt.Size = new System.Drawing.Size(180, 22);
            this.checkin_Cusnametxt.TabIndex = 0;
            // 
            // checkin_leftPanel
            // 
            this.checkin_leftPanel.Controls.Add(this.checkin_dataView);
            this.checkin_leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkin_leftPanel.Location = new System.Drawing.Point(0, 0);
            this.checkin_leftPanel.Name = "checkin_leftPanel";
            this.checkin_leftPanel.Size = new System.Drawing.Size(548, 519);
            this.checkin_leftPanel.TabIndex = 1;
            // 
            // checkin_dataView
            // 
            this.checkin_dataView.AllowUserToAddRows = false;
            this.checkin_dataView.AllowUserToDeleteRows = false;
            this.checkin_dataView.AllowUserToResizeRows = false;
            this.checkin_dataView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.checkin_dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.checkin_dataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cus_ID,
            this.CusName,
            this.CarNum,
            this.carVer,
            this.Service_ID,
            this.Service_status});
            this.checkin_dataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkin_dataView.Location = new System.Drawing.Point(0, 0);
            this.checkin_dataView.Name = "checkin_dataView";
            this.checkin_dataView.ReadOnly = true;
            this.checkin_dataView.RowHeadersVisible = false;
            this.checkin_dataView.RowHeadersWidth = 51;
            this.checkin_dataView.RowTemplate.Height = 24;
            this.checkin_dataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.checkin_dataView.Size = new System.Drawing.Size(548, 519);
            this.checkin_dataView.TabIndex = 0;
            this.checkin_dataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.checkin_dataView_CellContentClick);
            this.checkin_dataView.SelectionChanged += new System.EventHandler(this.checkin_dataView_SelectionChanged);
            // 
            // Cus_ID
            // 
            this.Cus_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Cus_ID.DataPropertyName = "customer_ID";
            this.Cus_ID.HeaderText = "Customer ID";
            this.Cus_ID.MinimumWidth = 6;
            this.Cus_ID.Name = "Cus_ID";
            this.Cus_ID.ReadOnly = true;
            this.Cus_ID.Width = 109;
            // 
            // CusName
            // 
            this.CusName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CusName.DataPropertyName = "customerUsername";
            this.CusName.HeaderText = "Name";
            this.CusName.MinimumWidth = 6;
            this.CusName.Name = "CusName";
            this.CusName.ReadOnly = true;
            // 
            // CarNum
            // 
            this.CarNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CarNum.DataPropertyName = "carNum";
            this.CarNum.HeaderText = "Car Plate Number";
            this.CarNum.MinimumWidth = 6;
            this.CarNum.Name = "CarNum";
            this.CarNum.ReadOnly = true;
            this.CarNum.Width = 130;
            // 
            // carVer
            // 
            this.carVer.DataPropertyName = "carVersion";
            this.carVer.HeaderText = "car version";
            this.carVer.MinimumWidth = 6;
            this.carVer.Name = "carVer";
            this.carVer.ReadOnly = true;
            this.carVer.Visible = false;
            this.carVer.Width = 125;
            // 
            // Service_ID
            // 
            this.Service_ID.DataPropertyName = "serviceAP_ID";
            this.Service_ID.HeaderText = "Service Ap ID";
            this.Service_ID.MinimumWidth = 6;
            this.Service_ID.Name = "Service_ID";
            this.Service_ID.ReadOnly = true;
            this.Service_ID.Visible = false;
            this.Service_ID.Width = 125;
            // 
            // Service_status
            // 
            this.Service_status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Service_status.DataPropertyName = "vehicleStatus";
            this.Service_status.HeaderText = "Service Status";
            this.Service_status.MinimumWidth = 6;
            this.Service_status.Name = "Service_status";
            this.Service_status.ReadOnly = true;
            this.Service_status.Width = 112;
            // 
            // CheckInOutF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 519);
            this.Controls.Add(this.checkin_leftPanel);
            this.Controls.Add(this.checkin_rightPanel);
            this.Name = "CheckInOutF";
            this.Text = "Check In and Check Out";
            this.Load += new System.EventHandler(this.CheckInOutF_Load);
            this.checkin_rightPanel.ResumeLayout(false);
            this.checkin_rightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reload_pict)).EndInit();
            this.checkin_leftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkin_dataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel checkin_rightPanel;
        private System.Windows.Forms.Panel checkin_leftPanel;
        private System.Windows.Forms.DataGridView checkin_dataView;
        private System.Windows.Forms.TextBox checkin_Carnumtxt;
        private System.Windows.Forms.TextBox checkin_Cusnametxt;
        private System.Windows.Forms.Label checkin_Statuslbl;
        private System.Windows.Forms.Label checkin_carnumlbl;
        private System.Windows.Forms.Label checkin_cusNamelbl;
        private System.Windows.Forms.ComboBox checkin_cbo;
        private System.Windows.Forms.Button checkin_Billbtn;
        private System.Windows.Forms.Button checkin_Upbtn;
        private System.Windows.Forms.Label checkin_carVer;
        private System.Windows.Forms.TextBox checkin_carVertxt;
        private System.Windows.Forms.PictureBox reload_pict;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cus_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn carVer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Service_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Service_status;
    }
}