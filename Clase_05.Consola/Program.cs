using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_05.Entidades;

namespace Clase_05.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Tinta tinta = new Tinta();
            Pluma pluma = new Pluma();

            string tintaB = (string)tinta;
            tintaB = pluma;

            pluma =  pluma + tinta;
                                    
            Console.WriteLine(Tinta.Mostrar(tinta)); 

            Console.ReadKey();
        }
    }
}
