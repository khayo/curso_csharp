using System;
using System.Globalization;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] v = Console.ReadLine().Split(' ');

            double A = double.Parse(v[0], CultureInfo.InvariantCulture);
            double B = double.Parse(v[1], CultureInfo.InvariantCulture);
            double C = double.Parse(v[2], CultureInfo.InvariantCulture);

            double triangulo = (A * C)/2;
            double circulo = Math.Pow(C, 2) * 3.14159;
            double trapezio = ((A * C) / 2) + ((B * C) / 2);
            double quadrado = B * B;
            double retangulo = A * B;



            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
