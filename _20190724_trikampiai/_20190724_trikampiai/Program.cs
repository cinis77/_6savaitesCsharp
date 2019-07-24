using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190724_trikampiai
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite skaiciu");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite skaiciu");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a + b > c)
            {
                if (a + c > b)
                {
                    if (b + c > a)
                    {
                        Console.WriteLine("Trikampi sudaryti imanoma");
                    }
                    else
                    {
                        Console.WriteLine("Trikampis nesusidarys");
                    }
                }
                else
                {
                    Console.WriteLine("Trikampis nesusidarys");
                }
            }
            else
            {
                Console.WriteLine("Trikampis nesusidarys");
            }

            if (a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("Trikampi sudaryti imanoma");
            }
            else
            {
                Console.WriteLine("Trikampis nesusidarys");
            }

            bool ab = a + b > c;
            bool ac = a + c > b;
            bool bc = b + c > a;
            if (ab && ac && bc)
            {
                Console.WriteLine("Trikampi sudaryti imanoma");
            }
            else
            {
                Console.WriteLine("Trikampis nesusidarys");
            }
        }
    }
}