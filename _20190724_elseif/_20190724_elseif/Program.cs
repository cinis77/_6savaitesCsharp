using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190724_elseif
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Iveskite amziu");
            int amzius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite skaiciu");
            int sk = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite skaiciu");
            int sk1 = Convert.ToInt32(Console.ReadLine());
            if (amzius > sk)
            {
                Console.WriteLine("Amzius yra didesnis nei pirmas skaicius");
            }
            else if (amzius > sk1)
            {
                Console.WriteLine("Amzius yra didesnis nei antras skaicius");
            }
        }
    }
}