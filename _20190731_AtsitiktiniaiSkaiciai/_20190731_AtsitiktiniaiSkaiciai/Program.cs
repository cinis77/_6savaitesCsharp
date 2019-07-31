using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190731_AtsitiktiniaiSkaiciai
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Random rng = new Random();
            int skaiciuKiekis = rng.Next(100, 100000);
            List<int> skaiciai = new List<int>();
            for (int i = 0; i < skaiciuKiekis; i++)
            {
                skaiciai.Add(rng.Next(-100000, 100000));
            }

            Console.WriteLine("Visu skaiciu suma: " + skaiciai.Sum());
            Console.WriteLine("Visu skaiciu vidurkis: " + skaiciai.Average());
            Console.WriteLine("Didziausias skaicius: " + skaiciai.Max());
            Console.WriteLine("Maziausias skaicius: " + skaiciai.Min());
            Console.WriteLine("Elementu kiekis: " + skaiciai.Count);

            List<int> A = new List<int> { 1, 2, 3, 4, 5 };
            List<int> B = new List<int>();
            B = A;
            A.Clear();
            foreach (var item in B)
            {
                Console.WriteLine(item);
            }
        }
    }
}