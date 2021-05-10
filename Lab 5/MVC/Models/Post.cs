using System;
using System.Collections.Generic;

namespace MVC.Models
{
  public class Post
  {
    public DateTime CreatedDate { get; set; }
    public int UserId { get; set; }
    public User Author { get; set; }
    public string Text { get; set; }
    public List<User> LikedBy { get; set; }
    
    public string Image { get; set; } 
    
  }
}