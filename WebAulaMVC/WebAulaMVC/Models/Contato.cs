using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using WebAulaMVC.Dal;
using WebAulaMVC.Services;
using System.Globalization;

namespace WebAulaMVC.Models {
    public class Contato {
        public int Id { get; set; }

        public int GrupoID { get; set; }

        [DisplayName("Nome"), Required]
        public string Nome { get; set; }

        [DisplayName("E-mail"), DataType(DataType.EmailAddress), Required(ErrorMessage ="Campo {0} é obrigatório!")]
        public string Email { get; set; }

        [DisplayName("Telefone"), DataType(DataType.PhoneNumber)]
        public string Celular { get; set; }

        [DisplayName("Data de Nascimento"), DataType(DataType.Date), Required(ErrorMessage = "Campo {0} é obrigatório!")]
        public DateTime DataNascimento { get; set; }

		[NotMapped, DisplayName("Grupo")]
		public string Grupo { get {
				GrupoService grupoService = new GrupoService();
				return grupoService.getById(this.GrupoID).Descricao;
			}
		}

        [NotMapped, DisplayName("Idade")]
        public int Idade { get {
                return Convert.ToInt16(DateTime.Now.Year - this.DataNascimento.Year);
            }
        }

        public Contato(string _nome, string _email) {
            this.Nome = _nome;
            this.Email = _email;
        }

        public Contato() { }

        public string getGrupoNome() {
            MyDbContext db = new MyDbContext();
            var consulta = from grupo in db.Grupoes where grupo.Id == GrupoID select grupo;
            var grupoResult = (Grupo)consulta.FirstOrDefault();
            return grupoResult.Descricao;
        }
    }
}