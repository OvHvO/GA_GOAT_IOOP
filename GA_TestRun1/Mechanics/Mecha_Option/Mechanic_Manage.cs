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
    public partial class Mechanic_Manage : UserControl
    {
        

        public Mechanic_Manage()
        {
            InitializeComponent();
        }

        private void Mechanic_Manage_Load(object sender, EventArgs e)
        {
            //---------- Parts List Items ----------//
            List<string> parts = new List<string>();
            parts = Mechanic.Parts();
            foreach (string Part in parts)
            {
                Parts_ListB.Items.Add(Part);
            }

            //---------- Status ComboBox Items ----------//
            Status_Cbo.Items.Add("PENDING");
            Status_Cbo.SelectedIndex = 0;
        }

        private void Parts_ListB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Request_btn_Click(object sender, EventArgs e)
        {
            RequestBtn("");
        }

        public void RequestBtn (string P_CarNum)
        {
            string P_ListBox;
            string P_TxtBox;
            string P_ComboB;

            P_ListBox = Parts_ListB.SelectedItem.ToString();
            P_TxtBox = R_Quantity_txt.Text;
            P_ComboB = Status_Cbo.SelectedItem.ToString();

            Mechanic mechanicViewForm = new Mechanic();
            Mechanic.RequestParts(P_ListBox, P_TxtBox, P_ComboB, P_CarNum);
        }

        //public void ReceiveCarNum(string CarNum)
        //{
        //    CarList = CarNum;
        //}
    }
}
