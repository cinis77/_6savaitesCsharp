using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190801_kortos
{
    internal class Korta
    {
        public string Tipas { get; }
        public string Skaicius { get; }
        public string Spalva { get; }

        public Korta(string tipas, string skaicius)
        {
            Tipas = tipas;
            Skaicius = skaicius;
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Random rng = new Random();
            string[] tipai = { "Š", "P", "K", "B" };
            List<Korta> kalade = new List<Korta>();
            int i = 0;
            while (i < 52)
            {
                Korta korta = new Korta(tipai[rng.Next(0, tipai.Length)], rng.Next(1, 14).ToString());
                bool unikali = true;
                foreach (var item in kalade)
                {
                    if (item.Tipas == korta.Tipas
                        && item.Skaicius == korta.Skaicius)
                    {
                        unikali = false;
                        break;
                    }
                }
                if (unikali)
                {
                    kalade.Add(korta);
                    i++;
                }
            }

            foreach (var korta in kalade)
            {
                Console.WriteLine(korta.Tipas + " " + korta.Skaicius);
            }
        }
    }
}