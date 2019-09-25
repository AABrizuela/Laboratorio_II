using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.txtTexto.Text = "";            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto = this.txtTexto.Text;

            MessageBox.Show("Su mensaje fue: " + texto);
            MessageBox.Show(texto, "ATENCION", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
        }
    }
}
