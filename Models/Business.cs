using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Business
    {
        [Key]
        public Guid BusinessId { get; set; }
        public Guid MerchantId { get; set; }
        public Merchant Merchant { get; set; }
        public string BName { get; set; }
        public string BTelephone { get; set; }
        public string BAddress { get; set; }
        public string CreatedOn { get; set; }
        public List<FoodItem> FoodItems { get; set; }

    }
}