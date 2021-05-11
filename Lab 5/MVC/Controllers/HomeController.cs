using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MVC.Models;
using MVC.Services;

namespace MVC.Controllers
{
  public class HomeController : Controller
  {
    private readonly IUserPorvider _user;
    private readonly IPostProvider _posts;

    public HomeController(IUserPorvider up, IPostProvider pp)
    {
      _user = up;
      _posts = pp;
    }

    public IActionResult Index()
    {
      var model = new View();

      model.Title = "Home Page";

      model.Users = new List<User> {_user.GetCurrentUser()};
      model.Posts = _posts.GetPostsForUser(model.Users[0]);
      
      return View(model);
    }

    public IActionResult Privacy()
    {
      return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
    }
  }
}