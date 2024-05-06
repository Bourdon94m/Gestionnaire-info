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
            if (DateTimePickerInterv.Value == null ||
                ComboBoxStaff.SelectedItem == null ||
                ComboBoxMaterial.SelectedItem == null ||
                string.IsNullOrEmpty(TextBoxCommentary.Text) ||
                !CheckBoxStatus.Checked)
            {
                // Afficher un message d'erreur ou prendre une autre action appropriée
                MessageBox.Show("Missing Fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Tous les champs sont remplis, procéder au traitement
            }
        }
    }
}
