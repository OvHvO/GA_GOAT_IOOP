using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
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
            //Cus_deleteForm Cus_del = new Cus_deleteForm(connectionS);
           
        }

        private void Receptionist_home_Load(object sender, EventArgs e)
        {
           

            Rcp_home_lbl.Text = $"Welcome! {name}";

            
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

       

        private void rcp_updateProf_btn_Click(object sender, EventArgs e)
        {
            Users object01=new Users(name);
            UpdateProfileF profile_form= new UpdateProfileF (name);
            //profile_form.ShowDialog();

            if (!panel1.Controls.Contains(UpdateProfileF.Instance))
            {
                panel1.Controls.Add(UpdateProfileF.Instance);
                UpdateProfileF.Instance.Dock= DockStyle.Fill;
                UpdateProfileF.Instance.BringToFront();
            }

            else
            {
                UpdateProfileF.Instance.BringToFront();
            }

        }
        
        
                        // -------- Delete Customer Form  --------//
       
        private void Rcp_home_delCus_Click(object sender, EventArgs e)
        {
            // 确认实例(instance=Cus_deleteForm)是否存在于Panel 1 中，假如不存在就创建一个实例，并移到最前面
            
            if (!panel1.Controls.Contains(Cus_deleteForm.Instance))
            {
                panel1.Controls.Add(Cus_deleteForm.Instance);
                Cus_deleteForm.Instance.Dock = DockStyle.Fill;
                Cus_deleteForm.Instance.BringToFront();

            } 
            //假如 Cus_deleteForm存在 Panel1 中就将Panel1 移动到前方
            else

            {
                Cus_deleteForm.Instance.BringToFront();
            }



            //var DEl= new Rcp_delCusForm();
            //DEl.ShowDialog();
        }

        private void Rcp_Add_Click(object sender, EventArgs e)
        {
            
            //panel1.Visible = false;
            if (!panel1.Controls.Contains(Rcp_addCusForm.Instance))
            {
                panel1.Controls.Add(Rcp_addCusForm.Instance);
                Rcp_addCusForm.Instance.Dock = DockStyle.Fill;
                Rcp_addCusForm.Instance.BringToFront();

            }
            else
            {
                Rcp_addCusForm.Instance.BringToFront();
            }


            //Rcp_signUp_form addcus= new Rcp_signUp_form();
            //addcus.ShowDialog();
        }

        private void Cus_delF_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
