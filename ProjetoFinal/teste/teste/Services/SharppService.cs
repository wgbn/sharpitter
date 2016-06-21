using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using teste.Helpers;
using teste.Models;

namespace teste.Services {
    public class SharppService {

        //private SharpitterDbContex db;
        private Sharpitter db;

        public SharppService() {
            //this.db = new SharpitterDbContex();
            this.db = new Sharpitter();
        }

        public bool PostSharpp(Sharpp _sharpp) {
            db.Sharpps.Add(_sharpp);
            return true;
        }

        public bool ExcluiSharpp(Sharpp _sharpp) {
            db.Sharpps.Remove(_sharpp);
            db.SaveChanges();
            return true;
        }

        public List<Sharpp> GetRecentes() {

            /*List<Sharpp> sharpps = new List<Sharpp>();

            if (db.Sharpps.ToList().Count > 0) {
                var result = from s in db.Sharpps.ToList()
                             orderby s.Registro descending
                             select s;

                foreach (Sharpp s in result) {
                    sharpps.Add(s);
                }
            }

            return sharpps;*/

            return db.Sharpps.ToList<Sharpp>();
        }

    }
}