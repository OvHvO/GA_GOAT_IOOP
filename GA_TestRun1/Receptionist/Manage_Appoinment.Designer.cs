namespace GA_TestRun1.Receptionist
{
    partial class Manage_Appoinment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage_Appoinment));
            this.Rcp_dataview = new System.Windows.Forms.DataGridView();
            this.CusID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.App_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cus_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cus_contactNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vechi_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MecName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Task_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reshedule_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rcp_appoimentBar = new System.Windows.Forms.Panel();
            this.Inv_hintlbl = new System.Windows.Forms.Label();
            this.reload_pict = new System.Windows.Forms.PictureBox();
            this.scr_lbl = new System.Windows.Forms.Label();
            this.SearchCBO_lbl = new System.Windows.Forms.Label();
            this.Rcp_searchbtn = new System.Windows.Forms.Button();
            this.Search_txtb = new System.Windows.Forms.TextBox();
            this.Search_cbo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Rcp_dataview)).BeginInit();
            this.rcp_appoimentBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reload_pict)).BeginInit();
            this.SuspendLayout();
            // 
            // Rcp_dataview
            // 
            this.Rcp_dataview.AllowUserToDeleteRows = false;
            this.Rcp_dataview.AllowUserToResizeColumns = false;
            this.Rcp_dataview.AllowUserToResizeRows = false;
            this.Rcp_dataview.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Rcp_dataview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Rcp_dataview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Rcp_dataview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CusID,
            this.App_id,
            this.Cus_name,
            this.Cus_contactNum,
            this.Vechi_num,
            this.MecName,
            this.Task_status,
            this.Reshedule_Status});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Rcp_dataview.DefaultCellStyle = dataGridViewCellStyle2;
            this.Rcp_dataview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Rcp_dataview.GridColor = System.Drawing.SystemColors.ControlLight;
            this.Rcp_dataview.Location = new System.Drawing.Point(0, 65);
            this.Rcp_dataview.Name = "Rcp_dataview";
            this.Rcp_dataview.ReadOnly = true;
            this.Rcp_dataview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Rcp_dataview.RowHeadersVisible = false;
            this.Rcp_dataview.RowHeadersWidth = 51;
            this.Rcp_dataview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Rcp_dataview.RowTemplate.Height = 24;
            this.Rcp_dataview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Rcp_dataview.Size = new System.Drawing.Size(1039, 462);
            this.Rcp_dataview.TabIndex = 3;
            this.Rcp_dataview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Rcp_dataview_CellContentClick_1);
            this.Rcp_dataview.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Rcp_dataview_CellContentDoubleClick);
            // 
            // CusID
            // 
            this.CusID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CusID.DataPropertyName = "customer_ID";
            this.CusID.HeaderText = "Customer ID";
            this.CusID.MinimumWidth = 6;
            this.CusID.Name = "CusID";
            this.CusID.ReadOnly = true;
            this.CusID.Width = 101;
            // 
            // App_id
            // 
            this.App_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.App_id.DataPropertyName = "serviceAP_ID";
            this.App_id.HeaderText = "Appointment ID";
            this.App_id.MinimumWidth = 6;
            this.App_id.Name = "App_id";
            this.App_id.ReadOnly = true;
            this.App_id.Width = 117;
            // 
            // Cus_name
            // 
            this.Cus_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cus_name.DataPropertyName = "customerUsername";
            this.Cus_name.HeaderText = "Customer Name";
            this.Cus_name.MinimumWidth = 6;
            this.Cus_name.Name = "Cus_name";
            this.Cus_name.ReadOnly = true;
            // 
            // Cus_contactNum
            // 
            this.Cus_contactNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Cus_contactNum.DataPropertyName = "customerContactNum";
            this.Cus_contactNum.HeaderText = "Contact Number";
            this.Cus_contactNum.MinimumWidth = 6;
            this.Cus_contactNum.Name = "Cus_contactNum";
            this.Cus_contactNum.ReadOnly = true;
            this.Cus_contactNum.Width = 121;
            // 
            // Vechi_num
            // 
            this.Vechi_num.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Vechi_num.DataPropertyName = "carNum";
            this.Vechi_num.HeaderText = "Vehicle Number";
            this.Vechi_num.MinimumWidth = 6;
            this.Vechi_num.Name = "Vechi_num";
            this.Vechi_num.ReadOnly = true;
            this.Vechi_num.Width = 121;
            // 
            // MecName
            // 
            this.MecName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MecName.DataPropertyName = "mechanic_ID";
            this.MecName.HeaderText = "Mechanic ID";
            this.MecName.MinimumWidth = 6;
            this.MecName.Name = "MecName";
            this.MecName.ReadOnly = true;
            this.MecName.Width = 101;
            // 
            // Task_status
            // 
            this.Task_status.DataPropertyName = "taskStatus";
            this.Task_status.HeaderText = "Task Status";
            this.Task_status.MinimumWidth = 6;
            this.Task_status.Name = "Task_status";
            this.Task_status.ReadOnly = true;
            this.Task_status.Width = 125;
            // 
            // Reshedule_Status
            // 
            this.Reshedule_Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Reshedule_Status.DataPropertyName = "rescheduleStatus";
            this.Reshedule_Status.HeaderText = "Rschedule Status ";
            this.Reshedule_Status.MinimumWidth = 6;
            this.Reshedule_Status.Name = "Reshedule_Status";
            this.Reshedule_Status.ReadOnly = true;
            this.Reshedule_Status.Width = 132;
            // 
            // rcp_appoimentBar
            // 
            this.rcp_appoimentBar.Controls.Add(this.Inv_hintlbl);
            this.rcp_appoimentBar.Controls.Add(this.reload_pict);
            this.rcp_appoimentBar.Controls.Add(this.scr_lbl);
            this.rcp_appoimentBar.Controls.Add(this.SearchCBO_lbl);
            this.rcp_appoimentBar.Controls.Add(this.Rcp_searchbtn);
            this.rcp_appoimentBar.Controls.Add(this.Search_txtb);
            this.rcp_appoimentBar.Controls.Add(this.Search_cbo);
            this.rcp_appoimentBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.rcp_appoimentBar.Location = new System.Drawing.Point(0, 0);
            this.rcp_appoimentBar.Name = "rcp_appoimentBar";
            this.rcp_appoimentBar.Size = new System.Drawing.Size(1039, 65);
            this.rcp_appoimentBar.TabIndex = 2;
            // 
            // Inv_hintlbl
            // 
            this.Inv_hintlbl.AutoSize = true;
            this.Inv_hintlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inv_hintlbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Inv_hintlbl.Location = new System.Drawing.Point(4, 13);
            this.Inv_hintlbl.Name = "Inv_hintlbl";
            this.Inv_hintlbl.Size = new System.Drawing.Size(346, 17);
            this.Inv_hintlbl.TabIndex = 7;
            this.Inv_hintlbl.Text = "Hint: Please Double Click a detail to Assign Mechanic ";
            // 
            // reload_pict
            // 
            this.reload_pict.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reload_pict.Image = ((System.Drawing.Image)(resources.GetObject("reload_pict.Image")));
            this.reload_pict.Location = new System.Drawing.Point(927, 24);
            this.reload_pict.Name = "reload_pict";
            this.reload_pict.Size = new System.Drawing.Size(33, 33);
            this.reload_pict.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.reload_pict.TabIndex = 5;
            this.reload_pict.TabStop = false;
            this.reload_pict.Click += new System.EventHandler(this.reload_pict_Click);
            // 
            // scr_lbl
            // 
            this.scr_lbl.AutoSize = true;
            this.scr_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scr_lbl.Location = new System.Drawing.Point(448, 37);
            this.scr_lbl.Name = "scr_lbl";
            this.scr_lbl.Size = new System.Drawing.Size(80, 20);
            this.scr_lbl.TabIndex = 4;
            this.scr_lbl.Text = "Search: ";
            // 
            // SearchCBO_lbl
            // 
            this.SearchCBO_lbl.AutoSize = true;
            this.SearchCBO_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchCBO_lbl.Location = new System.Drawing.Point(3, 33);
            this.SearchCBO_lbl.Name = "SearchCBO_lbl";
            this.SearchCBO_lbl.Size = new System.Drawing.Size(108, 20);
            this.SearchCBO_lbl.TabIndex = 3;
            this.SearchCBO_lbl.Text = "Search By: ";
            // 
            // Rcp_searchbtn
            // 
            this.Rcp_searchbtn.Location = new System.Drawing.Point(797, 34);
            this.Rcp_searchbtn.Name = "Rcp_searchbtn";
            this.Rcp_searchbtn.Size = new System.Drawing.Size(98, 23);
            this.Rcp_searchbtn.TabIndex = 2;
            this.Rcp_searchbtn.Text = "Search";
            this.Rcp_searchbtn.UseVisualStyleBackColor = true;
            this.Rcp_searchbtn.Click += new System.EventHandler(this.Rcp_searchbtn_Click_1);
            // 
            // Search_txtb
            // 
            this.Search_txtb.Location = new System.Drawing.Point(550, 35);
            this.Search_txtb.Name = "Search_txtb";
            this.Search_txtb.Size = new System.Drawing.Size(241, 22);
            this.Search_txtb.TabIndex = 1;
            this.Search_txtb.TextChanged += new System.EventHandler(this.Search_txtb_TextChanged);
            // 
            // Search_cbo
            // 
            this.Search_cbo.FormattingEnabled = true;
            this.Search_cbo.Items.AddRange(new object[] {
            "Appointment ID",
            "Customer Name",
            "Vehicle Number"});
            this.Search_cbo.Location = new System.Drawing.Point(136, 33);
            this.Search_cbo.Name = "Search_cbo";
            this.Search_cbo.Size = new System.Drawing.Size(173, 24);
            this.Search_cbo.TabIndex = 0;
            this.Search_cbo.SelectedIndexChanged += new System.EventHandler(this.Search_cbo_SelectedIndexChanged);
            // 
            // Manage_Appoinment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 527);
            this.Controls.Add(this.Rcp_dataview);
            this.Controls.Add(this.rcp_appoimentBar);
            this.Name = "Manage_Appoinment";
            this.Text = "Manage Appointment";
            this.Load += new System.EventHandler(this.Manage_Appoinment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Rcp_dataview)).EndInit();
            this.rcp_appoimentBar.ResumeLayout(false);
            this.rcp_appoimentBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reload_pict)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Rcp_dataview;
        private System.Windows.Forms.Panel rcp_appoimentBar;
        private System.Windows.Forms.Label scr_lbl;
        private System.Windows.Forms.Label SearchCBO_lbl;
        private System.Windows.Forms.Button Rcp_searchbtn;
        private System.Windows.Forms.TextBox Search_txtb;
        private System.Windows.Forms.ComboBox Search_cbo;
        private System.Windows.Forms.PictureBox reload_pict;
        private System.Windows.Forms.Label Inv_hintlbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn CusID;
        private System.Windows.Forms.DataGridViewTextBoxColumn App_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cus_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cus_contactNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vechi_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn MecName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Task_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reshedule_Status;
    }
}