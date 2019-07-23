using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190723Pirmas
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("To Do sąrašas: ");
            Console.WriteLine("1. Išnešti šiūkšles");
            Console.WriteLine("2. Nupirkti pieno");
            Console.WriteLine("3. Pavedžioti šunį");

            string Vardas = "Dominykas";
            string Pavarde = "Pavarde";
            int Amzius = 27;

            Console.WriteLine("{0} {1} ({2} m.)", Vardas, Pavarde, Amzius);
            Console.WriteLine(Vardas + " " + Pavarde + " (" + Amzius + " m.)");
            Console.WriteLine("Jo u{0} ");
        }
    }
}