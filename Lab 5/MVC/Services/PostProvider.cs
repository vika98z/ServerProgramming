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
          //User = user,
          Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quo recusandae nulla rem eos ipsa praesentium esse magnam nemo dolor sequi fuga quia quaerat cum, obcaecati hic, molestias minima iste voluptates."
        },
        new Post
        {
          CreatedDate = new DateTime(2021, 3, 1),
          //User = user,
          Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quo recusandae nulla rem eos ipsa praesentium esse magnam nemo dolor sequi fuga quia quaerat cum, obcaecati hic, molestias minima iste voluptates.",
          Image = "https://picsum.photos/300/300"
        },
        new Post
        {
          CreatedDate = new DateTime(2021, 5, 6),
          //User = user,
          Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quo recusandae nulla rem eos ipsa praesentium esse magnam nemo dolor sequi fuga quia quaerat cum, obcaecati hic, molestias minima iste voluptates.",
          Image = "https://picsum.photos/200/200"
        }
      };
    }
  }
}