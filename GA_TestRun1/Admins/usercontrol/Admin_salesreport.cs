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
        public Admin_salesreport()
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#EEEBE3");
        }

        private void SR_Month_CB_SelectedIndexChanged(object sender, EventArgs e)
        {   
            string target = SR_Month_CB.SelectedItem.ToString();

            List<string> months = new List<string>
            {
            "Use to make the index correct", "January", "February", "March", "April", "May", "June",
            "July", "August", "September", "October", "November", "December"
            };

            int index = months.IndexOf(target);
            string currentYear = (DateTime.Now.Year).ToString();
            string monthForm = (index).ToString("D2");

            Admins_Source admin = new Admins_Source();

            //For GrossProfit
            int totalGrossProfit = admin.grossProfitCal(monthForm, currentYear);
            string totalGrossProfitString = totalGrossProfit.ToString();
            SR_totalGrossProfit_TB.Text = "Total Gross Profit : " + totalGrossProfitString;
            List<string> grossProfitList = admin.grossProfitList(monthForm, currentYear);
            foreach(string item in grossProfitList)
            {
                SR_GrossProfit_LB.Items.Add(item);
            }

            //For Total Expenses
            int totalExpenses = 0;
            List<string> finalExpenses_List = new List<string>;
            Dictionary<string, int> totalExpensesDic = admin.ExpensesCal(monthForm,currentYear);

            foreach (KeyValuePair<string, int> item in totalExpensesDic)
            {
                finalExpenses_List.Add($"PartID : {item.Key}---------Sales : {item.Value}");
            }

            foreach (int value in totalExpensesDic.Values)
            {
                totalExpenses += value;
            }

            foreach (string item in finalExpenses_List)
            {
                SR_TotalExpenses_LB.Items.Add(item);
                
            }

        }
    }
}
