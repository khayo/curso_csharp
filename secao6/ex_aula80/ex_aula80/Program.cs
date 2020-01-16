using System;

namespace ex_aula80
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(valores[j]);
                }
                
            }

            Console.WriteLine("Diagonal principal:" );

            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i] + " ");
            }
            Console.WriteLine();
            int qtd = 0;

            foreach (int item in mat)
            {
                if (item < 0)
                {
                    qtd++;
                }
            }
            Console.WriteLine("Números negativos: {0}", qtd);
        }
    }
}
