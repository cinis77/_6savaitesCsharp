using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190724_KeturzenklisSkaicius
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Iveskite keturzenkli skaiciu");
            int sk = Convert.ToInt32(Console.ReadLine());
            int tukst = sk / 1000;
            int simt = (sk / 100) % 10;
            int desimt = (sk / 10) % 10;
            int vnt = sk % 10;
            Console.WriteLine("Atvirkscias skaicius yra: "
                + vnt.ToString() + desimt.ToString() + simt.ToString() + tukst.ToString());
        }
    }
}