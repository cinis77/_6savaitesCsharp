using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190724_PirmasAritmetikaKartojimo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            int sk = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite skaiciu");
            int sk1 = Convert.ToInt32(Console.ReadLine());
            int sveikaja = sk / sk1;
            int liekana = sk % sk1;
            Console.WriteLine("Sveika dalis yra: {0}, o liekana yra: {1}", sveikaja, liekana);
        }
    }
}