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
            Mcn_GridView.DataSource = Mechanic.ViewProfList(NewName);
            Search_list.SelectedIndex = 0;
        }
    }
}
