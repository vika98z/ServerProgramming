using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
  public class User
  {
    public string FullName { get; set; }
    public string UserNsme { get; set; }
    
    public string Biography { get; set; }
    
    [Display(Name = "Following")]
    public List<User> Following { get; set; }
    [Display(Name = "Followers")]
    public List<User> Followers { get; set; }
    
    [Display(Name = "UsersImage")]
    public string Image { get; set; } 
  }
}