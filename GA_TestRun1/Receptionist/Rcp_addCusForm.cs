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
    public partial class Rcp_addCusForm : UserControl
    {   
        //Create an Instance Fields
        private static Rcp_addCusForm _instance;
        public Rcp_addCusForm()
        {
            InitializeComponent();
        }

        //Instance Constructor Used to Connect With Database and Other Pages
        //Create an Instance Constructors(Property)

        public static Rcp_addCusForm Instance
        {
            get 
            {
                if (_instance == null)
                {
                    _instance = new Rcp_addCusForm();
                }
                return _instance;
            }

        }

        private void Rcp_addCusForm_Load(object sender, EventArgs e)
        {
            Sup_Cbox_role.SelectedIndex = 0;
        }

        private void Sup_username_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sup_password_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sup_Cpassword_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sup_Cbox_role_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Sup_contNum_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sup_btn_Click(object sender, EventArgs e)
        {
            Users signup = new Users(Sup_username_txt.Text, Sup_password_txt.Text);
            if (Sup_password_txt.Text != Sup_Cpassword_txt.Text)
            {
                MessageBox.Show("Password Doesn't Match, Please Try Again", "Reminder");
                Sup_password_txt.Clear();
                Sup_Cpassword_txt.Clear();
            }
            else if (!CheckIsNullorEmpty(Sup_contNum_txt.Text, Sup_Cpassword_txt.Text, Sup_password_txt.Text, Sup_username_txt.Text))
            {
                MessageBox.Show("Please fill all the blanks before submit!!!", "Check Again");
            }


            else
            {   //loop for the combobox and define what user have selected
                for (int i = 0; i < Sup_Cbox_role.Items.Count; i++)
                {
                    if (Sup_Cbox_role.SelectedIndex == i)
                    {
                        if (int.TryParse(Sup_contNum_txt.Text, out int phoneNum))
                        {



                            //Define SignUp Role
                            switch (i)
                            { //cus rep mech
                                case 0:
                                    {
                                       DialogResult YesorNo= MessageBox.Show("Do you want to Add this customer?","Reminder",MessageBoxButtons.YesNo);
                                        if (YesorNo == DialogResult.Yes)
                                        {

                                        
                                            signup.Customer_Sup(Sup_username_txt.Text, Sup_password_txt.Text, phoneNum);

                                            Sup_password_txt.Clear();
                                            Sup_username_txt.Clear();
                                            Sup_contNum_txt.Clear();
                                            Sup_Cpassword_txt.Clear();

                                            break;
                                        }
                                        break;
                                    }


                            }
                        }
                        else
                        {
                            MessageBox.Show("Please Enter Numbers Only In contact Number field", "Reminder");
                        }

                    }
                    else
                    {
                        // MessageBox.Show("Please Choose Your Role!!", "Reminder");
                        continue;
                    }
                }
            }
        }

        //Check the user input is null or not (*params is parameter)
        private bool CheckIsNullorEmpty(params string[] inputs)
        {
            foreach (string input in inputs)
            {
                if (string.IsNullOrWhiteSpace(input))
                {
                    return false;
                }

            }
            return true;
        }
    }
}
