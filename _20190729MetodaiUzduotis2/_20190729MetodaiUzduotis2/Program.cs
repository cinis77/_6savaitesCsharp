using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190729MetodaiUzduotis2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Pasisveikinti();
            Console.WriteLine("Iveskite varda");
            string vardas = Console.ReadLine();
            Console.WriteLine("Iveskite amziu");
            int amzius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite savo hobi");
            string hobis = Console.ReadLine();
            TekstoFormatavima(vardas, amzius, hobis);
            TekstoFormatavima(vard: vardas, hob: hobis, amzi: amzius);
            DateTime date = new DateTime(year: 2015, day: 26, month: 5);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="vard"> Cia reikia pateikti vartotojo ivesta varda</param>
        /// <param name="amzi"></param>
        /// <param name="hob"></param>
        private static void TekstoFormatavima(string vard, int amzi, string hob)
        {
            Console.WriteLine("Jusu vardas yra {0}, amzius {1}" +
                ", o hobio pavadinimas {2}", vard, amzi, hob);
        }

        private static void Pasisveikinti()
        {
            Console.WriteLine("Labas Pasauli!");
        }
    }
}