using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stuffed_Animal_Shop.Models
{
    public class Category
    {
        public Category()
        {
            this.Products = new HashSet<Product>();
        }

		[Key]
		[Column(TypeName = "raw(16)")]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public Guid CategoryId { get; set; }

		[Required]
		[Column(TypeName = "nvarchar2(50)")]
		[MinLength(1)]
		public string Name { get; set; }

		[Column(TypeName = "timestamp")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public virtual ICollection<Product> Products { get; set; }
    }
}
