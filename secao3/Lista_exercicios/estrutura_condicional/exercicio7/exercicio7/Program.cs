using System;
using System.Globalization;

namespace exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] v = Console.ReadLine().Split(' ');

            float x = float.Parse(v[0], CultureInfo.InvariantCulture);
            float y = float.Parse(v[1], CultureInfo.InvariantCulture);

            if (x == 0 && y == 0)
            {
                Console.WriteLine("Origem");
            }
            else if (x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0 && y > 0) 
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }
            else 
            {
                Console.WriteLine("Q4");
            }
        }
    }
}
