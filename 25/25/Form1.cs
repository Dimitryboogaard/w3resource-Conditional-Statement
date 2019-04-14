using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int intGetal1 = Convert.ToInt32(tbGetal1.Text);
            int intGetal2 = Convert.ToInt32(tbGetal2.Text);

            if(rbOptellen.Checked)
            {
                tbAntwoord.Text = Convert.ToString(intGetal1 + intGetal2);
            }
           
            if(rbAftrekken.Checked)
            {
                tbAntwoord.Text = Convert.ToString(intGetal1 - intGetal2);
            }

            if(rbVermenigVuldigen.Checked)
            {
                tbAntwoord.Text = Convert.ToString(intGetal1 * intGetal2);

            }

            if(rbDelen.Checked)
            {
                tbAntwoord.Text = Convert.ToString(intGetal1 / intGetal2);

            }

            if(rbExit.Checked)
            {
                tbGetal1.Text = "";
                tbGetal2.Text = "";
            }
        }
    }
}
