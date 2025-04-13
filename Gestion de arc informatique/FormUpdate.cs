using Npgsql;
using Siticone.Desktop.UI.WinForms.Suite;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Gestion_de_arc_informatique
{
    public partial class FormUpdate: Form
    {
        public FormUpdate(String materialID, String sn, int mtbf, String name, String desc, String type, String siteID)
        {
            InitializeComponent();

            textBoxMaterialID.Text = materialID;
            textBoxMaterialSN.Text = sn;
            textBoxMaterialMTBF.Text = mtbf.ToString();
            textBoxMaterialName.Text = name;
            textBoxMaterialDesc.Text = desc;
            textBoxMaterialType.Text = type;
            textBoxMaterialSiteID.Text = siteID;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormUpdate_Load(object sender, EventArgs e)
        {
            
            
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
           

            // confirmation
            if (MessageBox.Show(
                "Are you sure to confirm the modification ?", 
                "Question", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question) == DialogResult.Yes)

            {

                string updateMaterialQuery = @"
                        UPDATE material SET
                            serial_number = @sn,
                            mtbf = @mtbf,
                            name = @name,
                            description = @desc,
                            type = @type,
                            site_id = @siteID
                        WHERE material_id = @matID";

                using (var command = new NpgsqlCommand(updateMaterialQuery, Program.dbConnectionBase.getActualConnection()))
                {
                    command.Parameters.AddWithValue("@matID", int.Parse(this.textBoxMaterialID.Text)); // ID = int
                    command.Parameters.AddWithValue("@sn", this.textBoxMaterialSN.Text);
                    command.Parameters.AddWithValue("@mtbf", int.Parse(this.textBoxMaterialMTBF.Text)); // int
                    command.Parameters.AddWithValue("@name", this.textBoxMaterialName.Text);
                    command.Parameters.AddWithValue("@desc", this.textBoxMaterialDesc.Text);
                    command.Parameters.AddWithValue("@type", this.textBoxMaterialType.Text);
                    command.Parameters.AddWithValue("@siteID", int.Parse(this.textBoxMaterialSiteID.Text));



                    try { command.ExecuteNonQuery(); }
                    catch (Exception ex)
                    {
                        Console.WriteLine("La requête n'a pas été exécutée");
                        MessageBox.Show($"{ex.Message}");
                    }
                }

            }

            

          
            
        }
    }
}
