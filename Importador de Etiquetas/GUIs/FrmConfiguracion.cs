using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Importador_de_Etiquetas.DAL;

namespace Importador_de_Etiquetas.GUIs
{
    public partial class FrmConfiguracion : Form
    {
        public FrmConfiguracion()
        {
            InitializeComponent();
        }

        private void FrmConfiguracion_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private void CargarDatos()
        {
            var Config = Properties.Settings.Default;
            txbServer.Text = Config.Server;
            txbUser.Text = Config.User;
            txbPassword.Text = Config.Pass;
            txbPort.Text = Config.Port;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            CargarBases();
        }
        private void CargarBases()
        {
            GuardarDatos(false);
            MySQL mysql = new MySQL();
            List<string> lstBasesDeDatos = mysql.ObtenerBasesDeDatos();
            if (lstBasesDeDatos.Count != 0)
            {
                cmbDatabase.DataSource = lstBasesDeDatos;
                cmbDatabase.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Error al cargar las bases de datos, por favor verifique los parametros de conexión...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbDatabase.DataSource = null;
            }
        }
        private void GuardarDatos(bool Todos)
        {
            var Config = Properties.Settings.Default;
            Config.Server = txbServer.Text;
            Config.User = txbUser.Text;
            Config.Pass = txbPassword.Text;
            Config.Port = txbPort.Text;

            if (Todos == true)
            {
                Config.DataBase = Convert.ToString(cmbDatabase.SelectedItem);
                Config.EntityString = ObtenerEntityString();
            }

            Config.Save();
        }
        private string ObtenerEntityString()
        {
            string entityStringPlantilla =
                                    @"metadata=res://*/Entity.ModeloEtiquetas.csdl|
                                               res://*/Entity.ModeloEtiquetas.ssdl|
                                               res://*/Entity.ModeloEtiquetas.msl;
                                      provider=MySql.Data.MySqlClient;
                    provider connection string='server={server};
                                               user id={user};
                                              password={pass};
                                                  port={port};
                                              database={db}'";
            string entityString;
            entityString = entityStringPlantilla.Replace("{server}", txbServer.Text);
            entityString = entityString.Replace("{user}", txbUser.Text);
            entityString = entityString.Replace("{pass}", txbPassword.Text);
            entityString = entityString.Replace("{port}", txbPort.Text);
            entityString = entityString.Replace("{db}", Convert.ToString(cmbDatabase.SelectedItem));

            return entityString;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarDatos(true);
            MessageBox.Show("¡¡Los datos se guardaron con exito!!", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void txbPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
