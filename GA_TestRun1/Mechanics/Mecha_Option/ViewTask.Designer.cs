namespace GA_TestRun1.Mechanics.Mecha_Option
{
    partial class ViewTask
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
            this.ServiceTimelbl = new System.Windows.Forms.Label();
            this.serviceDateTimepick = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // ServiceTimelbl
            // 
            this.ServiceTimelbl.AutoSize = true;
            this.ServiceTimelbl.Location = new System.Drawing.Point(22, 115);
            this.ServiceTimelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ServiceTimelbl.Name = "ServiceTimelbl";
            this.ServiceTimelbl.Size = new System.Drawing.Size(75, 13);
            this.ServiceTimelbl.TabIndex = 26;
            this.ServiceTimelbl.Text = "Service Time: ";
            // 
            // serviceDateTimepick
            // 
            this.serviceDateTimepick.CustomFormat = "";
            this.serviceDateTimepick.Location = new System.Drawing.Point(134, 108);
            this.serviceDateTimepick.Margin = new System.Windows.Forms.Padding(2);
            this.serviceDateTimepick.Name = "serviceDateTimepick";
            this.serviceDateTimepick.Size = new System.Drawing.Size(202, 20);
            this.serviceDateTimepick.TabIndex = 25;
            // 
            // ViewTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 220);
            this.Controls.Add(this.ServiceTimelbl);
            this.Controls.Add(this.serviceDateTimepick);
            this.Name = "ViewTask";
            this.Text = "ViewTask";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ServiceTimelbl;
        private System.Windows.Forms.DateTimePicker serviceDateTimepick;
    }
}