using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Windows.Forms;


namespace Restaurant2
{
    public class Cook : Employee
    {
        public Cook()
        {

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
           
        }
    }
}