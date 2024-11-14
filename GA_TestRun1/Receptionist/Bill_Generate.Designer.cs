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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bill_id = new System.Windows.Forms.Label();
            this.bill_name = new System.Windows.Forms.Label();
            this.bill_dataview = new System.Windows.Forms.DataGridView();
            this.bill_part = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bill_partName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billpartPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceAp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.task_ids = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.subtotal_lbl = new System.Windows.Forms.Label();
            this.bill_datelbl = new System.Windows.Forms.Label();
            this.bill_invoiceNo = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bill_serviceData = new System.Windows.Forms.DataGridView();
            this.BService_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Service_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Service_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount_Given = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bill_Notestxt = new System.Windows.Forms.RichTextBox();
            this.bill_carPlatenumlbl = new System.Windows.Forms.Label();
            this.carPlateNum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bill_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bill_dataview)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bill_serviceData)).BeginInit();
            this.panel4.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(673, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "  INVOICE ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Location = new System.Drawing.Point(12, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1001, 10);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(659, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "DATE: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(659, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "INVOICE NO.:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "BILL TO: ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Location = new System.Drawing.Point(12, 222);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1001, 10);
            this.panel2.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "ID: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Name: ";
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(552, 1406);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(192, 29);
            this.label9.TabIndex = 13;
            this.label9.Text = "Total Amount: ";
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
            // panel3
            // 
            this.panel3.Controls.Add(this.bill_dataview);
            this.panel3.Location = new System.Drawing.Point(12, 394);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1001, 441);
            this.panel3.TabIndex = 19;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 861);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Service :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 371);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Part Used: ";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.bill_Notestxt);
            this.panel4.Location = new System.Drawing.Point(12, 1390);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(515, 234);
            this.panel4.TabIndex = 21;
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
            this.ClientSize = new System.Drawing.Size(1046, 1055);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.bill_serviceData);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.subtotal_lbl);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.carPlateNum);
            this.Controls.Add(this.bill_name);
            this.Controls.Add(this.bill_invoiceNo);
            this.Controls.Add(this.bill_datelbl);
            this.Controls.Add(this.bill_id);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bill_carPlatenumlbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bill_logo);
            this.Controls.Add(this.bill_headlbl);
            this.MaximizeBox = false;
            this.Name = "Bill_Generate";
            this.Text = "Bill_Generate";
            this.Load += new System.EventHandler(this.Bill_Generate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bill_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bill_dataview)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bill_serviceData)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bill_headlbl;
        private System.Windows.Forms.PictureBox bill_logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label bill_id;
        private System.Windows.Forms.Label bill_name;
        private System.Windows.Forms.DataGridView bill_dataview;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label subtotal_lbl;
        private System.Windows.Forms.Label bill_datelbl;
        private System.Windows.Forms.Label bill_invoiceNo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView bill_serviceData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
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
    }
}