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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            
            string query = "SELECT password FROM eurrobraille.users WHERE username = @username";
            MySqlCommand command = new MySqlCommand(query, Program.dbConnectionBase.getActualConnection());

            
        }
    }
}
