using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_20.Entidades
{
    public static class Serializadora
    {
        public static bool Serializar(IXML interfaz)
        {
            return interfaz.Guardar(AppDomain.CurrentDomain.BaseDirectory + "\\Archivo.xml");
        }

        public static bool Deserializar(IXML interfaz, out object obj)
        {
            return interfaz.Leer(AppDomain.CurrentDomain.BaseDirectory + "\\Archivo.xml", out obj);
        }
    }
}
