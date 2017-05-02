using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Restaurant2
{
    public class Manager : Employee
    {
        public void CreateEmployee(string firstName, string lastName, string payRate, string passWord, string role)
        {
            //SqlConnection connection = new SqlConnection();
            ////Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password = myPassword;
            //connection.ConnectionString = "Server=cis1.actx.edu;Database=project1;User Id=db1;Password = db10;";
            //connection.Open();
            //MessageBox.Show(connection.ServerVersion);

            //MessageBox.Show("---SQL INSERT---");
            //using (SqlCommand insertNewEmployee = connection.CreateCommand())
            //{
            //    insertNewEmployee.CommandText = "insert into dbo.Professor values (@FirstName, @LastName, @Degree);";
            //    var fnameParam = new SqlParameter("FirstName", SqlDbType.VarChar) { Value = firstName };
            //    var lnameParam = new SqlParameter("LastName", SqlDbType.VarChar) { Value = lastName };
            //    var prateParam = new SqlParameter("PayRate", SqlDbType.VarChar) { Value = payRate };
            //    var passParam = new SqlParameter("Password", SqlDbType.VarChar) { Value = passWord };
            //    var roleParam = new SqlParameter("Role", SqlDbType.VarChar) { Value = role };
            //    insertNewEmployee.Parameters.Add(fnameParam);
            //    insertNewEmployee.Parameters.Add(lnameParam);
            //    insertNewEmployee.Parameters.Add(prateParam);
            //    insertNewEmployee.Parameters.Add(passParam);
            //    insertNewEmployee.Parameters.Add(roleParam);
            //    insertNewEmployee.ExecuteNonQuery();
            //}
            

        }

        public void RemoveEmployee()
        {
            throw new System.NotImplementedException();
        }

        public void ModifyEmployee()
        {
            throw new System.NotImplementedException();
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