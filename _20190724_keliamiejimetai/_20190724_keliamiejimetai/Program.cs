using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190724_keliamiejimetai
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Iveskite metus");
            int metai = Convert.ToInt32(Console.ReadLine());
            bool Ar4Kartotinis = (metai % 4) == 0;
            if (Ar4Kartotinis)
            {
                if ((metai % 100) == 0)
                {
                    if ((metai % 400) == 0)
                    {
                        Console.WriteLine("Metai yra keliamieji");
                    }
                    else
                    {
                        Console.WriteLine("Metai nera keliamieji");
                    }
                }
                else
                {
                    Console.WriteLine("Metai yra keliamieji");
                }
            }
            else
            {
                Console.WriteLine("Metai nera keliamieji");
            }
        }
    }
}