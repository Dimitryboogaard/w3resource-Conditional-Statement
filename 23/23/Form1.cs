using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            int intMaand = Convert.ToInt32(tbInvoer.Text);

            switch(intMaand)
            {
                case 1:
                    lblAntwoord.Text = "31 dagen";
                    break;

                case 2:
                    lblAntwoord.Text = "28 dagen";
                    break;

                case 3:
                    lblAntwoord.Text = "31 dagen";
                    break;

                case 4:
                    lblAntwoord.Text = "30 dagen";
                    break;

                case 5:
                    lblAntwoord.Text = "31 dagen";
                    break;

                case 6:
                    lblAntwoord.Text = "30 dagen";
                    break;

                case 7:
                    lblAntwoord.Text = "31 dagen";
                    break;

                case 8:
                    lblAntwoord.Text = "31 dagen";
                    break;

                case 9:
                    lblAntwoord.Text = "30 dagen";
                    break;

                case 10:
                    lblAntwoord.Text = "31 dagen";
                    break;

                case 11:
                    lblAntwoord.Text = "30 dagen";
                    break;

                case 12:
                    lblAntwoord.Text = "31 dagen";
                    break;


            }
        }
    }
}
