using System.ComponentModel.DataAnnotations;

namespace Inventroy_System_API.Data
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; } // Primary Key
        [Required]
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public int? StockQuantity { get; set; }
        [Required]
        public int? CategoryId { get; set; } // Foreign Key
       // public Category Category { get; set; } // Navigation property
        
    }
}
