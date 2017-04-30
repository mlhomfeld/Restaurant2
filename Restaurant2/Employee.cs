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
                    // Playing around with a couple of ways to do this... 

                    readEmployeeRecords.CommandText = "select * from TABLE where employeeID = " + employeeID + " and password = " + password + " ;";
                    SqlDataAdapter reader = new SqlDataAdapter();
                    DataTable table = new DataTable();
                    reader.Fill(table);

                    //readEmployeeRecords.CommandText = "select * from TABLE where employeeID = @employeeID and password = @password;";
                    //var fnameParam = new SqlParameter(employeeID.ToString(), password);
                    //readEmployeeRecords.Parameters.Add(fnameParam);
                    //SqlDataAdapter adapter = new SqlDataAdapter();
                    //DataTable table = new DataTable();

                    //using (SqlDataReader reader = readEmployeeRecords.ExecuteReader())
                    //{
                    //    string rec = "";
                    //    while(reader.Read())
                    //    {
                    //        rec = reader.GetString(1);
                    //        rec += reader.GetString(2);
                    //    }

                    //}

                    do
                        {
                            if (table.Rows.Count == 1)
                            {
                                ManagerForm emp = new ManagerForm();
                                emp.Show();
                                tryAgain = false;
                            //if (reader.GetString(2) == busboy)
                            //{
                            //    BusboyForm emp = new BusboyForm();
                            //    emp.Show();
                            //    tryAgain = false;
                            //}
                            //if (reader.GetString(2).role == host)
                            //{
                            //    HostForm emp = new HostForm();
                            //    emp.Show();
                            //    tryAgain = false;
                            //}
                            //if (reader.GetString(2).role == cook)
                            //{
                            //    CookForm emp = new CookForm();
                            //    emp.Show();
                            //    tryAgain = false;
                            //}
                            //if (reader.GetString(2).role == waiter)
                            //{
                            //    WaiterForm emp = new WaiterForm();
                            //    host.Show();
                            //    tryAgain = false;
                            //}
                            //if (reader.GetString(2).role == host)
                            //{
                            //    ManagerForm emp = new ManagerForm();
                            //    emp.Show();
                            //    tryAgain = false;
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
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        public void LogOut()
        {
           Application.Restart();
        }

        public void Timestamp(string target, int order)
        {
            try
            {
                string date = "";
                date = System.DateTime.Now.ToString();
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password = db20;";
                con.Open();
                using (SqlCommand stampIt = con.CreateCommand())
                {
                    stampIt.CommandText = "update TABLE" + target + "set " + date + " where " + order + " = " + order + ";";
                    var timeStamp = new SqlParameter("TimeStamp", SqlDbType.Date) { Value = date };
                    stampIt.Parameters.Add(timeStamp);
                    stampIt.ExecuteNonQuery();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }
    }
}