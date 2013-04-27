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

      public JsonResult GetGames()
      {
         var games = new []{ "Metal Gear Solid", "Final Fantasy", "Super Robot War", "Dragon Quest"
                           , "Assassin Creed", "God of War"};

         return Json(games, JsonRequestBehavior.AllowGet);
      }
      public JsonResult GetRemoteGames()
      {
         using(var webClient = new System.Net.WebClient())
         {
            string json = webClient.DownloadString(@"http://localhost:3000/getData");

            //parse the string into Array
            string[] games = json.Replace("[","").Replace("]","").Split(',');
            List<string> result = new List<string>();
            foreach(string item in games)
            {
               result.Add(item.Replace("\"",""));
            }

            return Json (result, JsonRequestBehavior.AllowGet);
         }
      }
	}
}

