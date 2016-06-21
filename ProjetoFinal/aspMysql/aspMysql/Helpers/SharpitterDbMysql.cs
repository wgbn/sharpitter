namespace aspMysql.Helpers {
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SharpitterDbMysql : DbContext {
        public SharpitterDbMysql() : base("name=SharpitterDbMysql") { }

        public virtual DbSet<sharpp> sharpp { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Entity<sharpp>()
                .Property(e => e.Autor)
                .IsUnicode(false);

            modelBuilder.Entity<sharpp>()
                .Property(e => e.Texto)
                .IsUnicode(false);
        }
    }
}
