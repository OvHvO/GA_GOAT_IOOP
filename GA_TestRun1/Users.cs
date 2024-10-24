﻿using Azure.Identity;
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
        string connection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\LAB_IOOP\\TEST_RUN_GIT\\GA-Backup001\\GA_GOAT_IOOP\\GA_TestRun1\\Database_GA.mdf;Integrated Security=True";

        private string Username;
        private string Password;
        public string usernames { get => Username; set => Username = value; }
        public string passwords { get => Password; set => Password = value; }

        //Constructor
        public Users(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public Users(string username)
        {
            Username = username;
        }




        public string LoginForms(string username, string password)
        {
            var SigninP = new Login_Pages();
            //string role = null;
            string status = null;
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            //find user exsit or not

            string command = "select count(*) from Users\r\nwhere Username=@username and Password=@password";
            SqlCommand cmd = new SqlCommand(command, con);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("Password", password);
            int check = Convert.ToInt32(cmd.ExecuteScalar());
            if (check > 0)
            {
                //find roles of user


                string command2 = "select Roles from Users\r\nwhere Username=@username and Password=@password";
                SqlCommand cmd2 = new SqlCommand(command2, con);
                cmd2.Parameters.AddWithValue("@username", username);
                cmd2.Parameters.AddWithValue("@password", password);
                string[] Roles = new string[4] { "Receptionist", "Customer", "Admins", "Mechanic" };
                string position = (cmd2.ExecuteScalar()).ToString();

                for (int i = 0; i < Roles.Length; i++)
                {
                    if (Roles[i] == position)
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
                                    Admins_home admins = new Admins_home();
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

                        //status = "Login Sucessfull"; 

                    }
                    else
                    {
                        continue;
                    }

                    //break;



                }

                //status = "Role not found";

            }
            else
            {
                status = "Enter Worng Password or Username";

            }
            con.Close();
            return status;

        }

        // Receptionist-(ADD/DEL Customer)
        //Define SignUp Roles
        public void Customer_Sup(string username, string password, int contactNum)
        {
            SqlConnection Sp_con = new SqlConnection(connection);
            Sp_con.Open();
            string command = "Insert into Users(Username,Password,Roles)\r\nvalues(@username,@password,'Customer')";

            SqlCommand Sp_cmd = new SqlCommand(command, Sp_con);
            Sp_cmd.Parameters.AddWithValue("@username", username);
            Sp_cmd.Parameters.AddWithValue("@password", password);

            if (Sp_cmd.ExecuteNonQuery() == 1)
            { //Retrive user ID
                string command3 = "select Users.User_ID\r\nfrom Users\r\nwhere Users.Username=@username";
                SqlCommand Sp_cmd2 = new SqlCommand(command3, Sp_con);
                Sp_cmd2.Parameters.AddWithValue("@username", username);
                int Userid = Convert.ToInt32(Sp_cmd2.ExecuteScalar());

                //Check the user ID have or not
                if (Userid > 0)
                {   // add userid into Customer Table   

                    string command2 = "Insert into Customers(customerUsername,customerPW,customerContactNum,User_ID)\r\nvalues(@username,@password,@contactNum,@User_ID)";
                    SqlCommand sp_cmd2 = new SqlCommand(command2, Sp_con);

                    sp_cmd2.Parameters.AddWithValue("@username", username);
                    sp_cmd2.Parameters.AddWithValue("@password", password);
                    sp_cmd2.Parameters.AddWithValue("@contactNum", contactNum);

                    sp_cmd2.Parameters.AddWithValue("@User_ID", Userid);
                    if (sp_cmd2.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("SignUp Sucessfull");
                    }
                    else
                    {
                        MessageBox.Show("SignUp Failed");
                    }


                }

            }
            else { MessageBox.Show("Something Went Wrong, Please Try Again"); }


            Sp_con.Close();
        }



        public void Mechanic_Sup(string username, string password, int contactNum)
        {
            SqlConnection Sp_con = new SqlConnection(connection);
            Sp_con.Open();
            string command = "Insert into Users(Username,Password,Roles)\r\nvalues(@username,@password,'Mechanic')";
            SqlCommand Sp_cmd = new SqlCommand(command, Sp_con);
            Sp_cmd.Parameters.AddWithValue("@username", username);
            Sp_cmd.Parameters.AddWithValue("@password", password);

            if (Sp_cmd.ExecuteNonQuery() == 1)
            { //Retrive user ID
                string command3 = "select Users.User_ID\r\nfrom Users\r\nwhere Users.Username=@username";
                SqlCommand Sp_cmd2 = new SqlCommand(command3, Sp_con);
                Sp_cmd2.Parameters.AddWithValue("@username", username);
                int Userid = Convert.ToInt32(Sp_cmd2.ExecuteScalar());

                //Check the user ID have or not
                if (Userid > 0)
                {   // add userid into Mechanic Table   

                    string command2 = "Insert into Mechanics(mechanicUsername,mechanicPW,mechanicContactNum)\r\nvalues(@username,@password,@contactNum,@User_ID)";
                    SqlCommand sp_cmd2 = new SqlCommand(command2, Sp_con);

                    sp_cmd2.Parameters.AddWithValue("@username", username);
                    sp_cmd2.Parameters.AddWithValue("@password", password);
                    sp_cmd2.Parameters.AddWithValue("@contactNum", contactNum);

                    sp_cmd2.Parameters.AddWithValue("@User_ID", Userid);
                    if (sp_cmd2.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("SignUp Sucessfull");
                    }
                    else
                    {
                        MessageBox.Show("SignUp Failed");
                    }


                }

            }
            else { MessageBox.Show("Something Went Wrong, Please Try Again"); }


            Sp_con.Close();

        }

        public void Receptionist_Sup(string username, string password, int contactNum)
        {
            SqlConnection Sp_con = new SqlConnection(connection);
            Sp_con.Open();
            string command = "Insert into Users(Username,Password,Roles)\r\nvalues(@username,@password,'Receptionist')";
            SqlCommand Sp_cmd = new SqlCommand(command, Sp_con);
            Sp_cmd.Parameters.AddWithValue("@username", username);
            Sp_cmd.Parameters.AddWithValue("@password", password);

            if (Sp_cmd.ExecuteNonQuery() == 1)
            { //Retrive user ID
                string command3 = "select Users.User_ID\r\nfrom Users\r\nwhere Users.Username=@username";
                SqlCommand Sp_cmd2 = new SqlCommand(command3, Sp_con);
                Sp_cmd2.Parameters.AddWithValue("@username", username);
                int Userid = Convert.ToInt32(Sp_cmd2.ExecuteScalar());

                //Check the user ID have or not
                if (Userid > 0)
                {   // add userid into Receptionist Table   

                    string command2 = "Insert into Receptionist(rcptionistUsername,rcptionistPW,rcptionistContactNum)\r\nvalues(@username,@password,@contactNum,@User_ID)";
                    SqlCommand sp_cmd2 = new SqlCommand(command2, Sp_con);

                    sp_cmd2.Parameters.AddWithValue("@username", username);
                    sp_cmd2.Parameters.AddWithValue("@password", password);
                    sp_cmd2.Parameters.AddWithValue("@contactNum", contactNum);

                    sp_cmd2.Parameters.AddWithValue("@User_ID", Userid);
                    if (sp_cmd2.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("SignUp Sucessfull");
                    }
                    else
                    {
                        MessageBox.Show("SignUp Failed");
                    }


                }

            }
            else { MessageBox.Show("Something Went Wrong, Please Try Again"); }

            Sp_con.Close();
        }

        

        public void updateProf(string username, string password)
        { //string status;
            string oldusername = Username; //save the old username into new variable
            Username = username;           // retrive the new username and password
            Password = password;
           
                using (SqlConnection sp_con = new SqlConnection(connection))
                {
                    sp_con.Open();
                    // begin the update

                    string query = "Select roles from Users";
                    SqlCommand cmd = new SqlCommand(query, sp_con);
                    string[] Roles = { "Receptionist", "Customer", "Admins", "Mechanic" };
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
    




   


