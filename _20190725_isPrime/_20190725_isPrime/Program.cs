using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190725_isPrime
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int suma = 0;
            for (int i = 2; i < 1000; i++)
            {
                bool sudetinisSkaicius = false;
                for (int j = 2; j < i - 1; j++)
                {
                    if (i % j == 0)
                    {
                        sudetinisSkaicius = true;
                        break;
                    }
                }
                if (!sudetinisSkaicius)
                {
                    suma += i;
                }
            }
            Console.WriteLine(suma);
        }
    }
}