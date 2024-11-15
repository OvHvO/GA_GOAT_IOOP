using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GA_TestRun1.Mechanics.Mecha_Option
{
    public partial class Mechanic_Manage : Form
    {
        string Manage_CarNum;

        public Mechanic_Manage(string manage_CarNum)
        {
            InitializeComponent();
            Manage_CarNum = manage_CarNum;
        }

        private void Mechanic_Man_Load(object sender, EventArgs e)
        {
            //---------- Parts List Items ----------//
            List<string> parts = new List<string>();
            parts = Mechanic.Parts();
            foreach (string Part in parts)
            {
                Parts_ListB.Items.Add(Part);
            }

            //---------- Used Parts List Items ----------//
            List<string> Uparts = new List<string>();
            Uparts = Mechanic.UParts();
            foreach (string Parts in Uparts)
            {
                Update_List.Items.Add(Parts);
            }

            //---------- Status ComboBox Items ----------//
            Status_Cbo.Items.Add("PENDING");
            Status_Cbo.SelectedIndex = 0;
        }

        private void Request_btn_Click(object sender, EventArgs e)
        {
            string P_ListBox;
            string P_TxtBox;
            string P_ComboB;

            P_ListBox = Parts_ListB.SelectedItem.ToString();
            P_TxtBox = R_Quantity_txt.Text;
            P_ComboB = Status_Cbo.SelectedItem.ToString();

            Mechanic mechanic = new Mechanic();
            Mechanic.RequestParts(P_ListBox, P_TxtBox, P_ComboB, Manage_CarNum);

            Parts_ListB.SelectedIndex = -1;
            R_Quantity_txt.Clear();
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            string U_ListBox;
            string U_TxtBox;

            U_ListBox = Update_List.SelectedItem.ToString();
            U_TxtBox = U_Quantity_txt.Text;

            Mechanic mechanic = new Mechanic();
            Mechanic.UpdateParts(U_ListBox, U_TxtBox);
            Update_List.Items.Clear();

        }

        private void Parts_ListB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Update_List_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
