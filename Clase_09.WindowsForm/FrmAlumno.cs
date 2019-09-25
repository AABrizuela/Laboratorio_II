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
    public partial class FrmAlumno : Form
    {
        private Alumno alumno;

        public FrmAlumno()
        {
            InitializeComponent();
            this.cmbTipoDeExamen.Items.Add(ETipoExamen.Primero);
            this.cmbTipoDeExamen.Items.Add(ETipoExamen.Segundo);
            this.cmbTipoDeExamen.Items.Add(ETipoExamen.Final);
        }

        public FrmAlumno(Alumno alumno) : this()
        {
            this.txtNombre.Text = alumno.GetNombre;
            this.txtApellido.Text = alumno.GetApellido;
            this.txtLegajo.Text = alumno.GetLegajo.ToString();
            this.cmbTipoDeExamen.Text = alumno.GetExamen.ToString();
            this.txtLegajo.Enabled = false;
        }

        public Alumno GetAlumno { get { return this.alumno; } }

        protected virtual void btnAceptar_Click(object sender, EventArgs e)
        {
            if(int.TryParse(this.txtLegajo.Text, out int auxLegajo))
            {
                alumno = new Alumno(this.txtNombre.Text, this.txtApellido.Text, int.Parse(this.txtLegajo.Text), (ETipoExamen)this.cmbTipoDeExamen.SelectedItem);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Datos invalidos.");
                this.DialogResult = DialogResult.Cancel;
            }            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
