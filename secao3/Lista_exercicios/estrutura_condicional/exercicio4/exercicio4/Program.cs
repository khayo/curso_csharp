using System;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] v = Console.ReadLine().Split(' ');

            int inicio = int.Parse(v[0]);
            int fim = int.Parse(v[1]);
            int tempo = 0;

            if (inicio < fim)
            {
                tempo = fim - inicio;
            }
            else
            {
                tempo = (24 - inicio) + fim;
            }

            Console.WriteLine("O JOGO DUROU " + tempo + " HORA(S)");
        }
    }
}
