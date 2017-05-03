using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Restaurant2
{
    public class Busboy : Employee
    {
        public void Open(int Row)
        {
            //MessageBox that asks if you are sure you want to execute the below code
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to set this table to open?", "!!!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    //Opens connection to the database to update the status
                    SqlConnection connection = new SqlConnection();
                    connection.ConnectionString = "Server=cis1.actx.edu;Database=Project2;User Id=db2;Password = db20;";
                    connection.Open();
                    using (SqlCommand updateSeatingArea = connection.CreateCommand())
                    {
                        updateSeatingArea.CommandText = "update dbo.SeatingArea set SeatingAreaStatus = @SeatingAreaStatus where SeatingAreaID = @SeatingAreaID;";
                        var seatingAreaParam = new SqlParameter("SeatingAreaStatus", SqlDbType.VarChar) { Value = "Green" };
                        var idParam = new SqlParameter("SeatingAreaID", SqlDbType.Int) { Value = Row };
                        updateSeatingArea.Parameters.Add(seatingAreaParam);
                        updateSeatingArea.Parameters.Add(idParam);

                        updateSeatingArea.ExecuteNonQuery();
                        connection.Close();
                    }
                    MessageBox.Show("Table " + Row + " has been set to Open");

                }
                catch (Exception err)
                {
                    //Error box if connections fail
                    MessageBox.Show(err.Message);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else if choice was No
            }
        }
        public void Open(int Row)

    }
}