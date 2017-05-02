using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

namespace Restaurant2
{
    public class Customer
    {
        SqlConnection connection = new SqlConnection();

            //Connection.ConnectionString = "Server=cis1.actx.edu;Database=Restaurant2;User Id=db1;Password = db10;";
            //connection.Open();
            //Console.WriteLine(connection.ServerVersion);
            //Console.ReadKey();

            //Console.WriteLine("---SQL INSERT---");
            //using (SqlCommand insertNewProfessor = connection.CreateCommand())
            //{
            //    insertNewProfessor.CommandText = "insert into dbo.Professor values (@FirstName, @LastName, @Degree);";
            //    var degreeParam = new SqlParameter("Degree", SqlDbType.VarChar) { Value = "M.S. in IS" };
            //    var fnameParam = new SqlParameter("FirstName", SqlDbType.VarChar) { Value = "Dewayne" };
            //    var lnameParam = new SqlParameter("LastName", SqlDbType.VarChar) { Value = "Higgs" };
            //    insertNewProfessor.Parameters.Add(degreeParam);
            //    insertNewProfessor.Parameters.Add(fnameParam);
            //    insertNewProfessor.Parameters.Add(lnameParam);
            //    insertNewProfessor.ExecuteNonQuery();
            //}
            //Console.ReadKey();
        //private string groupName;
        //private int groupSize;
        //private int groupTable;
        private decimal groupTotal;

        public void Pay (decimal Payment )
        {
            while(true)
            {
                if(Payment >= groupTotal)
                {
                    Console.WriteLine("You payment is not enough ");

                    break;
                
                }
                else
                {
                    groupTotal = groupTotal - Payment;
                    Console.WriteLine("Thank you");
                    //groupTotal = groupTotal;
                }
                    //take the payment and subtrace to the grouptotal;
                    //if they didn't pay enough keep subtrace.
             
             }

        }
    }
}