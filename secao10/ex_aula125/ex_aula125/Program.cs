using System;
using ex_aula125.Entities;

namespace ex_aula125
{
    class Program
    {
        static void Main(string[] args)
        {

            //aula 125 - Herança
            Console.WriteLine();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Aula 125");
            Console.WriteLine("--------------------------------------");
            BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.0, 500.0);

            Console.WriteLine(account.Balance);

            account.Deposit(200);

            Console.WriteLine(account.Balance);

            //aula 126 - upcasting e downcasting
            Console.WriteLine();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Aula 126");
            Console.WriteLine("--------------------------------------");
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            //UPCASTING

            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingAccount(1004, "Anna", 0.0, 0.01);

            //DOWNCASTING

            //BusinessAccount acc4 = acc2; // da erro pq a variavel é do tipo account

            BusinessAccount acc4 = (BusinessAccount)acc2; //aqui foi feito o casting para a conversão explicita da variavel do tipo account para o tipo businessAccount
            acc4.Loan(100);

            if (acc3 is BusinessAccount)
            {
                BusinessAccount acc5 = (BusinessAccount)acc3; // falha em tempo de execução pois acc3 é do tipo SavingAccount;
                acc5.Loan(200);
                Console.WriteLine("Loan!");
            }
            if (acc3 is SavingAccount)
            {
                SavingAccount acc5 = (SavingAccount)acc3;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }

            //aula 127 - sobreposição, palavra virtual, override e base
            Console.WriteLine();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Aula 127");
            Console.WriteLine("--------------------------------------");

            Account acc6 = new Account(1005, "Alex", 500.0);
            Account acc7 = new SavingAccount(1006, "Anna", 500.0, 0.01);

            acc6.Withdral(10.0);
            acc7.Withdral(10.0);

            Console.WriteLine(acc6.Balance);
            Console.WriteLine(acc7.Balance);

            //aula 128 - classes e metodos selados
            Console.WriteLine();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Aula 127");
            Console.WriteLine("--------------------------------------");
        }
    }
}
