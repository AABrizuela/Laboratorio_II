using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_09.Entidades
{
    public class Catedra
    {
        private List<Alumno> ListAlumno = new List<Alumno>();        

        #region PROPIEDADES
        public List<Alumno> GetAlumnos
        {
            get { return ListAlumno; }
        }

        public Alumno this[int index]
        {
            get { return this.ListAlumno[index]; }
        }       
        #endregion

        #region CONSTRUCTORES
        public Catedra()
        {

        }
        #endregion

        #region METODOS
        //public override string ToString()
        //{
        //    string cadena = "";

        //    foreach(Alumno auxAlumno in ListAlumno)
        //    {
        //        cadena = cadena + Alumno.Mostrar(auxAlumno);
        //    }

        //    return cadena;
        //}
        #endregion

        #region SOBRECARGAS
        public static bool operator ==(Catedra catedra, Alumno alumno)
        {
            if (!Object.Equals(catedra, null) && !Object.Equals(alumno, null))
            {              
                if(catedra.ListAlumno.Contains(alumno))
                {
                     return true;
                }                
            }

            return false;
        }

        public static bool operator !=(Catedra catedra, Alumno alumno)
        {
            return !(catedra == alumno);
        }

        public static bool operator +(Catedra catedra, Alumno alumno)
        {
            if (!Object.Equals(catedra, null) && !Object.Equals(alumno, null))
            {
                if(catedra != alumno)
                {
                    catedra.ListAlumno.Add(alumno);
                    return true;
                }
            }

            return false;
        }

        public static bool operator -(Catedra catedra, Alumno alumno)
        {
            if (!Object.Equals(catedra, null) && !Object.Equals(alumno, null))
            {
                if(catedra == alumno)
                {
                    catedra.ListAlumno.Remove(alumno);
                    return true;
                }
            }
            return false;
        }

        public static int operator |(Alumno alumno, Catedra catedra)
        {
            if(!Object.Equals(catedra, null) && !Object.Equals(alumno, null))
            {
                return catedra.ListAlumno.IndexOf(alumno);
            }

            return -1;
        }
        #endregion
    }
}