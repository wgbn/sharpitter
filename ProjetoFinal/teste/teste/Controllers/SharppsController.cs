using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using teste.Helpers;
using teste.Models;
using teste.Services;

namespace teste.Controllers
{
    public class SharppsController : Controller
    {
        private SharppService _sharpp = new SharppService();

        // GET: Sharpps
        public ActionResult Index()
        {
            List<Sharpp> _sharpps = _sharpp.GetRecentes();
            return View(_sharpps);
        }

        // GET: Sharpps/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sharpps/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Autor,Texto,Registro,Like,Resposta")] Sharpp sharpp)
        {
            if (ModelState.IsValid)
            {
                _sharpp.PostSharpp(sharpp);
                return RedirectToAction("Index");
            }

            return View(sharpp);
        }
    }
}
