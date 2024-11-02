using System;
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
    public partial class Admin_part : UserControl
    {
        private string selected;

        public Admin_part()
        {
            InitializeComponent();
            Admins_Source admin = new Admins_Source();
            List<string> partList = admin.Part_Net();
            foreach (string service in partList)
            {
                PartListBox.Items.Add(service);
            }
        }

        private void PartListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected = PartListBox.SelectedItem as string;
            Admins_Source selectedPart = new Admins_Source();
            object[] partDetails = selectedPart.Part_Details(selected);
            foreach (string service in partDetails)
            {

            }
        }
    }
}
