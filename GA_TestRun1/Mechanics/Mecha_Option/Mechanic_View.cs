using Azure.Identity;
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

namespace GA_TestRun1.Mechanics
{
    public partial class Mechanic_View : UserControl
    {
        string NewName;

        public Mechanic_View(string Name)
        {
            InitializeComponent();
            NewName = Name;
        }

        private void Mechanic_View_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#EEEBE3");
            LoadGridView();
        }

        private void rcp_appoimentBar_Paint(object sender, PaintEventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#EEEBE3");
        }

        private void Search_cbo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Rcp_searchbtn_Click(object sender, EventArgs e)
        {

        }

        private void Mcn_GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void LoadGridView()
        {
        string userName = "OriUserName";
        string newName = "OriNewUserName";

        Mechanic mechanic = new Mechanic(Name);

        var data = mechanic.ViewProfList(userName, newName);

            if (data != null)
            {
                Mcn_GridView.DataSource = data;  // Show the DataTable to the GridView

                // Set the selected index of Search_list, ensuring it has items
                if (Search_list.Items.Count > 0)
                {
                    Mcn_GridView.AutoGenerateColumns = true;
                    Search_list.SelectedIndex = 0;
                }
            }
            else
            {
                MessageBox.Show("Failed to retrieve profile list. Please check for errors.");
            }
        }

        private void reload_pict_Click(object sender, EventArgs e)
        {
            Mechanic mechanic = new Mechanic(Name);
            string userName = "SomeUser";  // Replace with actual UserName value
            string newName = "SomeNewUser";
            Mcn_GridView.DataSource = mechanic.ViewProfList(userName, newName);
        }
    }
}
