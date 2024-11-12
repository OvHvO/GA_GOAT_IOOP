using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GA_TestRun1.Receptionist
{
    public partial class searchInv : Form
    {
        int partid;
        string status;
        public searchInv()
        {
            InitializeComponent();
            InvDataView.DataSource = Receptionists.RequestF();

        }

        private void searchInv_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchInv_Load(object sender, EventArgs e)
        {

        }

        private void Src_Invbtn_Click(object sender, EventArgs e)
        {
            string selectedItems;
            if (SearchInvcb.SelectedIndex==0)
            {
                selectedItems = "request_ID";
               InvDataView.DataSource=  Receptionists.invSearchFunc(selectedItems,Invsrc_txt.Text); 
            }
            else 
            {
                selectedItems = "rrequestStatus";
                InvDataView.DataSource = Receptionists.invSearchFunc(selectedItems, Invsrc_txt.Text);
            }

        }

     

        private void InvDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {       
              string p = InvDataView.Rows[e.RowIndex].Cells["Request_id"].Value.ToString();
              int.TryParse(p, out int spartid);
              partid=spartid;
              status = InvDataView.Rows[e.RowIndex].Cells["request_status"].Value.ToString();

        }

        private void Request_combtn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you confirm want to assign this Parts to Mechanics?","Assign Part",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Receptionists.TaskStatus(partid,status);
            }
            else
            {
                MessageBox.Show("Operation Cancelled","Assign Parts");
            }
           

        }
    }
}
