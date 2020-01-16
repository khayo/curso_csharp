using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int calculo = 0;

            if (N >= 1 && N <= 1000) 
            {
                for (int i = 1; i <= N; i++)
                {
                    calculo = i % 2;

                    if (calculo != 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            
        }
    }
}
