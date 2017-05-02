using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Data.Sql;


namespace Restaurant2
{
    public partial class BusboyForm : Form
    {
        public BusboyForm()
        {
            InitializeComponent();
        }
        
        
        private void btnTable1_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Server=cis1.actx.edu;Database=Project2;User Id=db2;Password = db20;";
                connection.Open();
                using (SqlCommand updateSeatingArea = connection.CreateCommand())
                {
                    updateSeatingArea.CommandText = "update dbo.SeatingArea set SeatingAreaStatus = @SeatingAreaStatus where ID = @ID;";
                    var seatingAreaParam = new SqlParameter("SeatingAreaStatus", SqlDbType.VarChar) { Value = "Open" };
                    var idParam = new SqlParameter("ID", SqlDbType.Int) { Value = 1 };
                    updateSeatingArea.Parameters.Add(seatingAreaParam);
                    updateSeatingArea.Parameters.Add(idParam);

                    updateSeatingArea.ExecuteNonQuery();
                    connection.Close();
                }
                    MessageBox.Show("Table 1 has been set to Open");
                
            }
            catch
            {

            }
        }

        private void btnTable2_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Server=cis1.actx.edu;Database=Project2;User Id=db2;Password = db20;";
                connection.Open();
                using (SqlCommand updateSeatingArea = connection.CreateCommand())
                {
                    updateSeatingArea.CommandText = "update dbo.SeatingArea set SeatingAreaStatus = @SeatingAreaStatus where ID = @ID;";
                    var seatingAreaParam = new SqlParameter("SeatingAreaStatus", SqlDbType.VarChar) { Value = "Open" };
                    var idParam = new SqlParameter("ID", SqlDbType.Int) { Value = 2 };
                    updateSeatingArea.Parameters.Add(seatingAreaParam);
                    updateSeatingArea.Parameters.Add(idParam);

                    updateSeatingArea.ExecuteNonQuery();
                    connection.Close();
                }
                    MessageBox.Show("Table 2 has been set to Open");
                
            }
            catch
            {

            }
        }

        private void btnTable3_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Server=cis1.actx.edu;Database=Project2;User Id=db2;Password = db20;";
                connection.Open();
                using (SqlCommand updateSeatingArea = connection.CreateCommand())
                {
                    updateSeatingArea.CommandText = "update dbo.SeatingArea set SeatingAreaStatus = @SeatingAreaStatus where ID = @ID;";
                    var seatingAreaParam = new SqlParameter("SeatingAreaStatus", SqlDbType.VarChar) { Value = "Open" };
                    var idParam = new SqlParameter("ID", SqlDbType.Int) { Value = 3 };
                    updateSeatingArea.Parameters.Add(seatingAreaParam);
                    updateSeatingArea.Parameters.Add(idParam);

                    updateSeatingArea.ExecuteNonQuery();
                    connection.Close();
                }
                    MessageBox.Show("Table 3 has been set to Open");
                
            }
            catch
            {

            }
        }

        private void btnTable4_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Server=cis1.actx.edu;Database=Project2;User Id=db2;Password = db20;";
                connection.Open();
                using (SqlCommand updateSeatingArea = connection.CreateCommand())
                {
                    updateSeatingArea.CommandText = "update dbo.SeatingArea set SeatingAreaStatus = @SeatingAreaStatus where ID = @ID;";
                    var seatingAreaParam = new SqlParameter("SeatingAreaStatus", SqlDbType.VarChar) { Value = "Open" };
                    var idParam = new SqlParameter("ID", SqlDbType.Int) { Value = 4 };
                    updateSeatingArea.Parameters.Add(seatingAreaParam);
                    updateSeatingArea.Parameters.Add(idParam);

                    updateSeatingArea.ExecuteNonQuery();
                    connection.Close();
                }
                    MessageBox.Show("Table 4 has been set to Open");
                
            }
            catch
            {

            }
        }

        private void btnTable5_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Server=cis1.actx.edu;Database=Project2;User Id=db2;Password = db20;";
                connection.Open();
                using (SqlCommand updateSeatingArea = connection.CreateCommand())
                {
                    updateSeatingArea.CommandText = "update dbo.SeatingArea set SeatingAreaStatus = @SeatingAreaStatus where ID = @ID;";
                    var seatingAreaParam = new SqlParameter("SeatingAreaStatus", SqlDbType.VarChar) { Value = "Open" };
                    var idParam = new SqlParameter("ID", SqlDbType.Int) { Value = 5 };
                    updateSeatingArea.Parameters.Add(seatingAreaParam);
                    updateSeatingArea.Parameters.Add(idParam);

                    updateSeatingArea.ExecuteNonQuery();
                    connection.Close();
                }
                    MessageBox.Show("Table 5 has been set to Open");
                
            }
            catch
            {

            }
        }

        private void btnTable6_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Server=cis1.actx.edu;Database=Project2;User Id=db2;Password = db20;";
                connection.Open();
                using (SqlCommand updateSeatingArea = connection.CreateCommand())
                {
                    updateSeatingArea.CommandText = "update dbo.SeatingArea set SeatingAreaStatus = @SeatingAreaStatus where ID = @ID;";
                    var seatingAreaParam = new SqlParameter("SeatingAreaStatus", SqlDbType.VarChar) { Value = "Open" };
                    var idParam = new SqlParameter("ID", SqlDbType.Int) { Value = 6 };
                    updateSeatingArea.Parameters.Add(seatingAreaParam);
                    updateSeatingArea.Parameters.Add(idParam);

                    updateSeatingArea.ExecuteNonQuery();
                    connection.Close();
                }
                    MessageBox.Show("Table 6 has been set to Open");
                
            }
            catch
            {

            }
        }

        private void btnTable7_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Server=cis1.actx.edu;Database=Project2;User Id=db2;Password = db20;";
                connection.Open();
                using (SqlCommand updateSeatingArea = connection.CreateCommand())
                {
                    updateSeatingArea.CommandText = "update dbo.SeatingArea set SeatingAreaStatus = @SeatingAreaStatus where ID = @ID;";
                    var seatingAreaParam = new SqlParameter("SeatingAreaStatus", SqlDbType.VarChar) { Value = "Open" };
                    var idParam = new SqlParameter("ID", SqlDbType.Int) { Value = 7 };
                    updateSeatingArea.Parameters.Add(seatingAreaParam);
                    updateSeatingArea.Parameters.Add(idParam);

                    updateSeatingArea.ExecuteNonQuery();
                    connection.Close();
                }
                MessageBox.Show("Table 7 has been set to Open");
            }
            catch
            {

            }
        }
    }
}
