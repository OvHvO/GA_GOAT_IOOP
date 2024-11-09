using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GA_TestRun1.Customer.cus_usercontrol
{
    public partial class Cus_Service : UserControl
    {
        private int cus_ID;
        public Cus_Service(int CusID)
        {   
            cus_ID = CusID;
            InitializeComponent();
            Cus_Source cus = new Cus_Source();
            List<string> serviceNameList = cus.Service_Net();
            foreach (string serviceName in serviceNameList)
            {
                Cus_Service_LB.Items.Add(serviceName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Just for testing");
        }

        private void Cus_Service_LB_SelectedIndexChanged(object sender, EventArgs e)
        {   
            Cus_ServiceDtls_LB.Items.Clear();
            Cus_Service_cusID.Clear();
            string targetservice = (Cus_Service_LB.SelectedItem).ToString();
            Cus_Source cus_service = new Cus_Source();
            object[] serviceDetails = cus_service.Service_Details(targetservice);
            foreach(string serviceD in serviceDetails)
            {
                Cus_ServiceDtls_LB.Items.Add(serviceD);
            }

            Cus_Service_cusID.Text = cus_ID.ToString();
            Cus_Service_cusID.ReadOnly = true;

            List<string> appointmentDate = cus_service.MechanicTime();
        }
    }
}
