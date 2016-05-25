using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Collections;

namespace CodeDojoCorrida.Controllers
{
	public class HomeController : Controller
	{
		private int[] PontuacaoLegada = new int {0,10,8,6,5,4,3,2,1};
		private int[] PontuacaoAtual = new int {0,25,18,16,14,12,10};

		public HomeController(){
			
		}

		public ActionResult Index ()
		{
			return View ();
		}

		public ActionResult AddTemporada(){
			
		}

		public ActionResult AddCorrida(){
			
		}

		public ActionResult AddPiloto(){
			
		}

	}
}

