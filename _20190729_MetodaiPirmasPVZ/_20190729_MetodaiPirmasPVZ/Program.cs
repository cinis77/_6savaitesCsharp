using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190729_MetodaiPirmasPVZ
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Program p = new Program(); // => new Program()
            p.Pasisveikinti();
            Program.Pasisveikint(); // => Singleton design pattern
            IsvedimasIConsoleLanga("Programa pradejo darba");
            IsvedimasIConsoleLanga("Trecia programos eilute");
            string txt = "Tekstas is kintamojo";
            IsvedimasIConsoleLanga(txt);
        }

        /// <summary>
        /// Metodas kuris spausdina i konsole langa inforamcija
        /// </summary>
        /// <param name="tekstas">Parametras arba tekstas kuris bus atvaizduojamas</param>
        private static void IsvedimasIConsoleLanga(string tekstas)
        {
            Console.WriteLine(tekstas);
        }

        private void Pasisveikinti()
        {
            Console.WriteLine("Labas");
        }

        private static void Pasisveikint()
        {
            Console.WriteLine("Ola");
        }
    }
}