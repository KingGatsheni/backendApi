using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class OrderDetail
    {
        [Key]
        public Guid OrderDetailId { get; set; }
        public Guid OrderId { get; set; }
        public Guid FoodItemId { get; set; }
        public FoodItem FoodItem { get; set; }
        public decimal FoodPrice { get; set; }
        public int Qauntity { get; set; }
    }
}