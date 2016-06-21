using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Helpers;
using MongoDB.Bson;
using Sharpitter.Services;
using Sharpitter.Models;

namespace Sharpitter.Controllers {
	
    public class UsuarioController : Controller {

		//private UsuarioService usuarioService = new UsuarioService();
		
		public EmptyResult Index() {
			Usuario usuario = new Usuario () {
				Email = "walter.wgbn@gmail.com",
				Username = "wgbn",
				Senha = "theo0712",
				Registro = DateTime.Now
			};
			usuario.HashSenha ();
			usuario.Save ();
			return new EmptyResult ();
        }

        public ActionResult Details(int id) {
            return View ();
        }

        public ActionResult Create() {
            return View ();
        } 

        [HttpPost]
        public ActionResult Create(FormCollection collection) {
            try {
                return RedirectToAction ("Index");
            } catch {
                return View ();
            }
        }
        
        public ActionResult Edit(int id) {
            return View ();
        }

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection) {
            try {
                return RedirectToAction ("Index");
            } catch {
                return View ();
            }
        }

        public ActionResult Delete(int id) {
            return View ();
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection) {
            try {
                return RedirectToAction ("Index");
            } catch {
                return View ();
            }
        }

    }

}