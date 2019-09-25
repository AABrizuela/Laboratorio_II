using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_09.Entidades
{
    public class Alumno
    {
        protected string apellido;
        protected ETipoExamen examen;
        protected int legajo;
        protected string nombre;

        #region PROPIEDADES
        public string GetApellido
        {
            get { return this.apellido; }
        }

        public ETipoExamen GetExamen
        {
            get { return this.examen; }
        }

        public int GetLegajo
        {
            get { return this.legajo; }
        }

        public string GetNombre
        {
            get { return this.nombre; }
        }
        #endregion

        #region CONSTRUCTORES
        public Alumno(string nombre, string apellido, int legajo, ETipoExamen examen)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
            this.examen = examen;
        }
        #endregion

        #region METODOS
        public static string Mostrar(Alumno alumno)
        {
            return "Nombre: " + alumno.nombre + " - Apellido: " + alumno.apellido + " - Legajo: " + alumno.legajo + " - Examen: " + alumno.examen;
        }

        public override string ToString()
        {
            return Alumno.Mostrar(this);
        }

        public static int OrdenarPorApellidoAsc(Alumno alumno, Alumno alumno2)
        {
            return string.Compare(alumno.apellido, alumno2.apellido);            
        }

        public static int OrdenarPorApellidoDesc(Alumno alumno, Alumno alumno2)
        {
            return -1 * OrdenarPorApellidoAsc(alumno, alumno2);
        }

        public static int OrdenarPorLegajoAsc(Alumno alumno, Alumno alumno2)
        {
            return string.Compare(alumno.legajo.ToString(), alumno2.legajo.ToString());
        }

        public static int OrdenarPorLegajoDesc(Alumno alumno, Alumno alumno2)
        {
            return -1 * OrdenarPorLegajoAsc(alumno, alumno2);
        }
        #endregion

        #region SOBRECARGA DE OPERADORES
        public static bool operator ==(Alumno alumno, Alumno alumno2)
        {
            bool retorno = false;

            if(Object.Equals(alumno, null) && Object.Equals(alumno2, null))
            {
                retorno = true;
            }
            else
            {
                if(!Object.Equals(alumno, null) && !Object.Equals(alumno2, null))
                {
                    if(alumno.legajo == alumno2.legajo)
                    {
                        retorno = true;
                    }
                }
            }

            return retorno;
        }

        public static bool operator !=(Alumno alumno, Alumno alumno2)
        {
            return !(alumno == alumno);
        }
        #endregion
    }
}
