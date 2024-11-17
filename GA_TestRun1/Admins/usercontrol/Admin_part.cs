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
    public partial class Admin_part : UserControl
    {
        private string selected;
        private string typeOfChange;
        public Admin_part()
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#EEEBE3");
            Admins_Source admin = new Admins_Source();
            List<string> partList = admin.Part_Net();
            foreach (string service in partList)
            {
                PartListBox.Items.Add(service);
            }
            PartIDTB.ReadOnly = true;
        }

        private void PartListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected = PartListBox.SelectedItem as string;
            Admins_Source selectedPart = new Admins_Source();
            string[] partDetails = selectedPart.Part_Details(selected);
            try
            {
                PartIDTB.Text = partDetails[0];
                PartNameTB.Text = selected;
                PartQuantityTB.Text = partDetails[1];
                PartPriceTB.Text = partDetails[2];
                PartNameTB.ReadOnly = true;
                PartIDTB.ReadOnly = true;
            }

            catch (Exception)
            {
                ///Already show from the Admin_Source
            }
        }

        private void PartDeleteBtn_Click(object sender, EventArgs e)
        {
            if (selected != null)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Admins_Source deletePart = new Admins_Source();
                    bool deleteResult = deletePart.Delete_Part(selected);
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
        }

        private void PartSaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string partName = PartNameTB.Text.ToString();
                int partQuantity = Convert.ToInt32(PartQuantityTB.Text);
                int partPrice = Convert.ToInt32(PartPriceTB.Text);

                if (PartListBox.SelectedItem != null)
                {
                    typeOfChange = "EDIT";
                    Admins_Source partEDIT = new Admins_Source();
                    bool result = partEDIT.Part_Change(typeOfChange, partName, partQuantity, partPrice);
                    if (result)
                    {
                        MessageBox.Show("Part edited");
                    }
                    PartIDTB.Clear();
                    PartNameTB.Clear();
                    PartQuantityTB.Clear();
                    PartPriceTB.Clear();
                }
                else
                {
                    typeOfChange = "ADD";
                    Admins_Source partADD = new Admins_Source();
                    bool result = partADD.Part_Change(typeOfChange, partName, partQuantity, partPrice);
                    if (result)
                    {
                        MessageBox.Show("Part added");
                    }
                    PartIDTB.Clear();
                    PartNameTB.Clear();
                    PartQuantityTB.Clear();
                    PartPriceTB.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Please enter the details or choose to edit a part");
            }
            
        }

    }
}
