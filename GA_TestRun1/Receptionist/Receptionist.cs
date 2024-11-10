using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IdentityModel.Tokens;
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

        static string connectionS;
        private string Username;
        private string Password;
        private string SelectedItems;
        private string ContactNum;
        //private Cus_deleteForm cus = new Cus_deleteForm(connectionS);
        public string usernames
        {
            get => Username; set => Username = value;
        }
        public string passwords { get => Password; set => Password = value; }
        public string selecteditem { get => SelectedItems; set => SelectedItems = value; }
        public string contactnum { get => ContactNum; set => ContactNum = value; }

        public Receptionists(string connection)
        {
            connectionS = connection;

        }
        public Receptionists(string username, string password)
        {
            usernames = username;
            passwords = password;

        }
        public Receptionists()
        {

        }
        public Receptionists(string connection, string username, string contact)
        {
            connectionS = connection;
            usernames = username;
            contactnum = contact;
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
            try
            {
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
            }
            catch (Exception)
            {
                MessageBox.Show("Please Choose Something! ");
            }
            conn.Close();
            return CusDetail;


        }

        public static void delCus(string selected)
        {
            SqlConnection conn = new SqlConnection(connectionS);

            conn.Open();
            try
            {
                string command = "Delete from Customers where customerUsername=@username";
                SqlCommand cmd = new SqlCommand(command, conn);
                cmd.Parameters.AddWithValue("@username", selected);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Delete Sucessfully!", "Delete Customer");
                }
                else
                {
                    MessageBox.Show("Something Went Wrong, Please try again", "Delete Failed",MessageBoxButtons.OK,MessageBoxIcon.Error);

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please Choose Something!");
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

                    //Enter into Temp Table (## is global temp table)
                    string query3 = "Update ##temptable set RcpUsername=@username, RcpPw=@password, OldName=@oldusername";
                    SqlCommand cmd3 = new SqlCommand(query3, conn, transaction);
                    cmd3.Parameters.AddWithValue("@username", username);
                    cmd3.Parameters.AddWithValue("@password", password);
                    cmd3.Parameters.AddWithValue("@oldusername", oldusername);
                    cmd3.ExecuteNonQuery();




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


                catch (Exception ex)
                {
                    MessageBox.Show("User not found or System Wrong! Error Message: " + ex.ToString());

                }

            }

        }



        public static Array newprofile(string name)
        {
            string connections = connectionS;
            using (SqlConnection conn = new SqlConnection(connections))
            {
                string newuser;
                conn.Open();

                string query1 = "Select RcpUsername from ##temptable where RcpUsername=@username";
                SqlCommand cmd = new SqlCommand(query1, conn);
                cmd.Parameters.AddWithValue("@username", name);
                string[] newProf = new string[2];
                //check the name is oldusername or newusername
                if (cmd.ExecuteScalar() != null)
                {
                    newuser = cmd.ExecuteScalar().ToString();



                    string query = "Select rcptionistUsername,rcptionistContactNum from Receptionists where rcptionistUsername=@username";
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
                string query2 = "Select RcpUsername from ##temptable where OldName=@username";
                SqlCommand cmd3 = new SqlCommand(query2, conn);
                cmd3.Parameters.AddWithValue("@username", name);
                newuser = cmd3.ExecuteScalar().ToString();
                string query3 = "Select rcptionistUsername,rcptionistContactNum from Receptionists where rcptionistUsername=@username";
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

        public void errorMessage(string messages)
        {
            MessageBox.Show(messages, "Error");
        }

        public static object getProfList()
        {
            SqlConnection conn = new SqlConnection(connectionS);
            conn.Open();
            string query = @"Select DISTINCT C.customer_ID, C.customerUsername,C.customerContactNum , SA.serviceAP_ID,SA.carNum, T.mechanic_ID
                             from Customers AS C
                             INNER JOIN ServiceAppoinments AS SA ON C.customer_ID = SA.customer_ID
                             LEFT JOIN Tasks as T ON T.serviceAP_ID = SA.serviceAP_ID

                            ";

            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);


            DataTable data = new DataTable();
            adapter.Fill(data);
            conn.Close();

            return data;
        }


        public static object searchFunc(string searchKey, string selectedItems)
        {
            using (SqlConnection conn = new SqlConnection(connectionS))
            {
                try { 
                    conn.Open();
                    string query = $@"Select DISTINCT C.customer_ID, C.customerUsername,C.customerContactNum , SA.serviceAP_ID,SA.carNum,T.mechanic_ID
                                 from Customers AS C
                                 INNER JOIN ServiceAppoinments AS SA ON C.customer_ID = SA.customer_ID
                                 LEFT JOIN Tasks as T ON T.serviceAP_ID = SA.serviceAP_ID
                                 WHERE SA.{selectedItems} LIKE '%'+@searchkey+'%' 
                                ";
                    SqlCommand cmd= new SqlCommand(query,conn);
                    cmd.Parameters.AddWithValue("@searchkey",searchKey);
                
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    conn.Close();
                    return table;
                
                }
                catch (SqlException)
                {
                    
                    string query = $@"Select DISTINCT C.customer_ID, C.customerUsername,C.customerContactNum , SA.serviceAP_ID,SA.carNum, T.mechanic_ID
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


        }

        public static List<string> mechanicName()
        {
            List<string> mecName = new List<string>();
            using (SqlConnection conn = new SqlConnection(connectionS))
            {
                conn.Open();
                string query = "Select mechanicUsername from Mechanics";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    mecName.Add(reader.GetString(0));
                }
                reader.Close();
                conn.Close();
                return mecName;
            }
        } 

        public void assignMec(string selectedItems,string taskname, string serviceID,string rcpname)
        {
            using (SqlConnection conn= new SqlConnection(connectionS))
            {
                conn.Open();
                
                SqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    string rcpid = null;
                    //search ID for receptionist
                    string query2 = "Select rcptionist_ID from Receptionists where rcptionistUsername=@users";
                    SqlCommand cmd2 = new SqlCommand(query2, conn, transaction);
                    cmd2.Parameters.AddWithValue("@users", rcpname);


                    if (cmd2.ExecuteScalar() == null)
                    {   //search from temptable (while name changed)

                        string query4 = "Select RcpUsername from ##temptable where OldName=@username";
                        SqlCommand cmd4 = new SqlCommand(query4, conn, transaction);
                        cmd4.Parameters.AddWithValue("@username",rcpname);
                        rcpname = cmd4.ExecuteScalar().ToString();

                    }
                    else
                    {
                       rcpid = cmd2.ExecuteScalar().ToString();
                    } 
                    //search ID for receptionist (while changing name)
                        string query5 = "Select rcptionist_ID from Receptionists where rcptionistUsername=@users";
                        SqlCommand cmd5 = new SqlCommand(query5, conn,transaction);
                        cmd5.Parameters.AddWithValue("@users", rcpname);
                        rcpid=cmd5.ExecuteScalar().ToString();

                        string query3 = "Select mechanic_ID from Mechanics where mechanicUsername=@mecuser";
                        SqlCommand cmd3 = new SqlCommand(query3, conn, transaction);
                        cmd3.Parameters.AddWithValue("@mecuser", selectedItems);
                        string mechanicID = cmd3.ExecuteScalar().ToString();

                        string query = "Insert Into Tasks(taskStatus,mechanic_ID,serviceAP_ID,rcptionist_ID) values('Under repairing',@mechanicID,@serviceAP_ID,@rcptionist_ID)";
                        SqlCommand cmd = new SqlCommand(query, conn, transaction);
                        cmd.Parameters.AddWithValue("@mechanicID", mechanicID);
                        cmd.Parameters.AddWithValue("@serviceAP_ID", serviceID);
                        cmd.Parameters.AddWithValue("@rcptionist_ID", rcpid);
                        cmd.ExecuteNonQuery();

                       
                            if (cmd.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("Sucessfull Assign Mechanic");
                                transaction.Commit();
                            }
                        
                            else
                            {

                            MessageBox.Show("Cannot Assign Mechanic, Please Try Again");
                            transaction.Rollback();

                            }
                     

                }
                catch(SqlException ex) 
                {
                    MessageBox.Show(ex.ToString());
                    //MessageBox.Show("Error, Please try again");
                   transaction.Rollback();
                   
                }
                
                
                conn.Close();
            }

        }
    }
}





