using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190802_ZmogausKlase
{
    internal class Darbas
    {
        public string Pavadinimas { get; private set; }
        public int ZmoniuSk { get; private set; }
        public DateTime IkurimoData { get; }

        public Darbas(string pavadinimas, int pirminisDarbuotojuSK, DateTime ikurimoData)
        {
            Pavadinimas = pavadinimas;
            ZmoniuSk = pirminisDarbuotojuSK;
            IkurimoData = ikurimoData;
        }

        public void PriimtasZmogus()
        {
            ZmoniuSk++;
        }

        public void AtleistasZmogus()
        {
            ZmoniuSk--;
        }
    }
}