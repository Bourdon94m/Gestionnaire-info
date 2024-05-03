using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return this.conn;   
        }

        public void Connect() {
            string connstring = "server=" + this.server + ";uid=" + this.username + ";password=" + this.password + ";database=" + this.database + ";";
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open )
            {
                Console.WriteLine("OPENN !!");
            }
        }

        public void Close()
        {
            conn.Close();
        }
    }
}
