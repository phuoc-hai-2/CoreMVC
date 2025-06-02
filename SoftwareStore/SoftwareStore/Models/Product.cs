using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoftwareStore.Models
{
    public class Product
    {
        [Key]
        public string Product_Id { get; set; }
        [Required, StringLength(200)]
        public string Product_Name { get; set; }
        public string? Images { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        [Required]
        public decimal Price { get; set; }
        [StringLength(1000)]
        public string? Introduce { get; set; }
        [Required]
        public int Category_Id { get; set; }
        [ForeignKey("Category_Id")]
        public Category? Category { get; set; }
    }
}
