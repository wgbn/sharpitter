using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using teste.Services;

namespace teste.Models {
    public class Sharpp {

        public int Id { get; set; }

        [Required, DataType(DataType.Text)]
        public string Autor { get; set; }

        [Required, DataType(DataType.MultilineText)]
        public string Texto { get; set; }

        [Required, DataType(DataType.DateTime)]
        public DateTime Registro { get; set; }

        public int Like { get; set; }

        public int Resposta { get; set; }

        public bool Save() {
            SharppService ss = new SharppService();
            ss.PostSharpp(this);
            return true;
        }

        public bool Delete() {

            return true;
        }

    }
}