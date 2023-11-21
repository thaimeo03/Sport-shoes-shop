using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stuffed_Animal_Shop.Models
{
    public class Color
    {
        [Key]
		[Column(TypeName = "raw(16)")]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public Guid ColorId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar2(10)")]
        public string Name { get; set; }

        public Product Product { get; set; }
    }
}
