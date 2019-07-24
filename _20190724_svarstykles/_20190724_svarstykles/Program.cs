using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190724_svarstykles
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int sk1 = 2;
            int sk2 = 2;
            int sk3 = 2;
            int sk4 = 2;
            int sk5 = 2;
            int sk6 = 2;
            int sk7 = 2;
            int sk8 = 2;

            if (sk1 + sk2 + sk3 < sk4 + sk5 + sk6)
            {
                if (sk1 < sk2)
                {
                    Console.WriteLine("Brokuotas yra pirmasis");
                }
                else if (sk1 > sk2)
                {
                    Console.WriteLine("Brokuotas yra antrasis");
                }
                else
                {
                    Console.WriteLine("Brokuotas yra treciasis");
                }
            }
            else if (sk1 + sk2 + sk3 > sk4 + sk5 + sk6)
            {
                if (sk4 < sk5)
                {
                    Console.WriteLine("Brokuotas yra ketvirtasis");
                }
                else if (sk4 > sk5)
                {
                    Console.WriteLine("Brokuotas yra penktasis");
                }
                else
                {
                    Console.WriteLine("Brokuotas yra sestasis");
                }
            }
            else
            {
                if (sk7 < sk8)
                {
                    Console.WriteLine("Brokuotas yra septintasis");
                }
                else
                {
                    Console.WriteLine("Brokuotas yra astuntasis");
                }
            }
        }
    }
}