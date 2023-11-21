using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace Stuffed_Animal_Shop.Models
{
    public class Image
    {
        [Key]
        [Column(TypeName = "raw(16)")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ImageId { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Column(TypeName = "timestamp")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public Product Product { get; set; }
    }
}
