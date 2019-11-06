using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_20.Entidades
{
    public class Empleado : Persona
    {
        #region Atributos
        public int legajo;
        public int sueldo;
        #endregion

        #region Constructores
        public Empleado()
        {

        }        

        public Empleado(int legajo, int sueldo, string nombre, string apellido, int edad) : base(nombre, apellido, edad)
        {
            this.legajo = legajo;
            this.sueldo = sueldo;
        }
        #endregion
    }
}
