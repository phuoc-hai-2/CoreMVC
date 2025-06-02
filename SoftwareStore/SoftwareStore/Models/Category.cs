using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoftwareStore.Models
{
    public class Category
    {
        [Key]
        public int Category_Id { get; set; }
        public string Category_Name { get; set; }

        public List<Product> Products { get; set; } = new List<Product>();
    }
}
