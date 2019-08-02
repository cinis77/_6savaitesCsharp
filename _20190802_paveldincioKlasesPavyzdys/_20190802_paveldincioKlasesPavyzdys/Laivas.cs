using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190802_paveldincioKlasesPavyzdys
{
    internal class Laivas : Transportas
    {
        public string Tipas { get; }

        public Laivas(string gamintojas) : base(gamintojas)
        {
            Gamintojas = "SAAB";
        }

        public override void Judejimas()
        {
            base.Judejimas();
            Console.WriteLine("Cia buvo laivas");
        }
    }
}