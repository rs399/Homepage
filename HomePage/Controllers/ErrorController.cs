using System.Web.Mvc;

namespace CreepyStuff.HomePage.Controllers
{
    public class ErrorController : Controller
    {
        // GET: /Error/
        public ActionResult Index()
        {
            Response.StatusCode = 500;
            return View("Error");
        }

        // GET: /Error/PageNotFound
        public ActionResult PageNotFound()
        {
            Response.StatusCode = 404;
            return View();
        }
    }
}