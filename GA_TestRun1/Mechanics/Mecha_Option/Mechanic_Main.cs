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

namespace GA_TestRun1.Mechanics.Mecha_Option
{
    public partial class Mechanic_Main : UserControl
    {
        private string Name;
        private string Contact;
        private string Connection;

        public Mechanic_Main(string N, string Connections, string Contactnum)
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#EEEBE3");

            Mechanic mechanic = new Mechanic(Connections);
            Name = N;
            Contact = Contactnum;
            Connection = Connections;
        }

        public Mechanic_Main(string newUsername)
        {
            Name = newUsername;
        }

        private void Refresh_btn_Click(object sender, EventArgs e)
        {
            RefreshProfile();
        }

        private void RefreshProfile()
        {
            string[] newprof = (string[])Receptionists.newprofile(Name);
            Name_lbl.Text = newprof[0];
            PNum_lbl.Text = newprof[1];
        }

        private void Welcome_txt_Click(object sender, EventArgs e)
        {

        }
    }
}
