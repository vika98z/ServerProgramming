using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using MVC.Models;

namespace MVC.Data
{
  public class SocialNetworkContext : DbContext
  {
    public SocialNetworkContext(DbContextOptions<SocialNetworkContext> options) 
      : base(options) { }

    public DbSet<User> Users { get; set; }
    public DbSet<Post> Posts { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<User>().ToTable("User");
      modelBuilder.Entity<Post>().ToTable("Post");
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      var connectionStringBuilder = new SqliteConnectionStringBuilder { DataSource = "MyDb.db" };
      var connectionString = connectionStringBuilder.ToString();
      var connection = new SqliteConnection(connectionString);

      optionsBuilder.UseSqlite(connection);
    }
  }
}