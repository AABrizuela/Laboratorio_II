using System;

namespace Clase_04.Entidades
{
    public class Cosa
    {
        private int entero;
        private string cadena;
        private DateTime fecha;

        public string Mostrar()
        {
            return "Entero: " + this.entero + " - Cadena: " + this.cadena + " - Fecha: " + this.fecha;
        }

        public void EstablecerValor(int entero)
        {
            this.entero = entero;
        }

        public void EstablecerValor(string cadena)
        {
            this.cadena = cadena;
        }
        public void EstablecerValor(DateTime fecha)
        {
            this.fecha = fecha;
        }

        public Cosa()
        {
            this.entero = -1;
            this.cadena = "Sin Valor";
            this.fecha = DateTime.Now;
        }
        //Le agrego 'this()' para que haga referencia al primer constructor
        public Cosa(string cadena):this()
        {
            this.cadena = cadena;            
        }
        //Le agrego 'this(cadena)' para que haga referencia al construcor anterior que recibe una cadena como param
        public Cosa(string cadena, DateTime fecha):this(cadena)
        {            
            this.fecha = fecha;
        }
        //Le agrego 'this(cadena, fecha)' para que haga referencia al constructor
        //anterior que recibe una cadena y una fecha como parametro, que a su vez
        //va a hacer referencia al constructor que recibe una cadena y ese va
        //a hacer referencia al primer constructor
        public Cosa(string cadena, DateTime fecha, int entero):this(cadena, fecha)
        {
            this.entero = entero;
        }
    }
}
