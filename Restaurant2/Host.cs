using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Restaurant2
{
    public class Host : Employee
    {
        // I'm working on host
        // Ray
        public void CreateCustomerParty()
        {
            
            throw new System.NotImplementedException();

        }

        public void SetTableToOccupied(int tableNumber)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to set this table to Occupied?", "!!!", MessageBoxButtons.YesNo);
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
                        var seatingAreaParam = new SqlParameter("SeatingAreaStatus", SqlDbType.VarChar) { Value = "Occupied" };
                        var idParam = new SqlParameter("ID", SqlDbType.Int) { Value = tableNumber };
                        updateSeatingArea.Parameters.Add(seatingAreaParam);
                        updateSeatingArea.Parameters.Add(idParam);

                        updateSeatingArea.ExecuteNonQuery();

                    }
                    MessageBox.Show("Table 1 has been set to Occupied");
                    connection.Close();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }

        }

    }

        public void RemoveFromQueue()
        {
            throw new System.NotImplementedException();
        }
    }
}