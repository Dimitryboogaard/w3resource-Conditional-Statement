using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intSom;
        double dblPercentage;
        string strDivisie;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            string strRollNummer = tbRollNummer.Text;
            string strNaam = tbNaam.Text;
            int intNatuurkunde = Convert.ToInt32(tbNatuurkunde.Text);
            int intScheikunde = Convert.ToInt32(tbScheikunde.Text);
            int intComputer = Convert.ToInt32(tbComputer.Text);

            intSom = intNatuurkunde + intScheikunde + intComputer;
            dblPercentage = 100 * intSom / 300;

            if(dblPercentage >= 80)
            {
                strDivisie = "Eerste";

            }

            if(dblPercentage < 80 && dblPercentage >= 60)
            {
                strDivisie = "Tweede";

            }

            if(dblPercentage < 60 && dblPercentage >= 40)
            {
                strDivisie = "Derde";
            }

            if(dblPercentage < 40)
            {
                strDivisie = "Laatste";
            }

            rtUitvoer.Text += "Roll nummer: " + strRollNummer + Environment.NewLine;
            rtUitvoer.Text += "Naam student: " + strNaam + Environment.NewLine;
            rtUitvoer.Text += "Cijfer natuurkunde: " + intNatuurkunde.ToString() + Environment.NewLine;
            rtUitvoer.Text += "Cijfer scheikunde: " + intScheikunde.ToString() + Environment.NewLine;
            rtUitvoer.Text += "Cijfer computer: " + intComputer.ToString() + Environment.NewLine;
            rtUitvoer.Text += "Totaal cijfers: " + intSom.ToString() + Environment.NewLine;
            rtUitvoer.Text += "Percentage: " + dblPercentage.ToString() + Environment.NewLine;
            rtUitvoer.Text += "Divisie: " + strDivisie;


        }
    }
}
