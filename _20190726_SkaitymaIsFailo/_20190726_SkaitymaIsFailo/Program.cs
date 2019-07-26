using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190726_SkaitymaIsFailo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string path = @"C:\Users\User\Documents\SkaitomasFailas.txt";
            System.IO.StreamReader reader = new System.IO.StreamReader(path);
            string line = null;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
}