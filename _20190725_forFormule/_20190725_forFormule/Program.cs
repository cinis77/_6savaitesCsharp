using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190725_forFormule
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            for (int x = -10; x <= 10; x++)
            {
                double ats = Math.Pow(x, 3) - ((double)1 / 8) * Math.Pow(x, 2)
                    + ((double)106 / 6) * x + 9;
                Console.WriteLine(ats.ToString("F3"));
            }
        }
    }
}