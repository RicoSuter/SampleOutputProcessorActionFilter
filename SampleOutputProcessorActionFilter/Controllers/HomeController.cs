using System.Web.Mvc;
using SampleOutputProcessorActionFilter.Infrastructure;

namespace SampleOutputProcessorActionFilter.Controllers
{
    public class HomeController : Controller
    {
        [ToUpperFilter]
        public ActionResult Index()
        {
            return View();
        }
    }
}