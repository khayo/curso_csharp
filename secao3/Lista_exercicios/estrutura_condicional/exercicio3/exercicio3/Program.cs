using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] v = Console.ReadLine().Split(' ');

            int A = int.Parse(v[0]);
            int B = int.Parse(v[1]);

            if ((A % B == 0) || (B % A == 0))
            {
                Console.WriteLine("SÃO MULTIPLOS");
            }
            else
            {
                Console.WriteLine("NÃO SÃO MULTIPLOS");
            }
        }
    }
}
