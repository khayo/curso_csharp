using System;
using System.Globalization;

namespace ex_aula69
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtd = int.Parse(Console.ReadLine());

            double[] vect = new double[qtd];

            for (int i = 0; i < qtd; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);                 
            }

            double soma = 0.0;

            for (int i = 0; i < qtd; i++)
            {
                soma += vect[i];
            }

            soma = soma / qtd;

            Console.WriteLine("Average Height = {0}", soma.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
