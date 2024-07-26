using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using System.Collections;
using System.Net.Sockets;

namespace ServerConnectInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFetchData_Click(object sender, EventArgs e)
        {
            string serverName = Dns.GetHostName();
            string connectionString = $"Server={serverName};Integrated Security=True;";
            string databaseName = null;
            string localIP = GetLocalIPAddress();
            txtIPAddress.Text = localIP;
            // Get the database name with 'ext' in it
            string query = "SELECT top 1 name FROM sys.databases WHERE upper(name) LIKE upper('%ext%');";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    databaseName = reader["name"].ToString();
                    //   txtDatabaseName.Text = databaseName;
                }

                reader.Close();
            }

            txtServerName.Text = serverName;

            LoadUserNames();
            LoadDatabaseNames();
        }

        private void LoadDatabaseNames()
        {
            string serverName = Dns.GetHostName();
            string connectionString = $"Server={serverName};Integrated Security=True;";
            string query = "SELECT name FROM sys.databases /*WHERE upper(name) LIKE upper('%ext%')*/;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string databaseName = reader["name"].ToString();
                        DatabaseComboBox.Items.Add(databaseName);
                        DatabaseComboBox.SelectedIndex = 0;
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void LoadUserNames()
        {
            string serverName = Dns.GetHostName();
            string connectionString = $"Server={serverName};Integrated Security=True;";
            string query = "SELECT name, password_hash FROM sys.sql_logins where upper(name) not LIKE upper('%#%');";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string userName = reader["name"].ToString();
                        NameComboBox.Items.Add(userName);
                        NameComboBox.SelectedIndex = 0;
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }
        private string GetLocalIPAddress()
        {
            string localIP = string.Empty;
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    localIP = ip.ToString();
                    break;
                }
            }
            return localIP;
        }
    }
}

