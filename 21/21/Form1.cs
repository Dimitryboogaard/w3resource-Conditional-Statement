using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            string strInvoer = tbInvoer.Text;

            switch(strInvoer)
            {
                case "0":
                    lblAntwoord.Text = "Nul";
                        break;

                case "1":
                    lblAntwoord.Text = "Een";
                        break;

                case "2":
                    lblAntwoord.Text = "Twee";
                        break;

                case "3":
                    lblAntwoord.Text = "Drie";
                        break;

                case "4":
                    lblAntwoord.Text = "Vier";
                        break;

                case "5":
                    lblAntwoord.Text = "Vijf";
                    break;

                case "6":
                    lblAntwoord.Text = "Zes";
                    break;

                case "7":
                    lblAntwoord.Text = "Zeven";
                    break;

                case "8":
                    lblAntwoord.Text = "Acht";
                    break;

                case "9":
                    lblAntwoord.Text = "Negen";
                    break;

                default:
                    lblAntwoord.Text = "Geef een getal op (0 t/m 9)";
                    break;
            }
        }
    }
}
