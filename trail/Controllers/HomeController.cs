using System.Web.Mvc;
using trail.Models;

namespace trail.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
//            var someObject = new {ModelValue = 5};

            var model = new ModelValue();

            return View(model);
        }
    }
}