using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190723_SkaitymasIsConsole
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Įveskite tekstą: ");
            string tekstasIšVartotojo = Console.ReadLine();
            Console.WriteLine("Jūsų įvestas tekstas yra: ");
            Console.WriteLine(tekstasIšVartotojo);

            Console.WriteLine("Iveskite savo varda: ");
            string Vardas = Console.ReadLine();
            Console.WriteLine("Iveskite pirmos megiamiausios splavos raide");
            char raide = Convert.ToChar(Console.ReadKey().KeyChar);
            Console.WriteLine("\nIveskite skaiciu");
            int sk = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite skaiciu");
            int sk1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Jusu vardas yra: {0}, megiamiausios"
                + " spalvos pirma raide {1} ivesti atsitiktiniai"
                + " skaiciai yra: {2}, {3}", Vardas, raide, sk, sk1);

            Console.ReadKey();
        }
    }
}