using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Data.Entity.ModelConfiguration.Conventions;
using WebAulaMVC.Models;

namespace WebAulaMVC.Dal {
    public class MyDbContext : DbContext {
        public MyDbContext() : base("MyDbContext4") { }
        public DbSet<Contato> Contatos { get; set; }
        protected void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public System.Data.Entity.DbSet<WebAulaMVC.Models.Grupo> Grupoes { get; set; }
    }
}