using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace Clase_11.WindowsForm
{
    public partial class Archivos : Form
    {
        public Archivos()
        {
            InitializeComponent();
            foreach (Environment.SpecialFolder item in Enum.GetValues(typeof(Environment.SpecialFolder)))
            {
                cmbPath.Items.Add(item);
            }

            cmbPath.SelectedIndex = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath((Environment.SpecialFolder)cmbPath.SelectedItem) + "\\" + txtArchivo.Text, true))
                {
                    streamWriter.WriteLine(txtBuffer.Text);
                }
                MessageBox.Show("Se ha guardado el archvivo en: " + Environment.GetFolderPath((Environment.SpecialFolder)cmbPath.SelectedItem) + "\\" + txtArchivo.Text);
            }
            catch (FileNotFoundException exception)
            {
                SystemSounds.Exclamation.Play();
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (DirectoryNotFoundException exception)
            {
                SystemSounds.Exclamation.Play();
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception exception)
            {
                SystemSounds.Exclamation.Play();
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader streamReader = new StreamReader(Environment.GetFolderPath((Environment.SpecialFolder)cmbPath.SelectedItem) + "\\" + txtArchivo.Text, true))
                {
                    if (streamReader != null)
                    {
                        txtBuffer.Text = streamReader.ReadToEnd();
                    }
                }
            }
            catch (FileNotFoundException exception)
            {
                SystemSounds.Exclamation.Play();
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (DirectoryNotFoundException exception)
            {
                SystemSounds.Exclamation.Play();
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception exception)
            {
                SystemSounds.Exclamation.Play();
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nos vemos en el corso");
            this.Close();
        }
    }
}
