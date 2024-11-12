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
using System.Xml.Schema;
using System.Data;

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

        public Dictionary<int, string> MechanicTime()
        {
            string query = @"select mechanic_ID, serviceTime from Mechanics";
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
                                string workingTime = reader["serviceTime"].ToString();

                                if (!mechanicDic.ContainsKey(mechanic_ID))
                                {
                                    if (!string.IsNullOrEmpty(workingTime))
                                    {
                                        mechanicDic.Add(mechanic_ID, workingTime);
                                    }
                                    
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

            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }

            return mechanicDic;

        }

        public bool Cus_Book_App(int cus_ID, string carNum, string carVersion, DateTime serviceTime, string targetservice)
        {
            int rowsAffectSP;
            int rowsAffectSA;
            string query = @"insert into ServiceAppoinments (serviceAPDate, carNum, carVersion, customer_ID)
                             values (@ServiceDate, @CarNum, @CarVersion, @Cus_ID)";
            using (SqlConnection connection = new SqlConnection(ConnectionS_admin.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@Cus_ID", cus_ID);
                    command.Parameters.AddWithValue("@ServiceDate", serviceTime);
                    command.Parameters.AddWithValue("@CarNum", carNum);
                    command.Parameters.AddWithValue("@CarVersion", carVersion);

                    connection.Open();

                    rowsAffectSP = command.ExecuteNonQuery();

                }
            }

            string query1 = @"select service_ID from Service
                              where serviceName = @TargetService";
            int service_ID = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionS_admin.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query1, connection))
                    {
                        command.Parameters.AddWithValue("@TargetService", targetservice);
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                service_ID = Convert.ToInt32(reader["service_ID"]);
                            }
                        }
                    }
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show($"Please dont click the empty space {ex}");
            }

            string query2 = @"select serviceAP_ID from ServiceAppoinments
                              where  serviceAPDate= @serviceTime and customer_ID = @Cus_ID";
            int serviceAP_ID = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionS_admin.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query2, connection))
                    {
                        command.Parameters.AddWithValue("@serviceTime", serviceTime);
                        command.Parameters.AddWithValue("@Cus_ID", cus_ID);
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                serviceAP_ID = Convert.ToInt32(reader["serviceAP_ID"]);
                            }
                        }
                    }
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Please dont click the empty space");
            }

            string query3 = @"insert into ServiceAdd (serviceAP_ID, service_ID)
                             values (@ServiceAP_ID, @Service_ID)";
            using (SqlConnection connection = new SqlConnection(ConnectionS_admin.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query3, connection))
                {

                    command.Parameters.AddWithValue("@ServiceAP_ID", serviceAP_ID);
                    command.Parameters.AddWithValue("@Service_ID", service_ID);


                    connection.Open();

                    rowsAffectSA = command.ExecuteNonQuery();

                    
                }
            }

            if (rowsAffectSA > 0 && rowsAffectSP > 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public List<string> FeedbackChecking(int target_ID)
        {
            List<string> serviceAP_List = new List<string>();
            List<string> serviceAP_CheckList = new List<string>();
            List<string> serviceAP_FinalList = new List<string>();

            string query1 = @"select serviceAP_ID 
                                from ServiceAppoinments 
                                where customer_ID = @Target_ID";

            string query2 = @"select serviceAP_ID 
                                 from Tasks 
                                 where taskStatus = 'COMPLETE' 
                                 and serviceAP_ID = @ServiceAP_ID";

            string query3 = @"select serviceAP_ID 
                                  from ServiceAppoinments
                                  where feedbackStatus = 0
                                  and serviceAP_ID = @SERVICEAP_ID";
            try
            {
                // First query - get initial service appointments
                using (SqlConnection connection = new SqlConnection(ConnectionS_admin.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query1, connection))
                    {
                        command.Parameters.AddWithValue("@Target_ID", target_ID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                serviceAP_List.Add(reader["serviceAP_ID"].ToString());
                            }
                        }
                    }
                }

                // Second query - check completed tasks
                using (SqlConnection connection = new SqlConnection(ConnectionS_admin.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query2, connection))
                    {
                        foreach (string serviceAP_ID in serviceAP_List)
                        {
                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@SERVICEAP_ID", serviceAP_ID);
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    serviceAP_CheckList.Add(reader["serviceAP_ID"].ToString());
                                }
                            }
                        }
                    }
                }

                using (SqlConnection connection = new SqlConnection(ConnectionS_admin.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query3, connection))
                    {
                        foreach (string serviceAP_ID in serviceAP_CheckList)
                        {
                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@ServiceAP_ID", serviceAP_ID);
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    serviceAP_FinalList.Add(reader["serviceAP_ID"].ToString());
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while processing feedback: {ex.Message}");
            }

            return serviceAP_FinalList;
        }

        public List<string> AppoinmentDtls(string target)
        { 
            string query = @"select serviceAP_ID, carNum, carVersion from ServiceAppoinments
                             where serviceAP_ID = @TargetID";
            List<string> dtlsList = new List<string>();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionS_admin.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TargetID", target);
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                dtlsList.Add("Appoinment ID : " + reader["serviceAP_ID"].ToString());
                                dtlsList.Add("Car number : " + reader["carNum"].ToString());
                                dtlsList.Add("Car version : " + reader["carVersion"].ToString());
                            }

                        }

                    }
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Please dont click the empty space");
            }

            return dtlsList;
        }

        public bool SubmitFeedback(string content, string ServiceAP_ID, int Cus_ID, DateTime timenow)
        {
            string query = @"insert into CustomerFeedBack (dateFeedback, cusFeedBackContent, customer_ID, serviceAP_ID)
                     values (@TIMENOW, @CONTENT, @CUS_ID, @SERVICEAP_ID)";

            string query1 = @"update ServiceAppoinments 
                      set feedbackStatus = 1
                      where serviceAP_ID = @SERVICEAP_ID";

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionS_admin.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TIMENOW", timenow);
                        command.Parameters.AddWithValue("@CONTENT",content);
                        command.Parameters.AddWithValue("@CUS_ID", Cus_ID);
                        command.Parameters.AddWithValue("@SERVICEAP_ID", ServiceAP_ID);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected == 0)
                        {
                            return false;
                        }
                    }

                    using (SqlCommand command = new SqlCommand(query1, connection))
                    {
                        command.Parameters.AddWithValue("@SERVICEAP_ID", ServiceAP_ID);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected == 0)
                        {
                            return false;
                        }
                    }

                    return true;
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    MessageBox.Show("You does not exist");
                    return false;
                }
                else
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }
        }
    }
}

