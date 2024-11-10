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
using GA_TestRun1.Admins;
using GA_TestRun1.Customer.cus_usercontrol;
using GA_TestRun1.Mechanics;
using GA_TestRun1.Receptionist;

namespace GA_TestRun1.Customer
{
    public partial class Customer_home : Form
    {
        public int cus_ID;

        public Customer_home(string userN)
        {   
            InitializeComponent();
            LoadUserControl(new Cus_Interface());
            Cus_Source cus = new Cus_Source();
            cus_ID = cus.ID_Checking(userN);
        }

        private void LoadUserControl(UserControl userControl)
        {
            cus_Panel.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            cus_Panel.Controls.Add(userControl);
        }

        private void updateProfileBtn_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Cus_UpdateProfile(cus_ID));

        }

        private void serviceViewBtn_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Cus_Service(cus_ID));
        }

        private void cusInterfaceBtn_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Cus_Interface());
        }

        private void feedbackBtn_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Cus_Feedback(cus_ID));
        }
    }
}
