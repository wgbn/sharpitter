using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PCW_20160308_mvc3_entity {

    [Table("tbProduto")]
    public class Produto {
        public int id { get; set; }

        [StringLength(100)]
        public string nome { get; set; }

        [Column(TypeName = "Money")]
        public decimal preco { get; set; }

        [Column("QTD")]
        public int quantidade { get; set; }

        public virtual Categoria Categoria { get; set; }
    }

}