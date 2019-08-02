using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190802_Vartotojai
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            SilverVartotojas silverVartotojas = new SilverVartotojas();
            SuperVartotojas superVartotojas = new SuperVartotojas();
            Basic basic = new Basic();
            List<Vartotojas> vartotojai = new List<Vartotojas>
            { silverVartotojas, superVartotojas, basic };
            foreach (var item in vartotojai)
            {
                Console.WriteLine(item.SkaiciuotiSuma(100));
            }
        }
    }
}