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
    public partial class Mechanic_Record : UserControl
    {
        public Mechanic_Record()
        {
            InitializeComponent();
        }

        private void Mechanic_Record_Load(object sender, EventArgs e)
        {
            Col_Time.Format = DateTimePickerFormat.Custom;
            Col_Time.CustomFormat = "dd / MM / yyyy hh: mm tt";
            Col_Time.ShowUpDown = true;
        }

        private void Status_Cbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Status_Cbo.Items.Add("COMPLETE");
            Status_Cbo.Items.Add("PENDING");
            Status_Cbo.Items.Add("NOT COMPLETE");
            Status_Cbo.SelectedIndex = 0;
        }

        private void CarNum_Cbo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
