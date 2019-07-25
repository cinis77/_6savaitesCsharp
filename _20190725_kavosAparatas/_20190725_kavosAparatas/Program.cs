using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190725_kavosAparatas
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Bing bang kavos aparatas");
            Console.WriteLine("Galimi pasirinkimai:");
            Console.WriteLine("  1- limonadas");
            Console.WriteLine("  2- arbata");
            Console.WriteLine("  3- kakava");
            Console.WriteLine("  4- kava");
            Console.WriteLine("  5- nieko");
            var pasirinkimas = Convert.ToInt32(Console.ReadLine());

            switch (pasirinkimas)
            {
                case 1:
                    Console.WriteLine(" - jusu pasirinkimas yra limonadas");
                    break;

                case 2:
                    Console.WriteLine(" - jusu pasirinkimas yra arbata");
                    break;

                case 3:
                    Console.WriteLine(" - jusu pasirinkimas yra kakava");
                    break;

                case 4:
                    Console.WriteLine(" - jusu pasirinkimas yra kava");
                    break;

                case 5:
                    Console.WriteLine(" - jusu pasirinkimas yra nieko");
                    break;

                default:
                    Console.WriteLine("  - Nezinommas pasirinkimas");
                    break;
            }
        }
    }
}