using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_20.Entidades;
using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace Clase_20.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona nuevaPersona = new Persona("Adrian", "Brizuela", 28);
            nuevaPersona.Apodos.Add("El Tigre");
            Persona nuevaPersona2 = new Persona("Lautaro", "Galarza", 21);
            nuevaPersona2.Apodos.Add("Bbto");
            Persona nuevaPersona3 = new Persona("Lucas", "Hulej", 20);
            nuevaPersona3.Apodos.Add("Pichichi");
            Persona nuevaPersona4 = new Persona("Axel", "Ghio", 26);
            nuevaPersona4.Apodos.Add("El gato");
            Persona nuevaPersona5 = new Persona("Pablito", "Machuiyi", 28);
            nuevaPersona5.Apodos.Add("Peps");
            Persona nuevaPersona6 = new Persona("Estefania", "Franco", 25);
            nuevaPersona6.Apodos.Add("La pibita");

            List<Persona> listaPersona = new List<Persona>();

            listaPersona.Add(nuevaPersona);
            listaPersona.Add(nuevaPersona2);
            listaPersona.Add(nuevaPersona3);
            listaPersona.Add(nuevaPersona4);
            listaPersona.Add(nuevaPersona5);
            listaPersona.Add(nuevaPersona6);

            Console.WriteLine(nuevaPersona.ToString());

            try
            {
                //XmlSerializer xmlSerializer = new XmlSerializer(typeof(Persona)); //Tipo de objeto a serializar
                //la clase debe tener un constructor sin parametros y la clase debe ser publica                
                XmlSerializer xmlSerializer2 = new XmlSerializer(typeof(List<Persona>));
                //StreamWriter stream = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\persona.xml");

                using (XmlTextWriter textWriter = new XmlTextWriter(AppDomain.CurrentDomain.BaseDirectory + "\\persona.xml", Encoding.UTF8))
                {                    
                    xmlSerializer2.Serialize(textWriter, listaPersona);                    
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

            try
            {
                //XmlSerializer xmlSerializer = new XmlSerializer(typeof(Persona));
                XmlSerializer xmlSerializer2 = new XmlSerializer(typeof(List<Persona>));

                using (XmlTextReader textReader = new XmlTextReader(AppDomain.CurrentDomain.BaseDirectory + "\\persona.xml"))
                {
                    //Persona persona = (Persona)xmlSerializer.Deserialize(textReader);//Deserializa el archivo usando el objeto que lo lee

                    List<Persona> listaPersonas = (List<Persona>)xmlSerializer2.Deserialize(textReader);

                    //Console.WriteLine(persona.ToString());
                    Console.WriteLine(listaPersonas);

                    //Console.WriteLine(((Persona)xmlSerializer.Deserialize(textReader)).ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
