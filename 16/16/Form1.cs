using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            if(tbLetter.Text == "a" || tbLetter.Text == "e" || tbLetter.Text == "u" ||
               tbLetter.Text == "o" || tbLetter.Text == "i" || tbLetter.Text == "A" ||
               tbLetter.Text == "E" || tbLetter.Text == "U" || tbLetter.Text == "O" ||
               tbLetter.Text == "I")
            {
                lblAntwoord.Text = "Letter is een klinker.";
            }

            else
            {
                lblAntwoord.Text = "Letter is een medeklinker.";
            }
        }
    }
}
