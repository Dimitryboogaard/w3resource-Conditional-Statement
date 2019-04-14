using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intJaartal;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            intJaartal = Convert.ToInt32(tbJaartal.Text);

            if(intJaartal % 400 == 0)
            {
                lblJaOfNee.Text = intJaartal.ToString() + " is een schrikkeljaar.";
            }

            else if (intJaartal % 100 == 0)
            {
                lblJaOfNee.Text = intJaartal.ToString() + " is geen schrikkeljaar.";
            }

            else if (intJaartal % 4 == 0)
            {
                lblJaOfNee.Text = intJaartal.ToString() + " is een schrikkeljaar.";
            }

            else
            {
                lblJaOfNee.Text = intJaartal.ToString() + " is geen schrikkeljaar.";
            }

        }
    }
}
