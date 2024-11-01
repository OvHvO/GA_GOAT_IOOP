using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;
using System.Windows.Forms;
using static GA_TestRun1.Users;
using Microsoft.Identity.Client;
using System.Threading;

namespace GA_TestRun1.Admins
{
    internal class Admins_Source
    {
        public string selectedItem;

        public Admins_Source()
        {
            Thread.Sleep(400);
        }

        public object[] Admin_Profile(string userN)
        {
            string query = @"select admin_ID, adminUsername, adminContactNum from Admins 
                             where adminUsername = @username";
            using (SqlConnection connection = new SqlConnection(ConnectionS_admin.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", userN);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            object[] adminProfile = new object[3];
                            adminProfile[0] = reader["admin_ID"];
                            adminProfile[1] = "Admin UserName:" + reader["adminUsername"].ToString();
                            adminProfile[2] = "Admin Contact Number: +60" + reader["adminContactNum"].ToString();

                            return adminProfile;
                        }
                        else
                        {
                            return null;
                        }
                    }

                }
            }
        }

        public List<string> Service_Net()
        {
            string query = @"select serviceName from Service";
            List<string> serviceList = new List<string>();
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
            return serviceList;
        }

        public object[] Service_Details(string targetService)
        {
            string query = @"select serviceInfo, serviceTimeTaken, servicePrice, serviceOffer, admin_ID, part_ID from Service
                                where serviceName = @serviceName";
            object[] serviceDetails = new object[6];
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
                            serviceDetails[1] = "Time taken :" + reader["serviceTimeTaken"].ToString();
                            serviceDetails[2] = "Price :" + reader["servicePrice"].ToString();
                            serviceDetails[3] = "Promotion :" + reader["serviceOffer"].ToString() + "%";
                            serviceDetails[4] = "Admin_ID:" + reader["admin_ID"].ToString();
                            serviceDetails[5] = "Part_ID:" + reader["part_ID"].ToString();

                        }

                    }

                }
            }
            return serviceDetails;
        }

        public string[] Edit_Service(string targetService)
        {
            string query = @"select serviceName, serviceInfo, serviceTimeTaken, servicePrice, serviceOffer, part_ID from Service
                                where serviceName = @serviceName";
            string[] editServiceInfo = new string[6];
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
                            editServiceInfo[0] = reader["serviceName"].ToString();
                            editServiceInfo[1] = reader["serviceInfo"].ToString();
                            editServiceInfo[2] = reader["serviceTimeTaken"].ToString();
                            editServiceInfo[3] = reader["servicePrice"].ToString();
                            editServiceInfo[4] = reader["serviceOffer"].ToString();
                            editServiceInfo[5] = reader["part_ID"].ToString();

                        }

                    }

                }
            }
            return editServiceInfo;
        }
    }
}
