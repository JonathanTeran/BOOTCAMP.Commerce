using System;
namespace Order.Common
{
    public class Enums
    {
        public enum OrderStatus
        {
            Cancel,
            Pending,
            Approved
        }

        public enum OrderPayment {
            Cash,
            CreditCart,
            Paypal,
            BankTransfer

        }

        
    }
}

