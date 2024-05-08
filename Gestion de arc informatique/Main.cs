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
            getStaffFromDB();

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
                Program.dbConnectionBase.executeQuery(DateTimePickerInterv.Value.ToShortDateString(), ComboBoxStaff.SelectedValue.ToString(), )
                

            }

        }


        // Get all Staff and their first name from DB
        public void getStaffFromDB()
        {
            // Insert les data dans les combobox
            DataSet dataSet = new DataSet(); // initialise le dataset

            using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT id_staff, first_name FROM gestion_matos.staff", Program.dbConnectionBase.getActualConnection()))
            {
                try
                {
                    // Essaye de se connecter a la db
                    Program.dbConnectionBase.getActualConnection();
                    // Remplissez le DataSet avec les résultats de la requête
                    adapter.Fill(dataSet);

                    DataTable dataTable = dataSet.Tables[0];
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
            }
        }

        
    }
}
