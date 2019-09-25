using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Alumno
    {
        private int nota1;
        private int nota2;
        private float notaFinal;

        public string apellido;
        public int legajo;
        public string nombre;

        public void CalcularFinal()
        {
            Random random = new Random();
            this.notaFinal = -1;

            if(this.nota1 >= 4 && this.nota2 >= 4)
            {
                this.notaFinal = (float) random.Next(1, 10);
            }
        }

        public void Estudiar(byte notaUno, byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }

        public string Mostrar()
        {
            string notaFinal;

            if (this.notaFinal != -1)
            {
                notaFinal = this.notaFinal.ToString();
            }
            else
            {
                notaFinal = "Alumno Desaprobado";
            }

            return this.nombre + " | " + this.apellido + " | " + this.legajo.ToString() + " | " + notaFinal;
        }

    }
}
