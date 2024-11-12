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
    public partial class Cus_AP_Management : UserControl
    {
        private int cusID;
        private string target;
        public Cus_AP_Management(int CUS_ID)
        {
            InitializeComponent();
            cusID = CUS_ID;
            this.BackColor = ColorTranslator.FromHtml("#EEEBE3");
            Cus_Source obj1 = new Cus_Source();
            List<string> AP_list = obj1.CusNetChecking(cusID, "NOT COMPLETE");
            foreach(string item in AP_list)
            {
                CusAP_LB.Items.Add(item);
            }
        }

        private void Cus_RSH_Btn_Click(object sender, EventArgs e)
        {
            Cus_Source rsh = new Cus_Source();
            bool checkR = rsh.Reschedule_AP(target);
            if (checkR)
            {
                MessageBox.Show("Your reschedule request has been submitted. Please wait for a response from the receptionist.\nThank you.");
            }
            else
            {
                MessageBox.Show("The reschedule request has some problem.");
            }
        }

        private void CusAP_LB_SelectedIndexChanged(object sender, EventArgs e)
        {
            CusAPDtls_LB.Items.Clear();
            target = CusAP_LB.SelectedItem as string;
            Cus_Source cus = new Cus_Source();
            List<string> cusAP_dtls = cus.AppoinmentDtls(target);
            foreach (string s in cusAP_dtls)
            {
                CusAPDtls_LB.Items.Add(s);
            }
        }

        private void cus_CancelAP_Btn_Click(object sender, EventArgs e)
        {
            Cus_Source cancel = new Cus_Source();
            bool checkR = cancel.Cancel_AP(target);
            if(checkR)
            {
                MessageBox.Show("Service Appoinment has been deleted");
            }
            else
            {
                MessageBox.Show("There are some problems");Wi
            }
        }
    }
}
