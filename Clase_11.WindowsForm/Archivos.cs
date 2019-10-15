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

namespace Clase_11.WindowsForm
{
    public partial class Archivos : Form
    {
        public Archivos()
        {
            InitializeComponent();
            foreach (Environment.SpecialFolder item in Enum.GetValues(typeof (Environment.SpecialFolder)))
            {
                cmbPath.Items.Add(item);
            }

            cmbPath.SelectedIndex = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath((Environment.SpecialFolder)cmbPath.SelectedItem) + "\\" + txtArchivo.Text))
            {
                streamWriter.WriteLine(txtArchivo.Text);
            }
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            using (StreamReader streamReader = new StreamReader(Environment.GetFolderPath((Environment.SpecialFolder)cmbPath.SelectedItem) + "\\" + txtArchivo.Text)
            {
                if (streamReader != null)
                {
                    streamReader.
                }
            }
        }
    }
}
