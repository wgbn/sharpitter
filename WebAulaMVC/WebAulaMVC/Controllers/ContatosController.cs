using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebAulaMVC.Dal;
using WebAulaMVC.Models;
using WebAulaMVC.Services;

namespace WebAulaMVC.Controllers {
    public class ContatosController : Controller {
        private MyDbContext db = new MyDbContext();
        private ContatoService contatoService = new ContatoService();
        private GrupoService grupoService = new GrupoService();

        // GET: Contatos
        public ActionResult Index() {
            return View(contatoService.getContatos());
        }

        // GET: Contatos/Details/5
        public ActionResult Details(int? id) {
            if (id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Contato contato = contatoService.getById(id);

            if (contato == null) {
                return HttpNotFound();
            }
            return View(contato);
        }

        // GET: Contatos/Create
        public ActionResult Create(){
            ViewBag.Grupos = new SelectList(grupoService.getGrupos(), "Id", "Descricao");
            return View();
        }

        // POST: Contatos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,GrupoID,Nome,Email,Celular,DataNascimento")] Contato contato){
            if (ModelState.IsValid){
                contatoService.insertContato(contato);
                return RedirectToAction("Index");
            }

            ViewBag.Grupos = new SelectList(grupoService.getGrupos(), "Id", "Descricao", contato.GrupoID);

            return View(contato);
        }

        // GET: Contatos/Edit/5
        public ActionResult Edit(int? id){
            if (id == null){
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Contato contato = contatoService.getById(id);

            if (contato == null){
                return HttpNotFound();
            }
            return View(contato);
        }

        // POST: Contatos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,GrupoID,Nome,Email,Celular")] Contato contato){
            if (ModelState.IsValid){
                contatoService.editContato(contato);
                return RedirectToAction("Index");
            }
            return View(contato);
        }

        // GET: Contatos/Delete/5
        public ActionResult Delete(int? id){
            if (id == null){
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Contato contato = contatoService.getById(id);

            if (contato == null){
                return HttpNotFound();
            }
            return View(contato);
        }

        // POST: Contatos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id){
            Contato contato = contatoService.getById(id);
            contatoService.deleteContato(contato);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing){
            if (disposing){
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
