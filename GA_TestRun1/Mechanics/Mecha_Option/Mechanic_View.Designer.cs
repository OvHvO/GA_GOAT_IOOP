namespace GA_TestRun1.Mechanics.Mecha_Option
{
    partial class Mechanic_View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mechanic_View));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rcp_appoimentBar = new System.Windows.Forms.Panel();
            this.Reload_pic = new System.Windows.Forms.PictureBox();
            this.scr_lbl = new System.Windows.Forms.Label();
            this.SearchCbo_lbl = new System.Windows.Forms.Label();
            this.Mcn_searchbtn = new System.Windows.Forms.Button();
            this.Search_txt = new System.Windows.Forms.TextBox();
            this.Search_Cbo = new System.Windows.Forms.ComboBox();
            this.Mcn_GridView = new System.Windows.Forms.DataGridView();
            this.CusID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.App_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cus_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cus_contactNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vechi_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MecName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reshedule_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rcp_appoimentBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Reload_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mcn_GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // rcp_appoimentBar
            // 
            this.rcp_appoimentBar.Controls.Add(this.Reload_pic);
            this.rcp_appoimentBar.Controls.Add(this.scr_lbl);
            this.rcp_appoimentBar.Controls.Add(this.SearchCbo_lbl);
            this.rcp_appoimentBar.Controls.Add(this.Mcn_searchbtn);
            this.rcp_appoimentBar.Controls.Add(this.Search_txt);
            this.rcp_appoimentBar.Controls.Add(this.Search_Cbo);
            this.rcp_appoimentBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.rcp_appoimentBar.Location = new System.Drawing.Point(0, 0);
            this.rcp_appoimentBar.Margin = new System.Windows.Forms.Padding(2);
            this.rcp_appoimentBar.Name = "rcp_appoimentBar";
            this.rcp_appoimentBar.Size = new System.Drawing.Size(729, 53);
            this.rcp_appoimentBar.TabIndex = 4;
            // 
            // Reload_pic
            // 
            this.Reload_pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reload_pic.Image = ((System.Drawing.Image)(resources.GetObject("Reload_pic.Image")));
            this.Reload_pic.Location = new System.Drawing.Point(695, 20);
            this.Reload_pic.Margin = new System.Windows.Forms.Padding(2);
            this.Reload_pic.Name = "Reload_pic";
            this.Reload_pic.Size = new System.Drawing.Size(25, 27);
            this.Reload_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Reload_pic.TabIndex = 5;
            this.Reload_pic.TabStop = false;
            // 
            // scr_lbl
            // 
            this.scr_lbl.AutoSize = true;
            this.scr_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scr_lbl.Location = new System.Drawing.Point(336, 30);
            this.scr_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.scr_lbl.Name = "scr_lbl";
            this.scr_lbl.Size = new System.Drawing.Size(69, 17);
            this.scr_lbl.TabIndex = 4;
            this.scr_lbl.Text = "Search: ";
            // 
            // SearchCbo_lbl
            // 
            this.SearchCbo_lbl.AutoSize = true;
            this.SearchCbo_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchCbo_lbl.Location = new System.Drawing.Point(2, 27);
            this.SearchCbo_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SearchCbo_lbl.Name = "SearchCbo_lbl";
            this.SearchCbo_lbl.Size = new System.Drawing.Size(92, 17);
            this.SearchCbo_lbl.TabIndex = 3;
            this.SearchCbo_lbl.Text = "Search By: ";
            // 
            // Mcn_searchbtn
            // 
            this.Mcn_searchbtn.Location = new System.Drawing.Point(598, 28);
            this.Mcn_searchbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Mcn_searchbtn.Name = "Mcn_searchbtn";
            this.Mcn_searchbtn.Size = new System.Drawing.Size(74, 19);
            this.Mcn_searchbtn.TabIndex = 2;
            this.Mcn_searchbtn.Text = "Search";
            this.Mcn_searchbtn.UseVisualStyleBackColor = true;
            this.Mcn_searchbtn.Click += new System.EventHandler(this.Mcn_searchbtn_Click);
            // 
            // Search_txt
            // 
            this.Search_txt.Location = new System.Drawing.Point(412, 28);
            this.Search_txt.Margin = new System.Windows.Forms.Padding(2);
            this.Search_txt.Name = "Search_txt";
            this.Search_txt.Size = new System.Drawing.Size(182, 20);
            this.Search_txt.TabIndex = 1;
            // 
            // Search_Cbo
            // 
            this.Search_Cbo.FormattingEnabled = true;
            this.Search_Cbo.Items.AddRange(new object[] {
            "Appoinment ID",
            "Customer Name",
            "Vehicle Number"});
            this.Search_Cbo.Location = new System.Drawing.Point(102, 27);
            this.Search_Cbo.Margin = new System.Windows.Forms.Padding(2);
            this.Search_Cbo.Name = "Search_Cbo";
            this.Search_Cbo.Size = new System.Drawing.Size(131, 21);
            this.Search_Cbo.TabIndex = 0;
            this.Search_Cbo.SelectedIndexChanged += new System.EventHandler(this.Search_Cbo_SelectedIndexChanged);
            // 
            // Mcn_GridView
            // 
            this.Mcn_GridView.AllowUserToAddRows = false;
            this.Mcn_GridView.AllowUserToDeleteRows = false;
            this.Mcn_GridView.AllowUserToResizeColumns = false;
            this.Mcn_GridView.AllowUserToResizeRows = false;
            this.Mcn_GridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Mcn_GridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Mcn_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Mcn_GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CusID,
            this.App_id,
            this.Cus_name,
            this.Cus_contactNum,
            this.Vechi_num,
            this.MecName,
            this.Reshedule_Status,
            this.TaskContent});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Mcn_GridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.Mcn_GridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mcn_GridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.Mcn_GridView.Location = new System.Drawing.Point(0, 53);
            this.Mcn_GridView.Margin = new System.Windows.Forms.Padding(2);
            this.Mcn_GridView.Name = "Mcn_GridView";
            this.Mcn_GridView.ReadOnly = true;
            this.Mcn_GridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Mcn_GridView.RowHeadersVisible = false;
            this.Mcn_GridView.RowHeadersWidth = 51;
            this.Mcn_GridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Mcn_GridView.RowTemplate.Height = 24;
            this.Mcn_GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Mcn_GridView.Size = new System.Drawing.Size(729, 344);
            this.Mcn_GridView.TabIndex = 5;
            // 
            // CusID
            // 
            this.CusID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CusID.DataPropertyName = "customer_ID";
            this.CusID.HeaderText = "Customer ID";
            this.CusID.MinimumWidth = 6;
            this.CusID.Name = "CusID";
            this.CusID.ReadOnly = true;
            this.CusID.Width = 83;
            // 
            // App_id
            // 
            this.App_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.App_id.DataPropertyName = "serviceAP_ID";
            this.App_id.HeaderText = "Appoiment ID";
            this.App_id.MinimumWidth = 6;
            this.App_id.Name = "App_id";
            this.App_id.ReadOnly = true;
            this.App_id.Width = 88;
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
            // 
            // Vechi_num
            // 
            this.Vechi_num.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Vechi_num.DataPropertyName = "carNum";
            this.Vechi_num.HeaderText = "Vehicle Number";
            this.Vechi_num.MinimumWidth = 6;
            this.Vechi_num.Name = "Vechi_num";
            this.Vechi_num.ReadOnly = true;
            this.Vechi_num.Width = 98;
            // 
            // MecName
            // 
            this.MecName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MecName.DataPropertyName = "mechanic_ID";
            this.MecName.HeaderText = "Mechanic ID";
            this.MecName.MinimumWidth = 6;
            this.MecName.Name = "MecName";
            this.MecName.ReadOnly = true;
            this.MecName.Width = 86;
            // 
            // Reshedule_Status
            // 
            this.Reshedule_Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Reshedule_Status.DataPropertyName = "rescheduleStatus";
            this.Reshedule_Status.HeaderText = "Rschedule Status ";
            this.Reshedule_Status.MinimumWidth = 6;
            this.Reshedule_Status.Name = "Reshedule_Status";
            this.Reshedule_Status.ReadOnly = true;
            this.Reshedule_Status.Width = 109;
            // 
            // TaskContent
            // 
            this.TaskContent.DataPropertyName = "taskContent";
            this.TaskContent.HeaderText = "Task Detail";
            this.TaskContent.Name = "TaskContent";
            this.TaskContent.ReadOnly = true;
            // 
            // Mechanic_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 397);
            this.Controls.Add(this.Mcn_GridView);
            this.Controls.Add(this.rcp_appoimentBar);
            this.Name = "Mechanic_View";
            this.Text = "Mechanic_View";
            this.Load += new System.EventHandler(this.Mechanic_View_Load);
            this.rcp_appoimentBar.ResumeLayout(false);
            this.rcp_appoimentBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Reload_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mcn_GridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel rcp_appoimentBar;
        private System.Windows.Forms.PictureBox Reload_pic;
        private System.Windows.Forms.Label scr_lbl;
        private System.Windows.Forms.Label SearchCbo_lbl;
        private System.Windows.Forms.Button Mcn_searchbtn;
        private System.Windows.Forms.TextBox Search_txt;
        private System.Windows.Forms.ComboBox Search_Cbo;
        private System.Windows.Forms.DataGridView Mcn_GridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn CusID;
        private System.Windows.Forms.DataGridViewTextBoxColumn App_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cus_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cus_contactNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vechi_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn MecName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reshedule_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskContent;
    }
}