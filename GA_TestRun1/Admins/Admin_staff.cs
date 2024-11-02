using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace GA_TestRun1.Admins
{
    public partial class Admin_staff : UserControl
    {
        public Admin_staff()
        {
            InitializeComponent();
        }

        private void RoleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {   
            StaffListBox.Items.Clear();
            if (RoleComboBox.SelectedItem.ToString() == "Receptionist")
            {
                Admins_Source rcptionistStaff = new Admins_Source();
                List<string> staffList = rcptionistStaff.Rcp_Net();
                foreach (string item in staffList)
                {
                    StaffListBox.Items.Add(item);
                }
            }
            else if (RoleComboBox.SelectedItem.ToString() == "Mechanic")
            {
                Admins_Source mechanicStaff = new Admins_Source();
                List<string> staffList = mechanicStaff.Mechanic_Net();
                foreach (string item in staffList)
                {
                    StaffListBox.Items.Add(item);
                }
            }
            else
            {
            }

        }

    }
}
