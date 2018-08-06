using System.Web.Mvc;

namespace NG.mvc.Web.UI.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      ViewBag.Title = "Home page.";
      return View();
    }
    public ActionResult About()
    {
      ViewBag.Title = "Your application description page.";
      return View();
    }

    public ActionResult Contact()
    {
      ViewBag.Title = "Your contact page.";
      return View();
    }
  }
}
