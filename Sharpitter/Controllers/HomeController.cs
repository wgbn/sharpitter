using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace Sharpitter.Controllers {
	
	public class HomeController : Controller {
		
		public ActionResult Index () {
			ViewData ["Version"] = "Sharpitter 1.0.0";
			return View ();
		}

	}

}