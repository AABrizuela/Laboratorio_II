using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02
{
    public class miClase
    {
        //Para poder acceder a los atributos de la clase desde, por ejemplo, el main
        //Tengo que poner los identificadores public y static a los "campos" de la clase
        public static int edad;
        public static string nombre;

        //Metodos
        //Al igual que los atributos, tienen que ser "public" y "static"
        //Para poder ser accedidos desde el main o lo donde sea
        public static void mostrarEdad()
        {
            Console.WriteLine("Edad {0}", miClase.edad);
            Console.ReadKey();
        }

        public static void mostrarNombre()
        {
            Console.WriteLine("Nombre {0}", miClase.nombre);
            Console.ReadKey();
        }

        public static bool compararNombres(string nombre)
        {
            //if(string.Compare(nombre, miClase.nombre))
            if(nombre == miClase.nombre)
            {
                Console.WriteLine("Los nombres son iguales");
                return true;
            }else
            {
                Console.WriteLine("Los nombres son distintos");
                return false;
            }
        }
    }
}