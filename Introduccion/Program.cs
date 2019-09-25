using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_01.Introduccion
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad = 12;
            int edadUsuario;
            string nombre = "Adrian";
            string apellido = "Brizuela";
            string nombreUsuario;
            string apellidoUsuario;

            Console.Title = "Ejercicio de Bienvenida";
            //Console.ForegroundColor = ConsoleColor.Magenta;
            //System.Console.WriteLine("asdfqwer");//printf("asdfqwer\n");
            Console.WriteLine("Hola Mundo C#");//printf("qwerasdf");
            
            Console.WriteLine("Mi nombre es {0} y mi apellido {1}", nombre, apellido);

            Console.WriteLine("Como es tu nombre?");
            nombreUsuario = Console.ReadLine();
            Console.WriteLine("Y tu apellido?");
            apellidoUsuario = Console.ReadLine();
            Console.WriteLine("Tu nombre es {0} {1}\n", nombreUsuario, apellidoUsuario);

            Console.Write("Ingresa tu edad: ");
            edadUsuario = int.Parse(Console.ReadLine());
            Console.WriteLine("Tenes {0}", edadUsuario);

            Console.ReadLine();
        }
    }
}
