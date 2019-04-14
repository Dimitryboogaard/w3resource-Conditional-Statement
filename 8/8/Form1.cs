using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] arrayGetallen = new int[4];
        int intTeller, intMaxGetal, intMaxGetalRij;
        
        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            arrayGetallen[1] = Convert.ToInt32(tbGetal1.Text);
            arrayGetallen[2] = Convert.ToInt32(tbGetal2.Text);
            arrayGetallen[3] = Convert.ToInt32(tbGetal3.Text);

            for(intTeller = 1; intTeller <= 3; intTeller++)
            {
                if(arrayGetallen[intTeller] > arrayGetallen[intTeller - 1])
                {
                    intMaxGetal = arrayGetallen[intTeller];
                    intMaxGetalRij = intTeller;
                }
            }

            lblAntwoord.Text = "Het " + intMaxGetalRij.ToString() + "e" + " getal is de grootste, " + intMaxGetal.ToString();
        }
    }
}
