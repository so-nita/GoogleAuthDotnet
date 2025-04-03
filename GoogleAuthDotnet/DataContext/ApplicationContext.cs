using GoogleAuthDotnet.Entities;
using Microsoft.EntityFrameworkCore;

namespace GoogleAuthDotnet.DataContext
{
	public class ApplicationContext : DbContext
	{
		public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
		{
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			//modelBuilder.Entity<User>().ToTable("Users");
		}
		public DbSet<User> Users { get; set; } = null!;
	}
}
