using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[7] { 1, 2, 3, 4, 5, 6, 7 };
            var results = from item in numbers
                          where (item % 2) == 0
                          select item;
            int evennumber = results.Count();
            Console.WriteLine(evennumber);
            Console.ReadLine();

          

        }
    }
}
