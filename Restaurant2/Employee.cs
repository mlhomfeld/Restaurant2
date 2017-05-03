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

        bool tryAgain = true;

        //public void TimeClock()
        //{
         
        //}

           // This will receive input (employeeID and password) from LoginForm and pass it into the below SQL statement
           public void LogIn(int employeeID, string password)
        {
            try
            {
                
                // This will look up employeeID and password based on input from LoginForm. If both match
                // the database entries, then based on the role associated with that employee,
                // the required form will open for the employee to perform their job. 

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password = db20;";
                con.Open();

                using (SqlCommand readEmployeeRecords = con.CreateCommand())
                {

                    readEmployeeRecords.CommandText = "select * from dbo.Employee where employeeID = @employeeID and password = @password;";
                    var empID = new SqlParameter("employeeID", employeeID);
                    var pass = new SqlParameter("password", password);
                    readEmployeeRecords.Parameters.Add(empID);
                    readEmployeeRecords.Parameters.Add(pass);

                    using (SqlDataReader reader = readEmployeeRecords.ExecuteReader())
                    {
                        string rec = "";
                        while (reader.Read())
                        {
                            rec = reader.GetString(5);
                        }

                        switch(rec)
                        {
                            case "Busboy":
                                BusboyForm bus = new BusboyForm();
                                bus.Show();
                                break;
                            case "Waiter":
                                WaiterForm wait = new WaiterForm();
                                wait.Show();
                                break;
                            case "Manager":
                                ManagerForm man = new ManagerForm();
                                man.Show();
                                break;
                            case "Host":
                                HostForm host = new HostForm();
                                host.Show();
                                break;
                            case "Cook":
                                CookForm cookie = new CookForm();
                                cookie.Show();
                                break;
                        }

                    }

                }


            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        // If any user hits the logout button on their home form, it will restart the application.
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