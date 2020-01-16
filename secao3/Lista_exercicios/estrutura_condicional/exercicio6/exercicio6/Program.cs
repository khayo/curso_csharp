using System;
using System.Globalization;

namespace exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            float num = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(num);

            if (num < 0 || num > 100)
            {
                Console.WriteLine("Fora de intervalo");
            }
            else if (num >= 0 && num <= 25)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (num <= 50)
            {
                Console.WriteLine("Intevalo (25,50]");
            }
            else if (num <= 75)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else
            {
                Console.WriteLine("Intervalo (75,100]");
            }
        }
    }
}
