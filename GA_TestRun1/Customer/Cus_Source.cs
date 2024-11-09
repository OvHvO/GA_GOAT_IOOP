using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static GA_TestRun1.Users;
using System.Windows.Forms;
using GA_TestRun1.Mechanics;

namespace GA_TestRun1.Customer
{
    internal class Cus_Source
    {
        public Cus_Source()
        {
            Thread.Sleep(400);
        }

        public object[] Cus_Profile(int cusID)
        {
            string query = @"select customer_ID, customerUsername, customerContactNum from Customers 
                             where customer_ID = @userID";
            using (SqlConnection connection = new SqlConnection(ConnectionS_admin.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userID", cusID);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            object[] cusProfile = new object[3];
                            cusProfile[0] = reader["customer_ID"];
                            cusProfile[1] = reader["customerUsername"].ToString();
                            cusProfile[2] = reader["customerContactNum"].ToString();

                            return cusProfile;
                        }
                        else
                        {
                            return null;
                        }
                    }

                }
            }
        }
        public bool Cus_Update_Profile(int cus_ID, string cus_UN, string cus_PW, int cus_CN)
        {
            string query = "update Customers \r\n SET customerUsername = @Cus_UN, \r\ncustomerPW = @cusPW, \r\ncustomerContactNum = @Cus_CN \r\n WHERE customer_ID = @cus_ID;";
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionS_admin.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Cus_UN", cus_UN);
                        command.Parameters.AddWithValue("@cusPW", cus_PW);
                        command.Parameters.AddWithValue("@Cus_CN", cus_CN);
                        command.Parameters.AddWithValue("@cus_ID", cus_ID);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            return true;
                        }

                        else
                        {
                            return false;
                        }
                    }
                }
            }

            catch (SqlException ex)
            {
                if (ex.Number == 547)  //547 is the number when foreign key has problem in our database
                {
                    MessageBox.Show("The CustomerName does not exist");
                    return false;
                }

                else
                {
                    MessageBox.Show("Okay gg I will lay off");
                    return false;
                }
            }

        }

        public int ID_Checking(string userN)
        {
            string query = @"select customer_ID from Customers where customerUsername = @UserN";
            int cusID = 0;
            using (SqlConnection connection = new SqlConnection(ConnectionS_admin.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserN", userN);
                    connection.Open();

                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        cusID = Convert.ToInt32(result);
                    }
                }
            }
            return cusID;
        }

        public List<string> Service_Net()
        {
            string query = @"select serviceName from Service";
            List<string> serviceList = new List<string>();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionS_admin.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                serviceList.Add(reader["serviceName"].ToString());
                            }

                        }

                    }
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Please dont click the empty space");
            }

            return serviceList;
        }

        public object[] Service_Details(string targetService)
        {
            string query = @"select serviceInfo, serviceTimeTaken, servicePrice, serviceOffer from Service
                                where serviceName = @serviceName";
            object[] serviceDetails = new object[4];

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionS_admin.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@serviceName", targetService);
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                serviceDetails[0] = "Service Info :" + reader["serviceInfo"].ToString();
                                serviceDetails[1] = "Time taken :" + reader["serviceTimeTaken"].ToString() + "H";
                                serviceDetails[2] = "Price :" + reader["servicePrice"].ToString();
                                serviceDetails[3] = "Promotion :" + reader["serviceOffer"].ToString() + "%";

                            }

                        }

                    }
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Please dont click the empty space");
            }
            return serviceDetails;
        }

        public List<string> Promotion_Service()
        {
            string query = @"select serviceName from Service
                             where serviceOffer > 0";
            List<string> serviceList = new List<string>();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionS_admin.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                serviceList.Add(reader["serviceName"].ToString());
                            }

                        }

                    }
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Please dont click the empty space");
            }

            return serviceList;
        }

        public List<string> MechanicTime()
        {
            string query = @"select mechanic_ID, mechanicUsername from Mechanics";
            Dictionary<int, string> mechanicDic = new Dictionary<int, string>();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionS_admin.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int mechanic_ID = Convert.ToInt32(reader["mechanic_ID"]);
                                string mechanicName = reader["mechanicUsername"].ToString();

                                if (!mechanicDic.ContainsKey(mechanic_ID))
                                {
                                    mechanicDic.Add(mechanic_ID, mechanicName);
                                }
                                else
                                {
                                    //nothing
                                }
                            }
                        }

                    }
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Please dont click the empty space");
            }

            string query1 = @"select mechanic_ID, mechanicUsername from Mechanics";
            Dictionary<int, string> mechanicDic = new Dictionary<int, string>();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionS_admin.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int mechanic_ID = Convert.ToInt32(reader["mechanic_ID"]);
                                string mechanicName = reader["mechanicUsername"].ToString();

                                if (!mechanicDic.ContainsKey(mechanic_ID))
                                {
                                    mechanicDic.Add(mechanic_ID, mechanicName);
                                }
                                else
                                {
                                    //nothing
                                }
                            }
                        }

                    }
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Please dont click the empty space");
            }
            return mechanicDic;

        }
    }
}
