using Microsoft.EntityFrameworkCore;
using appMvcEF.Models;
namespace appMvcEF.Data
{
	public class AppDbContext:DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
		{

		}

		public DbSet<Product> Products { get; set; }

		public DbSet<Warranty> Warrantys { get; set; }

		public DbSet<User> Users { get; set; }
		public DbSet<Rol> Rols { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Product>().ToTable("Product");
		}
	    public DbSet<appMvcEF.Models.Category> Category { get; set; } = default!;
	}
}
