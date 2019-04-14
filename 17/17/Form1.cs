using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            int intSaldo = Convert.ToInt32(tbVerkoopPrijs.Text) - Convert.ToInt32(tbInkoopPrijs.Text);

            if(intSaldo > 0)
            {
                lblAntwoord.Text = "Uw winst is " + intSaldo.ToString() + ".";
            }

            if(intSaldo == 0)
            {
                lblAntwoord.Text = "U heeft geen winst of verlies.";

            }

            if(Convert.ToInt32(tbVerkoopPrijs.Text) < Convert.ToInt32(tbInkoopPrijs.Text))
            {
                intSaldo = Convert.ToInt32(tbInkoopPrijs.Text) - Convert.ToInt32(tbVerkoopPrijs.Text);
                lblAntwoord.Text = "Uw verlies is " + intSaldo.ToString() + ".";

            }
        }
    }
}
