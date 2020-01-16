using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int entrada = int.Parse(Console.ReadLine());
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;


            while (entrada != 4)
            {
                if (entrada == 1)
                {
                    alcool++;
                }
                else if (entrada == 2)
                {
                    gasolina++;
                }
                else if (entrada == 3)
                {
                    diesel++;
                }

                entrada = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);

        }
    }
}
