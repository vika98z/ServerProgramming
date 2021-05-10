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
  }
}