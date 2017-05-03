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
namespace Restaurant2
{
    public partial class HostForm : Form
    {
        public HostForm()
        {
            InitializeComponent();
        }

        private void btnCreateParty_Click(object sender, EventArgs e)
        {

        }

        private void btnTable1_Click(object sender, EventArgs e)
        {

            //DialogResult dialogResult = MessageBox.Show("Are you sure you want to set this table to Occupied?", "!!!", MessageBoxButtons.YesNo);
            //if (dialogResult == DialogResult.Yes)
            //{
            //    try
            //    {

            //        SqlConnection connection = new SqlConnection();
            //        connection.ConnectionString = "Server=cis1.actx.edu;Database=Project2;User Id=db2;Password = db20;";
            //        connection.Open();
            //        using (SqlCommand updateSeatingArea = connection.CreateCommand())
            //        {
            //            updateSeatingArea.CommandText = "update dbo.SeatingArea set SeatingAreaStatus = @SeatingAreaStatus where ID = @ID;";
            //            var seatingAreaParam = new SqlParameter("SeatingAreaStatus", SqlDbType.VarChar) { Value = "Occupied" };
            //            var idParam = new SqlParameter("ID", SqlDbType.Int) { Value = 1 };
            //            updateSeatingArea.Parameters.Add(seatingAreaParam);
            //            updateSeatingArea.Parameters.Add(idParam);

            //            updateSeatingArea.ExecuteNonQuery();
                        
            //        }
            //        MessageBox.Show("Table 1 has been set to Occupied");
            //        connection.Close();
            //    }
            //    catch
            //    {

            //    }
            //}
            //else if (dialogResult == DialogResult.No)
            //{
            //    //do something else
            //}
        }

        private void btnTable2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTable3_Click(object sender, EventArgs e)
        {

        }

        private void btnTable4_Click(object sender, EventArgs e)
        {

        }

        private void btnTable5_Click(object sender, EventArgs e)
        {

        }

        private void btnTable6_Click(object sender, EventArgs e)
        {

        }

        private void btnTable7_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
