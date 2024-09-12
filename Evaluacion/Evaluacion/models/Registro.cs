using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//se deseaan almacenar un maximo de 1000 notas de estudiantes, obtener el promedio y los tres primeros lugares
namespace Evaluacion.Models
{
    internal class Registro
    {
        private int[] notas = new int[1000];
        private int contador = 0;

        public void AgregarNota(int nota)
        {
            if (contador < 1000)
            {
                notas[contador] = nota;
                contador++;
            }
        }

        public double Promedio()
        {
            double suma = 0;
            for (int i = 0; i < contador; i++)
            {
                suma += notas[i];
            }
            return suma / contador;
        }

        public int[] TresMejores()
        {
            int[] mejores = new int[3];
            Array.Sort(notas, 0, contador);
            for (int i = 0; i < 3; i++)
            {
                mejores[i] = notas[contador - 1 - i];
            }
            return mejores;
        }
    }
}