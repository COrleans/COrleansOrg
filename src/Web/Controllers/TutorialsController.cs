using System.Web.Mvc;

namespace COrleans.Web.Controllers
{
    public class TutorialsController : Controller
    { 
        [Route("~/tutorials/introduction")]
        public ActionResult Introduction()
        {
            return View();
        }
        [Route("~/tutorials/benefits")]
        public ActionResult Benefits()
        {
            return View();
        }

        [Route("~/tutorials/grains")]
        public ActionResult Grains()
        {
            return View();
        }
         
        [Route("~/tutorials/silos")]
        public ActionResult Silos()
        {
            return View();
        }

        [Route("~/tutorials/clients")]
        public ActionResult Clients()
        {
            return View();
        }

        [Route("~/tutorials/faq")]
        public ActionResult FAQ()
        {
            return View();
        }

        [Route("~/tutorials/prerequisites")]
        public ActionResult Prerequisites()
        {
            return View();
        }

        [Route("~/tutorials/vstool")]
        public ActionResult VsTool()
        {
            return View();
        }

        [Route("~/tutorials/tbp")]
        public ActionResult TemFromBigPark()
        {
            return View();
        }

        [Route("~/tutorials/nugetpackages")]
        public ActionResult NugetPackages()
        {
            return View();
        }

        [Route("~/tutorials/changlog")]
        public ActionResult ChangeLog()
        {
            return View();
        }

        [Route("~/tutorials/devgrain")]
        public ActionResult DevGrain()
        {
            return View();
        }

        [Route("~/tutorials/grainpersistence")]
        public ActionResult GrainPersistence()
        {
            return View();
        } 

        [Route("~/tutorials/devclient")]
        public ActionResult DevClient()
        {
            return View();
        }

        [Route("~/tutorials/observer")]
        public ActionResult Observer()
        {
            return View();
        } 

        [Route("~/tutorials/runapplication")]
        public ActionResult RunApplication()
        {
            return View();
        }

        [Route("~/tutorials/appbootwithsilo")]
        public ActionResult AppBootWithSilo()
        {
            return View();
        }

        [Route("~/tutorials/timerandreminder")]
        public ActionResult TimerAndReminder()
        {
            return View();
        }

        [Route("~/tutorials/orleansstream")]
        public ActionResult OrleansStream()
        {
            return View();
        } 

        [Route("~/tutorials/debugging")]
        public ActionResult Debugging()
        {
            return View();
        }
    }
}