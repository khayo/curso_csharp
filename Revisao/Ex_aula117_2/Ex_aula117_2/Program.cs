using System;
using System.Globalization;
using Ex_aula117_2.Entities;
using Ex_aula117_2.Entities.Enum;
using System.Collections.Generic;

namespace Ex_aula117_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            var department = new Department(Console.ReadLine());
            
            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Worker level (Junio/MidLevel/Senior): ");
            WorkerLevel workerLevel = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("How many contracts to this worker? ");

            Worker worker = new Worker(name, workerLevel, baseSalary, department);

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Duration: ");
                int duration = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valuePerHour, duration);

                worker.AddContract(contract);
            }

            Console.Write("Enter the month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3, 4));

            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);

            Console.WriteLine("Income for " + monthAndYear + ": " + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));



        {

        }
               
        }
    }
}
