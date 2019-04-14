using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22
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

            switch (intMaand)
            {
                case 1:
                    lblAntwoord.Text = "Januari";
                    break;

                case 2:
                    lblAntwoord.Text = "Februari";
                    break;

                case 3:
                    lblAntwoord.Text = "Maart";
                    break;

                case 4:
                    lblAntwoord.Text = "April";
                    break;

                case 5:
                    lblAntwoord.Text = "Mei";
                    break;

                case 6:
                    lblAntwoord.Text = "Juni";
                    break;

                case 7:
                    lblAntwoord.Text = "Juli";
                    break;

                case 8:
                    lblAntwoord.Text = "Augustus";
                    break;

                case 9:
                    lblAntwoord.Text = "September";
                    break;

                case 10:
                    lblAntwoord.Text = "Oktober";
                    break;

                case 11:
                    lblAntwoord.Text = "November";
                    break;

                case 12:
                    lblAntwoord.Text = "December";
                    break;

                default:
                    lblAntwoord.Text = "1 t/m 12";
                    break;
            }
            }
        }
}
