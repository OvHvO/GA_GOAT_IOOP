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
            this.label9 = new System.Windows.Forms.Label();
            this.discount_lbl = new System.Windows.Forms.Label();
            this.subtotal_lbl = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.totaldue_lbl = new System.Windows.Forms.Label();
            this.bill_datelbl = new System.Windows.Forms.Label();
            this.bill_invoiceNo = new System.Windows.Forms.Label();
            this.bill_part = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bill_partName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billpartPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billTotal_P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceAp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.task_ids = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bill_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bill_dataview)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(696, 28);
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
            this.panel1.Size = new System.Drawing.Size(880, 10);
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
            this.label4.Location = new System.Drawing.Point(15, 203);
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
            this.panel2.Size = new System.Drawing.Size(880, 10);
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
            this.label6.Location = new System.Drawing.Point(15, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Name: ";
            // 
            // bill_id
            // 
            this.bill_id.AutoSize = true;
            this.bill_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bill_id.Location = new System.Drawing.Point(163, 249);
            this.bill_id.Name = "bill_id";
            this.bill_id.Size = new System.Drawing.Size(53, 20);
            this.bill_id.TabIndex = 10;
            this.bill_id.Text = "label7";
            // 
            // bill_name
            // 
            this.bill_name.AutoSize = true;
            this.bill_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bill_name.Location = new System.Drawing.Point(163, 293);
            this.bill_name.Name = "bill_name";
            this.bill_name.Size = new System.Drawing.Size(53, 20);
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
            this.billTotal_P,
            this.ServiceAp,
            this.task_ids});
            this.bill_dataview.EnableHeadersVisualStyles = false;
            this.bill_dataview.Location = new System.Drawing.Point(12, 336);
            this.bill_dataview.Name = "bill_dataview";
            this.bill_dataview.ReadOnly = true;
            this.bill_dataview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.bill_dataview.RowHeadersVisible = false;
            this.bill_dataview.RowHeadersWidth = 51;
            this.bill_dataview.RowTemplate.Height = 24;
            this.bill_dataview.Size = new System.Drawing.Size(933, 602);
            this.bill_dataview.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(704, 941);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 29);
            this.label9.TabIndex = 13;
            this.label9.Text = "Subtotal: ";
            // 
            // discount_lbl
            // 
            this.discount_lbl.AutoSize = true;
            this.discount_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discount_lbl.Location = new System.Drawing.Point(854, 1014);
            this.discount_lbl.Name = "discount_lbl";
            this.discount_lbl.Size = new System.Drawing.Size(102, 29);
            this.discount_lbl.TabIndex = 14;
            this.discount_lbl.Text = "label10";
            // 
            // subtotal_lbl
            // 
            this.subtotal_lbl.AutoSize = true;
            this.subtotal_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotal_lbl.Location = new System.Drawing.Point(854, 941);
            this.subtotal_lbl.Name = "subtotal_lbl";
            this.subtotal_lbl.Size = new System.Drawing.Size(102, 29);
            this.subtotal_lbl.TabIndex = 15;
            this.subtotal_lbl.Text = "label11";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(704, 1014);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(136, 29);
            this.label12.TabIndex = 16;
            this.label12.Text = "Discount: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(704, 1083);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(147, 29);
            this.label13.TabIndex = 17;
            this.label13.Text = "Total Due: ";
            // 
            // totaldue_lbl
            // 
            this.totaldue_lbl.AutoSize = true;
            this.totaldue_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totaldue_lbl.Location = new System.Drawing.Point(854, 1083);
            this.totaldue_lbl.Name = "totaldue_lbl";
            this.totaldue_lbl.Size = new System.Drawing.Size(102, 29);
            this.totaldue_lbl.TabIndex = 18;
            this.totaldue_lbl.Text = "label14";
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
            // billTotal_P
            // 
            this.billTotal_P.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.billTotal_P.HeaderText = "Total Price ";
            this.billTotal_P.MinimumWidth = 6;
            this.billTotal_P.Name = "billTotal_P";
            this.billTotal_P.ReadOnly = true;
            this.billTotal_P.Width = 95;
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
            // Bill_Generate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(951, 1055);
            this.Controls.Add(this.totaldue_lbl);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.subtotal_lbl);
            this.Controls.Add(this.discount_lbl);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.bill_dataview);
            this.Controls.Add(this.bill_name);
            this.Controls.Add(this.bill_invoiceNo);
            this.Controls.Add(this.bill_datelbl);
            this.Controls.Add(this.bill_id);
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
            this.Name = "Bill_Generate";
            this.Text = "Bill_Generate";
            this.Load += new System.EventHandler(this.Bill_Generate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bill_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bill_dataview)).EndInit();
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
        private System.Windows.Forms.Label discount_lbl;
        private System.Windows.Forms.Label subtotal_lbl;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label totaldue_lbl;
        private System.Windows.Forms.Label bill_datelbl;
        private System.Windows.Forms.Label bill_invoiceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn bill_part;
        private System.Windows.Forms.DataGridViewTextBoxColumn bill_partName;
        private System.Windows.Forms.DataGridViewTextBoxColumn partQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn billpartPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn billTotal_P;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceAp;
        private System.Windows.Forms.DataGridViewTextBoxColumn task_ids;
    }
}