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
    public partial class WaiterOrderReady : Form
    {
        public WaiterOrderReady()
        {
            InitializeComponent();
        }

        private void btnDeliverOrder_Click(object sender, EventArgs e)
        {
            Waiter wt = new Waiter();
            wt.SetOrderToDelivered(int.Parse(lstReadyOrders.SelectedItem.ToString()));
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            lstReadyOrders.Items.Clear();
            Waiter wt = new Waiter();
            List<int> orderIDs = wt.RetrieveReadyOrders();
            for (int i = 0; i < orderIDs.Count; i++)
            {
                lstReadyOrders.Items.Add(orderIDs[i].ToString());
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            WaiterForm waitForm = new WaiterForm();
            waitForm.Show();
            this.Hide();
        }
    }
}
