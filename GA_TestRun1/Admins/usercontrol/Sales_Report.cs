using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GA_TestRun1.Admins.usercontrol
{
    public partial class Sales_Report : Form
    {
        public Sales_Report(string monthForm, string currentYear, string month)
        {
            InitializeComponent();

            label4.Text = month;

            Admins_Source admin = new Admins_Source();

            //For Gross Profit
            int totalGrossProfit = admin.grossProfitCal(monthForm, currentYear);
            string totalGrossProfitString = totalGrossProfit.ToString();

            SR_totalGrossProfit_TB.Text = "Total Gross Profit : " + totalGrossProfitString;

            List<string> grossProfitList = admin.grossProfitList(monthForm, currentYear);
            foreach (string item in grossProfitList)
            {
                SR_GrossProfit_LB.Items.Add(item);
            }

            //For Total Expenses
            int totalExpenses = 0;
            List<string> finalExpenses_List = new List<string>();
            Dictionary<string, int> totalExpensesDic = new Dictionary<string, int>()
            {
                { "4 Mechanics Salary", 1200 },
                { "2 Receptionists Salary", 1000 },
                { "Electricity and Water Bill", 400 }
            };

            foreach (KeyValuePair<string, int> item in totalExpensesDic)
            {
                finalExpenses_List.Add($"{item.Key}---------Expenses : {item.Value}");
            }

            foreach (int value in totalExpensesDic.Values)
            {
                totalExpenses += value;
            }

            foreach (string item in finalExpenses_List)
            {
                SR_TotalExpenses_LB.Items.Add(item);

            }

            SR_TotalExpenses_TB.Text = "Total Expenses : " + totalExpenses.ToString();

            //Net Profit
            SR_NetProfit_L.Text = (totalGrossProfit - totalExpenses).ToString();
        }
    }
}
