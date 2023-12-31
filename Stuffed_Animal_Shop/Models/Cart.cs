﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stuffed_Animal_Shop.Models
{
    public class Cart
    {

        [Key]
		[Column(TypeName = "raw(16)")]
        [ForeignKey("User")]
		public Guid CartId { get; set; }

        public virtual User User { get; set; }
    }
}