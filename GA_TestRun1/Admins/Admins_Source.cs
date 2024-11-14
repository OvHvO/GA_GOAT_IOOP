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
using System.ServiceProcess;
using System.Drawing;

namespace GA_TestRun1.Admins
{
    internal class Admins_Source
    {

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

        public List<string> Part_Net()
        {
            string query = @"select partName from Parts";
            List<string> partList = new List<string>();
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
                                partList.Add(reader["partName"].ToString());
                            }

                        }

                    }
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Please dont click the empty space");
            }
            return partList;
        }

        public object[] Service_Details(string targetService)
        {
            string query = @"select serviceInfo, serviceTimeTaken, servicePrice, serviceOffer, admin_ID, part_ID from Service
                                where serviceName = @serviceName";
            object[] serviceDetails = new object[6];

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
                                serviceDetails[1] = "Time taken :" + reader["serviceTimeTaken"].ToString();
                                serviceDetails[2] = "Price :" + reader["servicePrice"].ToString();
                                serviceDetails[3] = "Promotion :" + reader["serviceOffer"].ToString() + "%";
                                serviceDetails[4] = "Admin_ID:" + reader["admin_ID"].ToString();
                                serviceDetails[5] = "Part_ID:" + reader["part_ID"].ToString();

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

        public string[] Part_Details(string targetService)
        {
            string query = @"select part_ID, partQuantity, partPrice from Parts
                                where partName = @partName";
            string[] partDetails = new string[3];
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionS_admin.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@partName", targetService);
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                partDetails[0] = reader["part_ID"].ToString();
                                partDetails[1] = reader["partQuantity"].ToString();
                                partDetails[2] = reader["partPrice"].ToString();

                            }

                        }

                    }
                }
            }

            catch(Exception)
            {
                MessageBox.Show("Please dont click the empty space");
            }

            return partDetails;
        }
        public string[] Edit_Service(string targetService)
        {
            string query = @"select serviceName, serviceInfo, serviceTimeTaken, servicePrice, serviceOffer, part_ID from Service
                                where serviceName = @serviceName";
            string[] editServiceInfo = new string[6];
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
            }

            catch (Exception)
            {
                MessageBox.Show("Please dont click the empty space");
            }
            return editServiceInfo;
        }

        public string Part_Checking(int selectedPart)
        {
            string query = @"select partName from Parts where part_ID = @partID";
            string partName = null;
            using (SqlConnection connection = new SqlConnection(ConnectionS_admin.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@partID", selectedPart);
                    connection.Open();

                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        partName = result.ToString();
                    }
                }
            }
            return partName;
        }

        public bool Service_Change(string type, string serviceName, string serviceInfo, string serviceTimeTaken, int servicePrice, int serviceOffer, int admin_ID, int part_ID)
        {
            if (type == "ADD")
            {
                string query = "insert into Service (serviceName, serviceInfo, serviceTimeTaken, servicePrice, serviceOffer, admin_ID, part_ID) values (@ServiceName, @ServiceInfo, @ServiceTimeTaken, @ServicePrice, @ServiceOffer, @Admin_ID, @Part_ID)";

                try
                {
                    using (SqlConnection connection = new SqlConnection(ConnectionS_admin.ConnectionString))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@ServiceName", serviceName);
                            command.Parameters.AddWithValue("@ServiceInfo", serviceInfo);
                            command.Parameters.AddWithValue("@ServiceTimeTaken", serviceTimeTaken);
                            command.Parameters.AddWithValue("@ServicePrice", servicePrice);
                            command.Parameters.AddWithValue("@ServiceOffer", serviceOffer);
                            command.Parameters.AddWithValue("@admin_ID", admin_ID);
                            command.Parameters.AddWithValue("@part_ID", part_ID);

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

                catch(SqlException ex)
                {
                    if(ex.Number == 547) //547 is the number when foreign key has problem in our database
                    {
                        MessageBox.Show("The ParrID does not exist");
                        return false;
                    }

                    else
                    {
                        MessageBox.Show("Okay gg I will lay off");
                        return false;
                    }
                }

            }

            else if (type == "EDIT")
            {
                string query = "update Service \r\n SET serviceInfo = @ServiceInfo, \r\nserviceTimeTaken = @ServiceTimeTaken, \r\nservicePrice = @ServicePrice, serviceOffer = @ServiceOffer, admin_ID = @Admin_ID, part_ID = @Part_ID \r\n WHERE serviceName = @ServiceName;";

                try
                {
                    using (SqlConnection connection = new SqlConnection(ConnectionS_admin.ConnectionString))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@ServiceName", serviceName);
                            command.Parameters.AddWithValue("@ServiceInfo", serviceInfo);
                            command.Parameters.AddWithValue("@ServiceTimeTaken", serviceTimeTaken);
                            command.Parameters.AddWithValue("@ServicePrice", servicePrice);
                            command.Parameters.AddWithValue("@ServiceOffer", serviceOffer);
                            command.Parameters.AddWithValue("@admin_ID", admin_ID);
                            command.Parameters.AddWithValue("@part_ID", part_ID);

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
                        MessageBox.Show("The ServiceName does not exist");
                        return false;
                    }

                    else
                    {
                        MessageBox.Show("Okay gg I will lay off");
                        return false;
                    }
                }
            }

            else
            {
                return false;
            }
        }

        public bool Delete_Service(string selectedName)
        {
            string query = @"delete from Service where serviceName = @ServiceName";
            using (SqlConnection connection = new SqlConnection(ConnectionS_admin.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ServiceName", selectedName);
                    connection.Open();

                    int rowsAffect = command.ExecuteNonQuery();

                    return rowsAffect > 0; //logic if (rowsAffect > 0) = true, < 0 = false. It will also be a boolean data type 
                }
            }
        }

        public bool Delete_Part(string selectedName)
        {
            string query = @"delete from Parts where partName = @PartName";
            using (SqlConnection connection = new SqlConnection(ConnectionS_admin.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PartName", selectedName);
                    connection.Open();

                    int rowsAffect = command.ExecuteNonQuery();

                    return rowsAffect > 0; //logic if (rowsAffect > 0) = true, < 0 = false. It will also be a boolean data type 
                }
            }
        }

        public bool Part_Change(string type, string partName, int partQuantity, int partPrice)
        {
            if (type == "ADD")
            {
                string query = "insert into Parts (partName, partQuantity, partPrice) values (@PartName, @PartQuantity, @PartPrice)";

                try
                {
                    using (SqlConnection connection = new SqlConnection(ConnectionS_admin.ConnectionString))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@PartName", partName);
                            command.Parameters.AddWithValue("@PartQuantity", partQuantity);
                            command.Parameters.AddWithValue("@PartPrice", partPrice);

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
                    MessageBox.Show($"SQL ERROR: {ex.Number}\nWRONG REASON: {ex.Message}");

                    if (ex.Number == 547) //547 is the number when foreign key has problem in our database
                    {
                        MessageBox.Show("Error.....");
                        return false;
                    }

                    else
                    {
                        
                        return false;
                    }
                }

            }

            else if (type == "EDIT")
            {
                string query = "update Parts \r\n SET partQuantity = @PartQuantity, \r\n partPrice = @PartPrice \r\n where partName = @PartName;";

                try
                {
                    using (SqlConnection connection = new SqlConnection(ConnectionS_admin.ConnectionString))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@PartName", partName);
                            command.Parameters.AddWithValue("@PartQuantity", partQuantity);
                            command.Parameters.AddWithValue("@PartPrice", partPrice);

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
                    MessageBox.Show($"SQL WRONG: {ex.Number}\nWRONG REASON: {ex.Message}");

                    if (ex.Number == 547)  //547 is the number when foreign key has problem in our database
                    {
                        MessageBox.Show("The partName does not exist");
                        return false;
                    }

                    else
                    {
                        return false;
                    }
                }
            }

            else
            {
                return false;
            }
        }

        public List<string> Rcp_Net()
        {
            string query = @"select rcptionistUsername from Receptionists";
            List<string> rcpList = new List<string>();
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
                                rcpList.Add(reader["rcptionistUsername"].ToString());
                            }

                        }

                    }
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Please dont click the empty space");
            }
            return rcpList;
        }

        public List<string> Mechanic_Net()
        {
            string query = @"select mechanicUsername from Mechanics";
            List<string> mechanicList = new List<string>();
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
                                mechanicList.Add(reader["mechanicUsername"].ToString());
                            }

                        }

                    }
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Please dont click the empty space");
            }
            return mechanicList;
        }

        public string[] Staff_Details(string targetRole, string targetStaff)
        {
            if (targetRole == "Receptionist")
            {
                string query = @"select rcptionist_ID, rcptionistContactNum from Receptionists
                                where rcptionistUsername = @RcpUsername";
                string[] staffDetails = new string[3];
                try
                {
                    using (SqlConnection connection = new SqlConnection(ConnectionS_admin.ConnectionString))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@RcpUsername", targetStaff);
                            connection.Open();

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    staffDetails[0] = "Receptionist ID:" + reader["rcptionist_ID"].ToString();
                                    staffDetails[1] = "Rcptionist Username :" + targetStaff;
                                    staffDetails[2] = "Contact Number:" + reader["rcptionistContactNum"].ToString();

                                }

                            }

                        }
                    }
                }

                catch (Exception)
                {
                    MessageBox.Show("Please dont click the empty space");
                }
                return staffDetails;
            }
            else
            {
                string query = @"select mechanic_ID, mechanicContactNum from Mechanics
                                where mechanicUsername = @MechanicUsername";
                string[] staffDetails = new string[3];
                try
                {
                    using (SqlConnection connection = new SqlConnection(ConnectionS_admin.ConnectionString))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@MechanicUsername", targetStaff);
                            connection.Open();

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    staffDetails[0] = "Mechanic ID:" + reader["mechanic_ID"].ToString();
                                    staffDetails[1] = "Mechanic Username :" + targetStaff;
                                    staffDetails[2] = "Contact Number:" + reader["mechanicContactNum"].ToString();

                                }

                            }

                        }
                    }
                }


                catch (Exception)
                {
                    MessageBox.Show("Please dont click the empty space");
                }
                return staffDetails;
            }
        }

        public bool Delete_Staff(string role, string selectedStaff)
        {
            //100% success no need to use try, catch :) 
            if (role == "Receptionist")              
            {
                string query = @"delete from Receptionists where rcptionistUsername = @StaffName";
                using (SqlConnection connection = new SqlConnection(ConnectionS_admin.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StaffName", selectedStaff);
                        connection.Open();

                        int rowsAffect = command.ExecuteNonQuery();

                        return rowsAffect > 0; //logic if (rowsAffect > 0) = true, < 0 = false. It will also be a boolean data type 
                    }
                }
            }

            else if (role == "Mechanic")
            {
                string query = @"delete from Mechanics where mechanicUsername = @StaffName";
                using (SqlConnection connection = new SqlConnection(ConnectionS_admin.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StaffName", selectedStaff);
                        connection.Open();

                        int rowsAffect = command.ExecuteNonQuery();

                        return rowsAffect > 0; //logic if (rowsAffect > 0) = true, < 0 = false. It will also be a boolean data type 
                    }
                }
            }

            else
            {
                return false;
            }
        }

        public bool Staff_ADD(string role, string username, int contactnumber)
        {
            if (role == "Receptionist")
            {
                string query = "insert into Receptionists (rcptionistUsername, rcptionistPW, rcptionistContactNum) values (@Username, @PW, @ContactNum)";

                try
                {
                    using (SqlConnection connection = new SqlConnection(ConnectionS_admin.ConnectionString))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Username", username);
                            command.Parameters.AddWithValue("@PW", 0000);
                            command.Parameters.AddWithValue("@ContactNum", contactnumber);

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
                    MessageBox.Show($"SQL 错误代码: {ex.Number}\n错误信息: {ex.Message}");

                    if (ex.Number == 547) //547 is the number when foreign key has problem in our database
                    {
                        MessageBox.Show("Error.....");
                        return false;
                    }

                    else
                    {

                        return false;
                    }
                }

            }

            else if (role == "Mechanic")
            {
                string query = "insert into Mechanics (mechanicUsername, mechanicPW, mechanicContactNum) values (@Username, @PW, @ContactNum)";

                try
                {
                    using (SqlConnection connection = new SqlConnection(ConnectionS_admin.ConnectionString))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Username", username);
                            command.Parameters.AddWithValue("@PW", 0000);
                            command.Parameters.AddWithValue("@ContactNum", contactnumber);

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
                    MessageBox.Show($"SQL 错误代码: {ex.Number}\n错误信息: {ex.Message}");

                    if (ex.Number == 547) //547 is the number when foreign key has problem in our database
                    {
                        MessageBox.Show("Error.....");
                        return false;
                    }

                    else
                    {

                        return false;
                    }
                }

            }

            else
            {
                return false;
            }
        }

        public void Delete_Overtime_FB()
        {
            DateTime dateMinus30 = DateTime.Now.AddDays(-30);

            string checkDate = dateMinus30.ToString("yyyy-MM-dd");

            string query = "delete from CustomerFeedBack where dateFeedBack < @DateThreshold";

            using (SqlConnection connection = new SqlConnection(ConnectionS_admin.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DateThreshold", checkDate);

                    connection.Open();
                    command.ExecuteNonQuery();

                }
            }
        }

        public List<string> CusFB_Net()
        {
            string query = @"select cusFeedback_ID from CustomerFeedBack";
            List<string> feedBackList = new List<string>();
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
                                feedBackList.Add(reader["cusFeedback_ID"].ToString());
                            }

                        }

                    }
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Please dont click the empty space");
            }
            return feedBackList;
        }

        public string CusFB_Content(int targetID)
        {
            string query = @"select cusFeedBackContent from CustomerFeedBack where cusFeedback_ID = @TargetID";
            string cusFB_content = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionS_admin.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TargetID", targetID);
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                cusFB_content = reader["cusFeedBackContent"].ToString();
                            }
                        }
                    }
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Please dont click the empty space");
            }
            return cusFB_content;
        }

        public string[] CusFB_Details(int target)
        {
            //query for take out customer_ID later I will  use customerID go to Customers table to find out customer details
            string queryFB = @"select customer_ID from CustomerFeedBack where cusFeedback_ID = @TargetID";
            string[] cusDetails = new string[3];
            int customerID = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionS_admin.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(queryFB, connection))
                    {
                        command.Parameters.AddWithValue("@TargetID", target);
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                customerID = Convert.ToInt32(reader["customer_ID"]);
                            }
                        }
                    }
                }


                //query for serching customer details
                string queryCus = @"select customerUsername, customerContactNum from Customers where customer_ID = @cusID";

                using (SqlConnection connection = new SqlConnection(ConnectionS_admin.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(queryCus, connection))
                    {
                        command.Parameters.AddWithValue("@cusID", customerID);
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                cusDetails[0] = "Customer Username: " + reader["customerUsername"].ToString();
                                cusDetails[1] = "Customer ID: " + customerID.ToString();
                                cusDetails[2] = "Contact Number: " + reader["customerContactNum"].ToString();
                            }
                        }
                    }
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Please dont click the empty space");
            }
            return cusDetails;
        }

        public int grossProfitCal(string month, string year)
        {
            string query = @"SELECT paymentValue FROM Payments
                             WHERE MONTH(paymentDate) = @MONTH
                             AND YEAR(paymentDate) = @YEAR
                             AND paymentStatus = 'COMPLETE'";

            int totalGrossProfit = 0;
            List<int> grossProfit = new List<int>();

            using (SqlConnection connection = new SqlConnection(ConnectionS_admin.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MONTH", month);
                    command.Parameters.AddWithValue("@YEAR", year);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            grossProfit.Add(Convert.ToInt32(reader["paymentValue"]));
                        }
                    }
                }
            }

            foreach(int item in grossProfit)
            {
                totalGrossProfit += item;
            }

            return totalGrossProfit;
        }

        public List<string> grossProfitList(string month, string year)
        {
            string query = @"SELECT payment_ID, paymentValue FROM Payments
                             WHERE MONTH(paymentDate) = @MONTH
                             AND YEAR(paymentDate) = @YEAR
                             AND paymentStatus = 'COMPLETE'";

            Dictionary<string, string> grossProfitDic = new Dictionary<string, string>();
            List<string> grossProfitList = new List<string>();

            using (SqlConnection connection = new SqlConnection(ConnectionS_admin.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MONTH", month);
                    command.Parameters.AddWithValue("@YEAR", year);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            grossProfitDic.Add(reader["payment_ID"].ToString(), reader["paymentValue"].ToString());
                        }
                    }
                }
            }

            foreach (KeyValuePair<string, string> item in grossProfitDic)
            {
                grossProfitList.Add($"PaymentID:{item.Key}-----Paymentt Value: {item.Value}");
            }

            return grossProfitList;
        }

        public Dictionary<string, int> ExpensesCal(string month, string year)
        {
            List<string> serviceAP_List = new List<string>();
            List<string> taskID_List = new List<string>();
            List<string> finalExpenses_List = new List<string>();
            Dictionary<string, int> partInfo_Dic = new Dictionary<string, int>();
            Dictionary<string, int> partDtls_Dic = new Dictionary<string, int>();
            Dictionary<string, int> totalExpenses_Dic = new Dictionary<string, int>();

            string query1 = @"select serviceAP_ID 
                                from ServiceAppoinments 
                                where MONTH(serviceAPDate) = @MONTH
                                and YEAR(serviceAPDate) = @YEAR";

            string query2 = @"select task_ID
                                 from Tasks 
                                 where taskStatus = 'COMPLETE' 
                                 and serviceAP_ID = @SERVICEAP_ID";

            string query3 = @"select part_ID, requestPartQuantity
                                  from Requests
                                  where rrequestStatus = 'COMPLETE'
                                  and task_ID = @TASK_ID";

            string query4 = @"select part_ID, partPrice
                                from Parts
                                where part_ID = @PART_ID";

            try
            {
                // First query - get initial service appointments
                using (SqlConnection connection = new SqlConnection(ConnectionS_admin.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query1, connection))
                    {
                        command.Parameters.AddWithValue("@MONTH", month);
                        command.Parameters.AddWithValue("@YEAR", year);
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
                        foreach (string id in serviceAP_List)
                        {
                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@SERVICEAP_ID", id);
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    taskID_List.Add(reader["task_ID"].ToString());
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
                        foreach (string ID in taskID_List)
                        {
                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@TASK_ID", ID);
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    partInfo_Dic.Add(reader["part_ID"].ToString(), Convert.ToInt32(reader["requestPartQuantity"]));
                                }
                            }
                        }
                    }
                }

                using (SqlConnection connection = new SqlConnection(ConnectionS_admin.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query4, connection))
                    {
                        foreach (string key in partInfo_Dic.Keys)
                        {
                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@PART_ID", key);
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    partDtls_Dic.Add(reader["part_ID"].ToString(), Convert.ToInt32(reader["partPrice"]));
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

            foreach(KeyValuePair<string, int> info in partInfo_Dic)
            {
                foreach(KeyValuePair<string, int> dtls in partDtls_Dic)
                {
                    if(info.Key == dtls.Key)
                    {
                        int partTotalExpenses = info.Value * dtls.Value;
                        totalExpenses_Dic.Add(info.Key, partTotalExpenses);
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            return totalExpenses_Dic;
        }
    }
}