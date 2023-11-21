using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Stuffed_Animal_Shop.Models
{
    public class Order
    {
        [Key]
        [Column(TypeName = "raw(16)")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid OrderId { get; set; }

        [Column(TypeName = "nvarchar2(100)")]
        public string Status { get; set; } = "Pending";

        [Column(TypeName = "timestamp")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Column(TypeName = "timestamp")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public User User { get; set; }
    }
}
