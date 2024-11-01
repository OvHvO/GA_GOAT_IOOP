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
        
        public Admin_service_data()
        {
            InitializeComponent();
            Admins_Source addService = new Admins_Source();
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

        }

    }
}
