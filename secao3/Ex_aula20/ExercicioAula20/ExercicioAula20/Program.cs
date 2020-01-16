using System;

namespace ExercicioAula20
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(a);

            a += 2;
            Console.WriteLine(a);

            a *= 3;
            Console.WriteLine(a);

            string s = "ABC";
            Console.WriteLine(s);

            s += "DEF";
            Console.WriteLine(s);

            Console.WriteLine("----------------");

            int b = 10;
            b++;
            Console.WriteLine(b);
            b--;
            Console.WriteLine(b);

            Console.WriteLine("----------------");

            int c = ++b;
            Console.WriteLine(b);
            Console.WriteLine(c);

        }
    }
}
