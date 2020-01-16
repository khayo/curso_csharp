using System;

namespace Ex_aula34
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos números inteiros você vai digitar? ");
            int N = int.Parse(Console.ReadLine());
            int soma = 0;

            for (int i = 1; i <= N; i++)
            {
                Console.Write("Valor #{0}: ", i);
                soma += int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Soma = " + soma);

        }
    }
}
