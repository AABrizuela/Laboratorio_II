using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = "Juan";
            string nombre2 = "Marcos";
            string nombre3 = miLibreria.miClase.MostrarNombre(miLibreria.miClase.nombre);
            string mensaje;
            

            miClase.mostrarEdad();
            miClase.mostrarNombre();

            miClase.edad = 23;
            miClase.nombre = "Juan";

            miClase.mostrarEdad();
            miClase.mostrarNombre();
            miClase.compararNombres(nombre);
            miClase.compararNombres(nombre2);

            Console.WriteLine("El nombre en la libreria es: {0}", nombre3);

            Sello.mensaje = "Hola mundo";
            mensaje = Sello.Imprimir();
            Sello.Borrar();
            mensaje = Sello.Imprimir();
            Sello.mensaje = "Hola";
            Sello.color = ConsoleColor.Red;
            Sello.ImprimirEnColor();
            Console.ReadLine();

            Console.ReadKey();
        }
    }
}
