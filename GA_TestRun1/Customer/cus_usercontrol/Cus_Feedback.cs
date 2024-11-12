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
    public partial class Cus_Feedback : UserControl
    {
        private int cus_ID;
        private string selected;
        public Cus_Feedback(int cus_id)
        {
            InitializeComponent();
            cus_ID = cus_id;
            this.BackColor = ColorTranslator.FromHtml("#EEEBE3");
            Cus_Source cus = new Cus_Source();
            List<string> cusFeedback = cus.FeedbackChecking(cus_ID);
            foreach (string s in cusFeedback)
            {
                ServiceAP_LB.Items.Add(s);
            }
        }

        private void ServiceAP_LB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ServiceAPDtls_LB.Items.Clear();
            selected = ServiceAP_LB.SelectedItem as string;
            Cus_Source cus = new Cus_Source();
            List<string> cusAP_dtls = cus.AppoinmentDtls(selected);
            foreach (string s in cusAP_dtls)
            {
                ServiceAPDtls_LB.Items.Add(s);
            }
        }

        private void CusFB_submitBtn_Click(object sender, EventArgs e)
        {
            string feedbackContent = Cus_FeedBack_TB.Text;
            DateTime currentTime = DateTime.Now;

            Cus_Source submit = new Cus_Source();
            bool resultCheck = submit.SubmitFeedback(feedbackContent, selected, cus_ID, currentTime);
            if(resultCheck)
            {
                MessageBox.Show("Feedback submitted");
            }
            else
            {
                MessageBox.Show("There is some problem right here, you can try to find the admin");
            }
        }
    }
}
