using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKeuze_Click(object sender, EventArgs e)
        {
            if (btnKeuze.Text == "Keuze")
            {
                if (rbCirkel.Checked == true)
                {
                    tbEen.Visible = true;
                    lblEen.Visible = true;
                    lblEen.Text = "Straal";
                    btnKeuze.Text = "Antwoord";
                }

                if (rbDrieHoek.Checked == true)
                {
                    tbEen.Visible = true;
                    tbTwee.Visible = true;
                    lblEen.Visible = true;
                    lblEen.Text = "Basis";
                    lblTwee.Visible = true;
                    lblTwee.Text = "Hoogte";
                    btnKeuze.Text = "Antwoord";

                }

                if (rbRechtHoek.Checked == true)
                {
                    tbEen.Visible = true;
                    tbTwee.Visible = true;
                    lblEen.Visible = true;
                    lblEen.Text = "Lengte";
                    lblTwee.Visible = true;
                    lblTwee.Text = "Breedte";
                    btnKeuze.Text = "Antwoord";

                }
            }

            else
            {
                if(rbCirkel.Checked == true)
                {
                    tbAntwoord.Text = Convert.ToString(Math.Pow(Convert.ToInt16(tbEen.Text), 2) * 3.1415);
                  
                }

                if(rbDrieHoek.Checked == true)
                {
                    tbAntwoord.Text = Convert.ToString(0.5 * Convert.ToInt16(tbEen.Text) *
                                      Convert.ToInt16(tbTwee.Text));
                }

                if(rbRechtHoek.Checked == true)
                {
                    tbAntwoord.Text = Convert.ToString(Convert.ToInt16(tbEen.Text) *
                                      Convert.ToInt16(tbTwee.Text));

                }
            }

        }
    }
}
