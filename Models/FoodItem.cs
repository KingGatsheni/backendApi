using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class FoodItem
    {
        [Key]
        public Guid FoodItemId { get; set; }
        public string FoodItemName { get; set; }
        public string Category { get; set; }   
        public string FoodItemImage { get; set; }
        public string Description { get; set; }
        public bool FoodItemStatus { get; set; }
        public decimal Price { get; set; }
    }
}