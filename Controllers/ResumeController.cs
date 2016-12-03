using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VanOrd_Azure.Controllers
{
	public class ResumeController : Controller
	{
		// GET: Resume
		[Route("resume/{name}")]
		public ActionResult Display(string name)
		{
			return View(name);
		}

		[Route("jay/resume")]
		public ActionResult LegacyRedirect()
		{
			return RedirectToAction("Display", new { name = "Jay" });
		}
	}
}