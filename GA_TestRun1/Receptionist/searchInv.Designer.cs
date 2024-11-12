namespace GA_TestRun1.Receptionist
{
    partial class searchInv
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
            this.searchInv_panel = new System.Windows.Forms.Panel();
            this.Request_combtn = new System.Windows.Forms.Button();
            this.Src_Invbtn = new System.Windows.Forms.Button();
            this.Invsrc_txt = new System.Windows.Forms.TextBox();
            this.SearchInvcb = new System.Windows.Forms.ComboBox();
            this.InvsearchCb_lbl = new System.Windows.Forms.Label();
            this.Invsearch_lbl = new System.Windows.Forms.Label();
            this.InvDataView = new System.Windows.Forms.DataGridView();
            this.Request_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Part_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mechanic_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Part_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Request_Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.request_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchInv_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InvDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchInv_panel
            // 
            this.searchInv_panel.Controls.Add(this.Src_Invbtn);
            this.searchInv_panel.Controls.Add(this.Invsrc_txt);
            this.searchInv_panel.Controls.Add(this.SearchInvcb);
            this.searchInv_panel.Controls.Add(this.InvsearchCb_lbl);
            this.searchInv_panel.Controls.Add(this.Invsearch_lbl);
            this.searchInv_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchInv_panel.Location = new System.Drawing.Point(0, 0);
            this.searchInv_panel.Name = "searchInv_panel";
            this.searchInv_panel.Size = new System.Drawing.Size(1007, 77);
            this.searchInv_panel.TabIndex = 0;
            this.searchInv_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.searchInv_panel_Paint);
            // 
            // Request_combtn
            // 
            this.Request_combtn.Location = new System.Drawing.Point(456, 441);
            this.Request_combtn.Name = "Request_combtn";
            this.Request_combtn.Size = new System.Drawing.Size(82, 33);
            this.Request_combtn.TabIndex = 5;
            this.Request_combtn.Text = "Confirm";
            this.Request_combtn.UseVisualStyleBackColor = true;
            this.Request_combtn.Click += new System.EventHandler(this.Request_combtn_Click);
            // 
            // Src_Invbtn
            // 
            this.Src_Invbtn.Location = new System.Drawing.Point(889, 26);
            this.Src_Invbtn.Name = "Src_Invbtn";
            this.Src_Invbtn.Size = new System.Drawing.Size(79, 30);
            this.Src_Invbtn.TabIndex = 4;
            this.Src_Invbtn.Text = "Search";
            this.Src_Invbtn.UseVisualStyleBackColor = true;
            this.Src_Invbtn.Click += new System.EventHandler(this.Src_Invbtn_Click);
            // 
            // Invsrc_txt
            // 
            this.Invsrc_txt.Location = new System.Drawing.Point(713, 30);
            this.Invsrc_txt.Name = "Invsrc_txt";
            this.Invsrc_txt.Size = new System.Drawing.Size(154, 22);
            this.Invsrc_txt.TabIndex = 3;
            // 
            // SearchInvcb
            // 
            this.SearchInvcb.FormattingEnabled = true;
            this.SearchInvcb.Items.AddRange(new object[] {
            "Request ID",
            "Status"});
            this.SearchInvcb.Location = new System.Drawing.Point(136, 28);
            this.SearchInvcb.Name = "SearchInvcb";
            this.SearchInvcb.Size = new System.Drawing.Size(142, 24);
            this.SearchInvcb.TabIndex = 2;
            // 
            // InvsearchCb_lbl
            // 
            this.InvsearchCb_lbl.AutoSize = true;
            this.InvsearchCb_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvsearchCb_lbl.Location = new System.Drawing.Point(22, 30);
            this.InvsearchCb_lbl.Name = "InvsearchCb_lbl";
            this.InvsearchCb_lbl.Size = new System.Drawing.Size(108, 20);
            this.InvsearchCb_lbl.TabIndex = 1;
            this.InvsearchCb_lbl.Text = "Search By: ";
            // 
            // Invsearch_lbl
            // 
            this.Invsearch_lbl.AutoSize = true;
            this.Invsearch_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Invsearch_lbl.Location = new System.Drawing.Point(598, 31);
            this.Invsearch_lbl.Name = "Invsearch_lbl";
            this.Invsearch_lbl.Size = new System.Drawing.Size(80, 20);
            this.Invsearch_lbl.TabIndex = 0;
            this.Invsearch_lbl.Text = "Search: ";
            // 
            // InvDataView
            // 
            this.InvDataView.AllowUserToAddRows = false;
            this.InvDataView.AllowUserToDeleteRows = false;
            this.InvDataView.AllowUserToResizeColumns = false;
            this.InvDataView.AllowUserToResizeRows = false;
            this.InvDataView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.InvDataView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InvDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.InvDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InvDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Request_id,
            this.Part_ID,
            this.Mechanic_ID,
            this.Part_Name,
            this.Request_Qty,
            this.request_status});
            this.InvDataView.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.InvDataView.Location = new System.Drawing.Point(0, 77);
            this.InvDataView.Name = "InvDataView";
            this.InvDataView.ReadOnly = true;
            this.InvDataView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.InvDataView.RowHeadersVisible = false;
            this.InvDataView.RowHeadersWidth = 51;
            this.InvDataView.RowTemplate.Height = 24;
            this.InvDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InvDataView.Size = new System.Drawing.Size(1014, 346);
            this.InvDataView.TabIndex = 1;
            this.InvDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InvDataView_CellContentClick);
            // 
            // Request_id
            // 
            this.Request_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Request_id.DataPropertyName = "request_ID";
            this.Request_id.HeaderText = "Request ID";
            this.Request_id.MinimumWidth = 6;
            this.Request_id.Name = "Request_id";
            this.Request_id.ReadOnly = true;
            this.Request_id.Width = 95;
            // 
            // Part_ID
            // 
            this.Part_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Part_ID.DataPropertyName = "part_ID";
            this.Part_ID.HeaderText = "Part ID";
            this.Part_ID.MinimumWidth = 6;
            this.Part_ID.Name = "Part_ID";
            this.Part_ID.ReadOnly = true;
            this.Part_ID.Width = 71;
            // 
            // Mechanic_ID
            // 
            this.Mechanic_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Mechanic_ID.DataPropertyName = "mechanic_ID";
            this.Mechanic_ID.HeaderText = "Mechanic ID";
            this.Mechanic_ID.MinimumWidth = 6;
            this.Mechanic_ID.Name = "Mechanic_ID";
            this.Mechanic_ID.ReadOnly = true;
            this.Mechanic_ID.Width = 101;
            // 
            // Part_Name
            // 
            this.Part_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Part_Name.DataPropertyName = "partName";
            this.Part_Name.HeaderText = "Part Name";
            this.Part_Name.MinimumWidth = 6;
            this.Part_Name.Name = "Part_Name";
            this.Part_Name.ReadOnly = true;
            // 
            // Request_Qty
            // 
            this.Request_Qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Request_Qty.DataPropertyName = "requestPartQuantity";
            this.Request_Qty.HeaderText = "Request Quantity";
            this.Request_Qty.MinimumWidth = 6;
            this.Request_Qty.Name = "Request_Qty";
            this.Request_Qty.ReadOnly = true;
            this.Request_Qty.Width = 127;
            // 
            // request_status
            // 
            this.request_status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.request_status.DataPropertyName = "rrequestStatus";
            this.request_status.HeaderText = "Status";
            this.request_status.MinimumWidth = 6;
            this.request_status.Name = "request_status";
            this.request_status.ReadOnly = true;
            this.request_status.Width = 73;
            // 
            // searchInv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 486);
            this.Controls.Add(this.Request_combtn);
            this.Controls.Add(this.InvDataView);
            this.Controls.Add(this.searchInv_panel);
            this.Name = "searchInv";
            this.Text = "searchInv";
            this.Load += new System.EventHandler(this.searchInv_Load);
            this.searchInv_panel.ResumeLayout(false);
            this.searchInv_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InvDataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel searchInv_panel;
        private System.Windows.Forms.DataGridView InvDataView;
        private System.Windows.Forms.TextBox Invsrc_txt;
        private System.Windows.Forms.ComboBox SearchInvcb;
        private System.Windows.Forms.Label InvsearchCb_lbl;
        private System.Windows.Forms.Label Invsearch_lbl;
        private System.Windows.Forms.Button Src_Invbtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Request_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Part_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mechanic_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Part_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Request_Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn request_status;
        private System.Windows.Forms.Button Request_combtn;
    }
}