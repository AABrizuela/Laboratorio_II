using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_06.Entidades
{
    public class Paleta
    {
        private Tempera[] colores;
        private int cantidadMaximaColores;

        #region INDEXADOR
        public Tempera this[int index]
        {
            get { return this.colores[index]; }
        }
        #endregion

        #region CONSTRUCTORES
        public Paleta():this(5)
        {
            
        }

        public Paleta(int cantidadElementos)
        {
            this.cantidadMaximaColores = cantidadElementos;
            this.colores = new Tempera[cantidadElementos];
        }
        #endregion

        #region METODOS
        private string Mostrar()
        {
            #region Comentario
            /*string tempera = "";

            foreach (string cadena in this.colores)
            {
                tempera = cadena + this.colores;
            }

            return "Cantidad maxima de elementos: " + this.cantidadMaximaColores + "\nY tiene estas temperas: \n" + tempera;*/
            #endregion
            #region Comentario2
            /*string Mensaje = string.Format("Cantidad: " + this.cantidadMaximaColores + "\n");

            
                for (int i = 0; i < cantidadMaximaColores; i++)
                {
                    if (this.colores[i] != null)
                        Mensaje += this.colores[i].ToString() + "\n";
                }
            
            
            return Mensaje;*/
            #endregion
            string oracion = "";
            string aux;

            for (int i = 0; i < this.colores.Length; i++)
            {
                if (Object.Equals(colores[i], null) == false)
                {
                    aux = colores[i];
                    oracion = oracion + aux + "|| ";
                }
                else
                {
                    break;
                }
            }

            return "Cantidad maxima de colores: " + this.cantidadMaximaColores + "|| " + oracion;
        }

        private int obtenerLugarLibre()
        {
            int posicion = -1;

            if (this != null)
            {
                for (int i = 0; i < this.colores.Length; i++)
                {
                    if (this.colores[i] == null)
                    {
                        posicion = i;
                        break;
                    }
                }
            }
            
            return posicion;
        }

        private int ObtenerIndiceTempera(Tempera tempera)
        {
            int posicion = -1;
            if(this != null)
            {
                for (int i = 0; i < this.colores.Length; i++)
                {
                    if (this.colores[i] == tempera)
                    {
                        posicion = i;
                        break;
                    }
                }
            }
            
            return posicion;
        }
        #endregion

        #region SOBRECARGAS
        public static implicit operator Paleta(int entero)
        {
            Paleta paleta = new Paleta(entero);

            return paleta;
        }

        public static explicit operator string(Paleta paleta)
        {
            return paleta.Mostrar();            
        }

        public static bool operator ==(Paleta paleta, Tempera tempera)
        {
            #region Esto anda pero no sirve para lo que hay que hacer
            /*if (!Object.Equals(paleta, null) && !Object.Equals(tempera, null))
            {
                for (int i = 0; i < paleta.colores.Length; i++)
                {
                    if (paleta.colores[i] == tempera)
                    {
                        return true;
                    }
                }
            }
            else
            {
                if (Object.Equals(paleta, null) && Object.Equals(paleta, null))
                {
                    return true;
                }
            }

            return false;*/
            #endregion

            bool retorno = false;

            for (int i = 0; i < paleta.colores.Length; i++)
            {
                if (Object.Equals(paleta.colores[i], null))
                    break;

                retorno = (paleta.colores[i] == tempera);
                if (retorno == true)
                    break;
            }

            return retorno;
        }

        public static bool operator !=(Paleta paleta, Tempera tempera)
        {
            return !(paleta == tempera);
        }

        public static int operator |(Paleta paleta, Tempera tempera)
        {
            //retorna el indice de la tempera
            int posicion = -1;
            if (!Object.Equals(paleta, null) && !Object.Equals(tempera, null))
            {
                for (int i = 0; i < paleta.colores.Length; i++)
                {
                    if (paleta.colores[i] == tempera)
                    {
                        posicion = i;
                        break;
                    }
                }
            }
            return posicion;
        }

        public static Paleta operator +(Paleta paleta, Tempera tempera)
        {
            #region Sirve pero no para esto
            /*//Compruebo nulidad
            if(paleta != null && tempera != null)
            {
                //Si no existe la tempera
                if(paleta.ObtenerIndiceTempera(tempera) == -1)
                {
                    //Si no hay espacio
                    if(paleta.obtenerLugarLibre() == -1)
                    {
                        //Agrego la tempera en el primer lugar libre
                        paleta.colores[paleta.obtenerLugarLibre()] = tempera;
                    }
                }
            }
            else //Si existe
            {
                //Sumo las cantidades
                paleta.colores[paleta.ObtenerIndiceTempera(tempera)] = paleta.colores[paleta.ObtenerIndiceTempera(tempera)] + tempera;
            }
            return paleta;*/
            #endregion
            bool aux = false;
            int posicion = -1;
            int posicionTempera = -1;
            if (Object.Equals(paleta, null) == false && Object.Equals(tempera, null) == false)
            {
                if (paleta == tempera)
                {
                    posicionTempera = paleta | tempera;
                    paleta.colores[posicionTempera] = paleta.colores[posicionTempera] + tempera;
                    aux = true;
                }

                if (aux == false)
                {
                    posicion = paleta.obtenerLugarLibre();

                    if (posicion != -1)
                    {
                        paleta.colores[posicion] = tempera;
                    }
                }
            }
            return paleta;
        }

        public static Paleta operator -(Paleta paleta, Tempera tempera)
        {
            #region Sirve pero no para esto
            /*if(paleta != null && tempera != null)
            {
                //Si existe la tempera
                if(paleta.ObtenerIndiceTempera(tempera) != -1)
                {
                    //Sumo sus cantidades con sobrecarga + en temperas
                    paleta.colores[paleta.ObtenerIndiceTempera(tempera)] = paleta.colores[paleta.ObtenerIndiceTempera(tempera)] - tempera;
                }
            }
            return paleta;*/
            #endregion
            int posicionTempera = -1;
            if (Object.Equals(paleta, null) == false && Object.Equals(tempera, null) == false)
            {
                if (paleta == tempera)
                {
                    posicionTempera = paleta | tempera;
                    paleta.colores[posicionTempera] = paleta.colores[posicionTempera] - tempera;
                }
            }
            return paleta;
        }
        #endregion        
    }
}
