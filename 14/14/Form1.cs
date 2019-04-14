using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            int intZijdeA = Convert.ToInt32(tbZijdeA.Text);
            int intZijdeB = Convert.ToInt32(tbZijdeB.Text);
            int intZijdeC = Convert.ToInt32(tbZijdeC.Text);

            if(intZijdeA == intZijdeB && intZijdeB == intZijdeC)
            {
                lblAntwoord.Text = "Gelijkzijdig";
            }

            else if(intZijdeA == intZijdeB || intZijdeA == intZijdeC || intZijdeB == intZijdeC)
            {
                lblAntwoord.Text = "Gelijkbenig";

            }

            else
            {
                lblAntwoord.Text = "Ongelijkbenig";

            }
        }
    }
}
