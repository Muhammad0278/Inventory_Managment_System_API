using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Inventroy_System_API.Data
{
    public class Supplier
    {
        //public class SupplierInfo
        //{
          
            [Key]
            public int SupplierId { get; set; } // Primary Key
            [Required]
            public string? Name { get; set; }
            public string? ContactEmail { get; set; }
            public string? ContactPhone { get; set; }
        }
   // }
}
