using System;
using System.Collections.Generic;

namespace MVC.Models
{
  public class Post
  {
    public DateTime CreatedDate { get; set; }
    public int PostId { get; set; }
    public string Text { get; set; }
    public uint LikesCount { get; set; }
    public string Image { get; set; } 
    public User Author { get; set; }
    public int AuthorUserId { get; set; }
  }
}