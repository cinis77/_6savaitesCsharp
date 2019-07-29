using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190729_MetodasIntGrazina
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int rastaSuma = Suma(20, 15);
            Console.WriteLine(rastaSuma);
        }

        private static int Suma(int a, int b)
        {
            int suma = 0;
            suma = a + b;
            return suma;
        }

        private static int Skirtumas(int a, int b)
        {
            return a - b;
        }

        private static int Daugyba(int a, int b)
        {
            int daugyba = a * b;
            return daugyba;
        }

        private static double Dalyba(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Dalyba is 0 negalima");
                return 0;
            }
            else
            {
                return (double)a / b;
            }
        }
    }
}