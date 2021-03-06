﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Restaurant2
{
    public class Waiter : Employee
    {
        public void SubmitOrder(List<int> menuItemIDs)
        {
            int createdOrderID = CreateNewOrder();
            if (createdOrderID != 0)
            {
                PlaceOrderPurchasesInPurchaseTable(menuItemIDs, createdOrderID);
                AddMenuPricesToOrderTotal(menuItemIDs, createdOrderID);

                // Enter timestamps for order submission. 
                string path = "Waiter.txt";
                string employeeID;
                try
                {
                    using (StreamReader reader = new StreamReader(path))
                    {
                        while ((employeeID = reader.ReadLine()) != null)

                        {
                            employeeID.ToString();
                            Employee emp = new Employee();
                            emp.Timestamp(Convert.ToInt32(employeeID), "Order Submitted");
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Cannot read the session ID file at  " + path);

                }

                // end timestamp entry code
            }
            else
            {
                MessageBox.Show("OrderID was not correctly collected.", "Error");
            }
        }
        private int CreateNewOrder()
        {
            int newID = 0;
            // Creates a new Order record in the Order table
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password = db20;";
                connection.Open();
                using (SqlCommand insertNewOrder = connection.CreateCommand())
                {
                    insertNewOrder.CommandText = "insert into dbo.RestaurantOrder values (@Total, @OrderStatus);";
                    var totalParam = new SqlParameter("Total", SqlDbType.Money) { Value = 0 };
                    var orderStatusParam = new SqlParameter("OrderStatus", SqlDbType.VarChar) { Value = "Submitted" };
                    insertNewOrder.Parameters.Add(totalParam);
                    insertNewOrder.Parameters.Add(orderStatusParam);
                    // Potential alternative that would cut out select statement block of code.
                    //newID = (int)insertNewOrder.ExecuteScalar();
                    insertNewOrder.ExecuteNonQuery();
                }
                connection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            // Grabs newest Order record number
            //string rawNewID = "";
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password = db20;";
                connection.Open();
                using (SqlCommand selectNewOrderID = connection.CreateCommand())
                {
                    selectNewOrderID.CommandText = "select * from dbo.RestaurantOrder where Total = @Total;";
                    var totalParam = new SqlParameter("Total", SqlDbType.Money) { Value = 0 };
                    selectNewOrderID.Parameters.Add(totalParam);

                    using (SqlDataReader reader = selectNewOrderID.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            newID = reader.GetInt32(0);
                        }
                    }
                }
                connection.Close();
            }
            catch (Exception errr)
            {
                MessageBox.Show(errr.Message);
            }

            // Enter timestamps for order submission. 
            string path = "Waiter.txt";
            string employeeID;
            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    while ((employeeID = reader.ReadLine()) != null)

                    {
                        employeeID.ToString();
                        Employee emp = new Employee();
                        emp.Timestamp(Convert.ToInt32(employeeID), "Order Created");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Cannot read the session ID file at  " + path);

            }

            // end timestamp entry code

            //if(int.TryParse(rawNewID, out newID))
            //{
            //    return newID;
            //}
            //else
            //{
            //    return newID;
            //}
            return newID;

        }
        // Places appropriate Order IDs and MenuItemIDs into the Purchase table to
        // help determine which orders had which items
        private void PlaceOrderPurchasesInPurchaseTable(List<int> menuItemIDs, int createdOrderID)
        {
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password = db20;";
                connection.Open();
                for (int i = 0; i < menuItemIDs.Count; i++)
                {
                    using (SqlCommand insertOrderPurchases = connection.CreateCommand())
                    {
                        //for (int i = 0; i < menuItemIDs.Count; i++)
                        //{
                        insertOrderPurchases.CommandText = "insert into dbo.Purchase values (@OrderID, @MenuItemID);";
                        var orderIDParam = new SqlParameter("OrderID", SqlDbType.Int) { Value = createdOrderID };
                        var menuItemParam = new SqlParameter("MenuItemID", SqlDbType.Int) { Value = menuItemIDs[i] };
                        insertOrderPurchases.Parameters.Add(orderIDParam);
                        insertOrderPurchases.Parameters.Add(menuItemParam);
                        insertOrderPurchases.ExecuteNonQuery();
                        //}
                    }
                }
                connection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        // This method grabs menu item prices from dbo.MenuItem, adds them together and places
        // the total into the appropriate order record's total in dbo.Order
        private void AddMenuPricesToOrderTotal(List<int> menuItemIDs, int orderID)
        {
            decimal total = 0M;
            List<decimal> priceCollection = new List<decimal>();
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password = db20;";
                connection.Open();
                using (SqlCommand readMenuPrices = connection.CreateCommand())
                {
                    for (int i = 0; i < menuItemIDs.Count; i++)
                    {
                        readMenuPrices.CommandText = "select * from dbo.MenuItem where MenuItemID = @MenuItemID" + i.ToString() + ";";
                        var idParam = new SqlParameter("MenuItemID" + i.ToString(), menuItemIDs[i]);
                        readMenuPrices.Parameters.Add(idParam);

                        using (SqlDataReader reader = readMenuPrices.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                priceCollection.Add(reader.GetDecimal(2));
                            }
                        }
                    }
                }
                connection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            for (int i = 0; i < priceCollection.Count; i++)
            {
                total += priceCollection[i];
            }
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password = db20;";
                connection.Open();
                using (SqlCommand updateTotal = connection.CreateCommand())
                {
                    updateTotal.CommandText = "update dbo.RestaurantOrder set Total = @Total where OrderID = @OrderID;";
                    var totalParam = new SqlParameter("Total", SqlDbType.Money) { Value = total };
                    var idParam = new SqlParameter("OrderID", SqlDbType.Int) { Value = orderID };
                    updateTotal.Parameters.Add(totalParam);
                    updateTotal.Parameters.Add(idParam);

                    updateTotal.ExecuteNonQuery();
                }
                connection.Close();
            }
            catch (Exception errrr)
            {
                MessageBox.Show(errrr.Message);
            }
        }
        // Retrieves Orders with an OrderStatus of Ready and returns the orderIDs in a List
        public List<int> RetrieveReadyOrders()
        {
            List<int> orderIDs = new List<int>();
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password = db20;";
                connection.Open();
                using (SqlCommand readOrderStatus = connection.CreateCommand())
                {
                    readOrderStatus.CommandText = "select * from dbo.RestaurantOrder where OrderStatus = @OrderStatus;";
                    var orderStatusParam = new SqlParameter("OrderStatus", "Ready");
                    readOrderStatus.Parameters.Add(orderStatusParam);

                    using (SqlDataReader reader = readOrderStatus.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            orderIDs.Add(reader.GetInt32(0));
                        }
                    }
                }
                connection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            return orderIDs;
        }
        // Retrieves Orders with an OrderStatus of Delivered and returns the orderIDS in a List
        public List<int> RetrieveDeliveredOrders()
        {
            List<int> orderIDs = new List<int>();
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password = db20;";
                connection.Open();
                using (SqlCommand readOrderStatus = connection.CreateCommand())
                {
                    readOrderStatus.CommandText = "select * from dbo.RestaurantOrder where OrderStatus = @OrderStatus;";
                    var orderStatusParam = new SqlParameter("OrderStatus", "Delivered");
                    readOrderStatus.Parameters.Add(orderStatusParam);

                    using (SqlDataReader reader = readOrderStatus.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            orderIDs.Add(reader.GetInt32(0));
                        }
                    }
                }
                connection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            return orderIDs;
        }
        // Updates the order record's OrderStatus to Delivered
        public void SetOrderToDelivered(int orderNumber)
        {
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Server=cis1.actx.edu;Database=Project2;User Id=db2;Password = db20;";
                connection.Open();
                using (SqlCommand updateToDeliverOrder = connection.CreateCommand())
                {
                    updateToDeliverOrder.CommandText = "update dbo.RestaurantOrder set OrderStatus = @OrderStatus where OrderID = @OrderID;";
                    var orderParam = new SqlParameter("OrderStatus", SqlDbType.VarChar) { Value = "Delivered" };
                    var idParam = new SqlParameter("OrderID", SqlDbType.Int) { Value = orderNumber };
                    updateToDeliverOrder.Parameters.Add(orderParam);
                    updateToDeliverOrder.Parameters.Add(idParam);

                    updateToDeliverOrder.ExecuteNonQuery();
                }
                connection.Close();
                MessageBox.Show("Order " + orderNumber + " has been delivered.");

            }
            catch (Exception err)
            {
                //Error box if connections fail
                MessageBox.Show(err.Message);
            }
        }
        // Updates the order record's OrderStatus to Paid
        public void SetOrderToPaid(int orderNumber)
        {
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Server=cis1.actx.edu;Database=Project2;User Id=db2;Password = db20;";
                connection.Open();
                using (SqlCommand updateToPaidOrder = connection.CreateCommand())
                {
                    updateToPaidOrder.CommandText = "update dbo.RestaurantOrder set OrderStatus = @OrderStatus where OrderID = @OrderID;";
                    var orderParam = new SqlParameter("OrderStatus", SqlDbType.VarChar) { Value = "Paid" };
                    var idParam = new SqlParameter("OrderID", SqlDbType.Int) { Value = orderNumber };
                    updateToPaidOrder.Parameters.Add(orderParam);
                    updateToPaidOrder.Parameters.Add(idParam);

                    updateToPaidOrder.ExecuteNonQuery();
                }
                connection.Close();

            }
            catch (Exception err)
            {
                //Error box if connections fail
                MessageBox.Show(err.Message);
            }
        }
        // Updates the order record's OrderStatus to Canceled
        public bool SetOrderToCanceled(int orderNumber)
        {
            // Boolean value set to determine whether or not to clear/refresh listboxes and 
            // text boxes depending on whether or not the order is canceled
            bool yesNo = false;
            DialogResult dialogResult = MessageBox.Show("Would you like to cancel this order?", "!!!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    SqlConnection connection = new SqlConnection();
                    connection.ConnectionString = "Server=cis1.actx.edu;Database=Project2;User Id=db2;Password = db20;";
                    connection.Open();
                    using (SqlCommand updateToDeliverOrder = connection.CreateCommand())
                    {
                        updateToDeliverOrder.CommandText = "update dbo.RestaurantOrder set OrderStatus = @OrderStatus where OrderID = @OrderID;";
                        var orderParam = new SqlParameter("OrderStatus", SqlDbType.VarChar) { Value = "Canceled" };
                        var idParam = new SqlParameter("OrderID", SqlDbType.Int) { Value = orderNumber };
                        updateToDeliverOrder.Parameters.Add(orderParam);
                        updateToDeliverOrder.Parameters.Add(idParam);

                        updateToDeliverOrder.ExecuteNonQuery();
                    }
                    connection.Close();
                    yesNo = true;
                }
                catch (Exception err)
                {
                    //Error box if connections fail
                    MessageBox.Show(err.Message);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                // Close
                yesNo = false;
            }
            return yesNo;
        }
        // Pulls the items needed to be displayed for the Pay Order Form from dbo.Purchase
        public List<int> PullPayOrderItemsFromPurchaseTable(int orderID)
        {
            List<int> menuItemIDs = new List<int>();
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password = db20;";
                connection.Open();
                using (SqlCommand readOrderID = connection.CreateCommand())
                {
                    readOrderID.CommandText = "select * from dbo.Purchase where OrderID = @OrderID;";
                    var orderContentParam = new SqlParameter("OrderID", orderID);
                    readOrderID.Parameters.Add(orderContentParam);

                    using (SqlDataReader reader = readOrderID.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            menuItemIDs.Add(reader.GetInt32(2));
                        }
                    }

                }
                connection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            return menuItemIDs;
        }
        // Pulls menu item names for Pay Form
        public List<string> PullPayMenuItemNames(List<int> menuItemIDs)
        {
            List<string> menuItemNames = new List<string>();
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password = db20;";
                connection.Open();
                using (SqlCommand readMenuItemNames = connection.CreateCommand())
                {
                    for (int i = 0; i < menuItemIDs.Count; i++)
                    {
                        readMenuItemNames.CommandText = "select * from dbo.MenuItem where MenuItemID = @MenuItemID" + i.ToString() + ";";
                        var idParam = new SqlParameter("MenuItemID" + i.ToString(), menuItemIDs[i]);
                        readMenuItemNames.Parameters.Add(idParam);

                        using (SqlDataReader reader = readMenuItemNames.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                menuItemNames.Add(reader.GetString(1));
                            }
                        }

                    }
                }
                connection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            return menuItemNames;
        }
        public decimal PullPayOrderTotal(int orderID)
        {
            decimal orderTotal = 0M;
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password = db20;";
                connection.Open();
                using (SqlCommand readTableStatus = connection.CreateCommand())
                {
                        readTableStatus.CommandText = "select * from dbo.RestaurantOrder where OrderID = @OrderID;";
                        var idParam = new SqlParameter("OrderID", orderID);
                        readTableStatus.Parameters.Add(idParam);

                        using (SqlDataReader reader = readTableStatus.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                orderTotal = reader.GetDecimal(1);
                            }
                        }

                }
                connection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            return orderTotal;
        }
        public void SetTableToDirty(int tableNumber)
        {
            // This method will change the status of the table in the database.

            DialogResult dialogResult = MessageBox.Show("Would you like to set this table to dirty?", "!!!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    SqlConnection connection = new SqlConnection();
                    connection.ConnectionString = "Server=cis1.actx.edu;Database=Project2;User Id=db2;Password = db20;";
                    connection.Open();
                    using (SqlCommand updateSeatingArea = connection.CreateCommand())
                    {
                        updateSeatingArea.CommandText = "update dbo.SeatingArea set SeatingAreaStatus = @SeatingAreaStatus where SeatingAreaID = @SeatingAreaID;";
                        var seatingAreaParam = new SqlParameter("SeatingAreaStatus", SqlDbType.VarChar) { Value = "Red" };
                        var idParam = new SqlParameter("SeatingAreaID", SqlDbType.Int) { Value = tableNumber };
                        updateSeatingArea.Parameters.Add(seatingAreaParam);
                        updateSeatingArea.Parameters.Add(idParam);
                        updateSeatingArea.ExecuteNonQuery();
                        connection.Close();

                    }
                    MessageBox.Show("Table " + tableNumber + " has been set to dirty.");
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                // Close
            }
        }
    }
}