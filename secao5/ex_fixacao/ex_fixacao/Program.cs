using System;
using System.Globalization;

namespace ex_fixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria contaBancaria;
            
            //leitura das entradas
            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char dep_inicial = char.Parse(Console.ReadLine());
            
            if (dep_inicial == 's' || dep_inicial == 'S')
            {
                double deposito = 0.0;
                Console.Write("Entre o valor de depósito inicial: ");
                deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                contaBancaria = new ContaBancaria(numero, nome, deposito);
            }
            else
            {
                contaBancaria = new ContaBancaria(numero, nome);
            }

             
            Console.WriteLine();

            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(contaBancaria.ToString());
            Console.WriteLine();

            Console.Write("Entre um valor para depósito: " );
            contaBancaria.Deposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(contaBancaria.ToString());
            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            contaBancaria.Saque(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(contaBancaria.ToString());
            Console.WriteLine();

        }



    }
}

