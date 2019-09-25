using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase_09.Entidades;

namespace Clase_09.WindowsForm
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            this.IsMdiContainer = true;            
        }

        private void catedraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCatedra formCatedra = new FrmCatedra();

            formCatedra.ShowDialog();

            if(formCatedra.DialogResult == DialogResult.OK)
            {
                
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
