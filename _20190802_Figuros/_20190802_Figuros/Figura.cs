using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190802_Figuros
{
    internal abstract class Figura
    {
        public abstract void Plotas();
    }

    internal class Trikampis : Figura
    {
        public override void Plotas()
        {
            Console.WriteLine("1/2 * a* b");
        }
    }

    internal class Staciakampos : Figura
    {
        public override void Plotas()
        {
            Console.WriteLine("a*b");
        }
    }
}