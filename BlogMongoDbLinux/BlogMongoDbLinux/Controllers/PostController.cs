using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogMongoDbLinux.Controllers
{
	public class PostController : Controller
	{

		private PostService postService = new PostService ();

		public ActionResult Index ()
		{
			return View ();
		}

		public ActionResult Details (int id)
		{
			return View ();
		}

		[HttpGet]
		public ActionResult Create ()
		{
			return View (new Post ());
		}

		[HttpPost]
		public ActionResult Create (Post post)
		{
			if (ModelState.IsValid) {
				post.Url = BlogHelper.GenerateSlug (post.Title);
				post.Author = post.Author; //User.Identity.Name;
				post.Date = DateTime.Now;

				postService.Create (post);

				return RedirectToAction ("Index");
			}

			return View ();
		}

		public ActionResult Edit (int id)
		{
			return View ();
		}

		[HttpPost]
		public ActionResult Edit (int id, FormCollection collection)
		{
			try {
				return RedirectToAction ("Index");
			} catch {
				return View ();
			}
		}

		public ActionResult Delete (int id)
		{
			return View ();
		}

		[HttpPost]
		public ActionResult Delete (int id, FormCollection collection)
		{
			try {
				return RedirectToAction ("Index");
			} catch {
				return View ();
			}
		}
	}
}