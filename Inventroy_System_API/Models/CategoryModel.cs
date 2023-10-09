using Inventroy_System_API.Data;

namespace Inventroy_System_API.Models
{
    public class CategoryModel
    {
        public int CategoryId { get; set; } // Primary Key
        public string Name { get; set; }
        public string Description { get; set; }

        //public List<Products> Products { get; set; } // Navigation property
    }
}
