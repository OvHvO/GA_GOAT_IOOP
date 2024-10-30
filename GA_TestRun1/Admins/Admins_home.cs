using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Azure.Identity;
using GA_TestRun1;
using GA_TestRun1.Customer;
using GA_TestRun1.Mechanics;
using GA_TestRun1.Receptionist;

namespace GA_TestRun1.Admins
{
    public partial class Admins_home : Form
    {
        private string userN;
        public Admins_home(string username)
        {
            InitializeComponent();
            userN = username;
            Admins_Source admin = new Admins_Source();
            object[] adminProfile = admin.Admin_Profile(userN);
            for (int i = 0; i < adminProfile.Length; i++)
            {
                AdminProfilelistBox.Items.Add(adminProfile[i]);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void staff_MNG_Click(object sender, EventArgs e)
        {

        }

        private void service_MNG_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
