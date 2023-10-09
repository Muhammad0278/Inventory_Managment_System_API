using Microsoft.EntityFrameworkCore;

namespace Inventroy_System_API.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)       
        { 
        
        }
        public DbSet<Products> tbl_Products { get; set; }
        public DbSet<Category> tbl_Category{ get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=.;Database=InventoryDB; Integrated Security=True");
        //    base.OnConfiguring(optionsBuilder);
        //}

    }
}
