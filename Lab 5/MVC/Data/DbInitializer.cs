using System;
using System.Collections.Generic;
using System.Linq;
using MVC.Models;

namespace MVC.Data
{
  public class DbInitializer
  {
    public static List<Post> PostsStatic=new List<Post>();
    public static void Initialize(SocialNetworkContext context)
    {
      context.Database.EnsureCreated();

      // Look for any users.
      if (context.Users.Any())
        return; // DB has been seeded

      var users = new[]
      {
        new User {UserId = 0, UserName = "Carson", FullName = "Alexander", Biography = "none", FollowersCount = 2, FollowingCount = 23, Image = "https://picsum.photos/150/150"},
        new User {UserId = 1, UserName = "Meredith", FullName = "Alonso", Biography = "none", FollowersCount = 1, FollowingCount = 2, Image = "https://picsum.photos/150/150"},
        new User {UserId = 2, UserName = "Arturo", FullName = "Anand", Biography = "none", FollowersCount = 111, FollowingCount = 222, Image = "https://picsum.photos/150/150"},
        new User {UserId = 3, UserName = "Gytis", FullName = "Barzdukas", Biography = "none", FollowersCount = 238, FollowingCount = 425, Image = "https://picsum.photos/150/150"},
        new User {UserId = 4, UserName = "Yan", FullName = "Li", Biography = "none", FollowersCount = 42, FollowingCount = 53, Image = "https://picsum.photos/150/150"},
      };

      var posts = new[]
      {
        new Post {CreatedDate = DateTime.Parse("2021-09-03"), Text = "some post", AuthorUserId = 0, Author = users[0], LikesCount = 3},
        new Post {CreatedDate = DateTime.Parse("2009-04-05"), Text = "some post", AuthorUserId = 0, Author = users[0], LikesCount = 123},
        new Post {CreatedDate = DateTime.Parse("2003-29-11"), Text = "some post", AuthorUserId = 3, Author = users[3], LikesCount = 44},
        new Post {CreatedDate = DateTime.Parse("2015-09-01"), Text = "some post", AuthorUserId = 4, Author = users[4], LikesCount = 0},
        new Post {CreatedDate = DateTime.Parse("2020-12-07"), Text = "some post", AuthorUserId = 2, Author = users[2], LikesCount = 645},
      };

      PostsStatic = new List<Post>(posts);
      
      users[0].Posts = new List<Post>{posts[0], posts[1]};
      users[2].Posts = new List<Post>{posts[4]};
      users[3].Posts = new List<Post>{posts[2]};
      users[4].Posts = new List<Post>{posts[3]};
      
      foreach (var u in users)
        context.Users.Add(u);

      context.SaveChanges();

      foreach (var p in posts)
        context.Posts.Add(p);

      context.SaveChanges();
    }
  }
}