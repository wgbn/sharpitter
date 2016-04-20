using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebAulaMVC.Dal;
using WebAulaMVC.Models;

namespace WebAulaMVC.Services {
    public class ContatoService {

        private MyDbContext db;

        public ContatoService() {
            db = new MyDbContext();
        }

		public List<Contato> getContatos() {
            return db.Contatos.ToList();
            /*var consulta = from contato in db.Contatos
                            join grupo in db.Grupoes on contato.GrupoID equals grupo.Id
                            select new {
                                Id = contato.Id,
                                Nome = contato.Nome,
                                Email = contato.Email,
                                Celular = contato.Celular,
                                Grupo = grupo.Descricao
                            };
            var resultado = consulta.ToList<Object>();
            return resultado;*/
        }

        public Contato getById(int? _id) {
            return db.Contatos.Find(_id);
        }

        public void insertContato(Contato _contato) {
            db.Contatos.Add(_contato);
            db.SaveChanges();
        }

        public void editContato(Contato _contato) {
            db.Entry(_contato).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void deleteContato(Contato _contato) {
            db.Contatos.Remove(_contato);
            db.SaveChanges();
        }

    }
}