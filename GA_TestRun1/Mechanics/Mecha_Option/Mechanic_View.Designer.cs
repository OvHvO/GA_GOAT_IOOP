namespace GA_TestRun1.Mechanics
{
    partial class Mechanic_View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mechanic_View));
            this.rcp_appoimentBar = new System.Windows.Forms.Panel();
            this.reload_pict = new System.Windows.Forms.PictureBox();
            this.scr_lbl = new System.Windows.Forms.Label();
            this.SearchCBO_lbl = new System.Windows.Forms.Label();
            this.Rcp_searchbtn = new System.Windows.Forms.Button();
            this.Search_txt = new System.Windows.Forms.TextBox();
            this.Search_list = new System.Windows.Forms.ComboBox();
            this.Mcn_GridView = new System.Windows.Forms.DataGridView();
            this.rcp_appoimentBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reload_pict)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mcn_GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // rcp_appoimentBar
            // 
            this.rcp_appoimentBar.Controls.Add(this.reload_pict);
            this.rcp_appoimentBar.Controls.Add(this.scr_lbl);
            this.rcp_appoimentBar.Controls.Add(this.SearchCBO_lbl);
            this.rcp_appoimentBar.Controls.Add(this.Rcp_searchbtn);
            this.rcp_appoimentBar.Controls.Add(this.Search_txt);
            this.rcp_appoimentBar.Controls.Add(this.Search_list);
            this.rcp_appoimentBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.rcp_appoimentBar.Location = new System.Drawing.Point(0, 0);
            this.rcp_appoimentBar.Margin = new System.Windows.Forms.Padding(2);
            this.rcp_appoimentBar.Name = "rcp_appoimentBar";
            this.rcp_appoimentBar.Size = new System.Drawing.Size(587, 53);
            this.rcp_appoimentBar.TabIndex = 3;
            this.rcp_appoimentBar.Paint += new System.Windows.Forms.PaintEventHandler(this.rcp_appoimentBar_Paint);
            // 
            // reload_pict
            // 
            this.reload_pict.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reload_pict.Image = ((System.Drawing.Image)(resources.GetObject("reload_pict.Image")));
            this.reload_pict.Location = new System.Drawing.Point(552, 19);
            this.reload_pict.Margin = new System.Windows.Forms.Padding(2);
            this.reload_pict.Name = "reload_pict";
            this.reload_pict.Size = new System.Drawing.Size(26, 27);
            this.reload_pict.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.reload_pict.TabIndex = 5;
            this.reload_pict.TabStop = false;
            // 
            // scr_lbl
            // 
            this.scr_lbl.AutoSize = true;
            this.scr_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scr_lbl.Location = new System.Drawing.Point(281, 27);
            this.scr_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.scr_lbl.Name = "scr_lbl";
            this.scr_lbl.Size = new System.Drawing.Size(64, 16);
            this.scr_lbl.TabIndex = 4;
            this.scr_lbl.Text = "Search: ";
            // 
            // SearchCBO_lbl
            // 
            this.SearchCBO_lbl.AutoSize = true;
            this.SearchCBO_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchCBO_lbl.Location = new System.Drawing.Point(2, 27);
            this.SearchCBO_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SearchCBO_lbl.Name = "SearchCBO_lbl";
            this.SearchCBO_lbl.Size = new System.Drawing.Size(92, 17);
            this.SearchCBO_lbl.TabIndex = 3;
            this.SearchCBO_lbl.Text = "Search By: ";
            // 
            // Rcp_searchbtn
            // 
            this.Rcp_searchbtn.Location = new System.Drawing.Point(487, 29);
            this.Rcp_searchbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Rcp_searchbtn.Name = "Rcp_searchbtn";
            this.Rcp_searchbtn.Size = new System.Drawing.Size(61, 19);
            this.Rcp_searchbtn.TabIndex = 2;
            this.Rcp_searchbtn.Text = "Search";
            this.Rcp_searchbtn.UseVisualStyleBackColor = true;
            this.Rcp_searchbtn.Click += new System.EventHandler(this.Rcp_searchbtn_Click);
            // 
            // Search_txt
            // 
            this.Search_txt.Location = new System.Drawing.Point(349, 26);
            this.Search_txt.Margin = new System.Windows.Forms.Padding(2);
            this.Search_txt.Name = "Search_txt";
            this.Search_txt.Size = new System.Drawing.Size(123, 20);
            this.Search_txt.TabIndex = 1;
            // 
            // Search_list
            // 
            this.Search_list.FormattingEnabled = true;
            this.Search_list.Items.AddRange(new object[] {
            "Appoinment ID",
            "Customer Name",
            "Vehicle Number"});
            this.Search_list.Location = new System.Drawing.Point(98, 26);
            this.Search_list.Margin = new System.Windows.Forms.Padding(2);
            this.Search_list.Name = "Search_list";
            this.Search_list.Size = new System.Drawing.Size(131, 21);
            this.Search_list.TabIndex = 0;
            // 
            // Mcn_GridView
            // 
            this.Mcn_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Mcn_GridView.Location = new System.Drawing.Point(0, 53);
            this.Mcn_GridView.Name = "Mcn_GridView";
            this.Mcn_GridView.Size = new System.Drawing.Size(587, 376);
            this.Mcn_GridView.TabIndex = 4;
            this.Mcn_GridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Mcn_GridView_CellContentClick);
            // 
            // Mechanic_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Mcn_GridView);
            this.Controls.Add(this.rcp_appoimentBar);
            this.Name = "Mechanic_View";
            this.Size = new System.Drawing.Size(587, 429);
            this.Load += new System.EventHandler(this.Mechanic_View_Load);
            this.rcp_appoimentBar.ResumeLayout(false);
            this.rcp_appoimentBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reload_pict)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mcn_GridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel rcp_appoimentBar;
        private System.Windows.Forms.PictureBox reload_pict;
        private System.Windows.Forms.Label scr_lbl;
        private System.Windows.Forms.Label SearchCBO_lbl;
        private System.Windows.Forms.Button Rcp_searchbtn;
        private System.Windows.Forms.TextBox Search_txt;
        private System.Windows.Forms.ComboBox Search_list;
        private System.Windows.Forms.DataGridView Mcn_GridView;
    }
}
