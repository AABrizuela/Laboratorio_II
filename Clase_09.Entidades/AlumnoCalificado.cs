using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_09.Entidades;

namespace Clase_09.Entidades
{
    public partial class AlumnoCalificado : Alumno
    {
        protected double nota;        

        #region PROPIEDADES
        public double Nota
        {
            get { return this.nota; }
        }       
        #endregion

        #region CONSTRUCTOR
        public AlumnoCalificado(string nombre, string apellido, int legajo, ETipoExamen examen, double nota) 
            : base(nombre, apellido, legajo, examen)
        {
            this.nota = nota;
        }

        public AlumnoCalificado(Alumno alumno, double nota) 
            : this(alumno.GetNombre, alumno.GetApellido, alumno.GetLegajo, alumno.GetExamen, nota)
        {
            
        }        
        #endregion

        #region METODOS
        public string Mostrar()
        {
            return base.ToString() + " - Nota: " + this.nota;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
        #endregion
    }
}
