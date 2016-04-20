using System;
using WebAulaMVC.Dal;
using WebAulaMVC.Models;
using System.Data.Entity;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace WebAulaMVC {
	public class GrupoService {

		private MyDbContext db;

		public GrupoService() {
			db = new MyDbContext();
		}

		public List<Grupo> getGrupos() {
			return db.Grupoes.ToList<Grupo>();
		}

		public Grupo getById(int? _id) {
			return db.Grupoes.Find(_id);
		}

		public void insertGrupo(Grupo _grupo) {
			db.Grupoes.Add(_grupo);
			db.SaveChanges();
		}

		public void editGrupo(Grupo _grupo) {
			db.Entry(_grupo).State = EntityState.Modified;
			db.SaveChanges();
		}

		public void deleteGrupo(Grupo _grupo) {
			db.Grupoes.Remove(_grupo);
			db.SaveChanges();
		}

	}
}

