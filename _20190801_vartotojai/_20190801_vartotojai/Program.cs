using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190801_vartotojai
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Nuskaitymas skaitymas = new Nuskaitymas(@"C:\Users\User\Documents\vartotojusarasas.csv");
            skaitymas.Skaitom();
            List<Vartotojas> vartotojai = skaitymas.Vartotojai;
            Console.Write("Iveskite vartotojo varda: ");
            string login = Console.ReadLine();
            Console.Write("Iveskite slaptazodi: ");
            string psw = Console.ReadLine();
            foreach (var vartotojas in vartotojai)
            {
                if (vartotojas.Prisijungti(login, psw))
                {
                    Console.WriteLine("Jus prisijungete");
                }
            }
        }
    }
}