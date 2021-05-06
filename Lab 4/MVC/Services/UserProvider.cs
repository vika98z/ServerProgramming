using MVC.Models;

namespace MVC.Services
{
  public interface IUserPorvider
  {
    User GetCurrentUser();
  }
  
  public class UserProvider : IUserPorvider
  {
    public User GetCurrentUser()
    {
      return new User
        {FullName = "csd", UserNsme = "sxsxsxs", Biography = ":))))))))))))", Image = "https://picsum.photos/150/150"};
    }
  }
}