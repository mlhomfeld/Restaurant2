using System;
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
    public partial class WaiterMenu : Form
    {
        public WaiterMenu()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lstOrder.Items.Add("SoftDrink $1.50");
        }

        private void btnburger_Click(object sender, EventArgs e)
        {
            lstOrder.Items.Add("Burger $6.00");
        }

        private void btncheeseBurger_Click(object sender, EventArgs e)
        {
            lstOrder.Items.Add("CheeseBurger $7.00");
        }

        private void btnmilkShake_Click(object sender, EventArgs e)
        {
            lstOrder.Items.Add("MilkShake $3.50");
        }

        private void btnfries_Click(object sender, EventArgs e)
        {
            lstOrder.Items.Add("Fries $2.00");
        }

        private void btnsalad_Click(object sender, EventArgs e)
        {
            lstOrder.Items.Add("Salad $5.00");
        }
    }
}
