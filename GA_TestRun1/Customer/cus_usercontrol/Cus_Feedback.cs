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
        public Cus_Feedback()
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#EEEBE3");
            Cus_Source cus = new Cus_Source();
            
        }
    }
}
