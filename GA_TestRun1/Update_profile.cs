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
    public partial class Update_profile : Form
    {
        public static string currentName;
        public Update_profile(string username)
        {
            currentName = username;
            InitializeComponent();
        }

        private void Update_profile_Load(object sender, EventArgs e)
        {

        }

        private void updateProf_usern_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateProf_pw_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateProf_cpw_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateProf_btn_Click(object sender, EventArgs e)
        {
            
                if (updateProf_pw_txt.Text!= updateProf_cpw_txt.Text) 
                { 
    

                        MessageBox.Show("Password not match, Please try again", "Password not match");
                        updateProf_pw_txt.Clear();
                        updateProf_cpw_txt.Clear();

                    
                    
                }
                else if(!checkIsNullorNot(updateProf_usern_txt.Text, updateProf_pw_txt.Text, updateProf_cpw_txt.Text))
                {
                    MessageBox.Show("Please fill all the blanks!!", "Update Profile");

                }
                else
                {
                    DialogResult yes_orNo = MessageBox.Show("Do you sure want to update?", "Update Profile", MessageBoxButtons.YesNo);
                    if (yes_orNo == DialogResult.Yes)
                    {

                        Users updatePro = new Users(currentName);
                        //updatePro.updateProf(updateProf_usern_txt.Text, updateProf_pw_txt.Text);
                        updateProf_usern_txt.Clear();
                        updateProf_pw_txt.Clear();
                        updateProf_cpw_txt.Clear();

                    }
                    
                }

                   
            }
            


        

        //Check the user enter is empty or not
        private bool checkIsNullorNot(params string[] inputs)
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

        private void updateProf_showpw_checkb_CheckedChanged(object sender, EventArgs e)
        {
            if (updateProf_showpw_checkb.Checked)
            {
                updateProf_pw_txt.PasswordChar = '\0';
                updateProf_cpw_txt.PasswordChar= '\0';

            }
            else
            {
                updateProf_pw_txt.PasswordChar = '*';
                updateProf_cpw_txt.PasswordChar ='*';

            }
        }
    }
}
