using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Class._08.Entidades;

namespace Clase_08.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            //Capitulo c1 = "Primer Capitulo";
            //Capitulo c2 = "Me gusta la verga";
            //Capitulo c3 = "Mi primer anal";
            //Capitulo c4 = "No me arrepiento de nada";

            //Libro miLibro = new Libro("TITULO ASAS", "AUTOR: Axel Gay");

            //miLibro[0] = c1;
            //miLibro[1] = c2;
            //miLibro[2] = c3;
            //miLibro[3] = c4;

            //Console.WriteLine(string.Format("{0}{1}", miLibro[0].Titulo, miLibro[0].Paginas));
            //Console.ReadKey();

            Libro miLibro = new Libro("C# al descubierto", "Joe Mayo");

            miLibro[0] = "Fundamentos Básicos de C#";
            miLibro[1] = "Cómo comenzar con C#";
            miLibro[2] = "Cómo escribir expresiones con C#";

            miLibro[-1] = "Genero un índice erroneo";

            miLibro[5] = "Genero otro índice erroneo";





            Console.WriteLine("Libro:");

            Console.WriteLine("Titulo: {0}", miLibro.Titulo);

            Console.WriteLine("Autor: {0}", miLibro.Autor);

            Console.WriteLine("Cantidad de páginas: {0}", miLibro.CantidadPaginas);



            for (int i = 0; i < miLibro.CantidadDeCapitulos; i++)

            {

                Console.WriteLine("Capitulo {0}: {1} {2}", miLibro[i].Numero, miLibro[i].Titulo, miLibro[i].Paginas);

            }


            Console.ReadLine();
        }
    }
}
