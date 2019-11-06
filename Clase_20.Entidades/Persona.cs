using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace Clase_20.Entidades
{
    [XmlInclude(typeof(Empleado))]
    [XmlInclude(typeof(Alumno))]
    public class Persona : IXML
    {
        #region Atributos
        public int id;
        public string nombre;
        public string apellido;
        private int edad;
        //private List<string> apodos = new List<string>();
        #endregion

        #region Propiedades
        public int Edad { get => this.edad; set => this.edad = value; }

        //public List<string> Apodos { get => this.apodos; }
        #endregion

        #region Constructor
        public Persona()
        {
            
        }

        public Persona(string nombre, string apellido, int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;

        }

        public Persona(string nombre, string apellido, int edad, int id) : this(nombre, apellido, edad)
        {
            this.id = id;
        }
        #endregion

        #region Interfaces
        public bool Guardar(string dato)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Persona));

            try
            {
                using (XmlTextWriter textWriter = new XmlTextWriter(dato, Encoding.UTF8))
                {
                    xmlSerializer.Serialize(textWriter, this);
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool Leer(string dato, out object obj)
        {
            obj = null;

            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Persona));

                using (XmlTextReader textReader = new XmlTextReader(dato))
                {
                    obj = (Persona)xmlSerializer.Deserialize(textReader);
                    Console.WriteLine(obj.ToString());
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                
            }

            return false;
        }
        #endregion

        #region Sobrecarga
        public override string ToString()
        {
            return "Nombre: " + this.nombre + " - Apellido: " + this.apellido + " - Edad: " + this.edad;
        }
        #endregion

    }
}
