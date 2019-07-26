using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190726_WhileIzdas
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Pradinis izdas:");
            int izdas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kiek padideja izdas per diena");
            int plus = Convert.ToInt32(Console.ReadLine());
            int naktis = 1;
            int naktis1 = 1;
            int kiekNaktu = 2;
            izdas += 2 * plus - 2;
            while (izdas > 0)
            {
                int sumoketi = naktis + naktis1;
                izdas += plus - sumoketi;
                naktis = naktis1;
                naktis1 = sumoketi;
                kiekNaktu++;
            }
            Console.WriteLine("Pinigai baigsis: " + kiekNaktu);
        }
    }
}