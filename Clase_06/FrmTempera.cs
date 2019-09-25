using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase_06.Entidades;

namespace Clase_06
{
    public partial class FrmTempera : Form
    {
        private Tempera tempera;

        public Tempera MiTempera {

            get { return this.tempera; }            

        }

        public FrmTempera()
        {
            InitializeComponent();
            
            this.StartPosition = FormStartPosition.CenterScreen;
            
            //la clase Enum esta hecha para recibir los enumerados de cualquiera
            foreach (ConsoleColor color in Enum.GetValues(typeof(ConsoleColor)))
                this.cmbColor.Items.Add(color);

            this.cmbColor.SelectedItem = ConsoleColor.Magenta;
            this.cmbColor.DropDownStyle = ComboBoxStyle.DropDownList;
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string marca = this.txtMarca.Text;
            int cantidad = int.Parse(this.txtCantidad.Text);
            ConsoleColor color = (ConsoleColor) this.cmbColor.SelectedItem;

            this.tempera = new Tempera(color, marca, cantidad);                                    
            MessageBox.Show((string) tempera);
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
