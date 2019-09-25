using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_04.Entidades;

namespace Clase_04.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Cosa cosa = new Cosa();
            int entero = 5;
            string cadena = "Jaja todavia no entiendo el chiste de la fecha equis de";
            DateTime fecha = new DateTime(2018,12,9);

            Cosa cosa2 = new Cosa(cadena);
            Cosa cosa3 = new Cosa(cadena, fecha);
            Cosa cosa4 = new Cosa(cadena, fecha, entero);
            
            Console.WriteLine(cosa.Mostrar());
            Console.WriteLine(cosa2.Mostrar());
            Console.WriteLine(cosa3.Mostrar());
            Console.WriteLine(cosa4.Mostrar());
            
            Console.ReadKey();
        }
    }
}
