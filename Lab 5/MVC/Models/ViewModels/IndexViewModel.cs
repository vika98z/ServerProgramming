using System.Collections.Generic;

namespace MVC.Models.ViewModels
{
  public class IndexViewModel : BasicViewModel
  {
    public List<User> Users { get; set; }
    public List<Post> Posts { get; set; } 
  }
}