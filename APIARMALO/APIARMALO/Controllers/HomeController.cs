using System.Web.Mvc;

namespace APIARMALO.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            ConectarBD cc = ConectarBD.Connectar();

            return View();
        }
    }
}
