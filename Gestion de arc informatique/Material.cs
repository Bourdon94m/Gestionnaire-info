using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Npgsql;

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
            // Charger les données dans le DataGridView
            using (var command = new NpgsqlCommand("SELECT * FROM material", Program.dbConnectionBase.getActualConnection()))
            {
                using (var adapter = new NpgsqlDataAdapter(command))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    foreach (DataRow row in table.Rows)
                    {
                        siticoneDataGridView1.Rows.Add(row.ItemArray);
                    }
                }
            }

            siticoneDataGridView1.ReadOnly = true;

            // Charger les sites dans la ListBox
            using (var commandSiteID = new NpgsqlCommand("SELECT id_site, name FROM site", Program.dbConnectionBase.getActualConnection()))
            {
                using (var reader = commandSiteID.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string siteInfo = $"{reader["id_site"]}, {reader["name"]}";
                        listBoxSiteID.Items.Add(siteInfo);
                    }
                }
            }

            
        }

        
        private void CreateIntervention(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxType.Text) ||
                string.IsNullOrWhiteSpace(textBoxName.Text) ||
                string.IsNullOrWhiteSpace(listBoxSiteID.Text) ||
                string.IsNullOrWhiteSpace(textBoxSN.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }

            if (textBoxSN.Text.Length != 6)
            {
                MessageBox.Show("Le champ SN doit avoir exactement 6 caractères.");
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxSN.Text, "^[A-Z0-9]{6}$"))
            {
                MessageBox.Show("Le champ SN ne peut contenir que des lettres majuscules et des chiffres.");
                return;
            }
            else
            {
                string query = "INSERT INTO material (serial_number, MTBF, name, description, type, site_id) VALUES (@sn, @mtbf, @name, @description, @type, @site_id)";

                using (var command = new NpgsqlCommand(query, Program.dbConnectionBase.getActualConnection()))
                {
                    command.Parameters.AddWithValue("@sn", textBoxSN.Text);
                    command.Parameters.AddWithValue("@mtbf", NumericUpDownMTBF.Value);
                    command.Parameters.AddWithValue("@name", textBoxName.Text);
                    command.Parameters.AddWithValue("@description", textBoxDesc.Text);
                    command.Parameters.AddWithValue("@type", textBoxType.Text);
                    command.Parameters.AddWithValue("@site_id", int.Parse(listBoxSiteID.Text.Split(',')[0]));

                    command.ExecuteNonQuery();
                }

                timer1.Start();
                MessageBox.Show("Matériel ajouté avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Clear all fields
                DeleteAllFieldsAfterSubmit();
                timer1.Stop();
            }
        }

        private void DeleteAllFieldsAfterSubmit()
        {
            textBoxSN.Text = string.Empty;
            textBoxName.Text = string.Empty;
            textBoxDesc.Text = string.Empty;
            textBoxType.Text = string.Empty;
            listBoxSiteID.Text = string.Empty;
            NumericUpDownMTBF.Value = 0;
        }

        private void RefreshDataGridView()
        {
            using (var command = new NpgsqlCommand("SELECT * FROM material", Program.dbConnectionBase.getActualConnection()))
            {
                using (var adapter = new NpgsqlDataAdapter(command))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    siticoneDataGridView1.Rows.Clear();
                    siticoneDataGridView1.AutoGenerateColumns = false;

                    foreach (DataRow row in table.Rows)
                    {
                        siticoneDataGridView1.Rows.Add(row.ItemArray);
                    }
                }
            }
            timer1.Stop();
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            RefreshDataGridView();
        }

        private void siticoneDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}