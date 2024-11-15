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
        int ServiceAmt;
        int PartAmt;
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
                    MessageBox.Show("Something Went Wrong, Please try again", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        public void rcpUpdateProf(string oldusername, string username, string password, string contactNum)
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

                    string query2 = "Update Receptionists set rcptionistUsername=@username,rcptionistPW=@password,rcptionistContactNum=@contactNum where rcptionistUsername=@oldusername";
                    SqlCommand cmd2 = new SqlCommand(query2, conn, transaction);
                    cmd2.Parameters.AddWithValue("@username", username);
                    cmd2.Parameters.AddWithValue("@password", password);
                    cmd2.Parameters.AddWithValue("@contactNum",contactNum);
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
            string query = @"Select DISTINCT C.customer_ID, C.customerUsername,C.customerContactNum , SA.serviceAP_ID,SA.carNum, T.mechanic_ID,T.taskStatus, SA.rescheduleStatus
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


        public static object RequestF()
        {
            SqlConnection con = new SqlConnection(connectionS);
            con.Open();
            string query = "Select distinct R.request_ID,R.requestPartQuantity, R.rrequestStatus,R.part_ID,P.partName,T.mechanic_ID\r\nfrom Requests as R\r\nInner Join Parts as P on P.part_ID=R.part_ID\r\nLeft Join Tasks as T on T.task_ID =R.task_ID";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            adapter.Fill(data);
            con.Close();
            return data;
        }

        public static object invSearchFunc(string selectedItems, string searchkey)
        {
            try 
            { 
                SqlConnection connection = new SqlConnection(connectionS);
                connection.Open();
                string query = $@"Select distinct R.request_ID,R.requestPartQuantity, R.rrequestStatus,R.part_ID,P.partName,T.mechanic_ID from Requests as R Inner Join Parts as P on P.part_ID=R.part_ID Left Join Tasks as T on T.task_ID =R.task_ID
                                   where R.{selectedItems} LIKE '%'+@search+'%' ";
                SqlCommand cmd = new SqlCommand(query,connection);
                cmd.Parameters.AddWithValue("@search",searchkey);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable data= new DataTable();
                adapter.Fill(data);
                connection.Close();
                return data;
            }
            catch (SqlException)
            {
                return MessageBox.Show("Error");
               
            }

        }

        public static void RequestStatus(int requestid, string status, int quantity,string partName)
        {
            using (SqlConnection conn = new SqlConnection(connectionS)) 
            {   
                conn.Open();
                try
                {
                    SqlTransaction transaction = conn.BeginTransaction();
                    string query = @"Update Requests set rrequestStatus='ASSIGNED' where request_ID=@requestid AND rrequestStatus='PENDING'";
                    SqlCommand command = new SqlCommand(query, conn, transaction);
                    command.Parameters.AddWithValue("@requestid", requestid);

                    string query3 = @"Select partQuantity from Parts where partName=@partname";
                    SqlCommand cmd3 = new SqlCommand(query3, conn, transaction);
                    cmd3.Parameters.AddWithValue("@partname", partName);
                    int.TryParse(cmd3.ExecuteScalar().ToString(), out int partQty);
                    partQty -= quantity;
                    if (partQty >= 0)
                    {


                        string query2 = @"Update Parts set partQuantity=@quantity where partName=@partname";
                        SqlCommand cmd2 = new SqlCommand(query2, conn, transaction);

                        cmd2.Parameters.AddWithValue("@quantity", partQty);
                        cmd2.Parameters.AddWithValue("@partname", partName);
                        cmd2.ExecuteNonQuery();

                        if (command.ExecuteNonQuery() == 1)
                        {
                            transaction.Commit();
                            MessageBox.Show($"Assigned !, The Stock of the {partName} is {partQty}");
                            if (partQty<10) 
                            {
                                MessageBox.Show($"Please Note That {partName} Quantity is below than 20 !","Warning !",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                            }
                        }

                        else
                        {
                            transaction.Rollback();
                            MessageBox.Show("This Request has been marked as COMPLETED ! If you didn't see it Please Refresh !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        }
                    }
                    else
                    {
                        transaction.Rollback();
                        MessageBox.Show($"The Stock of the {partName} is not enough");

                    }
                }

                catch (SqlException) 
                {
                    MessageBox.Show("Please Click On A Content !","Reminder");
                }

            
            }
        }

        public static void DelRequest(int requestid)
        {
            using (SqlConnection conn = new SqlConnection(connectionS)) 
            {  
                conn.Open(); 
                SqlTransaction transaction = conn.BeginTransaction();
                string query = "Delete from Requests where request_ID=@requestid ";
                SqlCommand cmd= new SqlCommand(query, conn,transaction);
                cmd.Parameters.AddWithValue("@requestid", requestid);
                if (cmd.ExecuteNonQuery()<0)
                {
                    transaction.Rollback();
                    MessageBox.Show("Delete Unsucess!","Delete Request",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                    conn.Close();
                }
                else
                {
                    transaction.Commit();
                    MessageBox.Show("Delete Sucess!","Delete Request");
                    conn.Close();
                } 
            }
            
        }


        public static object searchFunc(string searchKey, string selectedItems)
        {
            using (SqlConnection conn = new SqlConnection(connectionS))
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

        public void assignMec(string selectedItems, string taskname, string serviceID, string rcpname, DateTime date)
        {
            using (SqlConnection conn = new SqlConnection(connectionS))
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
                        cmd4.Parameters.AddWithValue("@username", rcpname);
                        rcpname = cmd4.ExecuteScalar().ToString();

                    }
                    else
                    {
                        rcpid = cmd2.ExecuteScalar().ToString();
                    }
                    //search ID for receptionist (while changing name)
                    string query5 = "Select rcptionist_ID from Receptionists where rcptionistUsername=@users";
                    SqlCommand cmd5 = new SqlCommand(query5, conn, transaction);
                    cmd5.Parameters.AddWithValue("@users", rcpname);
                    rcpid = cmd5.ExecuteScalar().ToString();

                    string query3 = "Select mechanic_ID from Mechanics where mechanicUsername=@mecuser";
                    SqlCommand cmd3 = new SqlCommand(query3, conn, transaction);
                    cmd3.Parameters.AddWithValue("@mecuser", selectedItems);
                    string mechanicID = cmd3.ExecuteScalar().ToString();

                    string query = "Insert Into Tasks(taskStatus,mechanic_ID,serviceAP_ID,rcptionist_ID,taskContent) values('PENDING',@mechanicID,@serviceAP_ID,@rcptionist_ID,@taskname)";
                    SqlCommand cmd = new SqlCommand(query, conn, transaction);
                    cmd.Parameters.AddWithValue("@mechanicID", mechanicID);
                    cmd.Parameters.AddWithValue("@serviceAP_ID", serviceID);
                    cmd.Parameters.AddWithValue("@rcptionist_ID", rcpid);
                    cmd.Parameters.AddWithValue("@taskname",taskname);

                    string query6 = "Update ServiceAppoinments set serviceAPDate=@servicedate,rescheduleStatus='False' where serviceAP_ID=@serviceid";
                    SqlCommand cmd6 = new SqlCommand(query6, conn, transaction);
                    cmd6.Parameters.AddWithValue("@servicedate", date);
                    cmd6.Parameters.AddWithValue("@serviceid", serviceID);

                    string query7 = "Insert into Timetable(serviceAP_ID,mechanic_ID) values(@serviceid,@mechanicid)";
                    SqlCommand cmd7 = new SqlCommand(query7, conn, transaction);
                    cmd7.Parameters.AddWithValue("@serviceid", serviceID);
                    cmd7.Parameters.AddWithValue("@mechanicid", mechanicID);



                    if (cmd.ExecuteNonQuery() == 1 && cmd6.ExecuteNonQuery() == 1 && cmd7.ExecuteNonQuery() == 1)
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
                catch (SqlException )
                {

                    MessageBox.Show("Error, Please try again");
                    transaction.Rollback();

                }


                conn.Close();
            }

        }
        
        public static object cus_CheckInOut()
        {
            SqlConnection conn = new SqlConnection(connectionS);
            conn.Open();
            string query = @"Select Distinct C.customer_ID, C.customerUsername,SA.carNum,SA.carVersion,SA.serviceAP_ID,T.vehicleStatus
                           from Customers as C
                           Inner Join ServiceAppoinments as SA on SA.customer_ID= C.customer_ID
                           Left Join Tasks as T on SA.serviceAP_ID=T.serviceAP_ID";
            SqlCommand cmd= new SqlCommand(query, conn);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable data =new DataTable();
            adapter.Fill(data);
            conn.Close();
            return data;
        }


        public static void cus_UpdateCheckInOut(string cus_Name, string carNum,string carver, int serviceid,string status)
        {
            SqlConnection conn = new SqlConnection(connectionS);
            conn.Open();
            string query = "Update ServiceAppoinments set carNum=@carnum, carVersion=@carver where serviceAP_ID=@serviceid";
            SqlCommand cmd= new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@carnum",carNum);
            cmd.Parameters.AddWithValue("@carver",carver);
            cmd.Parameters.AddWithValue("@serviceid",serviceid);
            int serviceAppoiRowAffect= cmd.ExecuteNonQuery();

            

            if (status=="Check-In") 
            { 
                string query2 = "Update Tasks set vehicleStatus='True' where serviceAP_ID=@serviceid";
                SqlCommand cmd2 = new SqlCommand(query2, conn);
                cmd2.Parameters.AddWithValue("@serviceid",serviceid);
                int taskRowAffected= cmd2.ExecuteNonQuery();
                 if (serviceAppoiRowAffect>0 && taskRowAffected>0)
                 {
                    MessageBox.Show("Update Sucessfully");
                 }
                 else
                 {
                    MessageBox.Show("Update Failed Or Customer Task Haven't Assign");
                 }
            }
            else
            {
                string query2 = "Update Tasks set vehicleStatus='False' where serviceAP_ID=@serviceid";
                SqlCommand cmd2 = new SqlCommand(query2, conn);
                cmd2.Parameters.AddWithValue("@serviceid", serviceid);
                int secondtaskRowAffected= cmd2.ExecuteNonQuery();

                if (serviceAppoiRowAffect>0&& secondtaskRowAffected>0)
                {
                    MessageBox.Show("Update Sucessfully");

                }
                else
                {
                    MessageBox.Show("Update Failed or Customer Task Haven't Assign");
                }
            }

           
            conn.Close();
        }


        public object billdetails(int serviceid)
        {   List<int> price = new List<int>();
            List<int> quantity = new List<int>();
            int TotalAmt;
            int Allmt = 0;
            SqlConnection conn = new SqlConnection(connectionS);
            conn.Open();
            string query = @"Select P.part_ID, P.partName, R.requestPartQuantity, P.partPrice,R.task_ID, T.serviceAP_ID 
                           from Parts as P
                           Inner Join Requests as R on R.part_ID=P.part_ID
                           Left Join Tasks as T on T.task_ID=R.task_ID
                           Where T.serviceAP_ID =@serviceid;"
                           ;
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@serviceid",serviceid);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table= new DataTable();
            adapter.Fill(table);
            
            //add column
            table.Columns.Add("Total Price", Type.GetType("System.Int32"));

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                quantity.Add(Convert.ToInt32(reader[2]));
                price.Add(Convert.ToInt32(reader[3]));

            }

            for (int i = 0; i < price.Count; i++)
            {
                TotalAmt = price[i] * quantity[i];

                // first[i] is indicate the row number,second [""] is refer to column name 
                table.Rows[i]["Total Price"]=TotalAmt;
                Allmt += TotalAmt;
            }
            PartAmt = Allmt;
            
            conn.Close();
            return table;

        }


        public object billServiceDetail(int serviceid)
        {
            SqlConnection con = new SqlConnection(connectionS);
            List<int> price = new List<int>();
            List<int> offer = new List<int>();
            int Tprice;
            int Allamt=0;
            con.Open();
            string query = @"Select S.service_ID, S.serviceName, S.servicePrice, S.serviceOffer
                            from Service as S
                            Inner Join Requests as R on R.part_ID=S.part_ID
                            Left Join Tasks as T on T.task_ID =R.task_ID
                            Where T.serviceAP_ID=@serviceid";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@serviceid",serviceid);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table= new DataTable();
            adapter.Fill(table);
            table.Columns.Add("Total",Type.GetType("System.String"));
            

            SqlDataReader reader= cmd.ExecuteReader();
            while (reader.Read()) 
            {
                
                    price.Add(Convert.ToInt32(reader[2]));
                    offer.Add(Convert.ToInt32(reader[3]));
                

                
            }
            for (int index=0; index<price.Count;index++)
            {
               Tprice= price[index]-offer[index];
               table.Rows[index]["Total"]=Tprice;
               Allamt += Tprice;
               
            } 
            ServiceAmt=Allamt;

            con.Close();
            return table;

        }

        public string GetBillTotalAmt()
        {
            string totalamt = (ServiceAmt + PartAmt).ToString("C");
            return totalamt;
            
        }

        public string updatePaymentStatus(int serviceId,int cusid)
        {
            string paymentid = null;
            string taskid=null;
            string rcpid=null;
            string allvalue;
            string sId = serviceId.ToString();
            SqlConnection con = new SqlConnection(connectionS);
            con.Open();
            string query = "Select rcptionist_ID,task_id from Tasks where serviceAP_ID=@serviceid";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@serviceid", sId);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                rcpid = Convert.ToString(reader[0]);
                taskid = Convert.ToString(reader[1]);
            }
            reader.Close();

            string query4 = "Select payment_ID from Payments where customer_ID=@cusid And paymentStatus='PENDING'";
            SqlCommand cmd4 = new SqlCommand(query4, con);
            cmd4.Parameters.AddWithValue("@cusid", cusid);
            paymentid = Convert.ToString(cmd4.ExecuteScalar());
            
            if (string.IsNullOrEmpty(paymentid)) 
            { 

                string query2 = @"Insert into Payments(paymentStatus,paymentValue,customer_ID,rcptionist_id)
                                  Values ('PENDING',@paymentvalue,@cusid,@rcpid)";
                SqlCommand cmd2= new SqlCommand(query2, con);
                allvalue= (ServiceAmt + PartAmt).ToString();
                cmd2.Parameters.AddWithValue("@paymentvalue",allvalue);
                cmd2.Parameters.AddWithValue("@cusid",cusid);
                cmd2.Parameters.AddWithValue("@rcpid",rcpid);
          
                cmd2.ExecuteNonQuery();

                string query3 = "Select payment_ID from Payments where customer_ID=@cusid And paymentStatus='PENDING'";
                SqlCommand cmd3 = new SqlCommand(query3, con);
                cmd3.Parameters.AddWithValue("@cusid",cusid);
                paymentid= Convert.ToString(cmd3.ExecuteScalar());
                con.Close();
                return paymentid;
            }
            return paymentid;

            
        }

        public static List<string> AlretForShortage()
        {   
            List<string> shortageName = new List<string>();
            //List<string> shortageQty = new List<string>();

            SqlConnection con = new SqlConnection(connectionS);
            con.Open();
            string query = "Select partName from Parts where partShortage='True'";
            SqlCommand cmd= new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) 
            {
                shortageName.Add(reader[0].ToString());
                
            }
            reader.Close();

            con.Close();
            return shortageName;

        }



    }
}





