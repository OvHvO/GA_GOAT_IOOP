using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GA_TestRun1.Receptionist
{
    public partial class Bill_Generate : Form
    {
        int ServiceID;
        public Bill_Generate(int serviceid)
        {
            InitializeComponent();
            ServiceID = serviceid;
        }

        private void Bill_Generate_Load(object sender, EventArgs e)
        {
            bill_dataview.DataSource = Receptionists.billdetails(ServiceID);
        }


    }
}
