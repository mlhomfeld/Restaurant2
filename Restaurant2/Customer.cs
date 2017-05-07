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

        //public decimal GroupTotal { get; set; }

        // This method's internal commented code shows a seperate potential way to 
        // handle the payment logic depending on how the Waiter class operates.
        public string Pay(/*decimal payment*/string rawGroupTotal, string rawPayment)
        {
            decimal payment = 0M;
            decimal groupTotal = 0M;
            decimal remainingBalance = 0M;
            if (decimal.TryParse(rawGroupTotal, out groupTotal))
            {
                if (decimal.TryParse(rawPayment, out payment))
                {
                    remainingBalance = groupTotal - payment;
                    if (remainingBalance < 0M)
                    {
                        remainingBalance = remainingBalance * -1;
                        MessageBox.Show("Your change is $" + remainingBalance.ToString("F2") + "!", "Change");
                        remainingBalance = remainingBalance * -1;
                    }
                    else
                    {
                        groupTotal = remainingBalance;
                    }
                }
                else
                {
                    MessageBox.Show("Payment must only use numeric characters.", "Error");
                }
            }
            else
            {
                MessageBox.Show("Group Total must only use numeric characters.", "Error");
            }
            return remainingBalance.ToString();
            //decimal remainingBalance = GroupTotal - payment;
            //if (remainingBalance < 0M)
            //{
            //    remainingBalance = remainingBalance * -1;
            //    MessageBox.Show("Your change is $" + remainingBalance.ToString("F2") + "!", "Change");
            //}
            //else
            //{
            //    GroupTotal = remainingBalance;
            //}
        }
    }
}