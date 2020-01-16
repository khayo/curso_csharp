using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int dentro = 0;
            int fora = 0;
            for (int i = 0; i < N; i++)
            {
                int calculo = int.Parse(Console.ReadLine());

                if (calculo >= 10 && calculo <= 20)
                {
                    dentro++;
                }
                else
                {
                    fora++;
                }

            }

            Console.WriteLine("{0} in", dentro);
            Console.WriteLine("{0} out", fora);
        }
    }
}
