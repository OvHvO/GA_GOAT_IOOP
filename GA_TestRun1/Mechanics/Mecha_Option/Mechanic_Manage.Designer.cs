namespace GA_TestRun1.Mechanics.Mecha_Option
{
    partial class Mechanic_Manage
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
            this.R_Quantity_txt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Request_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Update_btn = new System.Windows.Forms.Button();
            this.Parts_ListB = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Welcome_txt
            // 
            this.Welcome_txt.AutoSize = true;
            this.Welcome_txt.Font = new System.Drawing.Font("Bauhaus 93", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome_txt.Location = new System.Drawing.Point(142, 19);
            this.Welcome_txt.Name = "Welcome_txt";
            this.Welcome_txt.Size = new System.Drawing.Size(302, 30);
            this.Welcome_txt.TabIndex = 2;
            this.Welcome_txt.Text = "Manage Inventory Sheet";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Heavy", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Parts: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Heavy", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(306, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quantity: ";
            // 
            // R_Quantity_txt
            // 
            this.R_Quantity_txt.Location = new System.Drawing.Point(390, 36);
            this.R_Quantity_txt.Name = "R_Quantity_txt";
            this.R_Quantity_txt.Size = new System.Drawing.Size(100, 20);
            this.R_Quantity_txt.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Parts_ListB);
            this.panel1.Controls.Add(this.Request_btn);
            this.panel1.Controls.Add(this.R_Quantity_txt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 156);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Update_btn);
            this.panel2.Location = new System.Drawing.Point(0, 293);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(587, 133);
            this.panel2.TabIndex = 8;
            // 
            // Request_btn
            // 
            this.Request_btn.Location = new System.Drawing.Point(243, 107);
            this.Request_btn.Name = "Request_btn";
            this.Request_btn.Size = new System.Drawing.Size(97, 29);
            this.Request_btn.TabIndex = 7;
            this.Request_btn.Text = "Request";
            this.Request_btn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Request Parts";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Update Used Parts";
            // 
            // Update_btn
            // 
            this.Update_btn.Location = new System.Drawing.Point(243, 91);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(97, 29);
            this.Update_btn.TabIndex = 8;
            this.Update_btn.Text = "Update";
            this.Update_btn.UseVisualStyleBackColor = true;
            // 
            // Parts_ListB
            // 
            this.Parts_ListB.FormattingEnabled = true;
            this.Parts_ListB.Location = new System.Drawing.Point(139, 34);
            this.Parts_ListB.Name = "Parts_ListB";
            this.Parts_ListB.Size = new System.Drawing.Size(120, 56);
            this.Parts_ListB.TabIndex = 8;
            this.Parts_ListB.SelectedIndexChanged += new System.EventHandler(this.Parts_ListB_SelectedIndexChanged);
            // 
            // Mechanic_Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Welcome_txt);
            this.Name = "Mechanic_Manage";
            this.Size = new System.Drawing.Size(587, 429);
            this.Load += new System.EventHandler(this.Mechanic_Manage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcome_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox R_Quantity_txt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Request_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Update_btn;
        private System.Windows.Forms.ListBox Parts_ListB;
    }
}
