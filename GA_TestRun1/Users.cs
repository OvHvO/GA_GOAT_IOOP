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

namespace GA_TestRun1
{
    internal class Users
    {   //**** PLEASE CHANGE THE STRING BEFORE USING DATABASE ****//
        string connection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\LAB_IOOP\\TEST_RUN_GIT\\GA_GIT_IOOP\\GA_TestRun1\\Database_GA.mdf;Integrated Security=True";
        
        private string username;
        private string password;
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        //Constructor
        public Users(string username, string password)
        {
            username = Username;
            password = Password;
        }

        public Users(string username) 
        {
            username = Username;
        }


        public string LoginForms(string username, string password)
        {   string status=null;
            SqlConnection con= new SqlConnection(connection);
            con.Open();
            //find user exsit or not

            string command = "select count(*) from Users\r\nwhere Username=@username and Password=@password";
            SqlCommand cmd =new SqlCommand(command, con);
            cmd.Parameters.AddWithValue("@username",username);
            cmd.Parameters.AddWithValue ("Password",password);
            int check=Convert.ToInt32(cmd.ExecuteScalar());
            if (check > 0)
            {   
                //find roles of user
                
                
                string command2 = "select Roles from Users\r\nwhere Username=@username and Password=@password";
                SqlCommand cmd2 = new SqlCommand(command2, con);
                cmd2.Parameters.AddWithValue("@username", username);
                cmd2.Parameters.AddWithValue("@password",password);
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
                                    Receptionist_home Form = new Receptionist_home();
                                    Form.ShowDialog();
                                    return status = "Login Sucessfull";

                                }
                            case 1:
                                {
                                    Customer_home customer = new Customer_home();
                                    customer.ShowDialog();
                                    return status = "Login Sucessfull";

                                }
                            case 2:
                                {
                                    Admins_home admins = new Admins_home();
                                    admins.ShowDialog();
                                    return status = "Login Sucessfull";
                                }
                            case 3:
                                {
                                    Mechanic_home mechanic = new Mechanic_home();
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
        public void Customer_Sup(string username, string password,int contactNum)
        {
            SqlConnection Sp_con=new SqlConnection(connection);
            Sp_con.Open();
            string command = "Insert into Users(Username,Password,Roles)\r\nvalues(@username,@password,'Customer')";
            string command2 = "Insert into Customers(customerUsername,customerPW,customerContactNum)\r\nvalues(@username,@password,@contactNum)";
            SqlCommand Sp_cmd=new SqlCommand(command,Sp_con);
            SqlCommand sp_cmd2=new SqlCommand(command2,Sp_con);
            
            
            sp_cmd2.Parameters.AddWithValue("@username", username);
            sp_cmd2.Parameters.AddWithValue ("@password", password);
            sp_cmd2.Parameters.AddWithValue("@contactNum", contactNum);
            Sp_cmd.Parameters.AddWithValue("@username", username);
            Sp_cmd.Parameters.AddWithValue("@password", password);
            if (sp_cmd2.ExecuteNonQuery() == 1 && Sp_cmd.ExecuteNonQuery() == 1) 
            {
                MessageBox.Show("SignUp Sucessfull");
            }
            else
            {
                MessageBox.Show("SignUp Failed");
            }
            Sp_con.Close();
        }

        public void Mechanic_Sup(string username, string password, int contactNum)
        {
            SqlConnection Sp_con = new SqlConnection(connection);
            Sp_con.Open();
            string command = "Insert into Users(Username,Password,Roles)\r\nvalues(@username,@password,'Mechanic')";
            SqlCommand Sp_cmd = new SqlCommand(command, Sp_con);
            string command2 = "Insert into Mechanics(mechanicUsername,mechanicPW,mechanicContactNum)\r\nvalues(@username,@password,@contactNum)";
            SqlCommand sp_cmd2 = new SqlCommand(command2, Sp_con);
            

            sp_cmd2.Parameters.AddWithValue("@username", username);
            sp_cmd2.Parameters.AddWithValue("@password", password);
            sp_cmd2.Parameters.AddWithValue("@contactNum", contactNum);
            Sp_cmd.Parameters.AddWithValue("@username", username);
            Sp_cmd.Parameters.AddWithValue("@password", password);
            Sp_con.Close();
            if (sp_cmd2.ExecuteNonQuery() == 1 && Sp_cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("SignUp Sucessfull");
            }
            else
            {
                MessageBox.Show("SignUp Failed");
            }
        }

        public void Receptionist_Sup(string username, string password, int contactNum)
        {
            SqlConnection Sp_con = new SqlConnection(connection);
            Sp_con.Open();
            string command = "Insert into Users(Username,Password,Roles)\r\nvalues(@username,@password,'Receptionist')";
            SqlCommand Sp_cmd = new SqlCommand(command, Sp_con);
            string command2 = "Insert into Receptionist(rcptionistUsername,rcptionistPW,rcptionistContactNum)\r\nvalues(@username,@password,@contactNum)";
            SqlCommand sp_cmd2 = new SqlCommand(command2, Sp_con);
            

            sp_cmd2.Parameters.AddWithValue("@username", username);
            sp_cmd2.Parameters.AddWithValue("@password", password);
            sp_cmd2.Parameters.AddWithValue("@contactNum", contactNum);
            Sp_cmd.Parameters.AddWithValue("@username", username);
            Sp_cmd.Parameters.AddWithValue("@password", password);
            if (sp_cmd2.ExecuteNonQuery() == 1 && Sp_cmd.ExecuteNonQuery() == 1)
            {
                 MessageBox.Show( "SignUp Sucessfull");
                
            }
            else
            {
                MessageBox.Show("SignUp Failed");
            }
            Sp_con.Close();
        }
            
       
    }
}

