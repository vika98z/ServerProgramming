using System;
using System.Collections.Generic;
using MVC.Models;

namespace MVC.Services
{
  public interface IPostProvider
  {
    List<Post> GetPostsForUser(User user);
  }
  
  public class PostProvider : IPostProvider
  {
    public List<Post> GetPostsForUser(User user)
    {
      return new List<Post>
      {
        new Post
        {
          CreatedDate = new DateTime(2021, 1, 1),
          Author = user,
          Text = "cjnsdljc sdscj ndkshfv sfjvdfslkv"
        },
        new Post
        {
          CreatedDate = new DateTime(2021, 5, 1),
          Author = user,
          Text = "mkva;f vsvf 222222222222222",
          Image = "https://picsum.photos/300/300"
        },
        new Post
        {
          CreatedDate = new DateTime(2021, 5, 6),
          Author = user,
          Text = "jfvnsd dvsk fvdfv",
          Image = "https://picsum.photos/300/300"
        }
      };
    }
  }
}