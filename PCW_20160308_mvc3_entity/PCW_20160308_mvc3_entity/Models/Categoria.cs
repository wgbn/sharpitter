using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PCW_20160308_mvc3_entity {

    [Table("tbCategoria")]
    public class Categoria {
        public int id { get; set; }
        public string nome { get; set; }
        public virtual ICollection<Produto> Produtos { get; set; }
    }

}