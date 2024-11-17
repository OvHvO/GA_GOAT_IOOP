using GA_TestRun1.Admins.usercontrol;
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
    public partial class Admin_salesreport : UserControl
    {
        private string currentYear;
        private string monthForm;
        private string target;
        public Admin_salesreport()
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#EEEBE3");
        }

        private void SR_Month_CB_SelectedIndexChanged(object sender, EventArgs e)
        {   
            target = SR_Month_CB.SelectedItem.ToString();

            List<string> months = new List<string>
            {
            "Use to make the index correct", "January", "February", "March", "April", "May", "June",
            "July", "August", "September", "October", "November", "December"
            };

            int index = months.IndexOf(target);
            currentYear = (DateTime.Now.Year).ToString();
            monthForm = (index).ToString("D2");            
        }

        private void SR_Generate_Btn_Click(object sender, EventArgs e)
        {
            if (monthForm != null)
            {
                new Sales_Report(monthForm, currentYear, target).ShowDialog();
            }

            else
            {
                MessageBox.Show("Please choose a month");
            }
        }
    }
}
