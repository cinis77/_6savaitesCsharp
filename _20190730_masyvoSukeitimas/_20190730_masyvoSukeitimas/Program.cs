using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190730_masyvoSukeitimas
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] A = { -5, -100, -54, -68, -71 };
            int[] B = { 29, 74, 31, 52, 22 };
            for (int i = 1; i < A.Length; i += 2)
            {
                int laikinas = A[i];
                A[i] = B[i];
                B[i] = laikinas;
            }
            //----------------------------
            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine("A: {0}, B: {1}", A[i], B[i]);
            }

            foreach (var item in A)
            {
                Console.WriteLine(item);
            }
        }
    }
}