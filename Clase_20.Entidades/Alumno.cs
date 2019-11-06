using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_20.Entidades
{
    public class Alumno : Persona
    {
        #region Atributos
        public int nota;
        #endregion

        #region Constructores
        public Alumno()
        {

        }

        public Alumno(int nota, string nombre, string apellido, int edad) : base(nombre, apellido, edad)
        {
            this.nota = nota;
        }
        #endregion
    }
}
