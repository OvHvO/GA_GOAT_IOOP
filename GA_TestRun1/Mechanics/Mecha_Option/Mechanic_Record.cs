using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GA_TestRun1.Mechanics.Mecha_Option
{
    public partial class Mechanic_Record : UserControl
    {
        string UNames;

        public Mechanic_Record(string UNAME)
        {
            InitializeComponent();
            UNames = UNAME;
        }


        private void Mechanic_Record_Load(object sender, EventArgs e)
        {
            //---------- Date Time Items ----------//
            Col_Time.Format = DateTimePickerFormat.Custom;
            Col_Time.CustomFormat = "dd / MM / yyyy hh: mm tt";
            Col_Time.ShowUpDown = true;

            //---------- Car Number List Items ----------//
            List<string> CarNums = new List<string>();
            CarNums = Mechanic.CarNumber(UNames);
            foreach (string CarNum in CarNums)
            {
                CarNumber_LstB.Items.Add(CarNum);
            }

            //---------- Status ComboBox Items ----------//
            Status_Cbo.Items.Add("COMPLETE");
            Status_Cbo.Items.Add("PENDING");
            Status_Cbo.SelectedIndex = 0;
        }

        private void Status_Cbo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CarNum_Cbo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Submit_btn_Click(object sender, EventArgs e)
        {
            string ComboBox;
            string ListBox;
            string TxtBox;
            
            if (Status_Cbo.SelectedItem == null)
            {
                MessageBox.Show("Warning: Please select a status to perform task.");
                return;
            }

            else if (CarNumber_LstB.SelectedItem == null)
            {
                MessageBox.Show("Warning: Please select an item to perform task.");
                return;
            }

            else if (string.IsNullOrWhiteSpace(Add_txt.Text))
            {
                MessageBox.Show("Warning: Please enter content to perform task.");
                return;
            }

            DateTime CollectionTime = Col_Time.Value;
            ComboBox = Status_Cbo.SelectedItem.ToString();
            ListBox = CarNumber_LstB.SelectedItem.ToString();
            TxtBox = Add_txt.Text;

            Mechanic mechanicViewForm = new Mechanic();
            Mechanic.SaveRecord(CollectionTime, ComboBox, ListBox, TxtBox);
            Mechanic_Manage mechanic_manage = new Mechanic_Manage(ListBox);
            mechanic_manage.ShowDialog();
        }

        private void _SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Number_LstB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
