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
    public partial class Assign_task : Form
    {
        string CustomerID;
        string Appoid;
        string Rcpname;
        public Assign_task(string name, string vehicle, string contactNum, string cusid, string appid, string username)
        {
            InitializeComponent();
            Name_txtb.Text = name;
            Vehicle_txtb.Text = vehicle;
            ContactNum_txtb.Text = contactNum;
            CustomerID = cusid;
            Appoid = appid;
            Rcpname = username;
        }

        private void Assign_task_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#EEEBE3");
            List<string> mecName = new List<string>();
            mecName = Receptionists.mechanicName();
            foreach (var items in mecName)
            {
                Mec_namelistb.Items.Add(items);
            }
        }

        private void Mec_namelistb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

     

        

        private void task_btn_Click_1(object sender, EventArgs e)
        {
            string selectedItems = Mec_namelistb.SelectedItem.ToString();
            if (string.IsNullOrEmpty(task_nametxtb.Text) == false)
            {
                Receptionists recep = new Receptionists();
                recep.assignMec(selectedItems, task_nametxtb.Text, Appoid, Rcpname);
            }
            else
            {
                MessageBox.Show("Please fill all the blanks");
            }
        }
    }
}
