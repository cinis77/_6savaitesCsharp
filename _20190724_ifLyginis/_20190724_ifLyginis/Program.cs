using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190724_ifLyginis
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            int liekana = skaicius % 2;
            if (liekana == 0)
            {
                Console.WriteLine("Skaicius yra lyginis");
            }
        }
    }
}