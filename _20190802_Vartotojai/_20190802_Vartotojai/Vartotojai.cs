using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190802_Vartotojai
{
    internal class Vartotojas
    {
        public int ID { get; set; }
        public string Vardas { get; set; }

        public virtual double SkaiciuotiSuma(double suma)
        {
            return suma;
        }
    }

    internal class SuperVartotojas : Vartotojas
    {
        public override double SkaiciuotiSuma(double suma)
        {
            return base.SkaiciuotiSuma(suma) * 0.7;
        }
    }

    internal class SilverVartotojas : Vartotojas
    {
        public override double SkaiciuotiSuma(double suma)
        {
            return base.SkaiciuotiSuma(suma) * 0.9;
        }
    }

    internal class Basic : Vartotojas
    {
    }
}