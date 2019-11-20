using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Anteultima.Entidades
{
    public class Empleado
    {
        #region Atributos
        public event limiteSueldoMejoradoDelegado sueldoMejorado;
        public event limiteSueldoDelegado limiteSueldo;
        private string nombre;
        private string apellido;
        private int legajo;
        private double sueldo;
        #endregion

        #region Contructores
        public Empleado(string nombre, string apellido, int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }
        #endregion

        #region Propiedades
        public string Nombre { get => this.nombre; set => this.nombre = value; }

        public string Apellido { get => this.apellido; set => this.apellido = value; }

        public int Legajo { get => this.legajo; set => this.legajo = value; }

        public double Sueldo
        {
            get => this.sueldo;

            set
            {
                if (value > 18000 && value < 30000)
                {
                    this.limiteSueldo(value, this);
                }
                else if (value > 30000)
                {
                    EmpleadoEventArgs evento = new EmpleadoEventArgs();
                    evento.SueldoAsignar = value;

                    this.sueldoMejorado(this, evento);
                }
                else
                {
                    this.sueldo = value;
                }                
            }
        }
        #endregion

        #region Sobreescritura
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendFormat("Nombre: {0}", Nombre);
            builder.AppendFormat(" - Apellido: {0}", Apellido);
            builder.AppendFormat(" - Legajo: {0}", Legajo);
            builder.AppendFormat(" - Sueldo: {0}", Sueldo);

            return builder.ToString();
        }
        #endregion
    }
}
