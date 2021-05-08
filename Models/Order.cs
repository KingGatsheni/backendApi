using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Order
    {
        [Key]
        public Guid OrderId { get; set; }
        public long OrderNumber { get; set; }
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
        public Guid BusinessId { get; set; }
        public Business Business { get; set; }
        public String PMethod { get; set; }
        public decimal TotalPrice { get; set; }
        public bool OrderStatus { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }

    }
}