using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Clase_Ultima.Entidades;
//using Entidades.Externa;
using Entidades.Externa.Sellada;

namespace Clase_Ultima.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("Pepe", "Argento", 69420);
            //PersonaExterna personaExterna = new PersonaExterna("Pablo", "Machuishin", 28, ESexo.Indefinido);
            PersonaExternaSellada externaSellada = new PersonaExternaSellada("Adrian", "Brizuela", 29, ESexo.Masculino);
            List<Persona> ListaPersona = p1.ObtenerListadoBD();

            Console.WriteLine(Entidades.Extensora.EsNulo(externaSellada));
            Console.WriteLine(Entidades.Extensora.ObtenerInfo(externaSellada));

            foreach (Persona item in ListaPersona)
            {
                Console.WriteLine(item.ObtenerInfo());
            }
            
            Console.ReadKey();
        }
    }
}
