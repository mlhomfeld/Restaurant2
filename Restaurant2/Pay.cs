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

        }
    }
}
