using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intX, intY;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            intX = Convert.ToInt32(tbX.Text);
            intY = Convert.ToInt32(tbY.Text);

            if(intX > 0 && intY > 0)
            {
                lblQuadrant.Text = "Eerst quadrant";
            }

            if (intX < 0 && intY > 0)
            {
                lblQuadrant.Text = "Tweede quadrant";
            }

            if (intX < 0 && intY < 0)
            {
                lblQuadrant.Text = "Derde quadrant";
            }

            if (intX > 0 && intY < 0)
            {
                lblQuadrant.Text = "Vierde quadrant";
            }

            if (intX == 0 && intY == 0)
            {
                lblQuadrant.Text = "Oorsprong";
            }

        }

    }
}
