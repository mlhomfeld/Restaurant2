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
    public class Customer
    {
        // SqlConnection connection = new SqlConnection();

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


        //take the payment and subtract to the grouptotal;
        //if they didn't pay enough keep subtrace.

        // ------------------

        //private decimal groupTotal;
        public decimal GroupTotal { get; set; }

        // This method's internal commented code shows a seperate potential way to 
        // handle the payment logic depending on how the Waiter class operates.
        public void Pay(decimal payment/*string rawGroupTotal, string rawPayment*/)
        {
            //decimal payment = 0M;
            //decimal groupTotal = 0M;
            //decimal remainingBalance = 0M;
            //if(decimal.TryParse(rawGroupTotal, out groupTotal))
            //{
            //    if(decimal.TryParse(rawPayment, out payment))
            //    {
            //        remainingBalance = groupTotal - payment;
            //        if (remainingBalance < 0M)
            //        {
            //            remainingBalance = remainingBalance * -1;
            //            MessageBox.Show("Your change is $" + remainingBalance.ToString("F2") + "!", "Change");
            //        }
            //        else
            //        {
            //            groupTotal = remainingBalance;
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Payment must only use numeric characters.","Error");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Group Total must only use numeric characters.", "Error");
            //}
            decimal remainingBalance = GroupTotal - payment;
            if (remainingBalance < 0M)
            {
                remainingBalance = remainingBalance * -1;
                MessageBox.Show("Your change is $" + remainingBalance.ToString("F2") + "!", "Change");
            }
            else
            {
                GroupTotal = remainingBalance;
            }
        }

        // ------------------


        //public void Pay (decimal Payment )
        //{

        //    decimal remainingBalance = groupTotal - Payment;
        //    //if the customers pay more then they own
        //    if(remainingBalance < 0)
        //    {

        //        MessageBox.Show("You change is " + remainingBalance.ToString());
        //    }
        //    //if the customers pay less then they own
        //    //else if(remainingBalance > 0)
        //    //{

        //    //        remainingBalance = groupTotal - Payment;
        //    //        MessageBox.Show("You own " + remainingBalance.ToString());

        //    //}
        //    //else

        //    //if (Payment >=  groupTotal)
        //    //{
        //    //        groupTotal = groupTotal - Payment;
        //    //        MessageBox.Show("Your change is " + groupTotal );


        //    //        //break;

        //    //}
        //    //else
        //    //{
        //    //        groupTotal = groupTotal - Payment;
        //    //        MessageBox.Show("Thank you");

        //    //}
        //}
    }
}