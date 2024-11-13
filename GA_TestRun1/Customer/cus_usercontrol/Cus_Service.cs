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
        private string targetservice;
        public Cus_Service(int CusID)
        {   
            cus_ID = CusID;
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#EEEBE3");
            Cus_SA_tooltip.SetToolTip(Cus_SA_timepicker, "Please choose your service appoinment time");
            Cus_Source cus = new Cus_Source();
            List<string> serviceNameList = cus.Service_Net();
            foreach (string serviceName in serviceNameList)
            {
                Cus_Service_LB.Items.Add(serviceName);
            }
        }

        private void appoinmentConfirmBtn_Click(object sender, EventArgs e)
        {
            string carNum = Cus_Service_carNum.Text;
            string carVersion = Cus_Service_carVersion.Text;
            string currentDateText = Cus_SA_timepicker.Text;
            DateTime currentDate = Cus_SA_timepicker.Value;

            //call method
            Cus_Source cus_app = new Cus_Source();
            bool book_R = cus_app.Cus_Book_App(cus_ID, carNum, carVersion, currentDate, targetservice);
            if (book_R)
            {
                MessageBox.Show("Successfully Booked");
            }
            else
            {
                MessageBox.Show("GG");
            }

        }

        private void Cus_Service_LB_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Cus_ServiceDtls_LB.Items.Clear();
                Cus_Service_cusID.Clear();
                //start finding the service details
                targetservice = (Cus_Service_LB.SelectedItem).ToString();
                Cus_Source cus_service = new Cus_Source();
                object[] serviceDetails = cus_service.Service_Details(targetservice);
                foreach (string serviceD in serviceDetails)
                {
                    Cus_ServiceDtls_LB.Items.Add(serviceD);
                }

                Cus_Service_cusID.Text = cus_ID.ToString();
                Cus_Service_cusID.ReadOnly = true;
            }

            catch(Exception)
            {

            }

            //Find Mechanics who can handle this job
            //Dictionary<int, string> appointmentDate = cus_service.MechanicTime();
            //foreach(KeyValuePair<int, string> entry in appointmentDate)
            //{
            //    TimeSpan timeSpan = TimeSpan.Parse(entry.Value);
            //    if (timeSpan.Hours == 8 && timeSpan.Minutes >30)
            //    {
            //        appointmentDate.Remove(entry.Key);
            //    }
            //    else if(timeSpan.Hours <= 7) 
            //    {
            //        MechanicCB.Items.Add(entry.Key);
            //    }
            //}
        }


    }
}
