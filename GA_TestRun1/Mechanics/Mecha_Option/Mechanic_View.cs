using GA_TestRun1.Receptionist;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GA_TestRun1.Mechanics.Mecha_Option
{
    public partial class Mechanic_View : Form
    {
        string NewName;

        public Mechanic_View(string Name, string Newname)
        {
            InitializeComponent();
            NewName = Name;
        }

        private void Mechanic_View_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#EEEBE3");
            LoadGridView(NewName);
        }

        private void rcp_appoimentBar_Paint(object sender, PaintEventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#EEEBE3");
        }

        private void Mcn_searchbtn_Click(object sender, EventArgs e)
        {
            string SelectedItems = "serviceAP_ID";
            if (Search_Cbo.SelectedIndex == 0)
            {
                SelectedItems = "serviceAP_ID";
                Mcn_GridView.DataSource = Mechanic.SearchFunc(Search_txt.Text, SelectedItems, NewName);
            }

            else if (Search_Cbo.SelectedIndex == 1)
            {
                SelectedItems = "customerUsername";
                Mcn_GridView.DataSource = Mechanic.SearchFunc(Search_txt.Text, SelectedItems, NewName);
            }

            else if (Search_Cbo.SelectedIndex == 2)
            {
                SelectedItems = "carNum";
                Mcn_GridView.DataSource = Mechanic.SearchFunc(Search_txt.Text, SelectedItems, NewName);
            }
        }

        private void Search_Cbo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Mcn_GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

//============================== Data Grid View ==============================//
        private void LoadGridView(string Uname)
        {
            Mechanic mechanic = new Mechanic(Uname);
            Mcn_GridView.DataSource = mechanic.ViewProfList(Uname);
            Search_Cbo.SelectedIndex = 0;
        }

        private void Mcn_GridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //e.RowIndex is to check now user selected which Row and the index
                //.Cells is to check the Cells of the datagrid view
                //Value is to return a value of selected cell and rows by user

                string name = Mcn_GridView.Rows[e.RowIndex].Cells["Cus_name"].Value.ToString();
                string vehicle = Mcn_GridView.Rows[e.RowIndex].Cells["Vechi_num"].Value.ToString();
                string contact = Mcn_GridView.Rows[e.RowIndex].Cells["Cus_contactNum"].Value.ToString();
                string cusID = Mcn_GridView.Rows[e.RowIndex].Cells["CusID"].Value.ToString();
                string serviceID = Mcn_GridView.Rows[e.RowIndex].Cells["App_id"].Value.ToString();
                string mechanicID = Mcn_GridView.Rows[e.RowIndex].Cells["MecName"].Value.ToString();
                string rescheduleStatus = Mcn_GridView.Rows[e.RowIndex].Cells["Reshedule_Status"].Value.ToString();
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.ToString());
                MessageBox.Show("Please Double Click On the Content Not header!", "Assigning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


    }
}
