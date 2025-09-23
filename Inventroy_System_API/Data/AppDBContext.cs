using Microsoft.EntityFrameworkCore;

namespace Inventroy_System_API.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)       
        { 
        
        }
        public DbSet<Supplier> tbl_Supplier { get; set; }
        public DbSet<Products> tbl_Products { get; set; }
        public DbSet<Category> tbl_Category{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Supplier>()
            //    .HasKey(s => s.SupplierId);
            base.OnModelCreating(modelBuilder);

            // Configure other entities here, if needed.
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=.;Database=InventoryDB; Integrated Security=True");
        //    base.OnConfiguring(optionsBuilder);
        //}

    }
}
