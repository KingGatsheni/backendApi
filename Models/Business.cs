using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Business
    {
        [Key]
        public Guid BussinessId { get; set; }
        public Guid MerchantId { get; set; }
        public Merchant Merchant { get; set; }
        public string BName { get; set; }
        public string BTelephone { get; set; }
        public string BAddress { get; set; }
        public string CreatedOn { get; set; }

    }
}