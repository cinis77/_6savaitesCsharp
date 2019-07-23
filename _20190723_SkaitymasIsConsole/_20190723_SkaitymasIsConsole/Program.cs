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
            Console.ReadKey();
        }
    }
}