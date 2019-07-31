using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190731_Sarasas
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int> pazymiai = new List<int>();
            int pazymys = 0;
            do
            {
                Console.WriteLine("Iveskite pazymi kai noresi baigti iveskite 0");
                pazymys = Convert.ToInt32(Console.ReadLine());
                if (pazymys != 0)
                {
                    pazymiai.Add(pazymys);
                }
            } while (pazymys != 0);
            Console.WriteLine("Visu pazymiu suma: " + pazymiai.Sum());
            Console.WriteLine("Visu pazymiu vidurkis: " + pazymiai.Average());
            Console.WriteLine("Didziausias pazymys: " + pazymiai.Max());
            Console.WriteLine("Maziausias pazymys: " + pazymiai.Min());
            Console.WriteLine("Pirmas ivestas pazymys: " + pazymiai.First());
            Console.WriteLine("Paskutinis ivestas pazymys: " + pazymiai.Last());
            Console.WriteLine("Ivestu pazymiu kiekis: " + pazymiai.Count);
        }
    }
}