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
    public partial class Manage_Appoinment : Form
    {
        string username;
        public Manage_Appoinment(string name)
        {
            InitializeComponent();
            username = name;
        }

        private void Manage_Appoinment_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#EEEBE3");
            Rcp_dataview.BackColor = ColorTranslator.FromHtml("#EEEBE3");

            Rcp_dataview.DataSource = Receptionists.getProfList();
            Search_cbo.SelectedIndex = 0;
        }


        private void Rcp_dataview_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // e.RowIndex is to check now user selected which Row and the index is what
                //.Cells is to check the Cells of the datagrid view
                //Value is to return a value of now user selected which cell and which rows

                string name = Rcp_dataview.Rows[e.RowIndex].Cells["Cus_name"].Value.ToString();
                string vehicle = Rcp_dataview.Rows[e.RowIndex].Cells["Vechi_num"].Value.ToString();
                string contact = Rcp_dataview.Rows[e.RowIndex].Cells["Cus_contactNum"].Value.ToString();
                string cusID = Rcp_dataview.Rows[e.RowIndex].Cells["CusID"].Value.ToString();
                string serviceID = Rcp_dataview.Rows[e.RowIndex].Cells["App_id"].Value.ToString();
                string mechanicID = Rcp_dataview.Rows[e.RowIndex].Cells["MecName"].Value.ToString();
                string rescheduleStatus= Rcp_dataview.Rows[e.RowIndex].Cells["Reshedule_Status"].Value.ToString();
                if (string.IsNullOrEmpty(mechanicID)|| rescheduleStatus == "True")
                {
                    Assign_task assign = new Assign_task(name, vehicle, contact, cusID, serviceID, username);
                    assign.ShowDialog(); 
                }
                else
                {
                    MessageBox.Show("This Task Has Already Been Assigned !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception )
            {
                //MessageBox.Show(ex.ToString());
                MessageBox.Show("Please Double Click On the Content Not header!","Assigning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }



        }

        private void Rcp_dataview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Search_cbo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Rcp_dataview_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Search_txtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Rcp_searchbtn_Click_1(object sender, EventArgs e)
        {
            string selectedItems = "serviceAP_ID";
            if (Search_cbo.SelectedIndex == 0)
            {
                selectedItems = "serviceAP_ID";
                Rcp_dataview.DataSource = Receptionists.searchFunc(Search_txtb.Text, selectedItems);
            }

            else if (Search_cbo.SelectedIndex == 1)
            {
                selectedItems = "customerUsername";
                Rcp_dataview.DataSource = Receptionists.searchFunc(Search_txtb.Text, selectedItems);
            }

            else if (Search_cbo.SelectedIndex == 2)
            {
                selectedItems = "carNum";
                Rcp_dataview.DataSource = Receptionists.searchFunc(Search_txtb.Text, selectedItems);
            }




            //Rcp_dataview.DataSource = Receptionists.searchFunc(Search_txtb.Text,selectedItems);
        }

        private void reload_pict_Click(object sender, EventArgs e)
        {
            Rcp_dataview.DataSource=Receptionists.getProfList();
        }
    }
}
