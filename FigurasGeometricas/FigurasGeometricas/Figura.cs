using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    internal class Figura
    {
        public string Nombre;

        public Figura(string nombre)
        {
            Nombre = nombre;
        }

        public virtual double CalcularArea()
        {
            return 0;  // Método que se sobrescribirá en las clases derivadas
        }
    }
}
