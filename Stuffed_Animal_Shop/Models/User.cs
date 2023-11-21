using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace Stuffed_Animal_Shop.Models
{
	public class User
	{
		[Key]
		[Column(TypeName = "raw(16)")]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public Guid UserId { get; set; }

		[Required]
		[Column(TypeName = "nvarchar2(50)")]
		[EmailAddress]
		public string Email { get; set; }

		[Required]
		[Column(TypeName = "nvarchar2(100)")]
		public string Password { get; set; }

		[Required]
		[Column(TypeName = "nvarchar2(50)")]
		[MinLength(1)]
		public string Name { get; set; }

		[Column(TypeName = "varchar2(10)")]
		[DefaultValue("User")]
		public string? Role { get; set; }

		[Column(TypeName = "nvarchar2(100)")]
		[DefaultValue("")]
		public string? Address { get; set; }

		[Column(TypeName = "nvarchar2(12)")]
		[DefaultValue("")]
		public string? PhoneNumber { get; set; }

		[Column(TypeName = "varchar2(300)")]
		[DefaultValue("")]
		public string? Avatar { get; set; }

		[Column(TypeName = "timestamp")]
		[DefaultValue("CURRENT_TIMESTAMP")]
		public DateTime CreatedAt { get; set; }

		[Column(TypeName = "timestamp")]
		[DefaultValue("CURRENT_TIMESTAMP")]
		public DateTime UpdatedAt { get; set; }

		public virtual Cart Cart { get; set; }
	}
}
