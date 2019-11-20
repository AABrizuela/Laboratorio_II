using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades.Externa;

namespace Clase_Ultima.Entidades
{
    public class Externa : PersonaExterna
    {
        #region Constructor
        public Externa(string nombre, string apellido, int edad, ESexo sexo) : base(nombre, apellido, edad, sexo)
        {

        }
        #endregion
         
        #region Propiedades
        public string Nombre { get => base._nombre; /*set => base._nombre = value;*/ }

        public string Apellido { get => base._apellido; /*set => base._apellido = value;*/ }

        public int Edad { get => base._edad; /*set => base._edad = value;*/ }

        public ESexo Sexo { get => base._sexo; /*set => base._sexo = value;*/ }
        #endregion
    }
}
