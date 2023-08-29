using FigurasGeometricas;
using System;

class Program
{
    static void Main(string[] args)
    {
        Circulo miCirculo = new Circulo("Círculo", 10);
        Rectangulo miRectangulo = new Rectangulo("Rectángulo", 85, 150);

        Console.WriteLine($"{miCirculo.Nombre} - Área: {miCirculo.CalcularArea()}");
        Console.WriteLine($"{miRectangulo.Nombre} - Área: {miRectangulo.CalcularArea()}");

        Console.ReadLine();
    }
}