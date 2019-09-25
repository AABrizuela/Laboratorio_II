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
    public partial class FrmCatedra : Form
    {
        private Catedra catedra = new Catedra();
        //public List<Alumno> listaAlumnos;
        public List<AlumnoCalificado> listaAlumnosCalificados = new List<AlumnoCalificado>();

        public FrmCatedra()
        {
            InitializeComponent();
            this.cmbSort.Items.Add(ETipoOrdenamiento.ApellidoAscendente);
            this.cmbSort.Items.Add(ETipoOrdenamiento.ApellidoDescendente);
            this.cmbSort.Items.Add(ETipoOrdenamiento.LegajoAscendente);
            this.cmbSort.Items.Add(ETipoOrdenamiento.LegajoDescendente);
            this.cmbSort.SelectedItem = ETipoOrdenamiento.ApellidoAscendente;
        }

        #region EVENTOS
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAlumno formAlumno = new FrmAlumno();
            Alumno alumno;
            bool existeLegajo = false;

            formAlumno.ShowDialog();

            if (formAlumno.DialogResult == DialogResult.OK)
            {
                alumno = formAlumno.GetAlumno;
                
                foreach(Alumno auxiliar in catedra.GetAlumnos)
                {
                    if(auxiliar.GetLegajo == alumno.GetLegajo)
                    {
                        existeLegajo = true;
                        break;
                    }
                }

                if(existeLegajo == false)
                {
                    catedra.GetAlumnos.Add(alumno);
                    printSortedList();
                }
                else
                {
                    MessageBox.Show("El legajo no es valido");
                }                
            }
        }

        private void btnCalificar_Click(object sender, EventArgs e)
        {            
            AlumnoCalificado alumnoCalificado;
            Alumno auxAlumno = new Alumno(this.catedra.GetAlumnos[this.lstAlumno.SelectedIndex].GetNombre, 
                                          this.catedra.GetAlumnos[this.lstAlumno.SelectedIndex].GetApellido, 
                                          this.catedra.GetAlumnos[this.lstAlumno.SelectedIndex].GetLegajo,
                                          this.catedra.GetAlumnos[this.lstAlumno.SelectedIndex].GetExamen);
            FrmAlumnoCalificado formAlumnoCalificado = new FrmAlumnoCalificado(auxAlumno);

            formAlumnoCalificado.ShowDialog();
            
            if(formAlumnoCalificado.DialogResult == DialogResult.OK)
            {
                alumnoCalificado = formAlumnoCalificado.GetAlumnoCalificado;

                this.listaAlumnosCalificados.Add(formAlumnoCalificado.GetAlumnoCalificado);
                this.catedra.GetAlumnos.Remove(catedra.GetAlumnos[this.lstAlumno.SelectedIndex]);
                printList();

                foreach(AlumnoCalificado item in this.listaAlumnosCalificados)
                {
                    this.lstAlumnosCalificados.Items.Add(item);
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FrmAlumno formAlumno = new FrmAlumno(catedra.GetAlumnos[this.lstAlumno.SelectedIndex]);
            formAlumno.ShowDialog();            
            
            if(formAlumno.DialogResult == DialogResult.OK)
            {
                this.catedra.GetAlumnos[this.lstAlumno.SelectedIndex] = formAlumno.GetAlumno;
                printList();
            }
        }

        private void cmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            printSortedList();
        }       
        #endregion

        #region METODOS
        private void printSortedList()
        {
            switch(this.cmbSort.SelectedItem)
            {
                case ETipoOrdenamiento.ApellidoAscendente:
                    catedra.GetAlumnos.Sort(Alumno.OrdenarPorApellidoAsc);
                    printList();
                    break;

                case ETipoOrdenamiento.ApellidoDescendente:
                    catedra.GetAlumnos.Sort(Alumno.OrdenarPorApellidoDesc);
                    printList();
                    break;

                case ETipoOrdenamiento.LegajoAscendente:
                    catedra.GetAlumnos.Sort(Alumno.OrdenarPorLegajoAsc);
                    printList();
                    break;

                case ETipoOrdenamiento.LegajoDescendente:
                    catedra.GetAlumnos.Sort(Alumno.OrdenarPorLegajoDesc);
                    printList();
                    break;
            }
        }

        public void printList()
        {
            this.lstAlumno.Items.Clear();
            foreach (Alumno auxiliar in catedra.GetAlumnos)
            {
                this.lstAlumno.Items.Add(auxiliar);
            }
        }
        #endregion        
    }
}
