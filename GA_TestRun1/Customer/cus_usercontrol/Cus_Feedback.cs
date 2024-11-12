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

        }
    }
}
