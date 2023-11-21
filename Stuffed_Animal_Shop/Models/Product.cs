using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stuffed_Animal_Shop.Models
{
    public class Product
    {
        public Product() {
            this.Categories = new HashSet<Category>();
        }

        [Key]
        [Column(TypeName = "raw(16)")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ProductId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar2(100)")]
        [MinLength(1)]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "int")]
        public int Price { get; set; }

        [Required]
        [Column(TypeName = "int")]
        public int Quantity { get; set; }

        [Column(TypeName = "int")]
        public int Sold { get; set; } = 0;

        [Required]
        [Column(TypeName = "nvarchar2(300)")]
        public string Description { get; set; }

        [Required]
        [Column(TypeName = "nvarchar2(200)")]
        public string MainImage { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Column(TypeName = "timestamp")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public virtual CartItem CartItem { get; set; }
        public virtual ICollection<Category> Categories { get; set; }

    }
}
