using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;


namespace Restaurant2
{

    // Making a comment
    public class Employee
    {
        public int userInput;
        private string employeeID;
        private string lastName;
        private string firstName;
        private string role;
        private decimal payRate;
        private double hours;
        bool tryAgain = true;

        public void TimeClock()
        {
         
        }

        public void LogIn(int employeeID, string password)
        {
            try
            {
                // need employee table created... 

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password = db20;";
                con.Open();

                using (SqlCommand readEmployeeRecords = con.CreateCommand())
                {
                    readEmployeeRecords.CommandText = "select * from TABLE where employeeID = " + employeeID + " and password = " + password + " ;";
                    SqlDataAdapter reader = new SqlDataAdapter();
                    DataTable table = new DataTable();
                    reader.Fill(table);

                    do
                    {
                        if (table.Rows.Count == 1)
                        {
                            ManagerForm emp = new ManagerForm();
                            emp.Show();
                            //if (reader.GetString() == busboy)
                            //{
                            //    BusboyForm emp = new BusboyForm();
                            //    emp.Show();
                            //}

                            //if (reader.GetString().role == host)
                            //{
                            //    HostForm emp = new HostForm();
                            //    emp.Show();
                            //}
                            //if (reader.GetString().role == cook)
                            //{
                            //    CookForm emp = new CookForm();
                            //    emp.Show();
                            //}
                            //if (reader.GetString().role == waiter)
                            //{
                            //    WaiterForm emp = new WaiterForm();
                            //    host.Show();
                            //}
                            //if (reader.GetString().role == host)
                            //{
                            //    ManagerForm emp = new ManagerForm();
                            //    emp.Show();
                            //}
                        }
                        else
                        {
                            MessageBox.Show("User or password incorrect, please try again.");
                        }

                    }
                    while (tryAgain);
                }
            }
            catch
            {

            }
        }

        public void LogOut()
        {
            //Application.Exit();
            Application.Restart();
        }

        public void Timestamp()
        {
         
        }
    }
}