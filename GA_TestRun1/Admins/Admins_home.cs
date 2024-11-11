using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Azure.Identity;
using GA_TestRun1;
using GA_TestRun1.Customer;
using GA_TestRun1.Mechanics;
using GA_TestRun1.Receptionist;

namespace GA_TestRun1.Admins
{
    public partial class Admins_home : Form
    {
        private string userN;


        public Admins_home(string username)
        {
            InitializeComponent();
            userN = username;
            FeatureBox.BackColor = ColorTranslator.FromHtml("#69764F");
            btn_cus_FB.BackColor = ColorTranslator.FromHtml("#69764F");
            btn_sales_Report.BackColor = ColorTranslator.FromHtml("#69764F");
            btn_service_MNG.BackColor = ColorTranslator.FromHtml("#69764F");
            btn_staff_MNG.BackColor = ColorTranslator.FromHtml("#69764F");
            LoadUserControl(new Admin_Interface(userN));
        }

        private void staff_MNG_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Admin_staff());
        }

        private void service_MNG_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Admin_service());
        }

        private void btn_sales_Report_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Admin_salesreport());
        }

        private void btn_cus_FB_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Admin_cus_FB());
        }

        private void LoadUserControl(UserControl userControl)
        {
            admin_Panel.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            admin_Panel.Controls.Add(userControl);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Admin_Interface(userN));
        }
    }
}
