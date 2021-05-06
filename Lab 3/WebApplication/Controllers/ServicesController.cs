using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace WebApplication.Controllers
{
  public class Service
  {
    public string Title;
    public string Text;
  }
    
  public class ServicesController
  {
    public List<Service> Items;
    
    public ServicesController() => 
      Items = JsonConvert.DeserializeObject<List<Service>>(File.ReadAllText("Data/services.json"));
  }
}