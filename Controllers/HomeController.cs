using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VanOrd_Azure.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return RedirectToAction("Display", "Resume", new { name = "Jay" });
		}

		public ActionResult About()
		{
			return Content("Why were you expecting an about page?");
		}

		public ActionResult Contact()
		{
			return Content("Why were you expecting a contact page?");
		}
	}
}