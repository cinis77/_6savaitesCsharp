using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190801_vartotojai
{
    internal class Nuskaitymas
    {
        public readonly List<Vartotojas> Vartotojai;
        private string path;

        public Nuskaitymas(string kelias)
        {
            path = kelias;
            Vartotojai = new List<Vartotojas>();
        }

        public void Skaitom()
        {
            System.IO.StreamReader reader = new System.IO.StreamReader(path);
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] data = line.Split(';');
                Vartotojas registruotasVartotojas = new Vartotojas(data[0], data[1]);
                Vartotojai.Add(registruotasVartotojas);
            }
        }
    }
}