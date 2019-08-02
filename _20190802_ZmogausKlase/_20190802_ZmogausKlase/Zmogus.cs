using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190802_ZmogausKlase
{
    internal class Zmogus
    {
        public string Vardas { get; }
        public string Pavarde { get; private set; }
        public DateTime GimimoData { get; }
        private GyvenamojiVieta Gyvenviete { get; set; }
        private Darbas DarboViete { get; set; }

        public Zmogus(string vardas, string pavarde, DateTime gimimoData)
        {
            Vardas = vardas;
            Pavarde = pavarde;
            GimimoData = gimimoData;
        }

        public int KiekMetu()
        {
            return DateTime.Today.Year - GimimoData.Year;
        }

        public void NaujasDarbas(Darbas darboVieta)
        {
            if (KiekMetu() >= 18)
            {
                DarboViete = darboVieta;
            }
            else
            {
                Console.WriteLine("Per jaunas dirbti");
            }
        }

        public void NaujaGyvenamojiVieta(GyvenamojiVieta gyvenu)
        {
            Gyvenviete = gyvenu;
        }

        public void KurGyvenu()
        {
            Console.WriteLine("Gyvenu " + Gyvenviete.Gatve + " "
                + Gyvenviete.NamoNr + " Miestas " + Gyvenviete.Miestas
                + " Salis " + Gyvenviete.Salis);
        }

        public void KurDirbuDabar()
        {
            if (KiekMetu() >= 18)
            {
                Console.WriteLine("Dirbu imoneje " + DarboViete.Pavadinimas);
            }
            else
            {
                Console.WriteLine("Per jaunas dirbti");
            }
        }

        public void Prisistatymas()
        {
            Console.WriteLine("Mano vardas {0}, pavarde{1}, amzius {2}",
                Vardas, Pavarde, KiekMetu());
            KurGyvenu();
            KurDirbuDabar();
        }
    }
}