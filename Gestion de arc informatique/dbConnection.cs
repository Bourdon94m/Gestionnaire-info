using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
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
                        Form formPage = new Form();

                        mainPage.Visible = true;
                        mainPage.Show();
                        formPage.Visible = false;                        
                        
                        

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

            try { command.ExecuteNonQuery(); }  // Test if query was executed
            catch (Exception ex) { Console.WriteLine("Querys wasnt executed"); } // If not executed return debug messages
        }


        // Overloading method 
        public void executeQuery(string date, string commentary, int material_id, bool completed, string staff_id)
        {
            string query = $"SET FOREIGN_KEY_CHECKS=0; INSERT INTO gestion_matos.intervention (planned_date, commentary, material_id, completed, staff_id) VALUES (@date, @commentary, @material, @completed, @staff); SET FOREIGN_KEY_CHECKS=1";
            MySqlCommand command = new MySqlCommand(query, getActualConnection());

            // Créer des paramètres pour éviter l'injection SQL
            command.Parameters.AddWithValue("@date", date);
            command.Parameters.AddWithValue("@commentary", commentary);
            command.Parameters.AddWithValue("@material", material_id);
            command.Parameters.AddWithValue("@completed", completed);
            command.Parameters.AddWithValue("@staff", staff_id);

            try { command.ExecuteNonQuery(); } // Utilisez ExecuteNonQuery() pour les requêtes INSERT, UPDATE ou DELETE 
            catch (Exception ex)
            {
                Console.WriteLine("La requête n'a pas été exécutée");
                MessageBox.Show($"{ex.Message}");
            }
        }


        // Hash le mot de passe en params
        public string hashPassword(string password)
        {
            byte[] salt = GenerateRandomSalt(); // Genere le salt randomly

            //configuration des params PBKDF2
            int iterations = 10000;
            int derivedKeyLength = 32;


            // Creer un obj PBKDF2 avec password et salt
            using (Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations))
            {
                //Calculer la clé dérivée
                byte[] derivedKey = pbkdf2.GetBytes(derivedKeyLength);

                //Convertir la clé dérivée en chaine héxa
                StringBuilder sb = new StringBuilder();
                foreach(byte b in derivedKey)
                {
                    sb.Append(b.ToString("x2"));
                }

                Console.WriteLine("Mot de passe haché (PBKDF2) : " + sb.ToString());
                return sb.ToString();
               
            }

        }

        // Méthode pour générer un sel aléatoire
        public byte[] GenerateRandomSalt()
        {
            byte[] salt = new byte[16]; // 16 octets pour le sel
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(salt);
            }
            return salt;
        }

        public void Close() { conn.Close(); }


        // Fonction pour crée un staff
        public void createStaff(string first_name, string last_name, string email, string password) {

            string query = $"INSERT INTO gestion_matos.staff (first_name, last_name, email, password) VALUES (@firstname, @lastname, @email, @password)";
            MySqlCommand command = new MySqlCommand(query, getActualConnection());


            // Créer des paramètres pour éviter l'injection SQL
            command.Parameters.AddWithValue("@firstname", first_name);
            command.Parameters.AddWithValue("@lastname", last_name);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@password", password);


            try { command.ExecuteNonQuery(); } // Utilisez ExecuteNonQuery() pour les requêtes INSERT, UPDATE ou DELETE 
            catch (Exception ex)
            {
                Console.WriteLine("Le staff na pas été crée car la requete n'a pas fonctionné !!");
            }


        }

    }
}
