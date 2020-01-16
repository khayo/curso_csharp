using System;

namespace exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int fatorial = 1;
            for (int i = 0; i < N; i++)
            {
                fatorial = fatorial * (N - i); 
            }
            Console.WriteLine(fatorial);
        }
    }
}
