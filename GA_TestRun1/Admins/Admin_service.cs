using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace GA_TestRun1.Admins
{
    public partial class Admin_service : UserControl
    {
        private string selectedItem;

        public Admin_service()
        {
            InitializeComponent();
            Admins_Source admin = new Admins_Source();
            List<string> serviceList = admin.Service_Net();
            foreach (string service in serviceList)
            {
                ServiceListBox.Items.Add(service);
            }
        }

        private void ServiceListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ServiceDetailslistB.Items.Clear();

            selectedItem = ServiceListBox.SelectedItem as string;

            Admins_Source selected_S_Details = new Admins_Source();
            object[] serviceDetails = selected_S_Details.Service_Details(selectedItem);
            foreach (object service in serviceDetails)
            {
                ServiceDetailslistB.Items.Add(service);
            }
        }

        private void adminServiceAddbtn_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Admin_service_data());
        }

        private void adminServiceEditbtn_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Admin_service_data(selectedItem));
        }

        private void LoadUserControl(UserControl userControl)
        {
            admin_service_panel.Controls.Clear();

            userControl.Dock = DockStyle.Fill;
            admin_service_panel.Controls.Add(userControl);
        }
    }
}
