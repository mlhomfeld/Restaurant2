using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restaurant2
{
    public class Customer
    {
        private string groupName;
        private int groupSize;
        private int groupTable;
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