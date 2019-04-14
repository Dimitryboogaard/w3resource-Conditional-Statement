using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            string strGraad = tbGraad.Text;

            if(strGraad == "F" || strGraad == "f")
            {
                lblAntwoord.Text = "Fail";
            }

            if (strGraad == "A" || strGraad == "a")
            {
                lblAntwoord.Text = "Average";
            }

            if (strGraad == "G" || strGraad == "g")
            {
                lblAntwoord.Text = "Good";
            }

            if (strGraad == "V" || strGraad == "v")
            {
                lblAntwoord.Text = "Very good";
            }

            if (strGraad == "E" || strGraad == "e")
            {
                lblAntwoord.Text = "Excellent";
            }

        }
    }
}
