using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoftwareStore.Models
{
    public class User
    {
        [Key]
        public int User_Id { get; set; }
        public string? Name { get; set; }
        public DateTime? DOB { get; set; }
    }
}
