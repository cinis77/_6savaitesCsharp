using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teleloto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            TextBox[] Melyni = { M1, M2, M3, M4, M5 };
            TextBox[] Juodi = { J1, J2, J3, J4, J5 };
            TextBox[] Raudoni = { R1, R2, R3, R4, R5 };
            TextBox[] Geltoni = { G1, G2, G3, G4, G5 };
            TextBox[] Zali = { Ž1, Ž2, Ž3, Ž4, Ž5 };
            SugeneruojaStulpeli(Melyni, 1, 16);
            SugeneruojaStulpeli(Juodi, 16, 31);
            SugeneruojaStulpeli(Raudoni, 31, 46);
            SugeneruojaStulpeli(Geltoni, 46, 61);
            SugeneruojaStulpeli(Zali, 61, 76);
        }

        private void SugeneruojaStulpeli(TextBox[] stulpelis, int a, int b)
        {
            Random rng = new Random();
            List<int> istrauktiMelyni = new List<int>();
            int i = 0;
            while (i < stulpelis.Length)
            {
                int kamuoliukas = rng.Next(a, b); //[1;16) 15
                bool naujas = true;
                foreach (var item in istrauktiMelyni)
                {
                    if (kamuoliukas == item)
                    {
                        naujas = false;
                        break;
                    }
                }
                if (naujas)
                {
                    stulpelis[i].Text = kamuoliukas.ToString();
                    istrauktiMelyni.Add(kamuoliukas);
                    i++;
                }
            }
        }

        private void Zaisti_Click(object sender, EventArgs e)
        {
            Random rng = new Random();
            Skaiciai.Text = string.Empty;
            List<int> jauIsridentiSkaiciai = new List<int>();
            int i = 0;
            while (i < 47)
            {
                int kamuoliukas = rng.Next(1, 76);
                bool naujasKamuoliukas = true;
                foreach (var item in jauIsridentiSkaiciai)
                {
                    if (item == kamuoliukas)
                    {
                        naujasKamuoliukas = false;
                        break;
                    }
                }
                if (naujasKamuoliukas)
                {
                    Skaiciai.Text += kamuoliukas.ToString() + " ";
                    i++;
                    jauIsridentiSkaiciai.Add(kamuoliukas);
                }
            }
        }
    }
}