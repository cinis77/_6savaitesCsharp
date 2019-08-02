using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190802_paveldincioKlasesPavyzdys
{
    internal class Automobilis : Transportas
    {
        public string Marke { get; }
        public string Klase { get; set; }

        public Automobilis(string gamintojas) : base(gamintojas)
        {
            Gamintojas = "Ferari";
        }

        public override void Judejimas()
        {
            Console.WriteLine("Vaziuoju");
        }
    }
}