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
        public Login_Pages()
        {
            InitializeComponent();
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
            MessageBox.Show(signin.LoginForms(L_username_txt.Text, L_pw_txt.Text));
            L_username_txt.Clear();
            L_pw_txt.Clear();

        }


       private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           Sign_Up_form sign_Up = new Sign_Up_form();
            sign_Up.ShowDialog();
           
        }
    }
}
