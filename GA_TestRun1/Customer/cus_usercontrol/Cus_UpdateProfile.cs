using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GA_TestRun1.Customer.cus_usercontrol
{
    public partial class Cus_UpdateProfile : UserControl
    {
        private int cus_ID;
         
        public Cus_UpdateProfile(int CusID)
        {
            InitializeComponent();
            cus_ID = CusID;
            Cus_Source cus = new Cus_Source();
            object[] cus_Details = cus.Cus_Profile(cus_ID);
            if (cus_Details != null && cus_Details.Length >= 3)
            {
                Cus_ID_TB.Text = cus_Details[0].ToString();
                Cus_ID_TB.ReadOnly = true;
                Cus_Update_UN_TB.Text = cus_Details[1].ToString();
                Cus_Update_CN_TB.Text = cus_Details[2].ToString();
            }
            else
            {
                MessageBox.Show("Failed to load customer details.");
            }
        }


        private void Cus_Update_Btn_Click(object sender, EventArgs e)
        {
            string cus_UN = Cus_Update_UN_TB.Text;
            string cus_PW = Cus_Update_PW_TB.Text;
            bool isValidContact = int.TryParse(Cus_Update_CN_TB.Text, out int cus_CN);

            if (string.IsNullOrWhiteSpace(cus_UN) || string.IsNullOrWhiteSpace(cus_PW) || !isValidContact)
            {
                MessageBox.Show("Please fill in all fields correctly. Contact number must be numeric.");
                return;
            }

            Cus_Source cus = new Cus_Source();
            bool updateC = cus.Cus_Update_Profile(cus_ID, cus_UN, cus_PW, cus_CN);

            if (updateC)
            {
                MessageBox.Show("Profile updated successfully!");
            }
            else
            {
                MessageBox.Show("Failed to update profile. Please try again.");
            }
        }


    }
}
