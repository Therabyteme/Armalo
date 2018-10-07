using System.Web.Mvc;
using APIARMALO.Models;

namespace APIARMALO.Controllers
{
    public class HomeController : Controller
    {
        Conexion conexion;
        public HomeController()
        {
            conexion = new Conexion();
        }
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            ConectarBD cc = ConectarBD.Connectar();

            return View();
        }
    }
}
