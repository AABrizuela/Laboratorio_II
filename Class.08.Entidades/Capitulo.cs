using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class._08.Entidades
{
    public class Capitulo
    {
        private int numero;
        private string titulo;
        private int paginas;

        private static Random generadorDeNumeros;
        private static Random generadorDePaginas;

        public int Numero
        {
            get { return this.numero; }
        }

        public string Titulo
        {
            get { return this.titulo; }
        }

        public int Paginas
        {
            get { return this.paginas; }
        }

        static Capitulo()
        {
            Capitulo.generadorDeNumeros = new Random();
            Capitulo.generadorDePaginas = new Random();
        }

        private Capitulo(int numero, string titulo, int paginas)
        {
            this.numero = numero;
            this.titulo = titulo;
            this.paginas = paginas;
        }

        public static implicit operator Capitulo(string s)
        {
            return new Capitulo(Capitulo.generadorDeNumeros.Next(1, 65), s, Capitulo.generadorDePaginas.Next(15, 233));
        }

        public static bool operator ==(Capitulo c1, Capitulo c2)
        {
            bool retorno = false;

            if (Object.Equals(c1, null) && Object.Equals(c2, null))
            {
                retorno = true;
            }
            else
            {
                if (!Object.Equals(c1, null) && !Object.Equals(c2, null))
                {
                    if (c1.numero == c2.numero && c1.titulo == c2.titulo)
                    {
                        retorno = true;
                    }
                    else
                    {
                        retorno = false;
                    }
                }
            }
            return retorno;
        }

        public static bool operator !=(Capitulo c1, Capitulo c2)
        {
            return !(c1 == c2);
        }
    }
}
