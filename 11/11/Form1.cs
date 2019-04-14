using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double dblD, dblX1, dblX2;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            int intA = Convert.ToInt32(tbA.Text);
            int intB = Convert.ToInt32(tbB.Text);
            int intC = Convert.ToInt32(tbC.Text);

            dblD = intB * intB - 4 * intA * intC;

            if(dblD == 0)
            {
                dblX1 = dblX2 = -intB / 2 * intA;
                lblNulPunten.Text = "x1 = " + Math.Round(dblX1, 2).ToString() + "   x2 = " + Math.Round(dblX2, 2).ToString();
            }

            else if(dblD > 0)
            {
                dblX1 = (-intB + Math.Sqrt(dblD)) / (2 * intA);
                dblX2 = (-intB - Math.Sqrt(dblD)) / (2 * intA);
                lblNulPunten.Text = "x1 = " + Math.Round(dblX1, 2).ToString() + "   x2 = " + Math.Round(dblX2, 2).ToString();

            }

            else
            {
                lblNulPunten.Text = "Geen nulpunten";
            }
        }
    }
}
