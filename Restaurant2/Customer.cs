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


        // This method is used on the Pay form for the Pay button logic
        public string Pay(string rawGroupTotal, string rawPayment)
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
        }
    }
}