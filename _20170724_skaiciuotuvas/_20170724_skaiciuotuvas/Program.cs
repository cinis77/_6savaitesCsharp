using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20170724_skaiciuotuvas
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite zenkla");
            char zenklas = Convert.ToChar(Console.ReadKey().KeyChar);
            Console.WriteLine("\nIveskite skaiciu");
            int b = Convert.ToInt32(Console.ReadLine());
            if (zenklas == '+')
            {
                int suma = a + b;
                Console.WriteLine("Suma: " + suma);
            }
            else if (zenklas == '-')
            {
                int skirtumas = a - b;
                Console.WriteLine("Skirtumas yra: " + skirtumas);
            }
            else if (zenklas == '*')
            {
                int sandauga = a * b;
                Console.WriteLine("Sandauga yra: " + sandauga);
            }
            else if (zenklas == '/')
            {
                if (b != 0)
                {
                    double dalmuo = (double)a / b;
                    Console.WriteLine("Dalmuo yra: " + dalmuo);
                }
                else
                {
                    Console.WriteLine("Dalyba is 0 negalima");
                }
            }
            else
            {
                Console.WriteLine("Klaidingai ivestas zenklas");
            }
        }
    }
}