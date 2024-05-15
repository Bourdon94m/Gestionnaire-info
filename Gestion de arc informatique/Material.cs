using System;
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
            
            
            
        }
    }
}
