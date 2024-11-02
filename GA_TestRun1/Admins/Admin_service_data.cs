using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GA_TestRun1.Admins
{
    public partial class Admin_service_data : UserControl
    {
        private string typeOfChange;
        
        public Admin_service_data()
        {
            InitializeComponent();
            Admins_Source addService = new Admins_Source();
            typeOfChange = "ADD";
        }

        public Admin_service_data(string selectedService)
        {
            InitializeComponent();
            Admins_Source editService = new Admins_Source();
            string[] editServiceInfo = editService.Edit_Service(selectedService);
            ServiceNameTB.Text = editServiceInfo[0];
            ServiceInfoTB.Text = editServiceInfo[1];
            ServiceTimeTakenTB.Text = editServiceInfo[2];
            ServicePriceTB.Text = editServiceInfo[3];
            ServiceOfferTB.Text = editServiceInfo[4];
            ServicePartIDTB.Text = editServiceInfo[5];
            typeOfChange = "EDIT";
            ServiceNameTB.ReadOnly = true;
        }

        private void serviceChangeBtn_Click(object sender, EventArgs e)
        {   
            string serviceName = ServiceNameTB.Text;
            string serviceInfo = ServiceInfoTB.Text;
            string serviceTimeTaken = ServiceTimeTakenTB.Text;
            int servicePrice = Convert.ToInt32(ServicePriceTB.Text);
            int serviceOffer = Convert.ToInt32(ServiceOfferTB.Text);
            int servicePartID = Convert.ToInt32(ServicePartIDTB.Text);
            Admins_Source serviceChange = new Admins_Source();

            bool resultChange = serviceChange.Service_Change(typeOfChange, serviceName, serviceInfo, serviceTimeTaken, servicePrice, serviceOffer, Admin_Interface.adminID, servicePartID);
            if (resultChange && (typeOfChange == "ADD"))
            {
                MessageBox.Show("Service added");
            }

            else if (resultChange && (typeOfChange == "EDIT"))
            {
                MessageBox.Show("Service edited");
            }

            else
            {
                MessageBox.Show("Problem occurs (Please remember Service name is unchangeable)");
            }

            ServiceNameTB.Clear();
            ServiceInfoTB.Clear();
            ServiceTimeTakenTB.Clear();
            ServicePriceTB.Clear();
            ServiceOfferTB.Clear();
            ServicePartIDTB.Clear();
        }

        private void partCheckBtn_Click(object sender, EventArgs e)
        {   
            string selectedItem = ServicePartIDTB.Text;
            int partID;
            if (int.TryParse(selectedItem, out partID))
            {
                Admins_Source part = new Admins_Source();
                string partName = part.Part_Checking(partID);
                MessageBox.Show($"Part name is [{partName}]");
            }

            else
            {
                MessageBox.Show("Please enter a correct PartID");
            }
        
        }
    }
}
