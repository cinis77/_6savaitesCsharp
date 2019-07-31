using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190731_masyvaiSuskaiciavimasMasyvoIlgio
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            int sk = Convert.ToInt32(Console.ReadLine());
            //------------------------------
            int masyvoIlgis = 0;
            int skaicius = 1;
            //------------------------------
            while (skaicius < sk)
            {
                masyvoIlgis++;
                Console.WriteLine(skaicius);
                skaicius *= (2); // Math.Pow(2,masyvoIlgis)
            }
            Console.WriteLine(masyvoIlgis);
            int[] masyvas = new int[masyvoIlgis];
            skaicius = 1;

            for (int i = 0; i < masyvas.Length; i++)
            {
                masyvas[i] = skaicius;
                skaicius *= 2;
            }

            foreach (var item in masyvas)
            {
                Console.WriteLine(item);
            }
        }
    }
}