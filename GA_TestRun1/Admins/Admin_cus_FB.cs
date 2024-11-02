using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GA_TestRun1.Admins
{
    public partial class Admin_cus_FB : UserControl
    {
        private int selectedFB_ID;
        public Admin_cus_FB()
        {
            InitializeComponent();
            Admins_Source objCusFB = new Admins_Source();
            objCusFB.Delete_Overtime_FB();
            List<string> feedBackList = objCusFB.CusFB_Net();
            foreach (string feedBack in feedBackList)
            {
                CusFBlistBox.Items.Add(feedBack);
            }

        }

        private void CusFBlistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedFB_ID = Convert.ToInt32(CusFBlistBox.SelectedItem);

            Admins_Source objCusFB = new Admins_Source();
            string fbContent = objCusFB.CusFB_Content(selectedFB_ID);
            string[] cusDetails = objCusFB.CusFB_Details(selectedFB_ID);

            CusFBContentTB.Text = fbContent;

            foreach(string item in cusDetails) 
            {
                 CusDetailsLB.Items.Add(item);
            }
        }

        private void CusFB_NoticeBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Each customer feedback entry will only exist in the system for 30 days.\nAfter 30 days, it will be automatically deleted, so please check customer feedback regularly.\nThank you.");
        }
    }
}
