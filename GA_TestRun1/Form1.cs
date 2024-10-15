using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace GA_TestRun1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\waiki\\OneDrive\\Desktop\\C# Learning\\GA_TestRun1\\GA_TestRun1\\Database2.mdf\";Integrated Security = True";

        private void button1_Click(object sender, EventArgs e)
        { 
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Successfully connected to the database.");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void insertData(string name, string position, int salary)
        {
            string query = "INSERT INTO Customers (customerUsername, customerPW, customerContactNum) VALUES (@customerUsername, @customerPW, @customerContactNum)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                
                // 添加参数以避免 SQL 注入攻击
                command.Parameters.AddWithValue("@customerUsername", name);
                command.Parameters.AddWithValue("@customerPW", position);
                command.Parameters.AddWithValue("@customerContactNum", salary);

                try
                {
                    connection.Open();
                    int result = command.ExecuteNonQuery();  // 返回受影响的行数
                    if (result > 0)
                    {
                        MessageBox.Show("Record inserted successfully.");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"SQL Error: {ex.Message}");
                }
            }  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = "Jame";
            string position = "Customer";
            int salary = 10000;
            insertData(name, position, salary);
        }
    }
}
