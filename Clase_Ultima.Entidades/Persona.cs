using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Ultima.Entidades
{
    public class Persona
    {
        #region Atributos
        protected string nombre;
        protected string apellido;
        protected int dni;
        #endregion

        #region Propiedades
        public string Nombre { get => this.nombre; set => this.nombre = value; }

        public string Apellido { get => this.apellido; set => this.apellido = value; }

        public int DNI { get => this.dni; set => this.dni = value; }
        #endregion

        #region Constructores
        public Persona(string nombre, string apellido, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }
        #endregion

        #region Metodos
        public string ObtenerInfo()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendFormat("Nombre: {0}\n", this.nombre);
            builder.AppendFormat("Apellido: {0}\n", this.apellido);
            builder.AppendFormat("DNI: {0}\n", this.dni);

            return builder.ToString();
        }
        #endregion

        
    }
}
