using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            int intHoekA = Convert.ToInt32(tbHoekA.Text);
            int intHoekB = Convert.ToInt32(tbHoekB.Text);
            int intHoekC = Convert.ToInt32(tbHoekC.Text);

            lblJaOfNee.Text = Convert.ToString((intHoekA + intHoekB + intHoekC == 180));
        }
    }
}
