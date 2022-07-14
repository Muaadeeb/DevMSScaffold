namespace DataAccess.Data
{
	public class AppDbContext : IdentityDbContext
	{
		// Code First:
		// 1). add-migration initialCommit
		// 2). update-database

		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{

		}

		public DbSet<Auto> Autos { get; set; } = null!;
	}
}
