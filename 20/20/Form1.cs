using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20
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
                case "1":
                    lblAntwoord.Text = "Maandag";
                    break;

                case "2":
                    lblAntwoord.Text = "Dinsdag";
                    break;

                case "3":
                    lblAntwoord.Text = "Woensdag";
                    break;

                case "4":
                    lblAntwoord.Text = "Donderdag";
                    break;

                case "5":
                    lblAntwoord.Text = "Vrijdag";
                    break;

                case "6":
                    lblAntwoord.Text = "Zaterdag";
                    break;

                case "7":
                    lblAntwoord.Text = "Zondag";
                    break;

            }
        }
    }
}
