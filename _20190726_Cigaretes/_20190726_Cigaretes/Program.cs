using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190726_Cigaretes
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /// Kaina => pakelio cigareciu kaina
            /// D => suruko per diena
            /// Kiekis => Pakelyje esanciu cigareciu kiekis
            /// ekstra => surukoma daugiau cigareciu per metus
            /// suma += (Kaina/Kiekis)*D *365
            /// D += Ekstra
            Console.WriteLine("Iveskite pakelio cigareciu kaina");
            double Kaina = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kiek cigareciu surukoma per diena");
            int D = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kiek cigerciu yra pakelyje");
            int Kiekis = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Po metu kiek daugiau surukoma per diena cigareciu");
            int ektra = Convert.ToInt32(Console.ReadLine());
            double suma = 0;
            for (int i = 0; i < 5; i++)
            {
                suma += (Kaina / Kiekis) * D * 365;
                Console.WriteLine("{0} metus isleista pinigu "
                    + ((Kaina / Kiekis) * D * 365).ToString("F2"), i);

                D += ektra;
            }
            Console.WriteLine("Isviso isleista pinigu: " + suma.ToString("F2"));
        }
    }
}