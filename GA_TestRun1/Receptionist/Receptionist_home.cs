using System;
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
    public partial class Receptionist_home : Form
    {
        public Receptionist_home()
        {
            InitializeComponent();
        }

        private void Receptionist_home_Load(object sender, EventArgs e)
        {

        }

        private void Rcp_Add_Click(object sender, EventArgs e)
        {
            Rcp_signUp_form addcus= new Rcp_signUp_form();
            addcus.ShowDialog();
        }
    }
}
