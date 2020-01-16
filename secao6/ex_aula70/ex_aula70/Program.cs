using System;
using System.Globalization;

namespace ex_aula70
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Produto[] vect = new Produto[n];

            for (int i = 0; i < n; i++)
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                vect[i] = new Produto { Name = nome, Preco = preco };
            }
            double soma = 0.0;

            for (int i = 0; i < n; i++)
            {
                soma += vect[i].Preco;
            }

            double media = soma / n;

            Console.WriteLine("Preço médio = " + media.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
