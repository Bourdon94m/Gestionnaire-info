using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_arc_informatique
{



    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        bool menuExpand = false;
        private void sideBarTimer_Tick(object sender, EventArgs e)
        {
            
            
        }

        private void ButtonCreateInterv_Click(object sender, EventArgs e)
        {

            // PART TEST COMBOBOX DATA
            insertToComboBox();

            if (DateTimePickerInterv.Value == null ||
                ComboBoxStaff.SelectedItem == null ||
                ComboBoxMaterial.SelectedItem == null ||
                string.IsNullOrEmpty(TextBoxCommentary.Text))
            {
                // Afficher un message d'erreur ou prendre une autre action appropriée
                MessageBox.Show("Missing Fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                // console test 
                Console.WriteLine("Date: " + DateTimePickerInterv.Value.ToShortDateString());
                Console.WriteLine("Staff: " + ComboBoxStaff.Text);
                Console.WriteLine("Material: " + ComboBoxMaterial.Text);
                Console.WriteLine("Status: " + CheckBoxStatus.Checked);
                Console.WriteLine("Commentary: " + TextBoxCommentary.Text);

            }
            else
            {
                Program.dbConnectionBase.executeQuery(DateTimePickerInterv.Value.ToShortDateString(), ComboBoxStaff.GetItemText, ComboBoxMaterial.GetItemText, )
                

            }

        }


        // Get all Staff and their first name from DB
        public void insertToComboBox()
        {
            // Insert les data dans les combobox
            DataSet dataSet_staff = new DataSet(); // initialise le dataset du staff
            DataSet dataSet_material = new DataSet(); // initialise le dataset du material



            string query_staff = "SELECT id_staff, first_name FROM gestion_matos.staff";
            string query_material = "SELECT name FROM gestion_matos.material";

            // Using du staff
            using (MySqlDataAdapter staff_adapter = new MySqlDataAdapter(query_staff,Program.dbConnectionBase.getActualConnection()))
            {
                try
                {
                    // Essaye de se connecter a la db
                    Program.dbConnectionBase.getActualConnection();
                    // Remplissez le DataSet avec les résultats de la requête
                    staff_adapter.Fill(dataSet_staff);

                    DataTable dataTable = dataSet_staff.Tables[0];
                    foreach (DataRow row in dataTable.Rows)
                    {
                        object columnValue = $"[{row["id_staff"]}] {row["first_name"]}";
                        ComboBoxStaff.Items.Add(columnValue);
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error" + ex.Message);
                }


                using (MySqlDataAdapter material_adapter = new MySqlDataAdapter(query_material, Program.dbConnectionBase.getActualConnection()))
                {
                    try
                    {
                        // Essaye de se connecter a la db
                        Program.dbConnectionBase.getActualConnection();
                        // Remplissez le DataSet avec les résultats de la requête
                        material_adapter.Fill(dataSet_material);

                        DataTable dataTable = dataSet_material.Tables[0];
                        foreach (DataRow row in dataTable.Rows)
                        {
                            object columnValue = $"{row["name"]}";
                            ComboBoxMaterial.Items.Add(columnValue);
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error" + ex.Message);
                    }
                }
            }
        }

        
    }
}
