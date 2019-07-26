using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190726_zaidimas
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Zaidimas sugalvok skaiciu o as atspesiu");
            Console.WriteLine("Sugalvokite skaiciu nuo 1 iki 3000 ir paspauskite enter");
            Console.ReadKey();
            int min = 1;
            int max = 3000;
            int spejimas = (min + max) / 2;
            Console.WriteLine("Ar tai yra: " + spejimas);
            Console.WriteLine("Jei atspejau parasyti atspejai, jei maziau"
                + " parasyti maziau jei daugiau parasyti daugiau");
            string atsakymas = Console.ReadLine();
            while (atsakymas.ToLower() != "atspejai")
            {
                if (atsakymas.ToLower() == "daugiau")
                {
                    min = spejimas;
                }
                else if (atsakymas.ToLower() == "maziau")
                {
                    max = spejimas;
                }
                else
                {
                    Console.WriteLine("Nesupratau atsakymo");
                }
                spejimas = (min + max) / 2;
                Console.WriteLine("Ar tai yra: " + spejimas);
                Console.WriteLine("Jei atspejau parasyti atspejai, jei maziau"
                    + " parasyti maziau jei daugiau parasyti daugiau");
                atsakymas = Console.ReadLine();
            }
            Console.WriteLine("ATSPEJAU skaicius " + spejimas);
        }
    }
}