﻿using System.ComponentModel.DataAnnotations;

namespace EFCodefirstAssignment.Models
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
