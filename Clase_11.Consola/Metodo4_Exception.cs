using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_11.Consola
{
    class Metodo4_Exception : Exception
    {
        #region Constructor
        public Metodo4_Exception(string message) : base(message)
        {
            
        }

        public Metodo4_Exception(string message, Exception obj) : base (message, obj)
        {

        }
        #endregion
    }
}
