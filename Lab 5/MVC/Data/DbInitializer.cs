using System;
using System.Collections.Generic;
using System.Linq;
using MVC.Models;

namespace MVC.Data
{
  public class DbInitializer
  {
    public static void Initialize(SocialNetworkContext context)
    {
      context.Database.EnsureCreated();

      // Look for any users.
      if (context.Users.Any())
        return; // DB has been seeded

      var users = new[]
      {
        new User {UserId = 0, UserName = "Carson", FullName = "Alexander", Biography = "none", FollowersCount = 2, FollowingCount = 23},
        new User {UserId = 1, UserName = "Meredith", FullName = "Alonso", Biography = "none", FollowersCount = 1, FollowingCount = 2},
        new User {UserId = 2, UserName = "Arturo", FullName = "Anand", Biography = "none", FollowersCount = 111, FollowingCount = 222},
        new User {UserId = 3, UserName = "Gytis", FullName = "Barzdukas", Biography = "none", FollowersCount = 238, FollowingCount = 425},
        new User {UserId = 4, UserName = "Yan", FullName = "Li", Biography = "none", FollowersCount = 42, FollowingCount = 53},
      };

      foreach (var u in users)
        context.Users.Add(u);

      context.SaveChanges();

      var posts = new[]
      {
        new Post {CreatedDate = DateTime.Parse("2005-09-01"), Text = "some post", Author = users[0], LikesCount = 3},
        new Post {CreatedDate = DateTime.Parse("2005-09-01"), Text = "some post", Author = users[0], LikesCount = 123},
        new Post {CreatedDate = DateTime.Parse("2005-09-01"), Text = "some post", Author = users[3], LikesCount = 44},
        new Post {CreatedDate = DateTime.Parse("2005-09-01"), Text = "some post", Author = users[4], LikesCount = 0},
        new Post {CreatedDate = DateTime.Parse("2005-09-01"), Text = "some post", Author = users[2], LikesCount = 645},
      };

      foreach (var p in posts)
        context.Posts.Add(p);

      context.SaveChanges();
    }
  }
}