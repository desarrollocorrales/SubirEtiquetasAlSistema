using System;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Importador_de_Etiquetas.Entity;

namespace Importador_de_Etiquetas.GUIs
{
    public partial class FrmPrincipal : Form
    {
        private string sFilePRN;
        private string sFileImage;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            new FrmConfiguracion().ShowDialog();
        }

        private void btnBuscarPRN_Click(object sender, EventArgs e)
        {
            var dr = ofdPRN.ShowDialog();
            if (dr == DialogResult.OK)
                sFilePRN = ofdPRN.FileName;
            else
                sFilePRN = string.Empty;

            txbPRN.Text = sFilePRN;
        }

        private void btnBuscarImagen_Click(object sender, EventArgs e)
        {
            var dr = ofdImagen.ShowDialog();
            if (dr == DialogResult.OK)
                sFileImage = ofdImagen.FileName;
            else
                sFileImage = string.Empty;

            pbImagen.ImageLocation = sFileImage;
            pbImagen.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarGuardar() == true)
            {
                Guardar();
            }
        }
        private void Guardar()
        {
            try
            {
                var entityString = Properties.Settings.Default.EntityString;
                EtiquetasEntities Contexto = new EtiquetasEntities(entityString);

                var comando = new catalog_comandos_etiquetas();
                comando.etiqueta = txbNombreEtiqueta.Text;
                comando.comando = ObtenerComando();
                comando.imagen_etiqueta = ObtenerImagen();

                Contexto.catalog_comandos_etiquetas.AddObject(comando);
                Contexto.SaveChanges();

                MessageBox.Show("¡¡¡La plantilla se ha agregado con exito!!!", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MostrarException(ex);
            }
        }
        private void MostrarException(Exception ex)
        {
            var exAux = ex;
            var sb = new StringBuilder();
            while (exAux != null)
            {
                sb.AppendLine(exAux.Message);
                exAux = exAux.InnerException;
            }

            MessageBox.Show(sb.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private string ObtenerComando()
        {
            string Comando = string.Empty;
            try
            {
                StreamReader sr = new StreamReader(sFilePRN);
                Comando = sr.ReadToEnd();
                sr.Close();
            }
            catch (Exception ex)
            {
                MostrarException(ex);
            }

            return Comando;
        }
        private Byte[] ObtenerImagen()
        {
            Byte[] byteArray = null;

            try
            {
                MemoryStream ms = new MemoryStream();

                if (pbImagen.Image != null)
                {
                    pbImagen.Image.Save(ms, ImageFormat.Png);
                    byteArray = ms.ToArray();
                }

            }
            catch (Exception ex)
            {
                MostrarException(ex);
            }

            return byteArray;
        }

        private bool ValidarGuardar()
        {
            if (txbNombreEtiqueta.Text.Trim() == string.Empty)
            {
                MessageBox.Show("No se ha puesto el nombre a la plantilla...", "Validar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txbPRN.Text.Trim() == string.Empty)
            {
                MessageBox.Show("No se ha cargado el archivo PRN...", "Validar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (sFileImage.Trim() == string.Empty)
            {
                MessageBox.Show("No se ha cargado la Imagen...", "Validar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (MessageBox.Show("¿Todos los datos son correctos?", "Validar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return false;

            return true;
        }
    }
}
