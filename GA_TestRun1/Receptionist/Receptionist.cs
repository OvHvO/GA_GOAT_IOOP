using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Azure.Identity;
using GA_TestRun1;
using GA_TestRun1.Customer;

namespace GA_TestRun1.Receptionist
{
    internal class Receptionists
    {

        static string connectionS = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\LAB_IOOP\\TEST_RUN_GIT\\GA-Backup001\\GA_GOAT_IOOP\\GA_TestRun1\\Database_GA.mdf;Integrated Security=True";
        SqlConnection conn = new SqlConnection(connectionS);
        private string Username;
        private string Password;
        private string SelectedItems;
        public string usernames
        {
            get => Username; set => Username = value;
        }
        public string passwords { get => Password; set => Password = value; }
        public string selecteditem { get => SelectedItems; set => SelectedItems = value; }

        public Receptionists(string username, string password)
        {
            usernames = username;
            passwords = password;

        }

        public Receptionists(string selecteditems)
        {
            selecteditem = selecteditems;
        }

        public static ArrayList ViewCustomer()
        {

            ArrayList ViewCus = new ArrayList();
            SqlConnection conn = new SqlConnection(connectionS);
            conn.Open();
            //call customer username
            string command = "Select customerUsername from Customers";
            SqlCommand cmd = new SqlCommand(command, conn);
            // Read the data
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            { // Add data into Arraylist
                ViewCus.Add(reader.GetString(0));
            }
            conn.Close();
            return ViewCus;

        }

        public static ArrayList viewProfileCus(string Selected)
        {
            ArrayList CusDetail = new ArrayList();
            SqlConnection conn = new SqlConnection(connectionS);

            conn.Open();
            string command = "Select customerUsername,CustomerContactNum from Customers where customerUsername=@username";
            SqlCommand cmd = new SqlCommand(command, conn);
            cmd.Parameters.AddWithValue("@username", Selected);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                CusDetail.Add(reader.GetString(0));
                CusDetail.Add(reader.GetInt32(1));

            }
            conn.Close();
            return CusDetail;


        }

        public void delCus(string selected)
        {
            SqlConnection conn = new SqlConnection(connectionS);

            conn.Open();
            string command = "Delete from Customers where customerUsername=@username";
            SqlCommand cmd = new SqlCommand(command, conn);
            cmd.Parameters.AddWithValue("@username", selected);
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Delete Sucessfully!", "Delete Customer");
            }
            else
            {
                MessageBox.Show("Something Went Wrong, Please try again", "Delete Failed");

            }
            conn.Close();
        }

        //refresh method
        public static List<string> refCus()
        {
            SqlConnection conn = new SqlConnection(connectionS);

            List<string> cusName = new List<string>();
            conn.Open();
            string query = "Select customerUsername from Customers";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                cusName.Add(read.GetString(0));
            }
            conn.Close();
            return cusName;
        }

        public void rcpUpdateProf(string oldusername, string username, string password)
        {



            usernames = username;
            passwords = password;

            using (SqlConnection conn = new SqlConnection(connectionS))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction(); // begin the update
                try
                {
                    string query1 = @"Select rcptionistUsername from Receptionists where rcptionistUsername=@username
                                    UNION ALL
                                    Select customerUsername from Customers where customerUsername=@username
                                    UNION ALL
                                    Select mechanicUsername from Mechanics where mechanicUsername= @username
                                    UNION ALL
                                    Select adminUsername from Admins where adminUsername=@username";
                    SqlCommand cmd = new SqlCommand(query1, conn, transaction);
                    cmd.Parameters.AddWithValue("@username", username);

                    string query2 = "Update Receptionists set rcptionistUsername=@username,rcptionistPW=@password where rcptionistUsername=@oldusername";
                    SqlCommand cmd2 = new SqlCommand(query2, conn, transaction);
                    cmd2.Parameters.AddWithValue("@username", username);
                    cmd2.Parameters.AddWithValue("@password", password);
                    cmd2.Parameters.AddWithValue("@oldusername", oldusername);



                    if (cmd2.ExecuteNonQuery() > 0 && cmd.ExecuteNonQuery() == 0)
                    {
                        transaction.Commit(); //transaction done (when all database change sucess, it will commit change)
                        MessageBox.Show("Update Sucessfull");

                    }
                    else
                    {

                        transaction.Rollback(); //Rollback transactions (at least one failed to change, it will cancel the change)
                        string messages = "The Username seems has been used or the update failed, Please Try again later";
                        errorMessage(messages);

                    }




                }


                catch (Exception ex)
                {
                    MessageBox.Show("User not found or System Wrong! Error Message: " + ex.ToString());

                }

            }

        }

        public void errorMessage(string messages)
        {
            MessageBox.Show(messages, "Error");
        }

    }
}





