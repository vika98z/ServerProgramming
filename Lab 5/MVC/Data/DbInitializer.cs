using System;
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
                return;   // DB has been seeded

            var users = new User[]
            {
            new User{Id = 0, UserNsme= "Carson",FullName="Alexander", Biography = "none"},
            new User{Id = 1, UserNsme= "Meredith",FullName="Alonso", Biography = "none"},
            new User{Id = 2, UserNsme= "Arturo",FullName="Anand", Biography = "none"},
            new User{Id = 3, UserNsme= "Gytis",FullName="Barzdukas", Biography = "none"},
            new User{Id = 4, UserNsme= "Yan",FullName="Li", Biography = "none"},
            };
            
            foreach (User u in users)
                context.Users.Add(u);
            
            context.SaveChanges();

            var posts = new Post[]
            {
            new Post{CreatedDate=DateTime.Parse("2005-09-01"), UserId = 0, Text = "some post"},
            new Post{CreatedDate=DateTime.Parse("2005-09-01"), UserId = 0, Text = "some post"},
            new Post{CreatedDate=DateTime.Parse("2005-09-01"), UserId = 3, Text = "some post"},
            new Post{CreatedDate=DateTime.Parse("2005-09-01"), UserId = 4, Text = "some post"},
            new Post{CreatedDate=DateTime.Parse("2005-09-01"), UserId = 2, Text = "some post"},
            };
            
            foreach (Post p in posts)
                context.Posts.Add(p);

            context.SaveChanges();
        }
  }
}