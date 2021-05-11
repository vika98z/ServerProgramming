using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC.Models
{
  public class User
  {
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int UserId { get; set; }
    public string FullName { get; set; }
    public string UserName { get; set; }
    
    public string Biography { get; set; }
    
    public uint FollowingCount { get; set; }
    public uint FollowersCount { get; set; }
    
    [Display(Name = "UsersImage")]
    public string Image { get; set; } 
    
    public List<Post> Posts { get; set; } = new List<Post>();
  }
}