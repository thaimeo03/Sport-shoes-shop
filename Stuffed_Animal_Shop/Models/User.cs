﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stuffed_Animal_Shop.Models
{
    public class User
    {
        [Key]
        [Column(TypeName = "varchar(36)")]
        public string UserId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Email { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string Password { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "varchar(10)")]
        public string Role { get; set; } = "User";

        [Column(TypeName = "nvarchar(100)")]
        public string Address { get; set; } = "";

        [Column(TypeName = "varchar(300)")]
        public string Avatar { get; set; } = "";

        [Required]
        public Cart Cart { get; set; }
    }
}
