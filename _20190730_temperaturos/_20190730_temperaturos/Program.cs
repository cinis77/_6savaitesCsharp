using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190730_temperaturos
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Iveskite kiek duomenu noretumete suvesti");
            int kiek = Convert.ToInt32(Console.ReadLine());
            double[] M = new double[kiek];
            for (int i = 0; i < M.Length; i++)
            {
                Console.WriteLine("Iveskite temperatura");
                M[i] = Convert.ToDouble(Console.ReadLine());
            }

            double max = double.MinValue;
            double min = double.MaxValue;

            double sumaVisu = 0;
            foreach (var item in M)
            {
                if (max < item)
                {
                    max = item;
                }

                if (min > item)
                {
                    min = item;
                }

                sumaVisu += item; // => sumaVisu = sumaVisu + item
            }

            Console.WriteLine("Maziausias skaicius yra: "
                 + min);
            Console.WriteLine("Didziausias skaicius yra: " + max);

            Console.WriteLine("Vidurkis yra: " + sumaVisu / M.Length);
            double mazesniuVSuma = 0;
            foreach (var item in M)
            {
                if (item < sumaVisu / M.Length)
                {
                    mazesniuVSuma += item;
                }
            }
            Console.WriteLine("Mazesniu nei vidurkis suma: " + mazesniuVSuma);
        }
    }
}