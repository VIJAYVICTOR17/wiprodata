﻿using System.ComponentModel.DataAnnotations;

namespace CarProg.Models
{
    public class Customer
    {
        [Key]
        public int customerID { get; set; }
        public string? firstName { get; set; }
        public string? lastName { get; set; }
        public string? email { get; set; }
        public string? phoneNumber { get; set; }
    }
}
