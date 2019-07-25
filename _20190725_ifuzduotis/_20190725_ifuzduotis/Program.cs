using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190725_ifuzduotis
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite skaiciu");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite skaiciu");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a < 100)
            {
                Console.WriteLine("Pirmos dalies ispildymas");
            }
            else if (b > 0 && b > a)
            {
                Console.WriteLine("Antros dalies ispildymas");
            }
            else if (a > b && a > c || a > 0)
            {
                Console.WriteLine("Trecios dalies ispildymas");
            }
            else if (c >= 5 && c <= 10 || c > a || c > b)
            {
                Console.WriteLine("Ketvirtos dalies ispildymas");
            }
        }
    }
}