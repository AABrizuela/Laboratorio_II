using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_08.Entidades
{
    public class Libro
    {
        private string titulo;
        private string autor;
        private List<Capitulo> listaCapitulos = new List<Capitulo>();

        #region CONSTRUCTORES
        public string Titulo
        {
            get { return this.titulo; }
        }

        public string Autor
        {
            get { return this.autor; }
        }

        public Libro(string titulo, string autor)
        {
            this.titulo = titulo;
            this.autor = autor;

        }
        #endregion

        #region METODOS
        #endregion

        #region SOBRECARGAS
        #endregion

        public int CantidadPaginas
        {
            get
            {
                int cantPag = 0;

                foreach (Capitulo item in this.listaCapitulos)
                {
                    cantPag = cantPag + item.Paginas;
                }

                return cantPag;
            }
        }
        public Capitulo this[int i]
        {
            get
            {
                if (this.listaCapitulos[i] != null)
                {
                    return this.listaCapitulos[i];
                }
                else
                {
                    return null;
                }
            }
            set
            {

                if (this.listaCapitulos.Count > 0 && i < this.listaCapitulos.Count && i >= 0)
                {
                    this.listaCapitulos[i] = value;
                }
                else if (this.listaCapitulos.Count == i)
                {
                    this.listaCapitulos.Add(value);
                }
                else
                {
                    Console.WriteLine("ERROR AL INGRESAR CAP");
                }
            }
        }

        public int CantidadDeCapitulos
        {
            get { return this.listaCapitulos.Count; }
        }
    }
}
