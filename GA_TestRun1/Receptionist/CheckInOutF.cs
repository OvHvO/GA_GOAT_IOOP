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
    public partial class CheckInOutF : Form
    {
        int serviceId;
        string serviceStatus;
        string CusID;
        string customername;
        public CheckInOutF()
        {
            InitializeComponent();
        }

        private void CheckInOutF_Load(object sender, EventArgs e)
        {
            checkin_dataView.DataSource = Receptionists.cus_CheckInOut();

        }

        private void checkin_dataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkin_dataView_SelectionChanged(object sender, EventArgs e)
        {   //check the row when change
            if (checkin_dataView.SelectedRows.Count>0)
            {   //[0] represent a selection colection
                 DataGridViewRow selectedRows= checkin_dataView.SelectedRows[0];
                 string cusname=checkin_Cusnametxt.Text = selectedRows.Cells["CusName"].Value.ToString();
                 string cusID= selectedRows.Cells["Cus_ID"].Value.ToString();
                 checkin_carVertxt.Text = selectedRows.Cells["carVer"].Value.ToString();
                 string id =selectedRows.Cells["Service_ID"].Value.ToString();
                 string currentStatus= selectedRows.Cells["Service_status"].Value.ToString();
                 int.TryParse(id, out int serid);
                 serviceStatus = currentStatus;
                 serviceId = serid;
                 CusID=cusID;
                 customername=cusname;
               
                 checkin_cbo.SelectedIndex = -1;
                 checkin_Carnumtxt.Text  = selectedRows.Cells["carNum"].Value.ToString();
                if (serviceStatus == "False")
                {
                    checkin_cbo.Enabled = false;
                    checkin_Upbtn.Enabled = false;
                    checkin_Carnumtxt.Enabled = false;
                    checkin_carVertxt.Enabled = false;
                    checkin_Billbtn.Enabled = true;

                }
                else
                {
                    checkin_cbo.Enabled = true;
                    checkin_Upbtn.Enabled = true;
                    checkin_Carnumtxt.Enabled = true;
                    checkin_carVertxt.Enabled = true;
                    checkin_Billbtn.Enabled = false;
                }

            }
        }

        private void checkin_Upbtn_Click(object sender, EventArgs e)
        {
            if (!IsNullCheck(checkin_Carnumtxt.Text, checkin_carVertxt.Text, checkin_cbo.Text))
            {
                MessageBox.Show("Please Fill All the blanks");
            }
            else 
            { 

                if (checkin_cbo.SelectedIndex == 1)
                {   
                    //Problem- Cannot Specify which customer check Out

                    DialogResult checkout = MessageBox.Show("Do You Want to check-out this Customer, this operation cannot be restored","Alert",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                    
                    if (checkout == DialogResult.OK )
                    {
                       
                      Receptionists.cus_UpdateCheckInOut(checkin_Cusnametxt.Text, checkin_Carnumtxt.Text, checkin_carVertxt.Text, serviceId, checkin_cbo.SelectedItem.ToString());
                      

                    }
 
                }
                else
                {
                        Receptionists.cus_UpdateCheckInOut(checkin_Cusnametxt.Text, checkin_Carnumtxt.Text, checkin_carVertxt.Text, serviceId, checkin_cbo.SelectedItem.ToString());
                
                }
            }
        }

        private void checkin_Billbtn_Click(object sender, EventArgs e)
        {
            Bill_Generate bill = new Bill_Generate(serviceId,CusID,customername, checkin_Carnumtxt.Text);
            bill.ShowDialog();
        }

        private bool IsNullCheck(params string[] values)
        {
            foreach (string value in values) 
            {
                if(string.IsNullOrEmpty(value))  
                    return false;
             
            }
            return true;
        }

        private void reload_pict_Click(object sender, EventArgs e)
        {
            checkin_dataView.DataSource=Receptionists.cus_CheckInOut();
        }
    }
}
