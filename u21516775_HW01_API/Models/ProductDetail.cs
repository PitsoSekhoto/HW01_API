using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace u21516775_HW01_API.Models
{
    public class ProductDetail
    {
        [Key]
        public int ProductId { get; set; }

        [Required]

        [Column(TypeName = "nvarchar(100)")]
        public string ProductName { get; set; } = string.Empty;

        
        public string Description { get; set; } = string.Empty;

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; } 
    }
}
