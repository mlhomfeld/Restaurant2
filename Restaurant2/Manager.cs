using System;
using System.Collections.Generic;
using System.Data.SqlClient;

using System.Data.Sql;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace Restaurant2
{
    public class Manager : Employee
    {
        public void CreateEmployee(string firstName, string lastName, string payRate, string passWord, string role)
        {
            try
            {
                SqlConnection connection = new SqlConnection();
                //Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password = myPassword;
                connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password = db20;";
                connection.Open();


                MessageBox.Show("Attempting to insert employee");
                using (SqlCommand insertNewEmployee = connection.CreateCommand())
                {
                    insertNewEmployee.CommandText = "insert into dbo.Employee values (@FirstName, @LastName, @PayRate, @Password, @Role, @EmployeeStatus, @Passcode);";
                    //var idParam = new SqlParameter("EmployeeID", SqlDbType.VarChar) { Value = "*" };
                    var fnameParam = new SqlParameter("FirstName", SqlDbType.VarChar) { Value = firstName };
                    var lnameParam = new SqlParameter("LastName", SqlDbType.VarChar) { Value = lastName };
                    var prateParam = new SqlParameter("PayRate", SqlDbType.Money) { Value = payRate };
                    var passParam = new SqlParameter("Password", SqlDbType.VarChar) { Value = passWord };
                    var roleParam = new SqlParameter("Role", SqlDbType.VarChar) { Value = role };
                    var empStatusParam = new SqlParameter("EmployeeStatus", SqlDbType.VarChar) { Value = "Active" };
                    var passcodeParam = new SqlParameter("Passcode", SqlDbType.Int) { Value = null }; // changed to null, set value if error arises and try again.
                    //insertNewEmployee.Parameters.Add(idParam);
                    insertNewEmployee.Parameters.Add(fnameParam);
                    insertNewEmployee.Parameters.Add(lnameParam);
                    insertNewEmployee.Parameters.Add(prateParam);
                    insertNewEmployee.Parameters.Add(passParam);
                    insertNewEmployee.Parameters.Add(roleParam);
                    insertNewEmployee.Parameters.Add(empStatusParam);
                    insertNewEmployee.Parameters.Add(passcodeParam);
                    insertNewEmployee.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Employee added succesfully");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }


        }

        public void RemoveEmployee(string employeeID)
        {
            try
            {
                SqlConnection connection = new SqlConnection();
                //Server = myServerAddress; Database = myDataBase; User Id = myUsername; Password = myPassword;
                connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password = db20;";
                connection.Open();


                Console.WriteLine("Attempting to change employee status.");
                using (SqlCommand updateEmployee = connection.CreateCommand())
                {
                    updateEmployee.CommandText = "update dbo.Employee set EmployeeStatus = @EmployeeStatus where EmployeeID = " + employeeID + ";";
                    var empIDParam = new SqlParameter("EmployeeStatus", SqlDbType.VarChar) { Value = "Inactive" };
                    updateEmployee.Parameters.Add(empIDParam);

                    updateEmployee.ExecuteNonQuery();
                    MessageBox.Show("Employee set to inactive.");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }


        }

        public void ModifyEmployee(string employeeID, string firstName, string lastName, string payRate, string passWord, string role)
        {
            try
            {
                SqlConnection connection = new SqlConnection();
                //Server = myServerAddress; Database = myDataBase; User Id = myUsername; Password = myPassword;
                connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password = db20;";
                connection.Open();
                

                Console.WriteLine("Attempting to update employee.");
                using (SqlCommand updateEmployee = connection.CreateCommand())
                {
                    updateEmployee.CommandText = "update dbo.Employee set FirstName = @FirstName, LastName = @LastName, PayRate = @PayRate, Password = @Password, Role = @Role, EmployeeStatus = @EmployeeStatus, Passcode = @Passcode where EmployeeID = " + employeeID + "; ";
                    var fnameParam = new SqlParameter("FirstName", SqlDbType.VarChar) { Value = firstName };
                    var lnameParam = new SqlParameter("LastName", SqlDbType.VarChar) { Value = lastName };
                    var prateParam = new SqlParameter("PayRate", SqlDbType.Money) { Value = payRate };
                    var passParam = new SqlParameter("Password", SqlDbType.VarChar) { Value = passWord };
                    var roleParam = new SqlParameter("Role", SqlDbType.VarChar) { Value = role };
                    var empStatusParam = new SqlParameter("EmployeeStatus", SqlDbType.VarChar) { Value = "Active" };
                    var passcodeParam = new SqlParameter("Passcode", SqlDbType.Int) { Value = 2 };
                    updateEmployee.Parameters.Add(fnameParam);
                    updateEmployee.Parameters.Add(lnameParam);
                    updateEmployee.Parameters.Add(prateParam);
                    updateEmployee.Parameters.Add(passParam);
                    updateEmployee.Parameters.Add(roleParam);
                    updateEmployee.Parameters.Add(empStatusParam);
                    updateEmployee.Parameters.Add(passcodeParam);
                    updateEmployee.ExecuteNonQuery();
                    MessageBox.Show("Employee updated.");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        public void CheckSales()
        {
            throw new System.NotImplementedException();
        }

        public void CheckTurnover()
        {
            throw new System.NotImplementedException();
        }

        public void PayEmployee()
        {
            throw new System.NotImplementedException();
        }

        public void CheckInventory()
        {
            throw new System.NotImplementedException();
        }
    }
}