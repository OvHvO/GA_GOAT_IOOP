using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
    public partial class Cus_deleteForm : UserControl
    {   //Create an Instance Constructor and Property
        
        private static Cus_deleteForm _instance;
       
        
        public Cus_deleteForm()
        {
            InitializeComponent();

        }


        //创建实例（instance）
        public static Cus_deleteForm Instance
        {
            get 
            { 
                if (_instance == null)      // 当实例为null值，会创建一个新的实例，并返回
                {
                    _instance = new Cus_deleteForm();
                }
                return _instance;           
            }
        }

       

       



        private void Cus_deleteForm_Load(object sender, EventArgs e)
        {
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
                string Selected = Cus_listBox.SelectedItem as string;
                ArrayList CusDetail = Receptionists.viewProfileCus(Selected);
                //Receptionists recep = new Receptionists(Selected);

                foreach (var items in CusDetail)
                {
                    Cus_detail_listb.Items.Add(items);

                }

            }
            catch (Exception er)
            {
                MessageBox.Show("Something Went Worng" + er.Message, "Error");
            }
        }

        private void Cus_del_Click(object sender, EventArgs e)
        {
            string Selected = Cus_listBox.SelectedItem as string;
            //Receptionists recep = new Receptionists(Selected);
            DialogResult delAcceptorNot = MessageBox.Show("Are you confirm want to delete this customer?", "Delete Customer", MessageBoxButtons.YesNo);
            if (delAcceptorNot == DialogResult.Yes)
            {
                Receptionists.delCus(Selected);


            }
        }

        private void ref_Rcpbtn_Click(object sender, EventArgs e)
        {
            //Refresh the data to avoid deleted data

            Cus_listBox.Items.Clear();
            //call refresh method(static)
            List<string> cusName = Receptionists.refCus();
            foreach (var cus in cusName)
            {
                Cus_listBox.Items.Add(cus);
            }
        }

        private void Cus_detail_listb_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }
    }
}
