﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Restaurant2
{
    public partial class CookForm : Form
    {
        public CookForm()
        {
            InitializeComponent();
        }

        private int orderNumber = 1;
        private void btnRetrieveOrder_Click(object sender, EventArgs e)
        {
            // Waiter submits order, I retrieve it.
        }

        private void btnPreppingOrder_Click(object sender, EventArgs e)
        {

        }

        private void btnOrderReady_Click(object sender, EventArgs e)
        {
            Cook cook = new Cook();
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to set order " + orderNumber + " to finish?", "!!!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                cook.SetOrderToReady(orderNumber);
                orderNumber++;
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else if choice was No
            }
        }
    }
}
