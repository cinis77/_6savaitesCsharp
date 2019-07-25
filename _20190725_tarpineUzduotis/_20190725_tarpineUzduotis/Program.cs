using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190725_tarpineUzduotis
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Iveskite kiek darbuotojas iskepa kepalu per valanda");
            double kpv = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite darbuotoju kieki kepykloje");
            int darbK = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite kepalo savikaina");
            double savikaina = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kepalo pardavimo kaina");
            double kaina = Convert.ToDouble(Console.ReadLine());
            var perDiena = kpv * darbK * 8;
            var savikainaPilna = perDiena * savikaina;
            var pajamos = perDiena * kaina;
            var pelnas = pajamos - savikainaPilna;
            Console.WriteLine("Per diena iskepama {0} kepalu, kuriu savikaina {1}"
                + " visos gaunamos pajamos yra {2}, imones perlnas {3}", perDiena, savikainaPilna, pajamos, pelnas);
        }
    }
}