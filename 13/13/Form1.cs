using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            int intTempertuur = Convert.ToInt32(tbTemperatuur.Text);

            if(intTempertuur < 0)
            {
                lblAntwoord.Text = "Het vriest";
            }

            if(intTempertuur >= 0 && intTempertuur < 10)
            {
                lblAntwoord.Text = "Het is erg koud";
            }

            if (intTempertuur >= 10 && intTempertuur < 20)
            {
                lblAntwoord.Text = "Het is koud";
            }

            if (intTempertuur >= 20 && intTempertuur < 30)
            {
                lblAntwoord.Text = "Het is normaal";
            }

            if (intTempertuur >= 30)
            {
                lblAntwoord.Text = "Het is heet";
            }

        }
    }
}
