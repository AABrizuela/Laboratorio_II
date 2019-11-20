using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Clase_Anteultima.Entidades;

namespace Clase_Anteultima.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado emp = new Empleado("Juan", "Perez", 123);
            emp.limiteSueldo += new limiteSueldoDelegado(LimiteSueldoDelegado);
            emp.sueldoMejorado += new limiteSueldoMejoradoDelegado(LimiteSueldoMejoradoDelegado);
            emp.Sueldo = 30000;            

            Console.WriteLine(emp.ToString());
            
            Console.ReadKey();

            void LimiteSueldoDelegado(double sueldo, Empleado empleado)
            {
                Console.WriteLine("Empleado zarpado: {0} {1}", empleado.Nombre, empleado.Apellido);
                Console.WriteLine("Lo que quiere ganar el atrevido: {0}", sueldo);
                Console.ReadKey();
            }

            void LimiteSueldoMejoradoDelegado(Empleado empl, EventArgs args1)
            {
                Console.WriteLine("Sueldo excedido mejorado");
                Console.WriteLine(empl.ToString());
                Console.ReadKey();
            }


        }

        
    }
}
