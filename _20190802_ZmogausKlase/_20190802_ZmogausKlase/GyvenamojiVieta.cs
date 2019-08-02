using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190802_ZmogausKlase
{
    internal class GyvenamojiVieta
    {
        public string Gatve { get; }
        public string Miestas { get; }
        public int NamoNr { get; private set; }
        public string Salis { get; }

        public GyvenamojiVieta(string gatve, string miestas, int namoNr, string Salis)
        {
            Gatve = gatve;
            Miestas = miestas;
            NamoNr = namoNr;
            this.Salis = Salis;
        }
    }
}