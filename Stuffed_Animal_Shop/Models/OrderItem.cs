﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Stuffed_Animal_Shop.Models
{
    public class OrderItem
    {
        [Key]
        [Column(TypeName = "raw(16)")]
        public Guid OrderItemId { get; set; }

        [Required]
        public Guid ProductId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar2(100)")]
        [MinLength(1)]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "int")]
        public int Count { get; set; }

        [Required]
        [Column(TypeName = "nvarchar2(10)")]
        public string Size { get; set; }

        [Required]
        [Column(TypeName = "nvarchar2(10)")]
        public string Color { get; set; }

        [Required]
        [Column(TypeName = "nvarchar2(200)")]
        public string Image { get; set; }

        [Required]
        [Column(TypeName = "int")]
        public int ItemPrice { get; set; }

        public Order Order { get; set; }
    }
}
