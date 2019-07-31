using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190731_KordensioSkaiciai
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            int sk = Convert.ToInt32(Console.ReadLine());
            int tikrasSkaicius = sk;
            List<int> skaiciai = new List<int>();
            while (sk > 0)
            {
                skaiciai.Add(sk % 10);
                sk /= 10;
            }
            int factorialuSuma = 0;
            foreach (var item in skaiciai)
            {
                int factorialas = 1;
                for (int i = item; i >= 1; i--)
                {
                    factorialas *= i;
                }
                factorialuSuma += factorialas;
            }

            if (tikrasSkaicius == factorialuSuma)
            {
                Console.WriteLine("Koderskio skaicius");
            }
            else
            {
                Console.WriteLine("cia ne Koderskio skaicius");
            }
        }
    }
}