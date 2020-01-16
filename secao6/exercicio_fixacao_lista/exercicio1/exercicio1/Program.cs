using System;
using System.Globalization;
using System.Collections.Generic;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            // entra a quantidade de funcionários a serem registrados
            Console.Write("Quantos empregados serão registrados? ");
            int qtd = int.Parse(Console.ReadLine());

            List<Funcionarios> lista = new List<Funcionarios>();

            Funcionarios funcionarios = new Funcionarios();

            for (int i = 0; i < qtd; i++)
            {
                Console.WriteLine("Funcionário #" + (i + 1));
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                lista.Add(new Funcionarios { Id = id, Nome = nome, Salario = salario });
                Console.WriteLine();
            }

            //aumento de salário
            Console.Write("Informe o empregado que terá aumento de salário: ");
            int id_func = int.Parse(Console.ReadLine());
            Funcionarios func = lista.Find(x => x.Id == id_func);

            if (func != null)
            {
                Console.Write("Informe  a porcentagem: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                func.Aumento(porcentagem);
            }
            else
            {
                Console.WriteLine("Este id não existe! ");
            }


            Console.WriteLine();

            //listar funcionários
            Console.WriteLine("Lista de funcionários atualizada: ");

            foreach (Funcionarios item in lista)
            {
                Console.WriteLine(item);
            }

        }
    }
}
