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
            MessageBox.Show("Contactez : Matthieu.poulard@gestion_matos.com", "Info", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void siticoneCheckBoxPassword_CheckedChanged(object sender, EventArgs e)
        {
            TextBoxPassword.PasswordChar = siticoneCheckBoxPassword.Checked ? '\0' : '*'; // if checked mask password
        }

        private void TextBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
