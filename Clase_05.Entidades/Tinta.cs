using System;

namespace Clase_05.Entidades
{
    //Puedo documentar de la siguiente forma para que aparezca una nota en el tooltip
    /// <summary>
    /// Esta clase servira para practicar.
    /// </summary>
    public class Tinta
    {
        private ConsoleColor _color;
        private ETipoTinta _tipo;

        #region CONSTRUCTORES
        //constructor con sobrecargas que va a tener 0, 1 y 2 parametros
        /// <summary>
        /// Constructor:
        /// color = Blue,
        /// tipo = comun.
        /// </summary>
        public Tinta()
        {
            this._color = ConsoleColor.Blue;
            this._tipo = ETipoTinta.comun;
        }

        /// <summary>
        /// Constructor:
        /// color = blue,
        /// tinta sera el valor del tipo.
        /// </summary>
        /// <param name="_tipo">El tipo a asignar</param>
        public Tinta(ETipoTinta _tipo):this()
        {
            this._tipo = _tipo;            
        }

        /// <summary>
        /// Constructor:
        /// color sera el valor del parametro color,
        /// se hereda el tipo.
        /// </summary>
        /// <param name="_tipo">El tipo a asignar</param>
        /// <param name="_color">El color a asignar</param>
        public Tinta(ETipoTinta _tipo, ConsoleColor _color):this(_tipo)
        {
            this._color = _color;
        }
        #endregion

        #region METODOS
        //Metodos
        //De instancia es sin static
        private string Mostrar()
        {
            return "Color: " + this._color + " - Tipo: " + this._tipo;
        }

        //De clase es con static
        public static string Mostrar(Tinta tinta)
        {
            //return "Color: " + tinta._color + " - Tipo: " + tinta._tipo;
            //Llamo al metodo privado desde aca para no tener que reescribir codigo
            if(!Object.Equals(tinta, null))
            {
                return tinta.Mostrar();
            }

            return "No hay nada que mostrar...";
        }
        #endregion

        #region SOBRECARGAS
        //
        public static bool operator ==(Tinta tinta1, Tinta tinta2)
        {
            if (!Object.Equals(tinta1, null) && !Object.Equals(tinta2, null))
            {
                //si los colores de tinta son iguales y los tipos de tinta son iguales retorno true
                if (tinta1._color == tinta2._color && tinta1._tipo == tinta2._tipo)
                {
                    return true;
                }
            }
            else
            {
                if(Object.Equals(tinta1, null) && Object.Equals(tinta2, null))
                {
                    return true;
                }
                //si ambos son null --> true
                //si uno es null y el otro no -->false
            }
            //cualquier otra combinacion hace que retorne false porque no me coinciden las instancias
            return false;
        }

        public static bool operator !=(Tinta tinta1, Tinta tinta2)
        {
            /*if(tinta1._color != tinta2._color && tinta1._tipo != tinta2._tipo)
            {
                return true;
            }

            return false;*/

            return !(tinta1 == tinta2);
        }

        public static bool operator ==(Tinta tinta, ConsoleColor color)
        {
            if(tinta._color == color)
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Tinta tinta, ConsoleColor color)
        {
            return !(tinta == color);
        }

        public static explicit operator string(Tinta tinta)
        {
            return tinta.Mostrar();
        }            
        #endregion
    }
}
