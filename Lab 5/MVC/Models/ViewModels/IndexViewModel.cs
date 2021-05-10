using System.Collections.Generic;

namespace MVC.Models.ViewModels
{
  public class IndexViewModel : BasicViewModel
  {
    public User User { get; set; }
    public List<Post> Posts { get; set; } 
  }
}