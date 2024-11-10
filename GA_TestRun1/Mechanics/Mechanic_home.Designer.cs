namespace GA_TestRun1.Mechanics
{
    partial class Mechanic_home
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
            this.OptionPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // OptionPanel
            // 
            this.OptionPanel.Location = new System.Drawing.Point(0, -5);
            this.OptionPanel.Name = "OptionPanel";
            this.OptionPanel.Size = new System.Drawing.Size(107, 429);
            this.OptionPanel.TabIndex = 0;
            this.OptionPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.OptionPanel_Paint);
            // 
            // Mechanic_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(694, 421);
            this.Controls.Add(this.OptionPanel);
            this.Name = "Mechanic_home";
            this.Text = "Mechanic_home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel OptionPanel;
    }
}