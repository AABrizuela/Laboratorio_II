using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase_04.Entidades;

namespace Clase_04.WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int entero = int.Parse(this.txtTextoEntero.Text);
            string cadena = this.txtTextoCadena.Text;
            DateTime fecha = Convert.ToDateTime(this.txtTextoFecha.Text);

            Cosa cosa = new Cosa(cadena, fecha, entero);

            //MessageBox.Show("Entero: " + entero + "\nCadena: " + cadena + "\nFecha: " + fecha);
            //MessageBox.Show(cosa.Mostrar());

            lstListaCosa.Items.Add(cosa.Mostrar());
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBotonRojo_Click(object sender, EventArgs e)
        {
            lstListaCosa.BackColor = Color.Red;
            lstListaCosa.ForeColor = Color.Black;                
        }

        private void btnBotonNegro_Click(object sender, EventArgs e)
        {
            lstListaCosa.BackColor = Color.Black;
            lstListaCosa.ForeColor = Color.White;
        }

        private void btnBotonAzul_Click(object sender, EventArgs e)
        {
            lstListaCosa.BackColor = Color.Blue;
            lstListaCosa.ForeColor = Color.Black;
        }

        private void txtTextoEntero_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstListaCosa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
