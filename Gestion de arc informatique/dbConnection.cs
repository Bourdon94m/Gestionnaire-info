using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_arc_informatique
{
    internal class dbConnection
    {
        private string server;
        private string database;
        private string username;
        private string password;
        MySqlConnection conn;
        public string Server { get => server; set => server = value; }
        public string Database { get => database; set => database = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        public void Connect(string connString)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
        }

        public dbConnection(string server, string database, string username, string password)
        {
            this.server = server;
            this.database = database;
            this.username = username;
            this.password = password;
            Connect();
        }

        



        public MySqlConnection getActualConnection() {
            Console.WriteLine(this.conn);
            return this.conn; 
        }

        public void Connect() {
            string connectionString = "server=" + this.server + ";database=" + this.database + ";user=" + this.username + ";password=" + this.password + ";";
            Console.WriteLine(connectionString);
            try
            {
                Console.WriteLine(connectionString);
                MySqlConnection conn = new MySqlConnection(connectionString);
                conn.Open();
                this.conn = conn;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void isValidAccount(string email, string password)
        {
            getActualConnection();
            string query = "SELECT password FROM gestion_matos.staff WHERE email = @email";
            MySqlCommand command = new MySqlCommand(query, getActualConnection());
            command.Parameters.AddWithValue("@email", email);

            using (MySqlDataReader reader = command.ExecuteReader())
            {

                if (reader.Read())
                {
                    string passwordFromDB = reader["password"].ToString();
                    
                    if (password.Equals(passwordFromDB))
                    {
                        Main mainPage = new Main();
                        Form1 form = new Form1();

                        form.Visible = false;
                        mainPage.Show();


                    }
                    else
                    {
                        MessageBox.Show("Wrong ID", "Wrong ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        reader.Close();

                    }
                }
                else
                {
                    MessageBox.Show("Not a valid account", "Wrong ID", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    reader.Close();
                }


            }

        }

        public void executeQuery(string query)
        {
            MySqlCommand command = new MySqlCommand(query, getActualConnection());

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex) { Console.WriteLine("Querys wasnt executed"); }
        }

        public void Close()
        {
            conn.Close();
        }
    }
}
