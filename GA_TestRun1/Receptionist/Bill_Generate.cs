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
    public partial class Bill_Generate : Form
    {
        int ServiceID;
        string cusid;
        string cusname;
        string carnum;
        public Bill_Generate(int serviceid, string Cusid, string cusName, string carNum)
        {
            InitializeComponent();
            ServiceID = serviceid;
            cusname= cusName;
            cusid=Cusid;
            carnum = carNum;
        }

        private void Bill_Generate_Load(object sender, EventArgs e)
        {   Receptionists receptionists = new Receptionists();
            bill_dataview.DataSource = receptionists.billdetails(ServiceID);
            bill_serviceData.DataSource = receptionists.billServiceDetail(ServiceID);
            subtotal_lbl.Text=receptionists.GetBillTotalAmt();
            carPlateNum.Text=carnum;
            bill_datelbl.Text = DateTime.Now.ToString("G");
            bill_id.Text=cusid;
            bill_name.Text=cusname;
            bill_Notestxt.Text = @"                  NOTES FOR CUSTOMERS
            1. All Charges are Counting in Ringgit Malaysia (RM)
            2. Please Proceed Your Payment In 30 Days
            3. If have Any Issues, Please Take Your Bill To Receptionist
                        PLEASE COME AGAIN


            NO SIGNATURE REQUIRED. MECHINE GENERATED.
                                    ";

        }

        private void bill_dataview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void subtotal_lbl_Click(object sender, EventArgs e)
        {

        }

        private void bill_Notetxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
