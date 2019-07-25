using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190725_ifUzduosi2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            if ((skaicius % 2 == 0 && skaicius % 3 == 0) || skaicius % 5 == 0)
            {
                Console.WriteLine("Skaicius yra 2 ir 3 kartotinis arba 5 kartotinis");
            }
        }
    }
}