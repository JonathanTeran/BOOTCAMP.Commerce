using System;
using System.Collections.Generic;
using static Order.Common.Enums;

namespace Order.Domain
{
    public class Order
    {
        public int OrderId { get; set; }
        public Common.Enums.OrderStatus Status { get; set; }
        public OrderPayment PaymentType { get; set; }
        public int ClientId { get; set; }
        public IEnumerable<OrderDetail> Items { get; set; } = new List<OrderDetail>();
        public DateTime CreateAt { get; set; }
        public decimal Total { get; set; }

    }
}

