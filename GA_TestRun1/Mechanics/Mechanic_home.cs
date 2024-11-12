using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GA_TestRun1.Admins;
using GA_TestRun1;
using GA_TestRun1.Customer;
using GA_TestRun1.Receptionist;
using GA_TestRun1.Mechanics.Mecha_Option;

namespace GA_TestRun1.Mechanics
{
    public partial class Mechanic_home : Form
    {
        public Mechanic_home()
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#EEEBE3");
        }

        private void OptionPanel_Paint(object sender, PaintEventArgs e)
        {
            OptionPanel.BackColor = ColorTranslator.FromHtml("#69764F");
            //----------Change btn text colour----------//
            V_ServiceTask_btn.ForeColor = ColorTranslator.FromHtml("#EEEBE3");
            R_Service_btn.ForeColor = ColorTranslator.FromHtml("#EEEBE3");
            M_Inventory_btn.ForeColor = ColorTranslator.FromHtml("#EEEBE3");
            U_Profile_btn.ForeColor = ColorTranslator.FromHtml("#EEEBE3");
            SignOut_btn.ForeColor = ColorTranslator.FromHtml("#EEEBE3");
        }

        private void Detailpanel_Paint(object sender, PaintEventArgs e)
        {
            Detailpanel.BackColor = ColorTranslator.FromHtml("#EEEBE3");
        }


//==============================Navigation Option==============================//
        private void V_ServiceTask_btn_Click(object sender, EventArgs e)
        {
            //----------Change border size----------//
            this.V_ServiceTask_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.V_ServiceTask_btn.FlatAppearance.BorderSize = 0;
            LoadUserControl(new Mechanic_View());
        }


        private void R_Service_btn_Click(object sender, EventArgs e)
        {
            //----------Change border size----------//
            this.R_Service_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.R_Service_btn.FlatAppearance.BorderSize = 0;
            LoadUserControl(new Mechanic_Record());
        }


        private void M_Inventory_btn_Click(object sender, EventArgs e)
        {
            //----------Change border size----------//
            this.M_Inventory_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.M_Inventory_btn.FlatAppearance.BorderSize = 0;
            LoadUserControl(new Mechanic_Manage());
        }


        private void U_Profile_btn_Click(object sender, EventArgs e)
        {
            //----------Change border size----------//
            this.U_Profile_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.U_Profile_btn.FlatAppearance.BorderSize = 0;
            LoadUserControl(new Mechanic_Update());
        }


        private void SignOut_btn_Click(object sender, EventArgs e)
        {
            //----------Change border size----------//
            this.U_Profile_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.U_Profile_btn.FlatAppearance.BorderSize = 0;
        }


        private void Mechanic_home_Load(object sender, EventArgs e)
        {
            LoadUserControl(new Mechanic_Main());
        }

        private void Logo_img_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Mechanic_Main());
        }


        //----------For 1 argument to show other panels----------//
        private void LoadUserControl(UserControl userControl)
        {
            Detailpanel.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            Detailpanel.Controls.Add(userControl);
        }



        //============================== ==============================//
    }
}
