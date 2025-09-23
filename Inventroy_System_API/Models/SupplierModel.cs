using System.ComponentModel.DataAnnotations;

namespace Inventroy_System_API.Models
{
    public class SupplierModel
    {
        public int SupplierId { get; set; } // Primary Key
        public string Name { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPhone { get; set; }
    }
}
