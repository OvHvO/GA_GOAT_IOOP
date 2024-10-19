using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GA_TestRun1
{
    public partial class Sign_Up_form : Form
    {   
        public Sign_Up_form()
        {
            InitializeComponent();
        }

        //Username Enter
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //Password Enter
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        //Re-enter Password
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        
       

        //Return Link
        private void Sup_linklbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Under Construct.....
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Sup_Cbox_role_SelectedIndexChanged(object sender, EventArgs e)
        {

        }




        private void Sup_contNum_txt_TextChanged(object sender, EventArgs e)
        {

        }
        //Sign Up function
        private void Sup_btn_Click(object sender, EventArgs e)
        {
            
            Users signup = new Users(Sup_username_txt.Text,Sup_password_txt.Text);
            if (Sup_password_txt.Text != Sup_Cpassword_txt.Text) 
            {
                MessageBox.Show("Password Doesn't Match, Please Try Again", "Reminder");
                Sup_password_txt.Clear();
                Sup_Cpassword_txt.Clear();
            }
            else
            {   //loop for the combobox and define what user have selected
                for (int i = 0; i < Sup_Cbox_role.Items.Count; i++) 
                {
                    if (Sup_Cbox_role.SelectedIndex == i) 
                    {   if (int.TryParse(Sup_contNum_txt.Text, out int phoneNum))
                        {



                            //Define SignUp Role
                            switch (i)
                            { //cus rep mech
                                case 0:
                                    {
                                        signup.Customer_Sup(Sup_username_txt.Text, Sup_password_txt.Text, phoneNum);
                                        Sup_password_txt.Clear();
                                        Sup_username_txt.Clear();
                                        Sup_contNum_txt.Clear();
                                        Sup_Cpassword_txt.Clear();
                                        Sup_Cbox_role.SelectedIndex = -1;
                                        break;
                                    }
                                case 1:
                                    {
                                        signup.Receptionist_Sup(Sup_username_txt.Text, Sup_password_txt.Text, phoneNum);
                                        Sup_password_txt.Clear();
                                        Sup_username_txt.Clear();
                                        Sup_contNum_txt.Clear();
                                        Sup_Cpassword_txt.Clear();
                                        Sup_Cbox_role.SelectedIndex = -1;
                                        break;
                                    }
                                case 2:
                                    {
                                        signup.Mechanic_Sup(Sup_username_txt.Text, Sup_password_txt.Text, phoneNum);
                                        Sup_password_txt.Clear();
                                        Sup_username_txt.Clear();
                                        Sup_contNum_txt.Clear();
                                        Sup_Cpassword_txt.Clear();
                                        Sup_Cbox_role.SelectedIndex = -1;
                                        break;
                                    }

                            }
                        }
                        else
                        {
                            MessageBox.Show("Please Enter Numbers Only In contact Number field","Reminder");
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

        
    }


}
