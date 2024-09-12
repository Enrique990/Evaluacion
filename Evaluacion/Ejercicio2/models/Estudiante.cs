using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.models
{
    internal class Estudiante
    {
        private List<string> nombres = new List<string>();
        private const int MaxEstudiantes = 25;

        public void AgregarNombre(string nombre)
        {
            if (nombres.Count < MaxEstudiantes)
            {
                nombres.Add(nombre);
            }
            else
            {
                throw new InvalidOperationException("No se pueden agregar más de 25 nombres.");
            }
        }

        public List<string> ObtenerNombresLargos()
        {
            List<string> nombresLargos = new List<string>();
            foreach (var nombre in nombres)
            {
                if (nombre.Length > 25)
                {
                    nombresLargos.Add(nombre);
                }
            }
            return nombresLargos;
        }
    }
}
