using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20190805_pavyzdys
{
    public partial class PagrindinisLangas : Form
    {
        public PagrindinisLangas()
        {
            InitializeComponent();
        }

        private void MygtukasSpausti_Click(object sender, EventArgs e)
        {
            GroupFirst.BackColor = Color.Red;
            TekstoLaukas.Text = "Mygtukas paspaustas";
        }
    }
}