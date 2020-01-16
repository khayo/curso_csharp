using System;
using System.Collections.Generic;

namespace ex_aula77
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Ana");
            list.Insert(2, "Marco");

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("List count: " + list.Count);

            Console.WriteLine("--------------------------");

            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine(s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine(s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine(pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine(pos2);

            Console.WriteLine("--------------------------");

            List<string> list2 = list.FindAll(x => x.Length == 5);
            foreach (string item in list2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------------------------");

            list.Remove("Alex");

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------------------------");
            list.RemoveAll(x => x[0] == 'M');

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            
        }
    }
}
