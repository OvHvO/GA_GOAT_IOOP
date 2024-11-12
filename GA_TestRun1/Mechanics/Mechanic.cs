using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GA_TestRun1.Mechanics
{
    internal class Mechanic
    {
        static string Connection;
        private string UserName;
        private string Password;
        static string connect = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\nixon\\OneDrive\\Desktop\\IOOP\\GA_Test2\\GA_TestRun1\\Database_GA.mdf;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connect);


        public Mechanic(string connection)
        {
            Connection = connection;

        }

        public string UserNames
        {
            get { return UserName; }
            set { UserName = value; }
        }

        public string Passwords
        {
            get { return Password; }
            set { Password = value; }
        }

        public Mechanic(string UserName, string Password)
        {
            UserNames = UserName;
            Passwords = Password;
        }

        public void mcnUpdateProf(string oldUserName, string UserName, string Password)
        {
            UserNames = UserName;
            Passwords = Password;
            using (SqlConnection connection = new SqlConnection(connect))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction(); // begin the update
                try
                {
                    string checking1 = @"Select rcptionistUsername from Receptionists where rcptionistUsername=@username
                                    UNION ALL
                                    Select customerUsername from Customers where customerUsername=@username
                                    UNION ALL
                                    Select mechanicUsername from Mechanics where mechanicUsername= @username
                                    UNION ALL
                                    Select adminUsername from Admins where adminUsername=@username";
                    SqlCommand cmd = new SqlCommand(checking1, connection, transaction);
                    cmd.Parameters.AddWithValue("@username", UserName);

                    string checking2 = "Update Mechanics set mechanicUsername=@username, mechanicPW=@password where mechanicUsername=@oldusername";
                    SqlCommand cmd2 = new SqlCommand(checking2, connection, transaction);
                    cmd2.Parameters.AddWithValue("@username", UserName);
                    cmd2.Parameters.AddWithValue("@password", Password);
                    cmd2.Parameters.AddWithValue("@oldusername", oldUserName);


                    if (cmd.ExecuteScalar() == null)
                    {
                        if (cmd2.ExecuteNonQuery() == 1)
                        {
                            transaction.Commit(); //transaction done (when all database change sucess, it will commit change)
                            MessageBox.Show("Update Sucessfull");

                        }
                        else
                        {

                            transaction.Rollback(); //Rollback transactions (at least one failed to change, it will cancel the change)
                            string messages = "Update failed";
                            errorMessage(messages);


                        }
                    }
                    else
                    {
                        transaction.Rollback(); //Rollback transactions (at least one failed to change, it will cancel the change)
                        string messages = "The Username seems has been used or the update failed, Please Try again later";
                        errorMessage(messages);

                    }
                }

                catch (Exception)
                {
                    MessageBox.Show("User not found or System Wrong! Error Message: Error");
                }

            }
        }
        public void errorMessage(string messages)
        {
            MessageBox.Show(messages, "Error");
        }
    }
    
}
