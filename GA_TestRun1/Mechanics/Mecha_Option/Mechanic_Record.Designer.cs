namespace GA_TestRun1.Mechanics.Mecha_Option
{
    partial class Mechanic_Record
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
            this.Record_txt = new System.Windows.Forms.Label();
            this.label_CS = new System.Windows.Forms.Label();
            this.label_CT = new System.Windows.Forms.Label();
            this.label_AR = new System.Windows.Forms.Label();
            this.Status_Cbo = new System.Windows.Forms.ComboBox();
            this.Col_Time = new System.Windows.Forms.DateTimePicker();
            this.Add_txt = new System.Windows.Forms.TextBox();
            this.Submit_btn = new System.Windows.Forms.Button();
            this.label_CR = new System.Windows.Forms.Label();
            this.CarNumber_LstB = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Record_txt
            // 
            this.Record_txt.AutoSize = true;
            this.Record_txt.Font = new System.Drawing.Font("Bauhaus 93", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Record_txt.Location = new System.Drawing.Point(109, 19);
            this.Record_txt.Name = "Record_txt";
            this.Record_txt.Size = new System.Drawing.Size(366, 30);
            this.Record_txt.TabIndex = 1;
            this.Record_txt.Text = "Record Service Progress Sheet";
            // 
            // label_CS
            // 
            this.label_CS.AutoSize = true;
            this.label_CS.Font = new System.Drawing.Font("Franklin Gothic Heavy", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CS.Location = new System.Drawing.Point(21, 114);
            this.label_CS.Name = "label_CS";
            this.label_CS.Size = new System.Drawing.Size(149, 20);
            this.label_CS.TabIndex = 2;
            this.label_CS.Text = "Completion Status: ";
            // 
            // label_CT
            // 
            this.label_CT.AutoSize = true;
            this.label_CT.Font = new System.Drawing.Font("Franklin Gothic Heavy", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CT.Location = new System.Drawing.Point(43, 173);
            this.label_CT.Name = "label_CT";
            this.label_CT.Size = new System.Drawing.Size(121, 20);
            this.label_CT.TabIndex = 3;
            this.label_CT.Text = "Collection Time:";
            // 
            // label_AR
            // 
            this.label_AR.AutoSize = true;
            this.label_AR.Font = new System.Drawing.Font("Franklin Gothic Heavy", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AR.Location = new System.Drawing.Point(22, 230);
            this.label_AR.Name = "label_AR";
            this.label_AR.Size = new System.Drawing.Size(149, 20);
            this.label_AR.TabIndex = 4;
            this.label_AR.Text = "Additional Repairs: ";
            // 
            // Status_Cbo
            // 
            this.Status_Cbo.FormattingEnabled = true;
            this.Status_Cbo.Location = new System.Drawing.Point(176, 113);
            this.Status_Cbo.Name = "Status_Cbo";
            this.Status_Cbo.Size = new System.Drawing.Size(121, 21);
            this.Status_Cbo.TabIndex = 5;
            this.Status_Cbo.SelectedIndexChanged += new System.EventHandler(this.Status_Cbo_SelectedIndexChanged);
            // 
            // Col_Time
            // 
            this.Col_Time.Location = new System.Drawing.Point(170, 173);
            this.Col_Time.Name = "Col_Time";
            this.Col_Time.Size = new System.Drawing.Size(200, 20);
            this.Col_Time.TabIndex = 6;
            // 
            // Add_txt
            // 
            this.Add_txt.Location = new System.Drawing.Point(25, 254);
            this.Add_txt.Multiline = true;
            this.Add_txt.Name = "Add_txt";
            this.Add_txt.Size = new System.Drawing.Size(539, 80);
            this.Add_txt.TabIndex = 7;
            // 
            // Submit_btn
            // 
            this.Submit_btn.Font = new System.Drawing.Font("Franklin Gothic Heavy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit_btn.Location = new System.Drawing.Point(243, 384);
            this.Submit_btn.Name = "Submit_btn";
            this.Submit_btn.Size = new System.Drawing.Size(99, 30);
            this.Submit_btn.TabIndex = 8;
            this.Submit_btn.Text = "Submit";
            this.Submit_btn.UseVisualStyleBackColor = true;
            this.Submit_btn.Click += new System.EventHandler(this.Submit_btn_Click);
            // 
            // label_CR
            // 
            this.label_CR.AutoSize = true;
            this.label_CR.Font = new System.Drawing.Font("Franklin Gothic Heavy", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CR.Location = new System.Drawing.Point(313, 114);
            this.label_CR.Name = "label_CR";
            this.label_CR.Size = new System.Drawing.Size(101, 20);
            this.label_CR.TabIndex = 9;
            this.label_CR.Text = "Car Number: ";
            // 
            // CarNumber_LstB
            // 
            this.CarNumber_LstB.FormattingEnabled = true;
            this.CarNumber_LstB.Location = new System.Drawing.Point(420, 114);
            this.CarNumber_LstB.Name = "CarNumber_LstB";
            this.CarNumber_LstB.Size = new System.Drawing.Size(129, 108);
            this.CarNumber_LstB.TabIndex = 10;
            this.CarNumber_LstB.SelectedIndexChanged += new System.EventHandler(this.Number_LstB_SelectedIndexChanged);
            // 
            // Mechanic_Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CarNumber_LstB);
            this.Controls.Add(this.label_CR);
            this.Controls.Add(this.Submit_btn);
            this.Controls.Add(this.Add_txt);
            this.Controls.Add(this.Col_Time);
            this.Controls.Add(this.Status_Cbo);
            this.Controls.Add(this.label_AR);
            this.Controls.Add(this.label_CT);
            this.Controls.Add(this.label_CS);
            this.Controls.Add(this.Record_txt);
            this.Name = "Mechanic_Record";
            this.Size = new System.Drawing.Size(587, 429);
            this.Load += new System.EventHandler(this.Mechanic_Record_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Record_txt;
        private System.Windows.Forms.Label label_CS;
        private System.Windows.Forms.Label label_CT;
        private System.Windows.Forms.Label label_AR;
        private System.Windows.Forms.ComboBox Status_Cbo;
        private System.Windows.Forms.DateTimePicker Col_Time;
        private System.Windows.Forms.TextBox Add_txt;
        private System.Windows.Forms.Button Submit_btn;
        private System.Windows.Forms.Label label_CR;
        private System.Windows.Forms.ListBox CarNumber_LstB;
    }
}
