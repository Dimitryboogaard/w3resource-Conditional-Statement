using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            int intWiskunde = Convert.ToInt16(tbWiskunde.Text);
            int intNatuurkunde = Convert.ToInt16(tbNatuurkunde.Text);
            int intScheikunde = Convert.ToInt16(tbScheikunde.Text);

            if (intWiskunde >= 65)
                if (intNatuurkunde >= 55)
                    if (intScheikunde >= 50)
                        if (intWiskunde + intNatuurkunde + intScheikunde >= 180 || intWiskunde + intNatuurkunde >= 140)
                            lblToegelatenJaOfNee.Text = "Toegelaten";
                        else
                            lblToegelatenJaOfNee.Text = "Niet toegelaten";
                    else
                        lblToegelatenJaOfNee.Text = "Niet toegelaten";
                else
                    lblToegelatenJaOfNee.Text = "Niet toegelaten";

            else
                lblToegelatenJaOfNee.Text = "Niet toegelaten";



        }
    }
}
