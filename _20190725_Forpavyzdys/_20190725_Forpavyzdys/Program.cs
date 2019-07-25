using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190725_Forpavyzdys
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            for (int i = 0; i < 20; i += 3)
            {
                Console.WriteLine(i);
            }

            int sandauga = 1;
            for (int i = 7; i < 100; i++)
            {
                if (i % 7 == 0)
                {
                    sandauga *= i; // sandauga = sandauga * i
                }
            }
            Console.WriteLine(sandauga);
        }
    }
}