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
            this.BackColor = ColorTranslator.FromHtml("#EEEBE3");
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
            try
            {
                foreach (object service in serviceDetails)
                {
                    ServiceDetailslistB.Items.Add(service);
                }
            }

            catch (Exception)
            {
                ///Already show from the Admin_Source
            }
        }

        private void adminServiceAddbtn_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Admin_service_data());
        }

        private void adminServiceEditbtn_Click(object sender, EventArgs e)
        {
            if (selectedItem != null)
            {   
                LoadUserControl(new Admin_service_data(selectedItem));
            }

            else
            {
                MessageBox.Show("Please f**king choose a service idiot");
            }
        }

        public void LoadUserControl(UserControl userControl)
        {
            admin_service_panel.Controls.Clear();

            userControl.Dock = DockStyle.Fill;
            admin_service_panel.Controls.Add(userControl);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Admin_service());
        }

        private void adminServiceDeletebtn_Click(object sender, EventArgs e)
        {
            if (selectedItem != null)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Admins_Source deleteService = new Admins_Source();
                    bool deleteResult = deleteService.Delete_Service(selectedItem);
                    if (deleteResult)
                    {
                        MessageBox.Show("Successfully deleted");
                        LoadUserControl(new Admin_service());
                    }
                    else
                    {
                        MessageBox.Show("Problem Occurs, please try again");
                    }
                }

            }
            else
            {
                MessageBox.Show("Please f**king choose a service idiot");
            }
        }

        private void PartBtn_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Admin_part());
        }
    }
}
