using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno = new Alumno();
            Alumno alumno2 = new Alumno();
            Alumno alumno3 = new Alumno();

            alumno.nombre = "Adrian";
            alumno.apellido = "Brizuela";
            alumno.legajo = 42069;
            alumno.Estudiar(2, 4);
            alumno.CalcularFinal();

            alumno2.nombre = "Pablo";
            alumno2.apellido = "Matarazzo";
            alumno2.legajo = 12345;
            alumno2.Estudiar(6, 8);
            alumno2.CalcularFinal();

            alumno3.nombre = "Pepe";
            alumno3.apellido = "Argento";
            alumno3.legajo = 67890;
            alumno3.Estudiar(5, 9);
            alumno3.CalcularFinal();

            Console.WriteLine(alumno.Mostrar());
            Console.WriteLine(alumno2.Mostrar());
            Console.WriteLine(alumno3.Mostrar());
            
            Console.ReadKey();
        }
    }
}
