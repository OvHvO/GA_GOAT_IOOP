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
            this.Welcome_txt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Status_Cbo = new System.Windows.Forms.ComboBox();
            this.Col_Time = new System.Windows.Forms.DateTimePicker();
            this.Add_txt = new System.Windows.Forms.TextBox();
            this.Submit_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Number_LstB = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Welcome_txt
            // 
            this.Welcome_txt.AutoSize = true;
            this.Welcome_txt.Font = new System.Drawing.Font("Bauhaus 93", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome_txt.Location = new System.Drawing.Point(109, 19);
            this.Welcome_txt.Name = "Welcome_txt";
            this.Welcome_txt.Size = new System.Drawing.Size(366, 30);
            this.Welcome_txt.TabIndex = 1;
            this.Welcome_txt.Text = "Record Service Progress Sheet";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Heavy", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Completion Status: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Heavy", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Collection Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Heavy", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Additional Repairs: ";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Heavy", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(313, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Car Number: ";
            // 
            // Number_LstB
            // 
            this.Number_LstB.FormattingEnabled = true;
            this.Number_LstB.Location = new System.Drawing.Point(420, 114);
            this.Number_LstB.Name = "Number_LstB";
            this.Number_LstB.Size = new System.Drawing.Size(129, 108);
            this.Number_LstB.TabIndex = 10;
            this.Number_LstB.SelectedIndexChanged += new System.EventHandler(this.Number_LstB_SelectedIndexChanged);
            // 
            // Mechanic_Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Number_LstB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Submit_btn);
            this.Controls.Add(this.Add_txt);
            this.Controls.Add(this.Col_Time);
            this.Controls.Add(this.Status_Cbo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Welcome_txt);
            this.Name = "Mechanic_Record";
            this.Size = new System.Drawing.Size(587, 429);
            this.Load += new System.EventHandler(this.Mechanic_Record_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcome_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Status_Cbo;
        private System.Windows.Forms.DateTimePicker Col_Time;
        private System.Windows.Forms.TextBox Add_txt;
        private System.Windows.Forms.Button Submit_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox Number_LstB;
    }
}
