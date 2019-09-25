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
    public partial class FrmAlumnoCalificado : FrmAlumno
    {
        private AlumnoCalificado alumnoCalificado;        

        public FrmAlumnoCalificado(Alumno alumno)
        {
            InitializeComponent();
            this.txtApellido.Text = alumno.GetApellido;
            this.txtNombre.Text = alumno.GetNombre;
            this.txtLegajo.Text = alumno.GetLegajo.ToString();
            this.cmbTipoDeExamen.SelectedItem = alumno.GetExamen;
            this.txtApellido.Enabled = false;
            this.txtNombre.Enabled = false;
            this.txtLegajo.Enabled = false;
            this.cmbTipoDeExamen.Enabled = false;
        }

        public AlumnoCalificado GetAlumnoCalificado { get { return this.alumnoCalificado; } }

        protected override void btnAceptar_Click(object sender, EventArgs e)
        {
            alumnoCalificado = new AlumnoCalificado(this.txtNombre.Text, 
                                                    this.txtApellido.Text, 
                                                    Convert.ToInt32(this.txtLegajo.Text), 
                                                    (ETipoExamen)this.cmbTipoDeExamen.SelectedItem, 
                                                    Convert.ToDouble(this.txtNota.Text));
            this.DialogResult = DialogResult.OK;            
        }
    }
}
