using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace GA_TestRun1.Mechanics
{
    internal class Mechanic
    {
        static string Connection;
        private string UserName;
        private string Password;
        static string connect = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\nixon\\OneDrive\\Desktop\\IOOP\\GA_Test1\\GA_TestRun1\\Database_GA.mdf;Integrated Security=True";
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

        //============================== Update Mechanic Profile ==============================//
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



        //============================== View Service List ==============================//
        public object ViewProfList(string UName)
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                try
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    string query = @"SELECT DISTINCT C.customer_ID, C.customerUsername, C.customerContactNum, SA.serviceAP_ID, SA.serviceAPDate, SA.carNum, T.mechanic_ID, M.mechanicUsername
                                    FROM Customers AS C
                                    INNER JOIN ServiceAppoinments AS SA ON C.customer_ID = SA.customer_ID
                                    LEFT JOIN Tasks AS T ON T.serviceAP_ID = SA.serviceAP_ID
                                    LEFT JOIN Mechanics AS M ON T.mechanic_ID = M.mechanic_ID
                                    WHERE M.mechanicUsername = @username";

                    string query1 = "SELECT McnUsername FROM ##Mcntemptable WHERE McnUsername = @username";
                    SqlCommand cmd1 = new SqlCommand(query1, conn, transaction);
                    cmd1.Parameters.AddWithValue("@username", UName);

                    //---------- For testing ----------//
                    //if (cmd1.ExecuteNonQuery() == 1)
                    //{
                    //    MessageBox.Show("Successful");
                    //    transaction.Commit();
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Unsuccessful");
                    //    transaction.Rollback();
                    //}

                    // Execute main query with parameters to fetch the desired data //
                    SqlCommand cmd = new SqlCommand(query, conn, transaction);
                    cmd.Parameters.AddWithValue("@UserName", UName);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable data = new DataTable();
                    adapter.Fill(data);

                    conn.Close();
                    return data;  // Returns DataTable to be displayed in GridView //

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return null;
                }
            }
        }


        //============================== Search Function ==============================//
        public static object SearchFunc(string searchKey, string selectedItems)
        {
            using (SqlConnection conn = new SqlConnection(Connection))
            {
                try
                {
                    conn.Open();
                    string query = $@"Select DISTINCT C.customer_ID, C.customerUsername,C.customerContactNum , SA.serviceAP_ID,SA.carNum,T.mechanic_ID,SA.rescheduleStatus
                                 from Customers AS C
                                 INNER JOIN ServiceAppoinments AS SA ON C.customer_ID = SA.customer_ID
                                 LEFT JOIN Tasks as T ON T.serviceAP_ID = SA.serviceAP_ID
                                 WHERE SA.{selectedItems} LIKE '%'+@searchkey+'%' 
                                ";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@searchkey", searchKey);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    conn.Close();
                    return table;

                }
                catch (SqlException)
                {

                    string query = $@"Select DISTINCT C.customer_ID, C.customerUsername,C.customerContactNum , SA.serviceAP_ID,SA.carNum, T.mechanic_ID, SA.rescheduleStatus
                             from Customers AS C
                             INNER JOIN ServiceAppoinments AS SA ON C.customer_ID = SA.customer_ID
                             LEFT JOIN Tasks as T ON T.serviceAP_ID = SA.serviceAP_ID
                             WHERE C.{selectedItems} LIKE '%'+@searchkey+'%' 
                            ";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@searchkey", searchKey);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    conn.Close();
                    return table;
                }

            }




            //============================== Testing ==============================//
            //public bool IsUserNameInMechanics(string userName)
            //{
            //    using (SqlConnection conn = new SqlConnection(connect))
            //    {
            //        conn.Open();
            //        string query = "SELECT COUNT(1) FROM Mechanics WHERE mechanicUsername = @username";
            //        SqlCommand cmd = new SqlCommand(query, conn);
            //        cmd.Parameters.AddWithValue("@UserName", userName);
            //        int result = (int)cmd.ExecuteScalar();
            //        conn.Close();
            //        return result > 0;
            //    }
            //}
        }

        //============================== Refresh Button Function ==============================//
        public static Array RefreshProfile(string Names)
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                string newuser;
                conn.Open();

                string query1 = "Select McnUsername from ##Mcntemptable where McnUsername=@username";
                SqlCommand cmd = new SqlCommand(query1, conn);
                cmd.Parameters.AddWithValue("@username", Names);
                string[] newProf = new string[2];
                //check the name is oldusername or newusername
                if (cmd.ExecuteScalar() != null)
                {
                    newuser = cmd.ExecuteScalar().ToString();

                    string query = "Select mechanicUsername,mechanicContactNum from Mechanics where mechanicUsername=@username";
                    SqlCommand cmd2 = new SqlCommand(query, conn);
                    cmd2.Parameters.AddWithValue("@username", newuser);

                    SqlDataReader read = cmd2.ExecuteReader();
                    while (read.Read())
                    {
                        newProf[0] = read.GetString(0);
                        newProf[1] = read.GetString(1);

                    }
                    conn.Close();
                    return newProf;

                }
                string query2 = "Select McnUsername from ##Mcntemptable where OldName=@username";
                SqlCommand cmd3 = new SqlCommand(query2, conn);
                cmd3.Parameters.AddWithValue("@username", Names);
                newuser = cmd3.ExecuteScalar().ToString();
                string query3 = "Select McnUsername, McnContactNum from Mechanics where McnUsername=@username";
                SqlCommand cmd4 = new SqlCommand(query3, conn);
                cmd4.Parameters.AddWithValue("@username", newuser);

                SqlDataReader read2 = cmd4.ExecuteReader();
                while (read2.Read())
                {
                    newProf[0] = read2.GetString(0);
                    newProf[1] = read2.GetString(1);
                }
                conn.Close();

                return newProf;
            }
        }
    }
}
