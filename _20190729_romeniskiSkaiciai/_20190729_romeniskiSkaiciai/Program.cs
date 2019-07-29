using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190729_romeniskiSkaiciai
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu nuo 1 iki 1000");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            if (skaicius == 1000)
            {
                Console.WriteLine("M");
            }
            else
            {
                int simtai = skaicius / 100;
                int desimtys = (skaicius / 10) % 10;
                int vnt = skaicius % 10;
                string atsakymas = vienetai(simtai, "C", "D", "M")
                    + vienetai(desimtys, "X", "L", "C")
                    + vienetai(vnt, "I", "V", "X");
                Console.WriteLine(atsakymas);
            }
        }

        private static string vienetai(int sk, string vienetas, string penketas, string desimt)
        {
            if (sk == 4)
            {
                return vienetas + penketas;
            }
            else if (sk == 9)
            {
                return vienetas + desimt;
            }
            else
            {
                int penki = sk / 5;
                int vien = sk % 5;
                string atsakymas = "";
                if (penki != 0)
                {
                    atsakymas += penketas;
                }
                for (int i = 0; i < vien; i++)
                {
                    atsakymas += vienetas;
                }
                return atsakymas;
            }
        }
    }
}