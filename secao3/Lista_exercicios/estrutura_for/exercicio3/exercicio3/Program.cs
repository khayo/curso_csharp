using System;
using System.Globalization;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] v = Console.ReadLine().Split(' ');

                double n1 = double.Parse(v[0], CultureInfo.InvariantCulture);
                double n2 = double.Parse(v[1], CultureInfo.InvariantCulture);
                double n3 = double.Parse(v[2], CultureInfo.InvariantCulture);

                double saida = ((n1 * 2) + (n2 * 3) + (n3 * 5)) / 10;
                Console.WriteLine(saida.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
