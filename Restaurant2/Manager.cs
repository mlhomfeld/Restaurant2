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
                connection.ConnectionString = "Server=cis1.actx.edu;Database=project1;User Id=db2;Password = db20;";
                connection.Open();
                MessageBox.Show(connection.ServerVersion);

                MessageBox.Show("---SQL INSERT---");
                using (SqlCommand insertNewEmployee = connection.CreateCommand())
                {
                    insertNewEmployee.CommandText = "insert into dbo.Employee values (@FirstName, @LastName, @PayRate, @Password, @Role);";
                    var fnameParam = new SqlParameter("FirstName", SqlDbType.VarChar) { Value = firstName };
                    var lnameParam = new SqlParameter("LastName", SqlDbType.VarChar) { Value = lastName };
                    var prateParam = new SqlParameter("PayRate", SqlDbType.Money) { Value = payRate };
                    var passParam = new SqlParameter("Password", SqlDbType.VarChar) { Value = passWord };
                    var roleParam = new SqlParameter("Role", SqlDbType.VarChar) { Value = role };
                    insertNewEmployee.Parameters.Add(fnameParam);
                    insertNewEmployee.Parameters.Add(lnameParam);
                    insertNewEmployee.Parameters.Add(prateParam);
                    insertNewEmployee.Parameters.Add(passParam);
                    insertNewEmployee.Parameters.Add(roleParam);
                    insertNewEmployee.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }


        }

        public void RemoveEmployee()
        {
            try
            {
                SqlConnection connection = new SqlConnection();
                //Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password = myPassword;
                connection.ConnectionString = "Server=cis1.actx.edu;Database=project1;User Id=db2;Password = db20;";
                connection.Open();
                MessageBox.Show(connection.ServerVersion);

                MessageBox.Show("---SQL INSERT---");
                using (SqlCommand insertNewEmployee = connection.CreateCommand())
                {
                    insertNewEmployee.CommandText = "insert into dbo.Employee values (@EmployeeStatus);";
                    var empStatusParam = new SqlParameter("EmployeeStatus", SqlDbType.VarChar) { Value = "Inactive" };
                    insertNewEmployee.Parameters.Add(empStatusParam);
                    insertNewEmployee.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }


        }

        public void ModifyEmployee(string firstName, string lastName, string payRate, string passWord, string role)
        {
            //try
            //{
            //    SqlConnection connection = new SqlConnection();
            //    //Server = myServerAddress; Database = myDataBase; User Id = myUsername; Password = myPassword;
            //    connection.ConnectionString = "Server=cis1.actx.edu;Database=project1;User Id=db2;Password = db20;";
            //    connection.Open();
            //    MessageBox.Show(connection.ServerVersion);

            //    Console.WriteLine("---SQL UPDATE---");
            //    using (SqlCommand updateEmployee = connection.CreateCommand())
            //    {
            //        updateEmployee.CommandText = " i'll need to ask group about how to set up this database code.;";
            //        var fnameParam = new SqlParameter("FirstName", SqlDbType.VarChar) { Value = firstName };
            //        var lnameParam = new SqlParameter("LastName", SqlDbType.VarChar) { Value = lastName };
            //        var prateParam = new SqlParameter("PayRate", SqlDbType.Money) { Value = payRate };
            //        var passParam = new SqlParameter("Password", SqlDbType.VarChar) { Value = passWord };
            //        var roleParam = new SqlParameter("Role", SqlDbType.VarChar) { Value = role };
            //        updateEmployee.Parameters.Add(fnameParam);
            //        updateEmployee.Parameters.Add(lnameParam);
            //        updateEmployee.Parameters.Add(prateParam);
            //        updateEmployee.Parameters.Add(passParam);
            //        updateEmployee.Parameters.Add(roleParam);
            //        updateEmployee.ExecuteNonQuery();
            //    }
            //}
            //catch (Exception err)
            //{
            //    MessageBox.Show(err.Message);
            //}
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