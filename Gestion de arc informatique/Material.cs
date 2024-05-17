﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gestion_de_arc_informatique
{
    public partial class Material : Form
    {
        public Material()
        {
            InitializeComponent();
        }

        private void pictureBoxCreateInterv_Click(object sender, EventArgs e)
        {
            Main mainWindow = new Main();
            mainWindow.Visible = true;
            mainWindow.Show();
            this.Visible = false;
        }

        private void Material_Load(object sender, EventArgs e)
        {
            
            // Create a new MySqlCommand object with a SQL query string and a connection object.
            MySqlCommand command = new MySqlCommand("SELECT * FROM material", Program.dbConnectionBase.getActualConnection());

            // Create a new MySqlDataAdapter object with the MySqlCommand object.
            // The MySqlDataAdapter represents a set of data commands and a database connection
            // that are used to fill a dataset and update a MySQL database.
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            // Create a new DataTable object.
            // A DataTable represents one table of in-memory relational data; the data is local to the .NET-based application in which it resides, but can be populated from a data source such as Microsoft SQL Server using a DataAdapter.
            DataTable table = new DataTable();

            // Call the Fill method of the MySqlDataAdapter object to execute the SELECT command and store the result set in the DataTable object.
            // The Fill operation automatically opens the connection to the data source if it is closed and closes it when it is done.
            adapter.Fill(table);
            
            foreach (DataRow row in table.Rows)
            {
                //insert data in datagridview
                siticoneDataGridView1.Rows.Add(row.ItemArray);
                
            }
            //make this datagridview readonly
            siticoneDataGridView1.ReadOnly = true;
            
            // Create a new MySqlCommand object with a SQL query string to select all site IDs
            MySqlCommand commandSiteID = new MySqlCommand("SELECT id_site, name FROM site", Program.dbConnectionBase.getActualConnection());

            // Execute the command and get the result set
            MySqlDataReader reader = commandSiteID.ExecuteReader();

            // Loop through the result set
            while (reader.Read())
            {
                // Format the string to add to the listBoxSiteID
                string siteInfo = $"{reader["id_site"]}, {reader["name"]}";

                // Add the formatted string to the listBoxSiteID
                listBoxSiteID.Items.Add(siteInfo);
            }

            // Close the reader
            reader.Close();
            
        }

        private void siticoneButton1_Click(object sender, EventArgs e) {
    
        // Vérifiez si les zones de texte ne sont pas nulles et non vides
        if (string.IsNullOrWhiteSpace(textBoxMTBF.Text) ||
            string.IsNullOrWhiteSpace(textBoxType.Text) ||
            string.IsNullOrWhiteSpace(textBoxName.Text) ||
            string.IsNullOrWhiteSpace(listBoxSiteID.Text) ||
            string.IsNullOrWhiteSpace(textBoxSN.Text))
        {
            MessageBox.Show("Veuillez remplir tous les champs.");
            return;
        }

        // Vérifiez si la zone de texte SN a exactement 4 caractères
        if (textBoxSN.Text.Length != 4)
        {
            MessageBox.Show("Le champ SN doit avoir exactement 4 caractères.");
            return;
        }

        // Vérifiez si la zone de texte SN contient uniquement des lettres majuscules et des chiffres
        if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxSN.Text, "^[A-Z0-9]{4}$"))
        {
            MessageBox.Show("Le champ SN ne peut contenir que des lettres majuscules et des chiffres.");
            return;
        }
        else
        {
            // Créez une nouvelle commande SQL pour insérer les données dans la base de données
            string query = "INSERT INTO material (serial_number, MTBF, name, description, type, site_id) VALUES (@sn, @mtbf, @name, @description, @type, @site_id)";
            MySqlCommand command = new MySqlCommand(query, Program.dbConnectionBase.getActualConnection());

            // Ajoutez les paramètres à la commande SQL
            command.Parameters.AddWithValue("@sn", textBoxSN.Text);
            command.Parameters.AddWithValue("@mtbf", textBoxMTBF.Text);
            command.Parameters.AddWithValue("@name", textBoxName.Text);
            command.Parameters.AddWithValue("@description", textBoxDesc.Text);
            command.Parameters.AddWithValue("@type", textBoxType.Text);
            command.Parameters.AddWithValue("@site_id", listBoxSiteID.Text.Split(',')[0]); // Prenez l'ID du site à partir du texte sélectionné dans listBoxSiteID

            // Exécutez la commande SQL
            command.ExecuteNonQuery();

             // Affichez un message de réussite
             MessageBox.Show("Matériel ajouté avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
        } 
        }
    }
}
     
        
    
    

