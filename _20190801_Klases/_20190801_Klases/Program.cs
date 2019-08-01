using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190801_Klases
{
    internal class Automobilis
    {
        private string Marke;
        private string Modelis;
        private int _GamybosMetai;

        public int GamybosMetai
        {
            get
            {
                return _GamybosMetai;
            }
            set
            {
                if (value != _GamybosMetai)
                {
                    _GamybosMetai = value;
                }
            }
        }

        public string Spalva { get; set; }

        private int _DuruSkaicius;

        public int DuruSkaicius
        {
            get { return _DuruSkaicius; }
            set { _DuruSkaicius = value; }
        }

        public int Rida;

        public Automobilis(string Marke, int Rida, int metai)
        {
            this.Marke = Marke;
            this.Rida = Rida;
            GamybosMetai = metai;
        }

        public string MarkeGet()
        {
            return Marke;
        }

        public void MarkeSet(string marke)
        {
            Marke = marke;
        }

        public string ModelisGet()
        {
            return Modelis;
        }

        public void ModelisSet(string modelis)
        {
            Modelis = modelis;
        }

        public double KiekNuvaziuotaPerMetus()
        {
            return (double)Rida / (DateTime.Today.Year - GamybosMetai);
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Automobilis auto = new Automobilis("Volvo", 2000, 2016);
            Automobilis auto1 = new Automobilis("BMW", 15000, 2017);
            Automobilis auto2 = new Automobilis("VW", 200000, 2010);

            Console.WriteLine("Automobilis {0}, nuvaziuoja per metus {1}", auto.MarkeGet(), auto.KiekNuvaziuotaPerMetus());
            Console.WriteLine("Automobilis {0}, nuvaziuoja per metus {1}", auto1.MarkeGet(), auto1.KiekNuvaziuotaPerMetus());
        }
    }
}