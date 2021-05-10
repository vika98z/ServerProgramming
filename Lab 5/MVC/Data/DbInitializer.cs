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
            new User{UserId = 0, UserName= "Carson",FullName="Alexander", Biography = "none"},
            new User{UserId = 1, UserName= "Meredith",FullName="Alonso", Biography = "none"},
            new User{UserId = 2, UserName= "Arturo",FullName="Anand", Biography = "none"},
            new User{UserId = 3, UserName= "Gytis",FullName="Barzdukas", Biography = "none"},
            new User{UserId = 4, UserName= "Yan",FullName="Li", Biography = "none"},
            };
            
            foreach (User u in users)
                context.Users.Add(u);
            
            context.SaveChanges();

            var posts = new Post[]
            {
            new Post{CreatedDate=DateTime.Parse("2005-09-01"),  Text = "some post", User = users[0]},
            new Post{CreatedDate=DateTime.Parse("2005-09-01"),  Text = "some post", User = users[0]},
            new Post{CreatedDate=DateTime.Parse("2005-09-01"),  Text = "some post", User = users[3]},
            new Post{CreatedDate=DateTime.Parse("2005-09-01"),  Text = "some post", User = users[4]},
            new Post{CreatedDate=DateTime.Parse("2005-09-01"),  Text = "some post", User = users[2]},
            };
            
            foreach (Post p in posts)
                context.Posts.Add(p);

            context.SaveChanges();
        }
  }
}