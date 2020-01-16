using System;
using System.Globalization;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario a, b;
            a = new Funcionario();
            b = new Funcionario();
            double media;
            
            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            a.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            a.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            b.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            b.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = (a.Salario + b.Salario) / 2;

            Console.WriteLine("Salario médio = {0}", media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
