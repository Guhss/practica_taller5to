using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    internal class Rectangulo : Figura
    {
        public double LadoA; 
        public double LadoB; 

        public Rectangulo(string nombre, double ladoA, double ladoB) : base(nombre)
        {
            LadoA = ladoA;
            LadoB = ladoB;
        }

        // override: indica que estás reemplazando una implementación de método en la clase base - double: el método devuelve un valor de tipo double.
        public override double CalcularArea() 
        {
            return LadoA * LadoB;
        }
    }
}
