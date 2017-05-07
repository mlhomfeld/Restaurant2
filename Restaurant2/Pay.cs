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
    public partial class Pay : Form
    {
        public Pay()
        {
            InitializeComponent();
        }


        private void btnPayOrder_Click(object sender, EventArgs e)
        {
            Customer cust = new Customer();
            txtRemainingBalance.Text = cust.Pay(txtRemainingBalance.Text,txtTotalPaid.Text);

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            lstOrders.Items.Clear();
            Waiter wt = new Waiter();
            List<int> orderIDs = wt.RetrieveDeliveredOrders();
            for (int i = 0; i < orderIDs.Count; i++)
            {
                lstOrders.Items.Add(orderIDs[i].ToString());
            }
            
        }
        private void btnDisplaySelectedOrder_Click(object sender, EventArgs e)
        {
            lstOrderedItems.Items.Clear();
            try
            {
                Waiter wt = new Waiter();
                List<int> menuIDs = wt.PullPayOrderItemsFromPurchaseTable(int.Parse(lstOrders.SelectedItem.ToString()));
                List<string> menuItemNames = wt.PullPayMenuItemNames(menuIDs);
                for (int i = 0; i < menuItemNames.Count; i++)
                {
                    lstOrderedItems.Items.Add(menuItemNames[i]);
                }
                txtYourTotal.Text = wt.PullPayOrderTotal(int.Parse(lstOrders.SelectedItem.ToString())).ToString("F2");
                txtRemainingBalance.Text = wt.PullPayOrderTotal(int.Parse(lstOrders.SelectedItem.ToString())).ToString("F2");
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
