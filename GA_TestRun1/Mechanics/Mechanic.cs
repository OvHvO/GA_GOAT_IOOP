using GA_TestRun1.Mechanics.Mecha_Option;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using System.Xml.Linq;
using static Azure.Core.HttpHeader;

namespace GA_TestRun1.Mechanics
{
    internal class Mechanic
    {
        static string Connection;
        private string UserName;
        private string Password;
        private static string AppID;
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

        public Mechanic() //Parameterless Constructor
        {

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

                    string query = @"SELECT DISTINCT C.customer_ID, SA.serviceAP_ID, C.customerUsername, C.customerContactNum, SA.carNum, T.mechanic_ID, T.taskStatus
                                    FROM Customers AS C
                                    INNER JOIN ServiceAppoinments AS SA ON C.customer_ID = SA.customer_ID
                                    LEFT JOIN Tasks AS T ON T.serviceAP_ID = SA.serviceAP_ID
                                    LEFT JOIN Mechanics AS M ON T.mechanic_ID = M.mechanic_ID
                                    WHERE M.mechanicUsername = @username";

                    string query1 = "SELECT McnUsername FROM ##Mcntemptable WHERE McnUsername = @username";
                    SqlCommand cmd1 = new SqlCommand(query1, conn, transaction);
                    cmd1.Parameters.AddWithValue("@username", UName);

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
        public static object SearchFunc(string SearchKey, string SelectedItems, string UName)
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                try
                {
                    conn.Open();
                    string query = $@"SELECT DISTINCT C.customer_ID, SA.serviceAP_ID, C.customerUsername, C.customerContactNum, SA.carNum, T.mechanic_ID, T.taskStatus
                                 from Customers AS C
                                 INNER JOIN ServiceAppoinments AS SA ON C.customer_ID = SA.customer_ID
                                 LEFT JOIN Tasks as T ON T.serviceAP_ID = SA.serviceAP_ID
                                 LEFT JOIN Mechanics as M ON M.mechanic_ID = T.mechanic_ID
                                 WHERE SA.{SelectedItems} LIKE '%'+@searchkey+'%' 
                                 AND M.mechanicUsername = @username
                                ";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@searchkey", SearchKey);
                    cmd.Parameters.AddWithValue("@username", UName);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    conn.Close();
                    return table;

                }
                catch (SqlException)
                {
                    string query = $@"SELECT DISTINCT C.customer_ID, SA.serviceAP_ID, C.customerUsername, C.customerContactNum, SA.carNum, T.mechanic_ID, T.taskStatus
                             from Customers AS C
                             INNER JOIN ServiceAppoinments AS SA ON C.customer_ID = SA.customer_ID
                             LEFT JOIN Tasks as T ON T.serviceAP_ID = SA.serviceAP_ID
                             LEFT JOIN Mechanics as M ON M.mechanic_ID = T.mechanic_ID
                             WHERE C.{SelectedItems} LIKE '%'+@searchkey+'%' 
                             AND M.mechanicUsername = @username
                            ";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@searchkey", SearchKey);
                    cmd.Parameters.AddWithValue("@username", UName);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    conn.Close();
                    return table;
                }

            }
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
                        newProf[1] = read.GetInt32(1).ToString();

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
                    newProf[1] = read2.GetString(1).ToString();
                }
                conn.Close();

                return newProf;
            }
        }

        //============================== Record Service ==============================//
        public static List<String> CarNumber(string Nname)
        {
            List<String> list = new List<String>();
            SqlConnection conn = new SqlConnection(connect);

            conn.Open();
            string query = @"SELECT DISTINCT SA.carNum 
                            FROM Mechanics AS M
                            INNER JOIN Tasks AS T ON T.mechanic_ID = M.mechanic_ID
                            LEFT JOIN ServiceAppoinments as SA ON T.serviceAP_ID = SA.serviceAP_ID
                            WHERE M.mechanicUsername = @username";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", Nname);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(reader.GetString(0));
            }
            reader.Close();
            conn.Close();
            return list;
        }

        public static void SaveRecord(DateTime CollectTime, string Status, string CarNumbs, string Add_Rep)
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    string query = @"SELECT serviceAP_ID 
                                    FROM ServiceAppoinments AS SA 
                                    WHERE carNum = @CarNumbs";

                    string query3 = @"UPDATE Tasks
                                    SET taskStatus = @Status, collectionTime = @CollectionTime, addRepair = @Add_Rep
                                    WHERE serviceAP_ID = @AppID";

                    SqlCommand cmd1 = new SqlCommand(query, conn, transaction);
                    cmd1.Parameters.AddWithValue("@CarNumbs", CarNumbs);
                    AppID = cmd1.ExecuteScalar().ToString();

                    SqlCommand cmd3 = new SqlCommand(query3, conn, transaction);
                    cmd3.Parameters.AddWithValue("@Status", Status);
                    cmd3.Parameters.AddWithValue("@CollectionTime", CollectTime);
                    cmd3.Parameters.AddWithValue("@Add_Rep", Add_Rep);
                    cmd3.Parameters.AddWithValue("@AppID", AppID);

                    if (cmd3.ExecuteNonQuery() < 1)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error");
                        conn.Close();
                    }
                    else
                    {
                        transaction.Commit();
                        MessageBox.Show("Successfully Updated Service List!");
                        conn.Close();
                    }
                }
                catch (SqlException ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error: " + ex);
                    conn.Close();
                }
            }
        }

        //============================== Show Parts in Listbox ==============================//
        //---------- Request Parts ----------//
        public static List<string> Parts() 
        {
            List<string> p_list = new List<string>();
            SqlConnection conn = new SqlConnection(connect);

            conn.Open();

            string query = @"SELECT Distinct partName
                             FROM Parts AS P";

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                p_list.Add(reader.GetString(0));
            }
            reader.Close();
            conn.Close();
            return p_list;

        }

        //---------- Used Request Parts ----------//
        public static List<string> UParts()
        {
            List<string> u_list = new List<string>();
            SqlConnection conn = new SqlConnection(connect);

            conn.Open();

            string query = @"SELECT Distinct partName
                             FROM Parts AS P";

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                u_list.Add(reader.GetString(0));
            }
            reader.Close();
            conn.Close();
            return u_list;

        }

        //============================== Request Parts ==============================//
        public static void RequestParts(string Parts, string Quantity, string Status, string carNum)
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    string query = @"SELECT P.part_ID 
                                     FROM Parts AS P
                                     WHERE partName = @Partname";

                    string query2 = @"SELECT T.task_ID
                                      FROM Tasks AS T
                                      INNER JOIN ServiceAppoinments AS SA ON SA.serviceAP_ID = T.serviceAP_ID
                                      WHERE SA.carNum = @CarNum";

                    string query3 = @"INSERT INTO Requests (requestPartQuantity, rrequestStatus, part_ID, task_ID)
                                      VALUES (@Quantity, @Status, @part_ID, @task_ID)";

                    SqlCommand cmd = new SqlCommand(query, conn, transaction);
                    cmd.Parameters.AddWithValue("@Partname", Parts);
                    string PartID = cmd.ExecuteScalar().ToString();

                    SqlCommand cmd2 = new SqlCommand(query2, conn, transaction);
                    cmd2.Parameters.AddWithValue("@CarNum", carNum);
                    string TaskID = cmd2.ExecuteScalar().ToString();

                    SqlCommand cmd3 = new SqlCommand(query3, conn, transaction);
                    cmd3.Parameters.AddWithValue("@Quantity", Quantity);
                    cmd3.Parameters.AddWithValue("@Status", Status);
                    cmd3.Parameters.AddWithValue("@part_ID", PartID);
                    cmd3.Parameters.AddWithValue("@task_ID", TaskID);

                    if (cmd3.ExecuteNonQuery() < 1)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error");
                        conn.Close();
                    }
                    else
                    {
                        transaction.Commit();
                        MessageBox.Show("Successfully Requested!");
                        conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error: " + ex);
                    conn.Close();
                }
            }  
        }

        //============================== Update Parts ==============================//
        public static void UpdateParts(string UParts, string UQuantity)
        {
            if (UParts == null || UQuantity == null)
            {
                MessageBox.Show("Warning: Please insert value or select parts to perform task.");
            }
            else 
            {
                using (SqlConnection conn = new SqlConnection(connect))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {

                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
        }
    }
}
