namespace aspMysql.Helpers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("wgbnc837_sharpitter.sharpp")]
    public partial class sharpp
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Autor { get; set; }

        public DateTime Registro { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string Texto { get; set; }
    }
}
