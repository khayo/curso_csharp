using System;
using System.Globalization;

namespace ex_aula88
{
    class Program
    {
        static void Main(string[] args)
        {

            var i = (2 > 4) ? "batata" : "morango";
            Console.WriteLine(i);

            Console.WriteLine((3 == 12) ? "verdadeiro" : "Falso");

            Console.WriteLine("-------------------------");

            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double desconto = (preco < 20 ) ? preco * 0.1 : preco * 0.05;

            Console.WriteLine(desconto);
        }
    }
}
