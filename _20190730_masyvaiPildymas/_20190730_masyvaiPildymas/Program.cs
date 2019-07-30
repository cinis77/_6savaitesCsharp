using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190730_masyvaiPildymas
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] masyvas = new int[7];
            for (int i = 0; i < masyvas.Length; i++)
            {
                Console.WriteLine("Iveskite skaiciu");
                masyvas[i] = Convert.ToInt32(Console.ReadLine());
            }

            int max = int.MinValue;
            int min = int.MaxValue;
            int kelintasMax = -1;
            int kelintasMin = -1;

            for (int i = 0; i < masyvas.Length; i++)
            {
                //Didziausio skaiciaus radimas
                if (masyvas[i] > max)
                {
                    max = masyvas[i];
                    kelintasMax = i;
                }
                //Maziausio skaiciaus radimas
                if (masyvas[i] < min)
                {
                    min = masyvas[i];
                    kelintasMin = i;
                }
            }

            Console.WriteLine("Didziausias skaicius yra: {0}, jo reiksme {1}", kelintasMax, max);
            Console.WriteLine("Maziausias skaicius yra: {0}, jo reiksme {1}", kelintasMin, min);
        }
    }
}