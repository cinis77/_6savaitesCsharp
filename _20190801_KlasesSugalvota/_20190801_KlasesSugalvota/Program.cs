using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190801_KlasesSugalvota
{
    internal class SportoSaka
    {
        public int Dalyviai;
        public string Ziurovai;
        public string Pavadinimas { get; }
        public bool ArReikiaKamuolio { get; set; }
        public string MetuLaikas { get; private set; }
        public string Vieta;

        /// <summary>
        ///
        /// </summary>
        /// <param name="pavadinimas"></param>
        /// <param name="arReikiaKamuoliu"></param>
        /// <param name="MetuLaikas"></param>
        public SportoSaka(string pavadinimas,
            bool arReikiaKamuoliu, string MetuLaikas)
        {
            Pavadinimas = pavadinimas;
            ArReikiaKamuolio = arReikiaKamuoliu;
            this.MetuLaikas = MetuLaikas;
        }

        public SportoSaka(string pavadinimas)
        {
            Pavadinimas = pavadinimas;
        }

        public SportoSaka()
        {
        }

        public void Zaisti()
        {
            Console.WriteLine("Zaidziam");
        }

        public void ArGalimaZaisti()
        {
            string KoksDabarMetuLaikas = null;
            if (DateTime.Today.Month == 12
                || DateTime.Today.Month == 1
                || DateTime.Today.Month == 2)
            {
                KoksDabarMetuLaikas = "Ziema";
            }
            else if (DateTime.Today.Month == 3
                || DateTime.Today.Month == 4
                || DateTime.Today.Month == 5)
            {
                KoksDabarMetuLaikas = "Pavasaris";
            }
            else if (DateTime.Today.Month == 6
                || DateTime.Today.Month == 7
                || DateTime.Today.Month == 8)
            {
                KoksDabarMetuLaikas = "Vasara";
            }
            else
            {
                KoksDabarMetuLaikas = "Ruduo";
            }

            if (KoksDabarMetuLaikas.ToLower() == MetuLaikas.ToLower())
            {
                Console.WriteLine("Zaisti galim");
            }
            else
            {
                Console.WriteLine("Zaisti negalima");
            }
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            SportoSaka krepsinis = new SportoSaka("Krepsinis", true, "vasara");
            krepsinis.ArGalimaZaisti();
            SportoSaka futbolas = new SportoSaka("Futbolas");
        }
    }
}