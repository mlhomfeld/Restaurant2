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
    public partial class CookForm : Form
    {
        public CookForm()
        {
            InitializeComponent();
        }

        private int orderNumber; //= 1;
        private void btnRetrieveOrder_Click(object sender, EventArgs e)
        {
            // Waiter submits order, I retrieve it.
        }

        private void btnPreppingOrder_Click(object sender, EventArgs e)
        {
            
            
            try
            {
                Cook cook = new Cook();
                List<int> orderContent = cook.ConvertOrders(int.Parse(lstPendingOrders.SelectedItem.ToString()));

                for (int i = 0; i < orderContent.Count; i++)
                {
                    lstMenuItemsDisplay.Items.Add(orderContent[i].ToString());
                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnOrderReady_Click(object sender, EventArgs e)
        {
            Cook cook = new Cook();
            orderNumber = int.Parse(lstPendingOrders.SelectedItem.ToString());
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to set order " + orderNumber + " to finish?", "!!!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                cook.SetOrderToReady(orderNumber);
                //orderNumber++;
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else if choice was No
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //logs out the cook Form
            Employee emp = new Restaurant2.Employee();
            emp.LogOut();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            lstPendingOrders.Items.Clear();
            Cook cook = new Cook();
            List<int> orderIDs = cook.ReceiveOrders();
            for(int i = 0; i < orderIDs.Count; i++)
            {
                lstPendingOrders.Items.Add(orderIDs[i].ToString());
            }           
        }
    }
}
