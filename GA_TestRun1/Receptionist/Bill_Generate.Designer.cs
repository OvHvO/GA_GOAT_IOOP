namespace GA_TestRun1.Receptionist
{
    partial class Bill_Generate
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
            this.bill_headlbl = new System.Windows.Forms.Label();
            this.bill_logo = new System.Windows.Forms.PictureBox();
            this.bill_invoicelbl = new System.Windows.Forms.Label();
            this.first_divider = new System.Windows.Forms.Panel();
            this.bill_dateSign = new System.Windows.Forms.Label();
            this.bill_invoiceNumlbl = new System.Windows.Forms.Label();
            this.lbl_billTolbl = new System.Windows.Forms.Label();
            this.second_divider = new System.Windows.Forms.Panel();
            this.bill_idNumSignlbl = new System.Windows.Forms.Label();
            this.bill_nameSignlbl = new System.Windows.Forms.Label();
            this.bill_id = new System.Windows.Forms.Label();
            this.bill_name = new System.Windows.Forms.Label();
            this.bill_dataview = new System.Windows.Forms.DataGridView();
            this.bill_part = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bill_partName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billpartPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceAp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.task_ids = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bill_totAmtSign = new System.Windows.Forms.Label();
            this.subtotal_lbl = new System.Windows.Forms.Label();
            this.bill_datelbl = new System.Windows.Forms.Label();
            this.bill_invoiceNo = new System.Windows.Forms.Label();
            this.bill_dgvPartPanel = new System.Windows.Forms.Panel();
            this.bill_serviceData = new System.Windows.Forms.DataGridView();
            this.BService_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Service_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Service_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount_Given = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bill_servicelbl = new System.Windows.Forms.Label();
            this.bill_partUsedlbl = new System.Windows.Forms.Label();
            this.Note_panel = new System.Windows.Forms.Panel();
            this.bill_Notestxt = new System.Windows.Forms.RichTextBox();
            this.bill_carPlatenumlbl = new System.Windows.Forms.Label();
            this.carPlateNum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bill_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bill_dataview)).BeginInit();
            this.bill_dgvPartPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bill_serviceData)).BeginInit();
            this.Note_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bill_headlbl
            // 
            this.bill_headlbl.AutoSize = true;
            this.bill_headlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bill_headlbl.Location = new System.Drawing.Point(156, 83);
            this.bill_headlbl.Name = "bill_headlbl";
            this.bill_headlbl.Size = new System.Drawing.Size(402, 39);
            this.bill_headlbl.TabIndex = 0;
            this.bill_headlbl.Text = "CarCare Service Center";
            // 
            // bill_logo
            // 
            this.bill_logo.Image = global::GA_TestRun1.Properties.Resources.logo__4_;
            this.bill_logo.Location = new System.Drawing.Point(12, 52);
            this.bill_logo.Name = "bill_logo";
            this.bill_logo.Size = new System.Drawing.Size(116, 107);
            this.bill_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bill_logo.TabIndex = 1;
            this.bill_logo.TabStop = false;
            // 
            // bill_invoicelbl
            // 
            this.bill_invoicelbl.AutoSize = true;
            this.bill_invoicelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bill_invoicelbl.Location = new System.Drawing.Point(673, 35);
            this.bill_invoicelbl.Name = "bill_invoicelbl";
            this.bill_invoicelbl.Size = new System.Drawing.Size(196, 39);
            this.bill_invoicelbl.TabIndex = 2;
            this.bill_invoicelbl.Text = "  INVOICE ";
            // 
            // first_divider
            // 
            this.first_divider.BackColor = System.Drawing.SystemColors.HotTrack;
            this.first_divider.Location = new System.Drawing.Point(12, 165);
            this.first_divider.Name = "first_divider";
            this.first_divider.Size = new System.Drawing.Size(1001, 10);
            this.first_divider.TabIndex = 3;
            // 
            // bill_dateSign
            // 
            this.bill_dateSign.AutoSize = true;
            this.bill_dateSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bill_dateSign.Location = new System.Drawing.Point(659, 101);
            this.bill_dateSign.Name = "bill_dateSign";
            this.bill_dateSign.Size = new System.Drawing.Size(59, 17);
            this.bill_dateSign.TabIndex = 4;
            this.bill_dateSign.Text = "DATE: ";
            // 
            // bill_invoiceNumlbl
            // 
            this.bill_invoiceNumlbl.AutoSize = true;
            this.bill_invoiceNumlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bill_invoiceNumlbl.Location = new System.Drawing.Point(659, 142);
            this.bill_invoiceNumlbl.Name = "bill_invoiceNumlbl";
            this.bill_invoiceNumlbl.Size = new System.Drawing.Size(107, 17);
            this.bill_invoiceNumlbl.TabIndex = 5;
            this.bill_invoiceNumlbl.Text = "INVOICE NO.:";
            // 
            // lbl_billTolbl
            // 
            this.lbl_billTolbl.AutoSize = true;
            this.lbl_billTolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_billTolbl.Location = new System.Drawing.Point(12, 199);
            this.lbl_billTolbl.Name = "lbl_billTolbl";
            this.lbl_billTolbl.Size = new System.Drawing.Size(92, 20);
            this.lbl_billTolbl.TabIndex = 6;
            this.lbl_billTolbl.Text = "BILL TO: ";
            // 
            // second_divider
            // 
            this.second_divider.BackColor = System.Drawing.SystemColors.Highlight;
            this.second_divider.Location = new System.Drawing.Point(12, 222);
            this.second_divider.Name = "second_divider";
            this.second_divider.Size = new System.Drawing.Size(1001, 10);
            this.second_divider.TabIndex = 7;
            // 
            // bill_idNumSignlbl
            // 
            this.bill_idNumSignlbl.AutoSize = true;
            this.bill_idNumSignlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bill_idNumSignlbl.Location = new System.Drawing.Point(15, 249);
            this.bill_idNumSignlbl.Name = "bill_idNumSignlbl";
            this.bill_idNumSignlbl.Size = new System.Drawing.Size(40, 20);
            this.bill_idNumSignlbl.TabIndex = 8;
            this.bill_idNumSignlbl.Text = "ID: ";
            // 
            // bill_nameSignlbl
            // 
            this.bill_nameSignlbl.AutoSize = true;
            this.bill_nameSignlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bill_nameSignlbl.Location = new System.Drawing.Point(15, 283);
            this.bill_nameSignlbl.Name = "bill_nameSignlbl";
            this.bill_nameSignlbl.Size = new System.Drawing.Size(69, 20);
            this.bill_nameSignlbl.TabIndex = 9;
            this.bill_nameSignlbl.Text = "Name: ";
            // 
            // bill_id
            // 
            this.bill_id.AutoSize = true;
            this.bill_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bill_id.Location = new System.Drawing.Point(163, 249);
            this.bill_id.Name = "bill_id";
            this.bill_id.Size = new System.Drawing.Size(59, 20);
            this.bill_id.TabIndex = 10;
            this.bill_id.Text = "label7";
            // 
            // bill_name
            // 
            this.bill_name.AutoSize = true;
            this.bill_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bill_name.Location = new System.Drawing.Point(163, 283);
            this.bill_name.Name = "bill_name";
            this.bill_name.Size = new System.Drawing.Size(59, 20);
            this.bill_name.TabIndex = 11;
            this.bill_name.Text = "label8";
            // 
            // bill_dataview
            // 
            this.bill_dataview.AllowUserToAddRows = false;
            this.bill_dataview.AllowUserToDeleteRows = false;
            this.bill_dataview.AllowUserToResizeColumns = false;
            this.bill_dataview.AllowUserToResizeRows = false;
            this.bill_dataview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.bill_dataview.ColumnHeadersHeight = 48;
            this.bill_dataview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bill_part,
            this.bill_partName,
            this.partQty,
            this.billpartPrice,
            this.ServiceAp,
            this.task_ids});
            this.bill_dataview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bill_dataview.EnableHeadersVisualStyles = false;
            this.bill_dataview.Location = new System.Drawing.Point(0, 0);
            this.bill_dataview.Name = "bill_dataview";
            this.bill_dataview.ReadOnly = true;
            this.bill_dataview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.bill_dataview.RowHeadersVisible = false;
            this.bill_dataview.RowHeadersWidth = 51;
            this.bill_dataview.RowTemplate.Height = 24;
            this.bill_dataview.Size = new System.Drawing.Size(1001, 441);
            this.bill_dataview.TabIndex = 12;
            this.bill_dataview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bill_dataview_CellContentClick);
            // 
            // bill_part
            // 
            this.bill_part.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.bill_part.DataPropertyName = "part_ID";
            this.bill_part.Frozen = true;
            this.bill_part.HeaderText = "Part ID";
            this.bill_part.MinimumWidth = 6;
            this.bill_part.Name = "bill_part";
            this.bill_part.ReadOnly = true;
            this.bill_part.Width = 70;
            // 
            // bill_partName
            // 
            this.bill_partName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bill_partName.DataPropertyName = "partName";
            this.bill_partName.HeaderText = "Part Name";
            this.bill_partName.MinimumWidth = 6;
            this.bill_partName.Name = "bill_partName";
            this.bill_partName.ReadOnly = true;
            // 
            // partQty
            // 
            this.partQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.partQty.DataPropertyName = "requestPartQuantity";
            this.partQty.HeaderText = "Quantity";
            this.partQty.MinimumWidth = 6;
            this.partQty.Name = "partQty";
            this.partQty.ReadOnly = true;
            this.partQty.Width = 83;
            // 
            // billpartPrice
            // 
            this.billpartPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.billpartPrice.DataPropertyName = "partPrice";
            this.billpartPrice.HeaderText = "Price (PCS)";
            this.billpartPrice.MinimumWidth = 6;
            this.billpartPrice.Name = "billpartPrice";
            this.billpartPrice.ReadOnly = true;
            this.billpartPrice.Width = 96;
            // 
            // ServiceAp
            // 
            this.ServiceAp.DataPropertyName = "serviceAP_ID";
            this.ServiceAp.HeaderText = "Service Appoinment ID";
            this.ServiceAp.MinimumWidth = 6;
            this.ServiceAp.Name = "ServiceAp";
            this.ServiceAp.ReadOnly = true;
            this.ServiceAp.Visible = false;
            this.ServiceAp.Width = 125;
            // 
            // task_ids
            // 
            this.task_ids.DataPropertyName = "task_ID";
            this.task_ids.HeaderText = "Task ID";
            this.task_ids.MinimumWidth = 6;
            this.task_ids.Name = "task_ids";
            this.task_ids.ReadOnly = true;
            this.task_ids.Visible = false;
            this.task_ids.Width = 125;
            // 
            // bill_totAmtSign
            // 
            this.bill_totAmtSign.AutoSize = true;
            this.bill_totAmtSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bill_totAmtSign.Location = new System.Drawing.Point(552, 1406);
            this.bill_totAmtSign.Name = "bill_totAmtSign";
            this.bill_totAmtSign.Size = new System.Drawing.Size(192, 29);
            this.bill_totAmtSign.TabIndex = 13;
            this.bill_totAmtSign.Text = "Total Amount: ";
            // 
            // subtotal_lbl
            // 
            this.subtotal_lbl.AutoSize = true;
            this.subtotal_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotal_lbl.Location = new System.Drawing.Point(815, 1406);
            this.subtotal_lbl.Name = "subtotal_lbl";
            this.subtotal_lbl.Size = new System.Drawing.Size(102, 29);
            this.subtotal_lbl.TabIndex = 15;
            this.subtotal_lbl.Text = "label11";
            this.subtotal_lbl.Click += new System.EventHandler(this.subtotal_lbl_Click);
            // 
            // bill_datelbl
            // 
            this.bill_datelbl.AutoSize = true;
            this.bill_datelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bill_datelbl.Location = new System.Drawing.Point(816, 98);
            this.bill_datelbl.Name = "bill_datelbl";
            this.bill_datelbl.Size = new System.Drawing.Size(53, 20);
            this.bill_datelbl.TabIndex = 10;
            this.bill_datelbl.Text = "label7";
            // 
            // bill_invoiceNo
            // 
            this.bill_invoiceNo.AutoSize = true;
            this.bill_invoiceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bill_invoiceNo.Location = new System.Drawing.Point(816, 139);
            this.bill_invoiceNo.Name = "bill_invoiceNo";
            this.bill_invoiceNo.Size = new System.Drawing.Size(53, 20);
            this.bill_invoiceNo.TabIndex = 10;
            this.bill_invoiceNo.Text = "label7";
            // 
            // bill_dgvPartPanel
            // 
            this.bill_dgvPartPanel.Controls.Add(this.bill_dataview);
            this.bill_dgvPartPanel.Location = new System.Drawing.Point(12, 394);
            this.bill_dgvPartPanel.Name = "bill_dgvPartPanel";
            this.bill_dgvPartPanel.Size = new System.Drawing.Size(1001, 441);
            this.bill_dgvPartPanel.TabIndex = 19;
            // 
            // bill_serviceData
            // 
            this.bill_serviceData.AllowUserToAddRows = false;
            this.bill_serviceData.AllowUserToDeleteRows = false;
            this.bill_serviceData.AllowUserToResizeColumns = false;
            this.bill_serviceData.AllowUserToResizeRows = false;
            this.bill_serviceData.ColumnHeadersHeight = 48;
            this.bill_serviceData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BService_ID,
            this.Service_Name,
            this.Service_Price,
            this.Discount_Given});
            this.bill_serviceData.Location = new System.Drawing.Point(12, 893);
            this.bill_serviceData.Name = "bill_serviceData";
            this.bill_serviceData.ReadOnly = true;
            this.bill_serviceData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.bill_serviceData.RowHeadersVisible = false;
            this.bill_serviceData.RowHeadersWidth = 51;
            this.bill_serviceData.RowTemplate.Height = 24;
            this.bill_serviceData.Size = new System.Drawing.Size(1001, 491);
            this.bill_serviceData.TabIndex = 20;
            // 
            // BService_ID
            // 
            this.BService_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.BService_ID.DataPropertyName = "service_ID";
            this.BService_ID.HeaderText = "Service ID";
            this.BService_ID.MinimumWidth = 6;
            this.BService_ID.Name = "BService_ID";
            this.BService_ID.ReadOnly = true;
            this.BService_ID.Width = 91;
            // 
            // Service_Name
            // 
            this.Service_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Service_Name.DataPropertyName = "serviceName";
            this.Service_Name.HeaderText = "Service Name";
            this.Service_Name.MinimumWidth = 6;
            this.Service_Name.Name = "Service_Name";
            this.Service_Name.ReadOnly = true;
            // 
            // Service_Price
            // 
            this.Service_Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Service_Price.DataPropertyName = "servicePrice";
            this.Service_Price.HeaderText = "Price";
            this.Service_Price.MinimumWidth = 6;
            this.Service_Price.Name = "Service_Price";
            this.Service_Price.ReadOnly = true;
            this.Service_Price.Width = 67;
            // 
            // Discount_Given
            // 
            this.Discount_Given.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Discount_Given.DataPropertyName = "serviceOffer";
            this.Discount_Given.HeaderText = "Discount ";
            this.Discount_Given.MinimumWidth = 6;
            this.Discount_Given.Name = "Discount_Given";
            this.Discount_Given.ReadOnly = true;
            this.Discount_Given.Width = 91;
            // 
            // bill_servicelbl
            // 
            this.bill_servicelbl.AutoSize = true;
            this.bill_servicelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bill_servicelbl.Location = new System.Drawing.Point(15, 861);
            this.bill_servicelbl.Name = "bill_servicelbl";
            this.bill_servicelbl.Size = new System.Drawing.Size(84, 20);
            this.bill_servicelbl.TabIndex = 9;
            this.bill_servicelbl.Text = "Service :";
            // 
            // bill_partUsedlbl
            // 
            this.bill_partUsedlbl.AutoSize = true;
            this.bill_partUsedlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bill_partUsedlbl.Location = new System.Drawing.Point(12, 371);
            this.bill_partUsedlbl.Name = "bill_partUsedlbl";
            this.bill_partUsedlbl.Size = new System.Drawing.Size(105, 20);
            this.bill_partUsedlbl.TabIndex = 9;
            this.bill_partUsedlbl.Text = "Part Used: ";
            // 
            // Note_panel
            // 
            this.Note_panel.Controls.Add(this.bill_Notestxt);
            this.Note_panel.Location = new System.Drawing.Point(12, 1390);
            this.Note_panel.Name = "Note_panel";
            this.Note_panel.Size = new System.Drawing.Size(515, 234);
            this.Note_panel.TabIndex = 21;
            // 
            // bill_Notestxt
            // 
            this.bill_Notestxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bill_Notestxt.Enabled = false;
            this.bill_Notestxt.Location = new System.Drawing.Point(0, 0);
            this.bill_Notestxt.Name = "bill_Notestxt";
            this.bill_Notestxt.ReadOnly = true;
            this.bill_Notestxt.Size = new System.Drawing.Size(515, 234);
            this.bill_Notestxt.TabIndex = 0;
            this.bill_Notestxt.Text = "";
            this.bill_Notestxt.TextChanged += new System.EventHandler(this.bill_Notetxt_TextChanged);
            // 
            // bill_carPlatenumlbl
            // 
            this.bill_carPlatenumlbl.AutoSize = true;
            this.bill_carPlatenumlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bill_carPlatenumlbl.Location = new System.Drawing.Point(15, 322);
            this.bill_carPlatenumlbl.Name = "bill_carPlatenumlbl";
            this.bill_carPlatenumlbl.Size = new System.Drawing.Size(80, 20);
            this.bill_carPlatenumlbl.TabIndex = 9;
            this.bill_carPlatenumlbl.Text = "Car No: ";
            // 
            // carPlateNum
            // 
            this.carPlateNum.AutoSize = true;
            this.carPlateNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carPlateNum.Location = new System.Drawing.Point(163, 325);
            this.carPlateNum.Name = "carPlateNum";
            this.carPlateNum.Size = new System.Drawing.Size(59, 20);
            this.carPlateNum.TabIndex = 11;
            this.carPlateNum.Text = "label8";
            // 
            // Bill_Generate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1067, 1055);
            this.Controls.Add(this.Note_panel);
            this.Controls.Add(this.bill_serviceData);
            this.Controls.Add(this.bill_dgvPartPanel);
            this.Controls.Add(this.subtotal_lbl);
            this.Controls.Add(this.bill_totAmtSign);
            this.Controls.Add(this.carPlateNum);
            this.Controls.Add(this.bill_name);
            this.Controls.Add(this.bill_invoiceNo);
            this.Controls.Add(this.bill_datelbl);
            this.Controls.Add(this.bill_id);
            this.Controls.Add(this.bill_partUsedlbl);
            this.Controls.Add(this.bill_servicelbl);
            this.Controls.Add(this.bill_carPlatenumlbl);
            this.Controls.Add(this.bill_nameSignlbl);
            this.Controls.Add(this.bill_idNumSignlbl);
            this.Controls.Add(this.lbl_billTolbl);
            this.Controls.Add(this.second_divider);
            this.Controls.Add(this.bill_invoiceNumlbl);
            this.Controls.Add(this.bill_dateSign);
            this.Controls.Add(this.first_divider);
            this.Controls.Add(this.bill_invoicelbl);
            this.Controls.Add(this.bill_logo);
            this.Controls.Add(this.bill_headlbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Bill_Generate";
            this.Text = "Bill ";
            this.Load += new System.EventHandler(this.Bill_Generate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bill_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bill_dataview)).EndInit();
            this.bill_dgvPartPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bill_serviceData)).EndInit();
            this.Note_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bill_headlbl;
        private System.Windows.Forms.PictureBox bill_logo;
        private System.Windows.Forms.Label bill_invoicelbl;
        private System.Windows.Forms.Panel first_divider;
        private System.Windows.Forms.Label bill_dateSign;
        private System.Windows.Forms.Label bill_invoiceNumlbl;
        private System.Windows.Forms.Label lbl_billTolbl;
        private System.Windows.Forms.Panel second_divider;
        private System.Windows.Forms.Label bill_idNumSignlbl;
        private System.Windows.Forms.Label bill_nameSignlbl;
        private System.Windows.Forms.Label bill_id;
        private System.Windows.Forms.Label bill_name;
        private System.Windows.Forms.DataGridView bill_dataview;
        private System.Windows.Forms.Label subtotal_lbl;
        private System.Windows.Forms.Label bill_datelbl;
        private System.Windows.Forms.Label bill_invoiceNo;
        private System.Windows.Forms.Panel bill_dgvPartPanel;
        private System.Windows.Forms.DataGridView bill_serviceData;
        private System.Windows.Forms.Label bill_servicelbl;
        private System.Windows.Forms.Label bill_partUsedlbl;
        private System.Windows.Forms.Panel Note_panel;
        private System.Windows.Forms.RichTextBox bill_Notestxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn BService_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Service_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Service_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount_Given;
        private System.Windows.Forms.DataGridViewTextBoxColumn bill_part;
        private System.Windows.Forms.DataGridViewTextBoxColumn bill_partName;
        private System.Windows.Forms.DataGridViewTextBoxColumn partQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn billpartPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceAp;
        private System.Windows.Forms.DataGridViewTextBoxColumn task_ids;
        private System.Windows.Forms.Label bill_carPlatenumlbl;
        private System.Windows.Forms.Label carPlateNum;
        private System.Windows.Forms.Label bill_totAmtSign;
    }
}