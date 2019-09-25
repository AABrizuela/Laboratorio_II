using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, i;
            float promedio;
            float acumulador = 0;
            int maximo = 0;
            int minimo = 0;

            for(i = 0; i<5; i++)
            {
                Console.Write("Ingrese numero: ");
                numero = int.Parse(Console.ReadLine());
                acumulador = acumulador + numero;

                if(i==0)
                {
                    maximo = numero;
                    minimo = numero;
                }

                if(numero > maximo)
                {
                    maximo = numero;
                }

                if(numero < minimo)
                {
                    minimo = numero;
                }
            }

            promedio = acumulador / i;

            Console.WriteLine("\nMaximo {0} | Minimo {1} | Promedio {2}", maximo, minimo, promedio);

            Console.ReadLine();
        }
    }
}
