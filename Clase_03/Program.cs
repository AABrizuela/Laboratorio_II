using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Objetos y Constructores";

            Persona persona = new Persona("Adrian", "Brizuela", 36084952);

            //persona.nombre = "Adrian";
            //persona.apellido = "Brizuela";
            //persona.dni = 36084952;

            Console.WriteLine(persona.Mostrar());

            Persona persona2 = new Persona("Pablo", "Guaymallen", 35630715) ;

            //persona2.nombre = "Pablo";
            //persona2.apellido = "Guaymallen";
            //persona2.dni = 35630715;

            Console.WriteLine(persona2.Mostrar());

            Console.ReadKey();
        }
    }
}
