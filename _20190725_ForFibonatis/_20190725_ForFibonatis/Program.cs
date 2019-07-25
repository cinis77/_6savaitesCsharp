using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190725_ForFibonatis
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Iveskite kiek norite matyti fibonacio sekos nariu");
            int n = Convert.ToInt32(Console.ReadLine());
            int sk = 1;
            int sk1 = 1;
            Console.Write(sk + ", " + sk1 + ", ");
            for (int i = 2; i < n; i++)
            {
                int sk3 = sk + sk1;
                Console.Write(sk3 + ", ");
                sk = sk1;
                sk1 = sk3;
            }
        }
    }
}