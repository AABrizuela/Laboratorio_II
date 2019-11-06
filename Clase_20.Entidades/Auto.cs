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
    public class Auto : IXML
    {
        #region Atributos
        public string marca;
        public double precio;
        #endregion

        #region Constructores
        public Auto()
        {

        }

        public Auto(string marca, double precio)
        {
            this.marca = marca;
            this.precio = precio;
        }
        #endregion

        #region Interfaces
        public bool Guardar(string dato)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Auto));

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
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Auto));

                using (XmlTextReader textReader = new XmlTextReader(dato))
                {
                    obj = (Auto)xmlSerializer.Deserialize(textReader);
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
            return "Marca: " + this.marca + " - Precio: " + this.precio;
        }
        #endregion
    }
}
