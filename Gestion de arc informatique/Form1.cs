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
        
            Program.dbConnectionBase.isValidAccount(TextBoxUsername.Text, TextBoxPassword.Text);
            

            
        }

        private void labelForgotPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contactez : Matthieu.poulard@ceciaa.com", "Info", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
