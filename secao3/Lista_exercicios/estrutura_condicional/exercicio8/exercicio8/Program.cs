using System;
using System.Globalization;

namespace exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double imposto = 0.0;

            if (salario > 0 && salario <= 2000.00 )
            {
                imposto = 0.0;
            }
            else if (salario <= 3000 )
            {
                imposto = (salario - 2000) * 0.08;
            }
            else if (salario <= 4500 )
            {
                imposto = ((salario - 3000) * 0.18) + 1000 * 0.08;
            }
            else
            {
                imposto = ((salario - 4500) * 0.28) + 1000 * 0.08 + 1500 * 0.18;
            }

            if (imposto == 0.0)
            {
                Console.WriteLine("Isento");
            }
            else
            {
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
            
        }
    }
}
