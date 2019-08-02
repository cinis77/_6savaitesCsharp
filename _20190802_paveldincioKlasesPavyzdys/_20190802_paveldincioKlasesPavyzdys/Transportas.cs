using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190802_paveldincioKlasesPavyzdys
{
    internal class Transportas
    {
        public string Gamintojas;
        public string Varuotojas;
        public DateTime PagaminoMetai { get; }
        public int SerijinisNumeris { get; }
        public int Svoris { get; set; }

        public Transportas(string gamintojas)
        {
            Gamintojas = gamintojas;
        }

        public virtual void Judejimas()
        {
            Console.WriteLine("Juda transportas");
        }
    }
}