using GA_TestRun1.Receptionist;
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
    public partial class Login_Pages : Form
    {
        public static string passwords;
        public Login_Pages()
        {   
            InitializeComponent();
        }

        private void Login_Pages_Load(object sender, EventArgs e)
        {
            Users pass=new Users(passwords);
            passwords=L_pw_txt.Text;
        }

        private void L_username_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void L_pw_txt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void L_sigin_btn_Click(object sender, EventArgs e)
        {   
            Users signin=new Users(L_username_txt.Text,L_pw_txt.Text);
            Users userName = new Users(L_username_txt.Text);
            Receptionists recep = new Receptionists(L_username_txt.Text,L_pw_txt.Text);
            
            MessageBox.Show(signin.LoginForms(L_username_txt.Text, L_pw_txt.Text));
            L_username_txt.Clear();
            L_pw_txt.Clear();

        }


       private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           Sign_Up_form sign_Up = new Sign_Up_form();  
            sign_Up.ShowDialog();
           
        }

        

        private void Lpages_showpw_CheckedChanged(object sender, EventArgs e)
        {   //hide password for privacy

            if (!Lpages_showpw.Checked)
            {
                L_pw_txt.PasswordChar = '*';
            }
            else
            {
                L_pw_txt.PasswordChar='\0';
            }
        }
    }
}
