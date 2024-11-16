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

        private string name;
        private string contact;
        private string connection;

        public Receptionist_home(string n, string connectionS, string contactnum)
        {
            InitializeComponent();
            name = n;
            Receptionists receptionists = new Receptionists(connectionS);

            contact = contactnum;
            connection = connectionS;
            //Cus_deleteForm Cus_del = new Cus_deleteForm(connectionS);

        }

        public Receptionist_home(string newUsername)
        {
            name = newUsername;

        }



        private void Receptionist_home_Load(object sender, EventArgs e)
        {
            nav_Bar.BackColor = ColorTranslator.FromHtml("#69764F");
            this.BackColor = ColorTranslator.FromHtml("#EEEBE3");
            Rcp_home_delCus.BackColor = ColorTranslator.FromHtml("#69764F");
            Rcp_home_signOut.BackColor = ColorTranslator.FromHtml("#69764F");
            Rcp_Add.BackColor = ColorTranslator.FromHtml("#69764F");
            rcp_updateProf_btn.BackColor = ColorTranslator.FromHtml("#69764F");
            rcp_manageAppbtn.BackColor = ColorTranslator.FromHtml("#69764F");
            rcp_srcInvbtn.BackColor = ColorTranslator.FromHtml("#69764F");
            rcp_CheckinOutbtn.BackColor = ColorTranslator.FromHtml("#69764F");




            LoadhomePage();



        }

        private void LoadhomePage()
        {
            string[] newprof = (string[])Receptionists.newprofile(name);
            Rcp_home_lbl.Text = $"Welcome! {newprof[0]}";
            Rcp_usernamelbl.Text = newprof[0];
            Rcp_contactNumlbl.Text = newprof[1];
            Rcp_rolelbl.Text = "Receptionist";


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
            Users object01 = new Users(name);
            UpdateProfileF profile_form = new UpdateProfileF(name);
            //profile_form.ShowDialog();
            Instance_loadControl(UpdateProfileF.Instance);

        }


        // -------- Delete Customer Form  --------//

        private void Rcp_home_delCus_Click(object sender, EventArgs e)
        {
            Instance_loadControl(Cus_deleteForm.Instance);
        }

        private void Rcp_Add_Click(object sender, EventArgs e)
        {
            rcp_homePanel.Controls.Clear();
            Loadcontrol(new Rcp_addCusForm());



        }

        private void Cus_delF_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        // Load The usercontrol with the clear pages
        private void Loadcontrol(UserControl controlp)
        {
            rcp_homePanel.Visible = true;
            rcp_homePanel.Controls.Clear();
            controlp.Dock = DockStyle.Fill;
            rcp_homePanel.Controls.Add(controlp);
        }

        // Load Usercontrol with previous data (the data won't delete when switch pages)
        private void Instance_loadControl(UserControl controlPage)
        {    // 确认实例(instance=Cus_deleteForm)是否存在于Panel 1 中，假如不存在就创建一个实例，并移到最前面
            if (!rcp_homePanel.Controls.Contains(controlPage))
            {
                rcp_homePanel.Visible = true;
                rcp_homePanel.Controls.Add(controlPage);
                controlPage.Dock = DockStyle.Fill;
                controlPage.BringToFront();
            }
            //假如 Cus_deleteForm存在 Panel1 中就将Panel1 移动到前方

            else
            {
                controlPage.BringToFront();
            }
        }

        private void nametxt_lbl_Click(object sender, EventArgs e)
        {

        }

        private void rcp_manageAppbtn_btn_Click(object sender, EventArgs e)
        {
            Manage_Appoinment manageform = new Manage_Appoinment(name);
            manageform.ShowDialog();
        }

        

        private void rcp_CheckinOutbtn_btn_Click(object sender, EventArgs e)
        {
            CheckInOutF checkinout=new CheckInOutF();
            checkinout.ShowDialog();
        }
        private void rcp_srcInvbtn_btn_Click(object sender, EventArgs e)
        {
            searchInv search= new searchInv();
            search.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Rcp_profileBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rcp_profieBox_btn_Click(object sender, EventArgs e)
        {
            LoadhomePage();
        }

        private void Rcp_usernamelbl_Click(object sender, EventArgs e)
        {

        }

        private void Rcp_contactNumlbl_Click(object sender, EventArgs e)
        {

        }

        private void Rcp_rolelbl_Click(object sender, EventArgs e)
        {

        }

        private void nav_Bar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Rcp_home_delCus_BackColorChanged(object sender, EventArgs e)
        {

        }

       

        private void logobox_Click(object sender, EventArgs e)
        {
            rcp_homePanel.Controls.Clear();
            rcp_homePanel.Visible = false;
        }

       

        private void buttonhover(object sender, EventArgs e)
        {
            Rcp_home_delCus.BackColor=Color.Aqua;
            
            
        }

        private void buttonmove(object sender, EventArgs e)
        {
            Rcp_home_delCus.BackColor = ColorTranslator.FromHtml("#69764F");
            Rcp_home_delCus.ForeColor = Color.Black;
        }
    }
}
