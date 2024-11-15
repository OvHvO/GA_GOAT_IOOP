using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            this.BackColor = ColorTranslator.FromHtml("#EEEBE3");

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

            //---------- Task Content----------//
            Show_taskDetail.Text = Mechanic.PassContent().ToString();
        }

        private void Request_btn_Click(object sender, EventArgs e)
        {
            string P_ListBox;
            string P_TxtBox;
            string P_ComboB;

            if (Parts_ListB.SelectedItem == null)
            {
                MessageBox.Show("Warning: Please select parts to perform task.");
                return;
            }

            if (string.IsNullOrWhiteSpace(R_Quantity_txt.Text))
            {
                MessageBox.Show("Warning: Please enter quantity to perform task.");
                return;
            }

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
            string Quantities = Mechanic.PassQuantity();
            int.TryParse(Quantities, out int quantity);
            int.TryParse(U_Quantity_txt.Text, out int uquantity);

            if (Update_List.SelectedItem == null)
            {
                MessageBox.Show("Warning: Please select an item to perform task.");
                return;
            }

            else if (string.IsNullOrWhiteSpace(U_Quantity_txt.Text))
            {
                MessageBox.Show("Warning: Please enter quantity to perform task.");
                return;
            }

            else if (uquantity > quantity)
            {
                MessageBox.Show("Warning: Quantity is more than Requested Quantity.");
                U_Quantity_txt.Clear();
                return;
            }

            
            U_ListBox = Update_List.SelectedItem.ToString();
            U_TxtBox = U_Quantity_txt.Text;

            Mechanic mechanic = new Mechanic();
            Mechanic.UpdateParts(U_ListBox, U_TxtBox, Manage_CarNum);
            U_Quantity_txt.Clear();
        }

        private void Parts_ListB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Update_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mechanic mechanic = new Mechanic();
            Customer_Show.Text = Mechanic.ShowName(Update_List.SelectedItem.ToString(), Manage_CarNum);
        }

        private void Reload_pic_Click(object sender, EventArgs e)
        {
            Update_List.Items.Clear();
            List<string> UUparts = new List<string>();
            UUparts = Mechanic.UParts();
            foreach (string Parts in UUparts)
            {
                Update_List.Items.Add(Parts);
            }
        }

        private void Customer_Show_TextChanged(object sender, EventArgs e)
        {

        }

        private void Show_taskDetail_TextChanged(object sender, EventArgs e)
        {

        }

        private void U_Quantity_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
