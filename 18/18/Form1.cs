using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const double cdblPercentage = 15;
        double dblPrijs, dblSurPlus, dblPrijsPerEenheid;
        bool booMinimum = false;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            string strKlantID = tbKlantID.Text;
            string strKlantNaam = tbKlantNaam.Text;
            int intVerbruik = Convert.ToInt32(tbVerbruik.Text);

            
            if(intVerbruik < 200)
            {
                dblPrijsPerEenheid = 1.20;
                dblPrijs = dblPrijsPerEenheid * intVerbruik;
            }

            if(intVerbruik >= 200 && intVerbruik < 400)
            {
                dblPrijsPerEenheid = 1.50;
                dblPrijs = dblPrijsPerEenheid * intVerbruik;


            }

            if (intVerbruik >= 400 && intVerbruik < 600)
            {
                dblPrijsPerEenheid = 1.80;
                dblPrijs = dblPrijsPerEenheid * intVerbruik;


            }

            if (intVerbruik >= 600)
            {
                dblPrijsPerEenheid = 1.20;
                dblPrijs = dblPrijsPerEenheid * intVerbruik;
                dblSurPlus = dblPrijs * cdblPercentage / 100;
            }

            rtUitvoer.Text += "Klant ID: " + strKlantID + Environment.NewLine;
            rtUitvoer.Text += "Klantnaam: " + strKlantNaam + Environment.NewLine;
            rtUitvoer.Text += "Verbruik: " + intVerbruik.ToString() + Environment.NewLine;

            if (dblPrijs < 100)
            {
                rtUitvoer.Text += "Prijs = " + dblPrijsPerEenheid + " x " + intVerbruik.ToString() +
                              " = " + dblPrijs.ToString() + Environment.NewLine;
                rtUitvoer.Text += "Minimumprijs = 100" + Environment.NewLine;
                dblPrijs = 100;
            }

            else
            {
                rtUitvoer.Text += "Prijs = " + dblPrijsPerEenheid + " x " + intVerbruik.ToString() +
                                  " = " + dblPrijs.ToString() + Environment.NewLine;
            }
            if (intVerbruik >= 600)
            {
                rtUitvoer.Text += "Surplus: " + dblSurPlus.ToString() + Environment.NewLine;
            }
            rtUitvoer.Text += "Totaalprijs: " + (dblPrijs + dblSurPlus);
        }
    }
}
