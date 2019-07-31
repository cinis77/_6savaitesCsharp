using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190731_prezidentoRinkimai
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Iveskite kandidatus");

            string kandidatai = Console.ReadLine();
            string[] kandidatuMasyvas = kandidatai.Split(' ');
            string kandidatas = kandidatuMasyvas[0];
            char[] raides = kandidatas.ToCharArray();
            foreach (var item in raides)
            {
                Console.WriteLine(item);
            }

            int max = int.MinValue;
            int laimetojas = -1;

            for (int i = 0; i < kandidatuMasyvas.Length; i++)
            {
                int unikaliosRaides = KiekYraUnikaliuRaidziu(kandidatuMasyvas[i].
                    ToLower().ToCharArray());
                if (unikaliosRaides > max)
                {
                    max = unikaliosRaides;
                    laimetojas = i;
                }
            }

            Console.WriteLine("Prezidentu tapo: " + kandidatuMasyvas[laimetojas]);
        }

        private static int KiekYraUnikaliuRaidziu(char[] raides)
        {
            int unikaliuRaidziuKiekis = 0;
            for (int i = 0; i < raides.Length; i++)
            {
                bool unikali = true;
                for (int j = i + 1; j < raides.Length; j++)
                {
                    if (raides[i] == raides[j])
                    {
                        //Kartojasi raide
                        unikali = false;
                        break;
                    }
                }

                if (unikali)
                {
                    unikaliuRaidziuKiekis++;
                }
            }

            return unikaliuRaidziuKiekis;
        }
    }
}