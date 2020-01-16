using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            bool completo = false;
            char genero = 'F';
            char letra = '\u0041';
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;
            float n5 = 4.5f;
            double n6 = 4.5;
            string nome = "Maria Green";
            object obj1 = "Alex Brown";
            object obj2 = 4.5f;

            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);


            int n7 = int.MinValue;
            int n8 = int.MaxValue;
            sbyte n9 = sbyte.MinValue;
            decimal n10 = decimal.MaxValue;

            Console.WriteLine(n7);
            Console.WriteLine(n8);
            Console.WriteLine(n9);
            Console.WriteLine(n10);

            Console.WriteLine("------------------");

            int idade = 32;
            double saldo = 10.35784;
            String nome2 = "Maria";

            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome2);
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4"));
            Console.WriteLine(saldo.ToString("F2", CultureInfo.InvariantCulture) );
            Console.WriteLine("");

            Console.WriteLine("------------------");
            Console.WriteLine("Placeholder");
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome2, idade, saldo);
            Console.WriteLine("");

            Console.WriteLine("------------------");
            Console.WriteLine("Interpolação");
            Console.WriteLine($"{nome2} tem {idade} anos e tem saldo igual a {saldo:F2} reais");
            Console.WriteLine("");

            Console.WriteLine("------------------");
            Console.WriteLine("Concatenação");
            Console.WriteLine(nome2 + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture ) + " reais");
            Console.WriteLine("");

        }
    }
}
