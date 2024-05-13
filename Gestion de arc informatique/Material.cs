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
    }
}
