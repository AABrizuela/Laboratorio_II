using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_05.Entidades
{
    public class Pluma
    {
        private string _marca;
        private Tinta _tinta;
        private int _cantidad;

        #region CONSTRUCTORES
        public Pluma()
        {
            this._marca = "Sin marca";
            this._tinta = null;
            this._cantidad = 0;
        }

        public Pluma(string marca):this()
        {
            this._marca = marca;
        }

        public Pluma(string marca, Tinta tinta):this(marca)
        {
            this._tinta = tinta;
        }

        public Pluma(string marca, Tinta tinta, int cantidad):this(marca, tinta)
        {
            this._cantidad = cantidad;
        }
        #endregion

        #region METODOS
        private string Mostrar()
        {
            return "Marca: " + this._marca + " - Tipo: " + Tinta.Mostrar(this._tinta) + " - Cantidad: " + this._cantidad;
        }
        #endregion

        #region SOBRECARGA
        public static implicit operator string(Pluma pluma)
        {
            return pluma.Mostrar();
        }

        public static bool operator ==(Pluma pluma, Tinta tinta)
        {
            /*if(pluma._tinta == tinta)
            {
                return true;
            }

            return false;*/

            //Puedo reusar la sobrecarga anterior que esta en la clase Tinta
            return pluma._tinta == tinta;
        }

        public static bool operator !=(Pluma pluma, Tinta tinta)
        {
            return !(pluma._tinta == tinta);
        }

        public static Pluma operator +(Pluma pluma, Tinta tinta)
        {
            if(pluma._tinta == tinta && pluma._cantidad < 100)
            {
                while(pluma._cantidad < 100)
                {
                    pluma._cantidad++;
                }
                return pluma;
            }

            return pluma;
        }
        #endregion
    }
}
