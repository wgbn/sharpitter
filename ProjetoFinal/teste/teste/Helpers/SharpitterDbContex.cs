using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using teste.Models;

namespace teste.Helpers {
    public class SharpitterDbContex : DbContext {
        public SharpitterDbContex() : base("Sharpitter2") { }
        public DbSet<Sharpp> Sharpps { get; set; }
        protected void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}