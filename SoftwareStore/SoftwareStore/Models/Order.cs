using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoftwareStore.Models
{
    public class Order
    {
        [Key]
        public string Order_Id { get; set; }
        public DateTime DayBought { get; set; }
        public int? User_Id { get; set; }
        [ForeignKey("User_Id")]
        public User? User { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal TotalAmount { get; set; }
        public Order()
        {
            DayBought = DateTime.UtcNow;
        }
    }
}