using System.IO;
using Newtonsoft.Json;

namespace WebApplication.Controllers
{
  public class About
  {
    public string Title;
    public string SubTitle;
    public string TextLead;
    public string Text;
  }
    
  public class AboutController
  {
    public About Items;
    
    public AboutController() => 
      Items = JsonConvert.DeserializeObject<About>(File.ReadAllText("Data/about.json"));
  }
}