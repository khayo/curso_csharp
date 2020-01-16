using System;
using System.Collections.Generic;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("O curso A possui quantos alunos? ");
            int qtd = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunos do curso A:");
            HashSet<int> A = new HashSet<int>();
            for (int i = 0; i < qtd; i++)
            {
                A.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("O curso B possui quantos alunos? ");
            qtd = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunos do curso B:");
            HashSet<int> B = new HashSet<int>();
            for (int i = 0; i < qtd; i++)
            {
                B.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("O curso C possui quantos alunos? ");
            qtd = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunos do curso C:");
            HashSet<int> C = new HashSet<int>();
            for (int i = 0; i < qtd; i++)
            {
                C.Add(int.Parse(Console.ReadLine()));
            }

            HashSet<int> Novo = new HashSet<int>();
            Novo.UnionWith(A);
            Novo.UnionWith(B);
            Novo.UnionWith(C);
            
            Console.WriteLine("Total de alunos: {0}", Novo.Count);

        }
    }
}
