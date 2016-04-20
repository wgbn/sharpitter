using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace WebAulaMVC.Models {
    public class Grupo {

        public int Id { get; set; }

        [DisplayName("Descrição"), Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Descricao { get; set; }

        public List<Contato> Contatos { get; set; }

        public Grupo(string _descricao) {
            this.Descricao = _descricao;
        }

        public Grupo() { }

    }
}