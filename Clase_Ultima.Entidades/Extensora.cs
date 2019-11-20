using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


using Entidades.Externa.Sellada;

namespace Clase_Ultima.Entidades
{
    public static class Extensora
    {
        #region Metodo de Extension
        /// <summary>
        /// Recibe una clase como parametro, adentro extrae la informacion a un StringBuilder y lo devuelve como cadena.
        /// </summary>
        /// <param name="externaSellada">El objeto que uso para mostrar, el cual viene de una clase sellada</param>
        /// <returns></returns>
        public static string ObtenerInfo(PersonaExternaSellada externaSellada)
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendFormat("Nombre: {0}\n", externaSellada.Nombre);
            builder.AppendFormat("Apellido: {0}\n", externaSellada.Apellido);
            builder.AppendFormat("Edad: {0}\n", externaSellada.Edad);
            builder.AppendFormat("Sexo: {0}\n", externaSellada.Sexo);

            return builder.ToString();
        }

        public static bool EsNulo(Object obj)
        {
            return obj.Equals(null);
        }

        public static List<Persona> ObtenerListadoBD(this Persona p)
        {
            List<Persona> lista = null;

            //try
            //{
            SqlConnection conexionSql = new SqlConnection(Properties.Settings.Default.Conexion);
            conexionSql.Open();
            lista = new List<Persona>();
            SqlCommand comandoSql = new SqlCommand();
            comandoSql.Connection = conexionSql;
            comandoSql.CommandType = System.Data.CommandType.Text;
            comandoSql.CommandText = "SELECT TOP 1000 [id],[nombre],[apellido],[edad] FROM[personas_bd].[dbo].[personas]";
            SqlDataReader dataReader = comandoSql.ExecuteReader();
            while (dataReader.Read() != false)
            {
                lista.Add(new Persona(dataReader["nombre"].ToString(), dataReader["apellido"].ToString(), Convert.ToInt32(dataReader["edad"])));
            }
            conexionSql.Close();
            //}
            //catch (Exception exception)
            //{
            //    (exception.Message);
            //}

            return lista;
        }
        #endregion
    }
}
