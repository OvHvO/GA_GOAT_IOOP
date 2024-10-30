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
        public static string name;
        public Receptionist_home(string n, string connectionS)
        {   
            InitializeComponent();
            name = n;
            Receptionists recep = new Receptionists(connectionS);

        }

        private void Receptionist_home_Load(object sender, EventArgs e)
        {
           

            Rcp_home_lbl.Text = $"Welcome! {name}";
        }

        private void Rcp_Add_Click(object sender, EventArgs e)
        {
            Rcp_signUp_form addcus= new Rcp_signUp_form();
            addcus.ShowDialog();
        }

        private void Rcp_home_lbl_Click(object sender, EventArgs e)
        {

        }

        private void Rcp_home_signOut_Click(object sender, EventArgs e)
        {
            DialogResult AcceptorNot = MessageBox.Show("Do you want to Sign Out?", "Sign Out", MessageBoxButtons.YesNo);
            if (AcceptorNot == DialogResult.Yes) 
            {
                var Signin = new Login_Pages();
                this.Hide();
                Signin.ShowDialog();
            }
            else
            {
                // nothing....
            }
        }

        private void Rcp_home_delCus_Click(object sender, EventArgs e)
        {
            var DEl= new Rcp_delCusForm();
            DEl.ShowDialog();
        }

        private void rcp_updateProf_btn_Click(object sender, EventArgs e)
        {
            Users object01=new Users(name);
            Update_profile profile_form= new Update_profile(name);
            profile_form.ShowDialog();
        }
    }
}
