using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_06.Entidades
{
    public class Tempera
    {
        private ConsoleColor color;
        private string marca;
        private int cantidad;

        #region CONSTRUCTOR
        public Tempera()
        {
            this.color = ConsoleColor.Blue;
            this.marca = "Sin marca";
            this.cantidad = 0;
        }

        public Tempera(ConsoleColor color):this()
        {
            this.color = color;
        }

        public Tempera(ConsoleColor color, string marca):this(color)
        {
            this.marca = marca;
        }

        public Tempera(ConsoleColor color, string marca, int cantidad):this(color, marca)
        {
            this.cantidad = cantidad;
        }
        #endregion

        #region METODOS
        private string Mostrar()
        {
            return "Marca: " + this.marca + " - Color: " + this.color + " - Cantidad: " + this.cantidad;
        }        
        #endregion

        #region SOBRECARGAS
        public static implicit operator string(Tempera tempera)
        {
            return tempera.Mostrar();
        }

        public static Tempera operator +(Tempera tempera, int cantidad)
        {
            tempera.cantidad += cantidad;

            return tempera;
        }

        public static Tempera operator -(Tempera tempera, int cantidad)
        {
            tempera.cantidad = tempera.cantidad - cantidad;
            return tempera;
        }

        public static Tempera operator +(Tempera tempera1, Tempera tempera2)
        {
            if (tempera1 == tempera2)
            {
                tempera1 += tempera2.cantidad;
            }

            return tempera1;
        }

        public static Tempera operator -(Tempera tempera1, Tempera tempera2)
        {
            if(tempera1 == tempera2)
            {
                tempera1.cantidad = tempera1.cantidad - tempera2.cantidad;
            }

            return tempera1;
        }
        public static bool operator ==(Tempera tempera1, Tempera tempera2)
        {
            if(!Object.Equals(tempera1, null) && !Object.Equals(tempera2, null))
            {
                if(tempera1.marca == tempera2.marca && tempera1.color == tempera2.color)
                {
                    return true;
                }                
            }
            /*else
            {
                if (Object.Equals(tempera1, null) && Object.Equals(tempera2, null))
                {
                    return true;
                }             
            }*/

            return false;
        }

        public static bool operator !=(Tempera tempera1, Tempera tempera2)
        {
            return !(tempera1 == tempera2);
        }
        #endregion
    }
}
