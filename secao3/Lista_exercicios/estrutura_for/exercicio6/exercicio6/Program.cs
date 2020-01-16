using System;

namespace exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int calc = 0;

            for (int i = 1; i <= N; i++)
            {
                calc = N % i;
                if (calc == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
