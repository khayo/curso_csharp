using System;
using System.Globalization;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int funcionario = int.Parse(Console.ReadLine());
            int horas = int.Parse(Console.ReadLine());
            double valor_hora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario = horas * valor_hora;

            Console.WriteLine("Numero = " + funcionario);
            Console.WriteLine("Salário = R$ " + salario.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
