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
        static string connectionS = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\nixon\\Source\\Repos\\GA_GOAT_IOOP\\GA_TestRun1\\Database_GA.mdf;Integrated Security=True";
        SqlConnection connect = new SqlConnection(connectionS);
        private string UserName;
        private string Password;

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

        public void mcnUpdateProf(string oldusername, string UserName, string Password)
        {
            UserNames = UserName;
            Passwords = Password;

            using (SqlConnection connect = new SqlConnection(connectionS))
            {
                connect.Open();
                SqlTransaction transaction = connect.BeginTransaction(); // begin the update
                try
                {
                    string query1 = @"Select rcptionistUsername from Receptionists where rcptionistUsername=@username
                                    UNION ALL
                                    Select customerUsername from Customers where customerUsername=@username
                                    UNION ALL
                                    Select mechanicUsername from Mechanics where mechanicUsername= @username
                                    UNION ALL
                                    Select adminUsername from Admins where adminUsername=@username";
                    SqlCommand cmd = new SqlCommand(query1, connect, transaction);
                    cmd.Parameters.AddWithValue("@username", UserName);

                    string query2 = "Update Receptionists set rcptionistUsername=@username,rcptionistPW=@password where rcptionistUsername=@oldusername";
                    SqlCommand cmd2 = new SqlCommand(query2, connect, transaction);
                    cmd2.Parameters.AddWithValue("@username", UserName);
                    cmd2.Parameters.AddWithValue("@password", Password);
                    cmd2.Parameters.AddWithValue("@oldusername", oldusername);



                    if (cmd2.ExecuteNonQuery() > 0 && cmd.ExecuteNonQuery() == 0)
                    {
                        transaction.Commit(); //transaction done (when all database change sucess, it will commit change)
                        MessageBox.Show("Update Sucessfull");

                    }
                    else
                    {
                        transaction.Rollback(); //Rollback transactions (at least one failed to change, it will cancel the change)
                        MessageBox.Show("The Username seems has been used or the update failed, Please Try again later");
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("User not found or System Wrong! Error Message: " + ex.ToString());

                }
            }
        }
    }
}
