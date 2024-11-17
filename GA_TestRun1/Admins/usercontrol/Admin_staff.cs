using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace GA_TestRun1.Admins
{
    public partial class Admin_staff : UserControl
    {
        private string selectedStaff;
        private string selectedRole;
        public Admin_staff()
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#EEEBE3");
        }

        private void RoleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {   
            StaffListBox.Items.Clear();
            selectedStaff = null;
            StaffDetailsLB.Items.Clear();

            if (RoleComboBox.SelectedItem.ToString() == "Receptionist")
            {
                Admins_Source rcptionistStaff = new Admins_Source();
                List<string> staffList = rcptionistStaff.Rcp_Net();
                try
                {
                    foreach (string item in staffList)
                    {
                        StaffListBox.Items.Add(item);
                    }
                }

                catch (Exception)
                {
                    ///Already show from the Admin_Source
                }
            }
            else if (RoleComboBox.SelectedItem.ToString() == "Mechanic")
            {
                Admins_Source mechanicStaff = new Admins_Source();
                List<string> staffList = mechanicStaff.Mechanic_Net();
                try
                {
                    foreach (string item in staffList)
                    {
                        StaffListBox.Items.Add(item);
                    }
                }

                catch (Exception)
                {
                    ///Already show from the Admin_Source
                }
            }
            else
            {
            }

        }

        private void StaffListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            StaffDetailsLB.Items.Clear();

            selectedStaff = StaffListBox.SelectedItem as string;
            selectedRole = RoleComboBox.SelectedItem as string;

            Admins_Source targetStaff = new Admins_Source();
            string[] staffDetails = targetStaff.Staff_Details(selectedRole, selectedStaff);
            try
            {
                foreach (string item in staffDetails)
                {
                    StaffDetailsLB.Items.Add(item);
                }
            }

            catch (Exception)
            {
                ///Already show from the Admin_Source
            }
        }

        private void StaffDeleteBtn_Click(object sender, EventArgs e)
        {   
            if (selectedStaff != null)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    StaffDetailsLB.Items.Clear();
                    Admins_Source deleteStaff = new Admins_Source();
                    bool deleteResult = deleteStaff.Delete_Staff(selectedRole, selectedStaff);
                    if (deleteResult)
                    {
                        MessageBox.Show("Successfully deleted");

                    }
                    else
                    {
                        MessageBox.Show("Problem Occurs, please try again");
                    }
                }

            }
            else
            {
                MessageBox.Show("Please choose a staff");
            }
        }

        private void StaffAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string username = NewStaffNameTB.Text;
                int contactnum = Convert.ToInt32(NewStaffContactNumTB.Text);
                string role = NewStaffRoleCB.SelectedItem as string;
                Admins_Source newStaff = new Admins_Source();
                bool newStaffResult = newStaff.Staff_ADD(role, username, contactnum);
                if (newStaffResult)
                {
                    MessageBox.Show("New staff created");
                }
            }

            catch
            {
                MessageBox.Show("Please enter a correct form of contact number.");
            }
        }

    }
}
