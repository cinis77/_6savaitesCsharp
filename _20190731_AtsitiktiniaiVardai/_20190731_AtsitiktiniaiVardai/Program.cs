using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190731_AtsitiktiniaiVardai
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] varduMasyvas = {"Rokas", "Liucija", "Petras", "Ursule"
                    , "Tomas", "Jone", "Jokubas", "Luka"};
            Random rng = new Random();
            List<string> VarduSarasas = new List<string>();
            for (int i = 0; i < rng.Next(); i++)
            {
                VarduSarasas.Add(varduMasyvas[rng.Next(0, varduMasyvas.Length)]);
            }

            foreach (var item in VarduSarasas)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(VarduSarasas.Count);
        }
    }
}