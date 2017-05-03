using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Restaurant2
{
    public class Waiter : Employee
    {
        public void TakeOrder()
        {
            throw new System.NotImplementedException();           

        }

        public void RetrieveOrder()
        {
            throw new System.NotImplementedException();
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
                        updateSeatingArea.CommandText = "update dbo.SeatingArea set SeatingAreaStatus = @SeatingAreaStatus where ID = @ID;";
                        var seatingAreaParam = new SqlParameter("SeatingAreaStatus", SqlDbType.VarChar) { Value = "Red" };
                        var idParam = new SqlParameter("ID", SqlDbType.Int) { Value = tableNumber };
                        updateSeatingArea.Parameters.Add(seatingAreaParam);
                        updateSeatingArea.Parameters.Add(idParam);

                        updateSeatingArea.ExecuteNonQuery();
                        connection.Close();
                    }
                    MessageBox.Show("Table 1 has been set to dirty.");
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                // Close?
            }
        }
    }
}