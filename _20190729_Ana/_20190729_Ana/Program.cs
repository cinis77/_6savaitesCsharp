using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190729_Ana
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            int sk = Convert.ToInt32(Console.ReadLine());
            for (int i = sk; i > 0; i--)
            {
                if (ArTvarkingasSkacius(i))
                {
                    Console.WriteLine("Didziausias tvarkingas skaicius: " + i);
                    break;
                }
            }
        }

        private static bool ArTvarkingasSkacius(int skaiciu)
        {
            int pask = skaiciu % 10;
            int priepask = (skaiciu / 10) % 10;
            if (pask >= priepask)
            {
                //skaicius dar tvarkingas
                if (skaiciu >= 9)
                {
                    return ArTvarkingasSkacius(skaiciu / 10);
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
    }
}