using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190726_DaugybeBeDaugybos
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            int sk = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite skaiciu");
            int sk1 = Convert.ToInt32(Console.ReadLine());
            int suma = 0;
            for (int i = 0; i < sk1; i++)
            {
                suma += sk; // suma = suma + sk
            }
            Console.WriteLine("Atsakymas yra: " + suma);
        }
    }
}