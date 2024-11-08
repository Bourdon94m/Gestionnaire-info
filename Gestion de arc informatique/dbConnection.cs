using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Diagnostics;
using System.Windows.Forms;
using Npgsql;

namespace Gestion_de_arc_informatique
{
    internal class dbConnection
    {
        private string server;
        private string database;
        private string username;
        private string password;
        private NpgsqlConnection conn;
        public string Server { get => server; set => server = value; }
        public string Database { get => database; set => database = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        public void Connect(string connString)
        {
            conn = new NpgsqlConnection(connString);
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

        public NpgsqlConnection getActualConnection()
        {
            Console.WriteLine(this.conn);
            return this.conn;
        }

        public void Connect()
        {
            string connectionString = $"Host={this.server};Database={this.database};Username={this.username};Password={this.password}";
            Console.WriteLine(connectionString);
            try
            {
                Console.WriteLine(connectionString);
                conn = new NpgsqlConnection(connectionString);
                conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void isValidAccount(string email, string password)
        {
            getActualConnection();
            string query = "SELECT password FROM staff WHERE email = @email";
            using (var command = new NpgsqlCommand(query, getActualConnection()))
            {
                command.Parameters.AddWithValue("@email", email);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string passwordFromDB = reader["password"].ToString();

                        if (password.Equals(passwordFromDB))
                        {
                            Main mainPage = new Main();
                            Form formPage = new Form();

                            mainPage.Visible = true;
                            mainPage.Show();
                            formPage.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Wrong ID", "Wrong ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Not a valid account", "Wrong ID", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        public void executeQuery(string query)
        {
            using (var command = new NpgsqlCommand(query, getActualConnection()))
            {
                try { command.ExecuteNonQuery(); }
                catch (Exception ex)
                {
                    Console.WriteLine("Query wasn't executed");
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public void executeQuery(string date, string commentary, int material_id, bool completed, string staff_id)
        {
            // PostgreSQL n'a pas besoin de SET FOREIGN_KEY_CHECKS
            string query = "INSERT INTO intervention (planned_date, commentary, material_id, completed, staff_id) VALUES (@date, @commentary, @material, @completed, @staff)";

            using (var command = new NpgsqlCommand(query, getActualConnection()))
            {
                command.Parameters.AddWithValue("@date", date);
                command.Parameters.AddWithValue("@commentary", commentary);
                command.Parameters.AddWithValue("@material", material_id);
                command.Parameters.AddWithValue("@completed", completed);
                command.Parameters.AddWithValue("@staff", staff_id);

                try { command.ExecuteNonQuery(); }
                catch (Exception ex)
                {
                    Console.WriteLine("La requête n'a pas été exécutée");
                    MessageBox.Show($"{ex.Message}");
                }
            }
        }

        public void Close()
        {
            if (conn != null && conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public void createStaff(string first_name, string last_name, string email, string password)
        {
            string query = "INSERT INTO staff (first_name, last_name, email, password) VALUES (@firstname, @lastname, @email, @password)";

            using (var command = new NpgsqlCommand(query, getActualConnection()))
            {
                command.Parameters.AddWithValue("@firstname", first_name);
                command.Parameters.AddWithValue("@lastname", last_name);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@password", password);

                try { command.ExecuteNonQuery(); }
                catch (Exception ex)
                {
                    Console.WriteLine("Le staff n'a pas été créé car la requête n'a pas fonctionné !");
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}