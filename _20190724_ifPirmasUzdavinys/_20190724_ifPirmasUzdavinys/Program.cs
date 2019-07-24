using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190724_ifPirmasUzdavinys
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            int sk = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite skaiciu");
            int sk1 = Convert.ToInt32(Console.ReadLine());
            if (sk > sk1)
            {
                Console.WriteLine("Pirmas skaicius yra didesnis");
            }
            if (sk < sk1)
            {
                Console.WriteLine("Antras skaicius yra didesnis");
            }
            if (sk == sk1)
            {
                Console.WriteLine("Abu skaiciai yra lygus");
            }
        }
    }
}