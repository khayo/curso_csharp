using System;
using System.Globalization;

namespace exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] v1 = Console.ReadLine().Split(' ');
            string[] v2 = Console.ReadLine().Split(' ');

            int cod1 = int.Parse(v1[0]);
            int qtd1 = int.Parse(v1[1]);
            double val1 = double.Parse(v1[2], CultureInfo.InvariantCulture);

            int cod2 = int.Parse(v2[0]);
            int qtd2 = int.Parse(v2[1]);
            double val2 = double.Parse(v2[2], CultureInfo.InvariantCulture);

            double total = (qtd1 * val1) + (qtd2 * val2);

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
                        
        }
    }
}
