﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt16(tbGetalM.Text) < 0)
            {
                lblNIs.Text = "n = -1";
            }

           else if (Convert.ToInt16(tbGetalM.Text) == 0)
            {
                lblNIs.Text = "n = 0";

            }

            else if (Convert.ToInt16(tbGetalM.Text) > 0)
            {
                lblNIs.Text = "n = 1";

            }

        }
    }
}
