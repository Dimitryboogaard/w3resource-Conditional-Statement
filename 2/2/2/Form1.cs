﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt16(tbInvoer.Text) % 2 == 0)
            {
                lblAntwoord.Text = tbInvoer.Text + " is even.";
            }

            else
            {
                lblAntwoord.Text = tbInvoer.Text + " is oneven.";

            }
        }
    }
}
