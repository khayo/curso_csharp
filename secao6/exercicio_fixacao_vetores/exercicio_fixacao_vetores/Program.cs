using System;

namespace exercicio_fixacao_vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Quartos[] vect = new Quartos[10];

            //laço de repetição para receber dados dos locatários
            for (int i = 0; i < n; i++)
            {
                //recebendo dados do locatário
                Console.WriteLine("Aluguel #{0}:", i+1);
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("E-mail: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                //mandando as informaçõea para o vetor
                vect[quarto] = new Quartos { Nome = nome, Email = email }; //poderia usar o construtor
                Console.WriteLine();
            }

            Console.WriteLine("Quartos ocupados: ");

            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine( i + ": "+ vect[i].ToString());
                }
            }
            
        }
    }
}
