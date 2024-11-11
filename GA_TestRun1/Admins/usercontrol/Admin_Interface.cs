using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GA_TestRun1.Admins
{
    public partial class Admin_Interface : UserControl
    {
        public static int adminID;
        public int adminID_P { get => adminID; set => adminID = value; }
        public Admin_Interface(string userN)
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#EEEBE3");
            textBox2.ReadOnly = true;
            Admins_Source admin = new Admins_Source();
            object[] adminProfile = admin.Admin_Profile(userN);
            for (int i = 0; i < adminProfile.Length; i++)
            {
                AdminProfilelistBox.Items.Add(adminProfile[i]);
                if (i == 0)
                {
                    adminID = Convert.ToInt32(adminProfile[i]);
                }
            }
        }
    }
}
