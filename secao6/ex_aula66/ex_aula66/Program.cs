using System;

namespace ex_aula66
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point;

            point.X = 10;
            point.Y = 20;

            Console.WriteLine(point);

            point = new Point();
            Console.WriteLine(point);


            char c = new char();
            Console.WriteLine(c);
        }
    }
}
