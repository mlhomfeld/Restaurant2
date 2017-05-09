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
        // This list holds MenuItemIDs
        private List<int> CurrentOrder = new List<int>();
        private void btnBurger_Click(object sender, EventArgs e)
        {
            lstOrder.Items.Add("Burger $6.00");
            CurrentOrder.Add(1);
        }

        private void btnCheeseburger_Click(object sender, EventArgs e)
        {
            lstOrder.Items.Add("CheeseBurger $7.00");
            CurrentOrder.Add(2);
        }

        private void btnMilkshake_Click(object sender, EventArgs e)
        {
            lstOrder.Items.Add("MilkShake $3.50");
            CurrentOrder.Add(3);
        }

        private void btnSoftDrink_Click(object sender, EventArgs e)
        {
            lstOrder.Items.Add("SoftDrink $1.50");
            CurrentOrder.Add(4);
        }

        private void btnFries_Click(object sender, EventArgs e)
        {
            lstOrder.Items.Add("Fries $2.00");
            CurrentOrder.Add(6);
        }

        private void btnSalad_Click(object sender, EventArgs e)
        {
            lstOrder.Items.Add("Salad $5.00");
            CurrentOrder.Add(7);
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            CurrentOrder.RemoveAt(lstOrder.SelectedIndex);
            lstOrder.Items.Remove(lstOrder.SelectedItem);
        }

        private void btnSubmitOrder_Click(object sender, EventArgs e)
        {
            Waiter wt = new Waiter();
            wt.SubmitOrder(CurrentOrder);
            MessageBox.Show("Order submitted.", "!!!");
            lstOrder.Items.Clear();
            CurrentOrder.Clear();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            WaiterForm waitForm = new WaiterForm();
            waitForm.Show();
            this.Hide();
        }
    }
}
