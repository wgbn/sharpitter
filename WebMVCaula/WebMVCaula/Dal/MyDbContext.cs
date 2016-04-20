using System;
using System.Collections.Generic
using System.Data.Entity;
using System.Linq;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace WebMVCaula.Dal {
	public class MyDbContext : DbContext {
		public MyDbContext() : base("MyDbContext"){ }
		public DbSet<Contato> Contatos { get; set; }
		protected override void OnModelCreating(DbModelBuilder modelBuilder){
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention> ();
		}
	}
}

