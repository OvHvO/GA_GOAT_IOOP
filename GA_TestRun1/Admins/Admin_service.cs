using System;
using System.Collections;
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
    public partial class Admin_service : UserControl
    {
        public Admin_service(string connection)
        {
            InitializeComponent();
            Admins_Source admin = new Admins_Source(connection);
            List<string> serviceList = admin.Service_Net();
            foreach (string service in serviceList)
            {
                ServiceListBox.Items.Add(service);
            }
        }

    }
}
