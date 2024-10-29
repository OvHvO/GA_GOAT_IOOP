using Azure.Identity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GA_TestRun1.Receptionist;
using GA_TestRun1.Customer;
using GA_TestRun1.Admins;
using GA_TestRun1.Mechanics;
using System.Windows.Forms;
using System.Diagnostics.Eventing.Reader;
using System.Net.Http.Headers;

namespace GA_TestRun1
{

    internal class Users
    {   //**** PLEASE CHANGE THE STRING BEFORE USING DATABASE ****//

        string connection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\waiki\\OneDrive\\Desktop\\C# OOP\\GA_TestRun1\\GA_TestRun1\\Database_GA.mdf\";Integrated Security=True";
        private string Username;
        private string Password;
        public string usernames { get => Username; set => Username = value; }
        public string passwords { get => Password; set => Password = value; }

        //Constructor
        public Users(string username, string password)
        {
            usernames = username;
            passwords = password;
        }

        public Users(string username)
        {
            usernames = username;
        }

        public string LoginForms(string username, string password)
        {
            var SigninP = new Login_Pages();
            //string role = null;
            string status = null;
            string role = AuthenticateUser(connection, username, password);
            string[] Roles = new string[4] { "rcptionist", "customer", "admin", "mechanic" };


            for (int i = 0; i < Roles.Length; i++)
            {
                if (Roles[i] == role)
                {
                    switch (i)
                    {
                        case 0:
                            {
                                Receptionist_home Form = new Receptionist_home(username);

                                SigninP.Hide();
                                Form.ShowDialog();

                                return status = "Login Sucessfull";

                            }
                        case 1:
                            {
                                Customer_home customer = new Customer_home();
                                SigninP.Hide();
                                customer.ShowDialog();

                                return status = "Login Sucessfull";

                            }
                        case 2:
                            {
                                Admins_home admins = new Admins_home(username);
                                SigninP.Hide();
                                admins.ShowDialog();

                                return status = "Login Sucessfull";
                            }
                        case 3:
                            {
                                Mechanic_home mechanic = new Mechanic_home();
                                SigninP.Hide();
                                mechanic.ShowDialog();

                                return status = "Login Sucessfull";
                            }
                        default:
                            {
                                status = "Error";
                                return status;

                            }
                    }

                }
                else
                {
                    continue;
                }

            }

            status = "Role not found";
            return status;

        }


        public string AuthenticateUser(string connectionString, string username, string password)
        {
            string query = @"
            SELECT 'rcptionist' AS role FROM Receptionists WHERE rcptionistUsername = @username AND rcptionistPW = @password
            UNION
            SELECT 'admin' AS role FROM Admins WHERE adminUsername = @username AND adminPW = @password
            UNION
            SELECT 'customer' AS role FROM Customers WHERE customerUsername = @username AND customerPW = @password
            UNION
            SELECT 'mechanic' AS role FROM Mechanics WHERE mechanicUsername = @username AND mechanicPW = @password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    connection.Open();

                    string role = (string)command.ExecuteScalar();
                    return role;
                }
            }
        }

        // Receptionist-(ADD/DEL Customer)
        //Define SignUp Roles
        public void Customer_Sup(string username, string password, int contactNum)
        {
            SqlConnection Sp_con = new SqlConnection(connection);
            Sp_con.Open();



            string query1 = @"Select rcptionistUsername from Receptionists where rcptionistUsername=@username
                                    UNION ALL
                                    Select customerUsername from Customers where customerUsername=@username
                                    UNION ALL
                                    Select mechanicUsername from Mechanics where mechanicUsername= @username
                                    UNION ALL
                                    Select adminUsername from Admins where adminUsername=@username";
            SqlCommand cmd2 = new SqlCommand(query1, Sp_con);
            cmd2.Parameters.AddWithValue("@username", username);

            if (cmd2.ExecuteNonQuery() == 0)
            {

                string command2 = "Insert into Customers(customerUsername,customerPW,customerContactNum,)\r\nvalues(@username,@password,@contactNum)";
                SqlCommand sp_cmd2 = new SqlCommand(command2, Sp_con);

                sp_cmd2.Parameters.AddWithValue("@username", username);
                sp_cmd2.Parameters.AddWithValue("@password", password);
                sp_cmd2.Parameters.AddWithValue("@contactNum", contactNum);

                if (sp_cmd2.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("SignUp Sucessfull");
                }
                else
                {
                    MessageBox.Show("SignUp Failed");
                }
            }

            else
            {
                MessageBox.Show("The Username Seems has been Used, Please Try Again", "Username Issues");
            }




            Sp_con.Close();
        }



        public void Mechanic_Sup(string username, string password, int contactNum)
        {
            SqlConnection Sp_con = new SqlConnection(connection);
            Sp_con.Open();



            string query1 = @"Select rcptionistUsername from Receptionists where rcptionistUsername=@username
                                    UNION ALL
                                    Select customerUsername from Customers where customerUsername=@username
                                    UNION ALL
                                    Select mechanicUsername from Mechanics where mechanicUsername= @username
                                    UNION ALL
                                    Select adminUsername from Admins where adminUsername=@username";
            SqlCommand cmd2 = new SqlCommand(query1, Sp_con);
            cmd2.Parameters.AddWithValue("@username", username);

            if (cmd2.ExecuteNonQuery() == 0)
            {

                string command2 = "Insert into Mechanics(mechanicUsername,mechanicPW,mechanicContactNum,)\r\nvalues(@username,@password,@contactNum)";
                SqlCommand sp_cmd2 = new SqlCommand(command2, Sp_con);

                sp_cmd2.Parameters.AddWithValue("@username", username);
                sp_cmd2.Parameters.AddWithValue("@password", password);
                sp_cmd2.Parameters.AddWithValue("@contactNum", contactNum);

                if (sp_cmd2.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("SignUp Sucessfull");
                }
                else
                {
                    MessageBox.Show("SignUp Failed");
                }
            }

            else
            {
                MessageBox.Show("The Username Seems has been Used, Please Try Again", "Username Issues");
            }




            Sp_con.Close();

        }





        public void Receptionist_Sup(string username, string password, int contactNum)
        {
            SqlConnection Sp_con = new SqlConnection(connection);
            Sp_con.Open();



            string query1 = @"Select rcptionistUsername from Receptionists where rcptionistUsername=@username
                                    UNION ALL
                                    Select customerUsername from Customers where customerUsername=@username
                                    UNION ALL
                                    Select mechanicUsername from Mechanics where mechanicUsername= @username
                                    UNION ALL
                                    Select adminUsername from Admins where adminUsername=@username";
            SqlCommand cmd2 = new SqlCommand(query1, Sp_con);
            cmd2.Parameters.AddWithValue("@username", username);

            if (cmd2.ExecuteNonQuery() == 0)
            {

                string command2 = "Insert into Receptionists(rcptionistUsername,rcptionistPW,rcptionistContactNum,)\r\nvalues(@username,@password,@contactNum)";
                SqlCommand sp_cmd2 = new SqlCommand(command2, Sp_con);

                sp_cmd2.Parameters.AddWithValue("@username", username);
                sp_cmd2.Parameters.AddWithValue("@password", password);
                sp_cmd2.Parameters.AddWithValue("@contactNum", contactNum);

                if (sp_cmd2.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("SignUp Sucessfull");
                }
                else
                {
                    MessageBox.Show("SignUp Failed");
                }
            }

            else
            {
                MessageBox.Show("The Username Seems has been Used, Please Try Again", "Username Issues");
            }




            Sp_con.Close();
        }



        public void updateProf(string username, string password)
        { //string status;
            string oldusername = Username; //save the old username into new variable
            usernames = username;           // retrive the new username and password
            passwords = password;

            using (SqlConnection sp_con = new SqlConnection(connection))
            {
                sp_con.Open();
                // begin the update


                string query = @"
                SELECT 'rcptionist' AS role FROM Receptionists WHERE rcptionistUsername = @username 
                SELECT 'admin' AS role FROM Admins WHERE adminUsername = @username 
                UNION
                SELECT 'customer' AS role FROM Customers WHERE customerUsername = @username 
                SELECT 'mechanic' AS role FROM Mechanics WHERE mechanicUsername = @username";
                SqlCommand cmd = new SqlCommand(query, sp_con);
                cmd.Parameters.AddWithValue("@username", oldusername);



                string[] Roles = { "rcptionist", "customer", "admin", "mechanic" };
                string Positions = (cmd.ExecuteScalar().ToString());
                for (int i = 0; i < Roles.Length; i++)
                {
                    if (Roles[i] == Positions)
                    {
                        switch (i)
                        {
                            case 0:
                                {
                                    Receptionists recep = new Receptionists(username, password);
                                    recep.rcpUpdateProf(oldusername, username, password);
                                    //status = "Update Sucessful!";
                                    //return status;  
                                    break;
                                }
                                //case 1: { Put Your Code for Customer.....
                        }

                    }


                }


            }
        }


    }

}












