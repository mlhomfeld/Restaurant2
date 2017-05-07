using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Windows.Forms;
using System.IO;


namespace Restaurant2
{
    public class Cook : Employee
    {
        public List<int> ReceiveOrders()
        {
            List<int> orderIds = new List<int>();
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password = db20;";
                connection.Open();
                using (SqlCommand readOrderStatus = connection.CreateCommand())
                {
                    //for (int i = 1; i < 8; i++)
                    //{
                    readOrderStatus.CommandText = "select * from dbo.RestaurantOrder where OrderStatus = @OrderStatus;";
                    var orderStatusParam = new SqlParameter("OrderStatus", "Submitted");
                    //var fnameParam = new SqlParameter("TableID", SqlDbType.VarChar) { Value = i };
                    readOrderStatus.Parameters.Add(orderStatusParam);

                    using (SqlDataReader reader = readOrderStatus.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            orderIds.Add(reader.GetInt32(0));
                        }
                    }


                    //}
                }
                connection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            return orderIds;
        }

        public List<int> ConvertOrders(int orderID)
        {
            List<int> ordercontent = new List<int>();
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password = db20;";
                connection.Open();
                using (SqlCommand readOrderID = connection.CreateCommand())
                {
                    //for (int i = 1; i < 8; i++)
                    //{
                    readOrderID.CommandText = "select * from dbo.Purchase where OrderID = @OrderID;";
                    var orderContentParam = new SqlParameter("OrderID", orderID);
                    //var fnameParam = new SqlParameter("TableID", SqlDbType.VarChar) { Value = i };
                    readOrderID.Parameters.Add(orderContentParam);

                    using (SqlDataReader reader = readOrderID.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ordercontent.Add(reader.GetInt32(2));
                        }
                    }

                    // Enter timestamp for prepping order 

                    string path = "Cook.txt";
                    string employeeID;
                    try
                    {
                        using (StreamReader reader = new StreamReader(path))
                        {
                            while ((employeeID = reader.ReadLine()) != null)

                            {
                                employeeID.ToString();
                                Employee emp = new Employee();
                                emp.Timestamp(Convert.ToInt32(employeeID), "Prepping Order");
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Cannot read the session ID file at  " + path);

                    }

                    // end timestamp entry code. 

                    //}
                }
                connection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            return ordercontent;
        }

        public List<string> ConvertMenuItemsIDs()
        {
            List<string> status = new List<string>();
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password = db20;";
                connection.Open();
                using (SqlCommand readTableStatus = connection.CreateCommand())
                {
                    for (int i = 1; i < 8; i++)
                    {
                        readTableStatus.CommandText = "select * from dbo.SeatingArea where SeatingAreaID = @SeatingAreaID" + i.ToString() + ";";
                        var idParam = new SqlParameter("SeatingAreaID" + i.ToString(), i);
                        //var fnameParam = new SqlParameter("TableID", SqlDbType.VarChar) { Value = i };
                        readTableStatus.Parameters.Add(idParam);

                        using (SqlDataReader reader = readTableStatus.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                status.Add(reader.GetString(1));
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
            return status;
        }

        public void SetOrderToReady(int orderNumber)
        {
            
           
                try
                {
                    //Opens connection to the database to update the status
                    SqlConnection connection = new SqlConnection();
                    connection.ConnectionString = "Server=cis1.actx.edu;Database=Project2;User Id=db2;Password = db20;";
                    connection.Open();
                    using (SqlCommand updateOrder = connection.CreateCommand())
                    {
                        updateOrder.CommandText = "update dbo.RestaurantOrder set OrderStatus = @OrderStatus where OrderID = @OrderID;";
                        var orderParam = new SqlParameter("OrderStatus", SqlDbType.VarChar) { Value = "Ready" };
                        var idParam = new SqlParameter("OrderID", SqlDbType.Int) { Value = orderNumber };
                        updateOrder.Parameters.Add(orderParam);
                        updateOrder.Parameters.Add(idParam);

                        updateOrder.ExecuteNonQuery();
                        connection.Close();
                    }
                    MessageBox.Show("Order "+ orderNumber + " has been set to Ready");
                    
                }
                catch (Exception err)
                {
                    //Error box if connections fail
                    MessageBox.Show(err.Message);
                }


            // Enter the timestamp that the order was set to ready. 


            string path = "Cook.txt";
            string employeeID;
            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    while ((employeeID = reader.ReadLine()) != null)

                    {
                        employeeID.ToString();
                        Employee emp = new Employee();
                        emp.Timestamp(Convert.ToInt32(employeeID), "Order Set to Ready");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Cannot read the session ID file at  " + path);

            }

            // end timestamp entry code.. 

        }
    }
}