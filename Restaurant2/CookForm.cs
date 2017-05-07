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

        private int orderNumber;
        

        private void btnPreppingOrder_Click(object sender, EventArgs e)
        {
            //Converts Order number into the Menu Items To diplay
            lstMenuItemsDisplay.Items.Clear();
            try
            {
                Cook cook = new Cook();
                List<int> orderContent = cook.ConvertOrders(int.Parse(lstPendingOrders.SelectedItem.ToString()));
                //Changes the order number to the respectable food
                for (int i = 0; i < orderContent.Count; i++)
                {
                    
                    if (orderContent[i].ToString() == "1")
                    {
                        lstMenuItemsDisplay.Items.Add("Burger");
                    }
                    else if (orderContent[i].ToString() == "2")
                    {
                        lstMenuItemsDisplay.Items.Add("CheeseBurger");
                    }
                    else if (orderContent[i].ToString() == "3")
                    {
                        lstMenuItemsDisplay.Items.Add("MilkShake");
                    }
                    else if (orderContent[i].ToString() == "4")
                    {
                        lstMenuItemsDisplay.Items.Add("SoftDrink");
                    }
                    else if (orderContent[i].ToString() == "6")
                    {
                        lstMenuItemsDisplay.Items.Add("Fries");
                    }
                    else if (orderContent[i].ToString() == "7")
                    {
                        lstMenuItemsDisplay.Items.Add("Salad");
                    }
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
                //Runs cook Method
                cook.SetOrderToReady(orderNumber);
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
            //Refreshs the table to see which orders there are and then adds to the table
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
