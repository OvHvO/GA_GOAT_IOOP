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
    public partial class Cus_Interface : UserControl
    {
        public Cus_Interface()
        {
            InitializeComponent();
            Cus_Source cus = new Cus_Source();
            List<string> promotionservice = cus.Promotion_Service();
            foreach (string promotionserviceitem in promotionservice)
            {
                promotionServiceLB.Items.Add(promotionserviceitem);
            }
        }


    }
}
