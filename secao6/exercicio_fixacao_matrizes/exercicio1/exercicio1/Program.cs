using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] formato = Console.ReadLine().Split(' ');
            
            int m = int.Parse(formato[0]);
            int n = int.Parse(formato[1]);

            int[,] matriz = new int[m, n];
                        
            for (int i = 0; i < m; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(valores[j]);
                }
            }

            int loc = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] == loc) 
                    {
                        Console.WriteLine("Posição: " + i + ", " + j);

                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + matriz[i - 1, j]);
                        }
                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + matriz[i, j - 1]);
                        }
                        if (i < m - 1)
                        {
                            Console.WriteLine("Right: " + matriz[(i + 1), j]);
                        }
                        if (j < n - 1)
                        {
                            Console.WriteLine("Down " + matriz[i, (j + 1)]);
                        }

                    }
                }
            }


        }
    }
}
