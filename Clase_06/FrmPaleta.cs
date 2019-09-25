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
    public partial class FrmPaleta : Form
    {
        Paleta miPaleta = 5;

        public FrmPaleta()
        {
            InitializeComponent();

            //Creo el mdi container para que no se me pierda el form
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
            this.gbxPaleta.Visible = false;
            
        }

        private void crearPaletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.miPaleta = 5;                        
            this.crearPaletaToolStripMenuItem.Enabled = false;
            this.gbxPaleta.Visible = true;
        }

        private void agregarTemperasToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            FrmTempera frmTempera = new FrmTempera(); //formulario de tempera
                
            frmTempera.ShowDialog();
            //this.miPaleta -= frmTempera.MiTempera;

            //solo agregar si se presiona el boton aceptar
            if (frmTempera.DialogResult == DialogResult.OK)
            {
                this.miPaleta = this.miPaleta + frmTempera.MiTempera;
                this.lstPaleta.Items.Clear();

                for (int i = 0; i < 5; i++)
                {
                    if (this.miPaleta[i] != null)
                    {
                        this.lstPaleta.Items.Add(this.miPaleta[i].ToString());
                    }
                }
            }
            
        }

        private void gbxPaleta_Enter(object sender, EventArgs e)
        {

        }

        private void lstPaleta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            FrmTempera frmTempera = new FrmTempera();
            frmTempera.ShowDialog();

            if(frmTempera.DialogResult == DialogResult.OK)
            {
                this.miPaleta = this.miPaleta + frmTempera.MiTempera;
                this.lstPaleta.Items.Clear();
                for(int i = 0; i < 5; i++)
                {
                    if (Object.Equals(miPaleta[i], null) == false)
                    {
                        this.lstPaleta.Items.Add((string)miPaleta[i]);
                    }
                }
            }
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            FrmTempera frmTempera = new FrmTempera();
            frmTempera.ShowDialog();

            if(frmTempera.DialogResult == DialogResult.OK)
            {
                this.miPaleta = this.miPaleta - frmTempera.MiTempera;
                this.lstPaleta.Items.Clear();

                for (int i = 0; i < 5; i++)
                {
                    if (Object.Equals(miPaleta[i], null) == false)
                    {
                        this.lstPaleta.Items.Add((string)miPaleta[i]);
                    }
                }
            }
        }
    }
}
