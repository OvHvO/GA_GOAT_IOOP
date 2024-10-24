using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GA_TestRun1;
using GA_TestRun1.Admins;
using GA_TestRun1.Customer;
using GA_TestRun1.Mechanics;

namespace GA_TestRun1.Receptionist
{
    public partial class Rcp_delCusForm : Form
    {
        public Rcp_delCusForm()
        {
            InitializeComponent();
        }
        private void Rcp_delCusForm_Load(object sender, EventArgs e)
        {   //Dynamic Arraylist
            
            ArrayList CusName = new ArrayList();

            CusName = Receptionists.ViewCustomer();
            foreach (var items in CusName)
            {
                Cus_listBox.Items.Add(items);
            }
        }

        private void Cus_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //clear the previous detail avoid repeated data

            Cus_detail_listb.Items.Clear();
            
            try 
            {
            //MessageBox.Show(Selected);
            string Selected = Cus_listBox.SelectedItem.ToString();
            ArrayList CusDetail = Receptionists.viewProfileCus(Selected);
            Receptionists recep = new Receptionists(Selected);

                foreach (var items in CusDetail)
                {
                Cus_detail_listb.Items.Add(items);
               
                }  
               
            }
            catch (Exception er)
            {
                MessageBox.Show("Something Went Worng" +er.Message, "Error");
            }

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        //cusprofile
        private void label2_Click(object sender, EventArgs e)
        {


        }

        private void Check_cus_Click(object sender, EventArgs e)
        {

        }

        //Delete Customer Button
        private void button1_Click(object sender, EventArgs e)
        {
            string Selected = Cus_listBox.SelectedItem.ToString();
            Receptionists recep = new Receptionists(Selected);
            DialogResult delAcceptorNot = MessageBox.Show("Are you confirm want to delete this customer?", "Delete Customer", MessageBoxButtons.YesNo);
            if (delAcceptorNot == DialogResult.Yes)
            {
                recep.delCus(Selected);


            }
        }

        private void ref_Rcpbtn_Click(object sender, EventArgs e)
        {   //Refresh the data to avoid deleted data

            Cus_listBox.Items.Clear();
            //call refresh method(static)
            List<string> cusName= Receptionists.refCus();
            foreach (var cus in cusName) 
            {
                Cus_listBox.Items.Add(cus);
            }

           
        }
    }
}
