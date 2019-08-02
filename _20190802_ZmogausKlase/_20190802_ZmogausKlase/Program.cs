using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190802_ZmogausKlase
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Zmogus pirmas = new Zmogus("Adomas", "Adomaitis",
                new DateTime(year: 1986, month: 12, day: 14));
            GyvenamojiVieta gyvenamojiVieta = new GyvenamojiVieta("Lozoraicio", "Vilnius", 14, "Lietuva");
            pirmas.NaujaGyvenamojiVieta(gyvenamojiVieta);
            Darbas darbas = new Darbas("SEB", 5000, new DateTime(1999, 10, 06));
            pirmas.NaujasDarbas(darbas);
            pirmas.Prisistatymas();

            Zmogus antras = new Zmogus(vardas: "Tomas", pavarde: "Tomaitus",
                gimimoData: new DateTime(year: 2009, month: 10, day: 08));
            antras.NaujaGyvenamojiVieta(new GyvenamojiVieta("Vilniaus", "Kaunas", 2, "D"));
            antras.Prisistatymas();
        }
    }
}