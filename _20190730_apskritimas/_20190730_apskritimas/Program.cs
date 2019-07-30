using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190730_apskritimas
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] X = new int[10];
            int[] Y = new int[10];

            Random rng = new Random();
            for (int i = 0; i < X.Length; i++)
            {
                X[i] = rng.Next(-10, 10);
                Y[i] = rng.Next(-10, 10);
            }

            Console.WriteLine("Iveskite X centro koordinate");
            int xc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite y centro koordinate");
            int yc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite apskritimo spinduli");
            int R = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < X.Length; i++)
            {
                double D = Math.Sqrt(Math.Pow(xc - X[i], 2) + Math.Pow(yc - Y[i], 2));
                if (R >= D)
                {
                    Console.WriteLine("Taskas priklauso ({0},{1})", X[i], Y[i]);
                }
            }

            int sk = 1;
            int sk2 = 10;
            Method(ref sk, ref sk2);
            Console.WriteLine(sk + " " + sk2);
        }

        private static void Method(ref int a, ref int b)
        {
            a += 5;
            b += 10;
        }
    }
}