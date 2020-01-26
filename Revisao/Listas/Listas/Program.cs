using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        string employee = Console.ReadLine();
        double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double totalSale = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double salary = baseSalary + (totalSale * 0.15);

        Console.WriteLine("TOTAL = R$ " + salary.ToString("F2", CultureInfo.InvariantCulture));
    }

}