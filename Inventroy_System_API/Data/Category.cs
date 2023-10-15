using System.ComponentModel.DataAnnotations;

namespace Inventroy_System_API.Data
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; } // Primary Key
        [Required]
        public string? Name { get; set; }
        public string? Description { get; set; }
       // public List<Products> Products { get; set; } // Navigation property
    }
}
