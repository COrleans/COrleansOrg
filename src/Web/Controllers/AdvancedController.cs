using System.Web.Mvc;

namespace COrleans.Web.Controllers
{
    public class AdvancedController : Controller
    {
        [Route("~/advanced/concept")]
        public ActionResult Concept()
        {
            return View();
        }
    }
}