using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190802_paveldincioKlasesPavyzdys
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Automobilis auto = new Automobilis("Ferrari");
            Laivas laivas = new Laivas("SAAB");
            List<Transportas> transportai = new List<Transportas>();
            transportai.Add(auto);
            transportai.Add(laivas);
            Transportas tran = new Transportas("A");
            tran = auto;
            foreach (var transportas in transportai)
            {
                transportas.Judejimas();
            }
        }
    }
}