using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Noobot.Examples.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly INoobotHost _noobotHost;

        public HomeController(INoobotHost noobotHost)
        {
            _noobotHost = noobotHost;
        }

        public ActionResult Index()
        {
            return View(_noobotHost.GetLog());
        }
    }
}