using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Stuffed_Animal_Shop.Models
{
    public class Review
    {
        [Key]
        [Column(TypeName = "raw(16)")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ReviewId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar2(100)")]
        [EmailAddress]
        public string EmailUser { get; set; }

        [Column(TypeName = "int")]
        public int ?Rating { get; set; } = null;

        [Column(TypeName = "nvarchar2(100)")]
        public string ?Comment { get; set; } = null;

        [Column(TypeName = "timestamp")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public Product Product { get; set; }
    }
}
