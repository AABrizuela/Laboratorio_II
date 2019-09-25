using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02
{
    class Sello
    {
        public static string mensaje;
        public static ConsoleColor color;

        public static string Imprimir()
        {
            Sello.ArmarFormatoMensaje();
            Console.WriteLine("{0}", Sello.mensaje);

            return Sello.mensaje;
        }

        public static void Borrar()
        {
            Sello.mensaje = "";
        }

        public static void ImprimirEnColor()
        {
            Console.ForegroundColor = Sello.color;
            Sello.mensaje = Sello.ArmarFormatoMensaje();
            Console.WriteLine("{0}", Sello.mensaje);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        private static string ArmarFormatoMensaje()
        {
            int strlen = Sello.mensaje.Length;
            int i;
            string techo = string.Empty;

            for(i = 0; i < (strlen+2); i++)
            {
                techo += "*";
            }

            return techo + "\n*" + Sello.mensaje + "*\n" + techo;
        }
    }
}
