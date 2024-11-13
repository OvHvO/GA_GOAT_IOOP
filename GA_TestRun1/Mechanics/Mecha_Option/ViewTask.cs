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
    public partial class ViewTask : Form
    {        
        string CustomerID;
        string Appoid;
        string Mcnname;

        public ViewTask()
        {
            InitializeComponent();
        }

        private void Assign_task_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#EEEBE3");
            serviceDateTimepick.Format = DateTimePickerFormat.Custom;
            serviceDateTimepick.CustomFormat = "dd / MM / yyyy hh: mm tt";
            serviceDateTimepick.ShowUpDown = true;
            //this.BackColor = ColorTranslator.FromHtml("#EEEBE3");
            //List<string> mecName = new List<string>();
            //mecName = Mechanic.mechanicName();
            //foreach (var items in mecName)
            //{
            //    Mec_namelistb.Items.Add(items);
            //}
        }

        private void Mec_namelistb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
