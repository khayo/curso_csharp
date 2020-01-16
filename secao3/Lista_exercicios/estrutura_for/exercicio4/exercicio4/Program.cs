using System;
using System.Globalization;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] v = Console.ReadLine().Split(' ');

                int n1 = int.Parse(v[0]);
                int n2 = int.Parse(v[1]);

                if (n2 == 0)
                {
                    Console.WriteLine("Divisão Impossível");
                }
                else
                {
                    double resultado = (double)n1 / n2;
                    Console.WriteLine(resultado.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
