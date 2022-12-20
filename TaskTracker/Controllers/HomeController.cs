using Microsoft.AspNetCore.Mvc;

namespace TaskTracker.Controllers
{
  [Controller]
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      return View();
    }
  }
}
