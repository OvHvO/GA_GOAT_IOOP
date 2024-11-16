namespace GA_TestRun1.Mechanics.Mecha_Option
{
    partial class Mechanic_Main
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
            this.panel_Prof = new System.Windows.Forms.Panel();
            this.Refresh_btn = new System.Windows.Forms.Button();
            this.PNum_lbl = new System.Windows.Forms.Label();
            this.Name_lbl = new System.Windows.Forms.Label();
            this.label_PNum = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panel_Month = new System.Windows.Forms.Panel();
            this.panel_Prof.SuspendLayout();
            this.panel_Month.SuspendLayout();
            this.SuspendLayout();
            // 
            // Welcome_txt
            // 
            this.Welcome_txt.AutoSize = true;
            this.Welcome_txt.Font = new System.Drawing.Font("Bauhaus 93", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome_txt.Location = new System.Drawing.Point(89, 9);
            this.Welcome_txt.Name = "Welcome_txt";
            this.Welcome_txt.Size = new System.Drawing.Size(426, 30);
            this.Welcome_txt.TabIndex = 0;
            this.Welcome_txt.Text = "Welcome to Mechanic Home Page";
            this.Welcome_txt.Click += new System.EventHandler(this.Welcome_txt_Click);
            // 
            // panel_Prof
            // 
            this.panel_Prof.Controls.Add(this.Refresh_btn);
            this.panel_Prof.Controls.Add(this.PNum_lbl);
            this.panel_Prof.Controls.Add(this.Name_lbl);
            this.panel_Prof.Controls.Add(this.label_PNum);
            this.panel_Prof.Controls.Add(this.label_name);
            this.panel_Prof.Location = new System.Drawing.Point(0, 105);
            this.panel_Prof.Name = "panel_Prof";
            this.panel_Prof.Size = new System.Drawing.Size(293, 186);
            this.panel_Prof.TabIndex = 1;
            // 
            // Refresh_btn
            // 
            this.Refresh_btn.Location = new System.Drawing.Point(127, 129);
            this.Refresh_btn.Name = "Refresh_btn";
            this.Refresh_btn.Size = new System.Drawing.Size(75, 23);
            this.Refresh_btn.TabIndex = 4;
            this.Refresh_btn.Text = "Refresh";
            this.Refresh_btn.UseVisualStyleBackColor = true;
            this.Refresh_btn.Click += new System.EventHandler(this.Refresh_btn_Click);
            // 
            // PNum_lbl
            // 
            this.PNum_lbl.AutoSize = true;
            this.PNum_lbl.Font = new System.Drawing.Font("Franklin Gothic Heavy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PNum_lbl.Location = new System.Drawing.Point(165, 78);
            this.PNum_lbl.Name = "PNum_lbl";
            this.PNum_lbl.Size = new System.Drawing.Size(56, 21);
            this.PNum_lbl.TabIndex = 3;
            this.PNum_lbl.Text = "label4";
            // 
            // Name_lbl
            // 
            this.Name_lbl.AutoSize = true;
            this.Name_lbl.Font = new System.Drawing.Font("Franklin Gothic Heavy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_lbl.Location = new System.Drawing.Point(164, 46);
            this.Name_lbl.Name = "Name_lbl";
            this.Name_lbl.Size = new System.Drawing.Size(56, 21);
            this.Name_lbl.TabIndex = 2;
            this.Name_lbl.Text = "label3";
            // 
            // label_PNum
            // 
            this.label_PNum.AutoSize = true;
            this.label_PNum.Font = new System.Drawing.Font("Franklin Gothic Heavy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PNum.Location = new System.Drawing.Point(32, 78);
            this.label_PNum.Name = "label_PNum";
            this.label_PNum.Size = new System.Drawing.Size(127, 21);
            this.label_PNum.TabIndex = 1;
            this.label_PNum.Text = "Phone Number: ";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Franklin Gothic Heavy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Location = new System.Drawing.Point(97, 46);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(61, 21);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Name: ";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(22, 15);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // panel_Month
            // 
            this.panel_Month.Controls.Add(this.monthCalendar1);
            this.panel_Month.Location = new System.Drawing.Point(294, 105);
            this.panel_Month.Name = "panel_Month";
            this.panel_Month.Size = new System.Drawing.Size(293, 186);
            this.panel_Month.TabIndex = 5;
            // 
            // Mechanic_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_Month);
            this.Controls.Add(this.panel_Prof);
            this.Controls.Add(this.Welcome_txt);
            this.Name = "Mechanic_Main";
            this.Size = new System.Drawing.Size(587, 429);
            this.Load += new System.EventHandler(this.Mechanic_Main_Load);
            this.panel_Prof.ResumeLayout(false);
            this.panel_Prof.PerformLayout();
            this.panel_Month.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcome_txt;
        private System.Windows.Forms.Panel panel_Prof;
        private System.Windows.Forms.Label label_PNum;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button Refresh_btn;
        private System.Windows.Forms.Label PNum_lbl;
        private System.Windows.Forms.Label Name_lbl;
        private System.Windows.Forms.Panel panel_Month;
    }
}
