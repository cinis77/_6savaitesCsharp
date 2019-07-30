using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190730_MasyvaiPirmas
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] masyvas = { 8, 7, 3, 5, -5, 80, 100, 66, 58, 45 };
            Random rng = new Random();
            Console.WriteLine("Masyvo ilgis: " + masyvas.Length);
            Console.WriteLine("Pirmas masyvo elementas: " + masyvas[0]);
            Console.WriteLine("Paskutinis masyvo elementas: " + masyvas[masyvas.Length - 1]);
            Console.WriteLine("Betkuris masyvo elementas yra: "
                + masyvas[rng.Next(0, masyvas.Length)]);
            int[] M = new int[6];
            M[0] = 65;
            M[1] = 48;
            M[2] = -68;
            M[3] = 100;
            M[4] = 6;
            M[5] = 78;
            for (int i = 0; i < M.Length; i++)
            {
                Console.WriteLine(M[i]);
            }
        }
    }
}