using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;
using System.Windows.Forms;

namespace GA_TestRun1.Admins
{
    internal class Admins_Source
    {
        public string connectionString;

        public Admins_Source(string connection)
        {
            connectionString = connection;  
        }

        public object[] Admin_Profile(string userN)
        {
            string query = @"select admin_ID, adminUsername, adminContactNum from Admins 
                             where adminUsername = @username";
            using (SqlConnection connection = new SqlConnection(connectionString))
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
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            List<string> serviceList = new List<string>();
                            serviceList.Add(reader["serviceName"].ToString());
                            return serviceList;
                        }
                        else
                        {
                            return null;
                        }
                    }

                }
            }
        }

    }
}
