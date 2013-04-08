using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace jQuery_Ajax_Demo00.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index ()
		{
			ViewData ["Message"] = "Welcome to ASP.NET MVC on Mono!";
			return View ();
		}

		public JsonResult GetCustomer()
		{
            var customers = new []{ "Namco", "Konami", "Capcom", "Bandai", "SEGA"
                                  , "Square Enix", "EA", "Level-5", "Tri-Ace", "Saint Monica"
                                  , "Naughty Dog", "SCE", "Microsoft", "Nitendo" };

			return Json(customers, JsonRequestBehavior.AllowGet);
		}
	}
}

