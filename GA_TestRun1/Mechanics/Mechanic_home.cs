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
        private string Name;
        private string Contact;
        private string Connection;
        string CARNUM;

        public Mechanic_home(string N, string ConnectionS, string ContactNum, string CarNum)
        {
            InitializeComponent();
            Name = N;
            Mechanic mechanics = new Mechanic(Connection);
            Contact = ContactNum;
            Connection = ConnectionS;
            CARNUM = CarNum;
        }


        //============================== Change panel colour ==============================//
        public Mechanic_home(string newUsername)
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#EEEBE3");
            Name = newUsername;
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


//============================== Navigation Option ==============================//
        private void V_ServiceTask_btn_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if the Name is not null, empty or whitespace
                if (string.IsNullOrWhiteSpace(Name))
                {
                    // If Name doesn't exist, it'll show an error message
                    MessageBox.Show("Name is not valid or not provided. Please check the input.",
                                    "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; 
                }
                //----------Change border size----------//
                this.V_ServiceTask_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.V_ServiceTask_btn.FlatAppearance.BorderSize = 0;
                Mechanic_View mechanicViewForm = new Mechanic_View(Name, " ");
                mechanicViewForm.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while trying to load the service task view: {ex.Message}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void R_Service_btn_Click(object sender, EventArgs e)
        {
            //----------Change border size----------//
            this.R_Service_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.R_Service_btn.FlatAppearance.BorderSize = 0;
            LoadUserControl(new Mechanic_Record(Name));
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

            //----------Set Name to latest name----------//
            Users object01 = new Users(Name);
            UpdateProfileF profile_form = new UpdateProfileF(Name);
            LoadUserControl(UpdateProfileF.Instance);
        }


        private void SignOut_btn_Click(object sender, EventArgs e)
        {
            //----------Change border size----------//
            this.U_Profile_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.U_Profile_btn.FlatAppearance.BorderSize = 0;
        }


        private void Mechanic_home_Load(object sender, EventArgs e)
        {
            LoadUserControl(new Mechanic_Main(Name, Connection, Contact));
        }

        private void Logo_img_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Mechanic_Main(Name, Connection, Contact));
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
