using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using LojaRazor.Models;

namespace LojaRazor.DAO
{
    public class EstoqueContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }


        public EstoqueContext()
            : base("ConexaoERP")
        {
            Database.SetInitializer<EstoqueContext>(null);
        }

   
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var __DBOwner = "dbo";

            modelBuilder.Entity<Usuario>().ToTable("Usuario", schemaName: __DBOwner);
            modelBuilder.Entity<Produto>().ToTable("Produtos", schemaName: __DBOwner);
            modelBuilder.Entity<Departamento>().ToTable("Departamentos", schemaName: __DBOwner);
            modelBuilder.Entity<Categoria>().ToTable("Categorias", schemaName: __DBOwner);
        }

        //protected override bool ShouldValidateEntity(DbEntityEntry entityEntry)
        //{
        //    //return base.ShouldValidateEntity(entityEntry)
        //    //    || (entityEntry.State == EntityState.Deleted
        //    //       && entityEntry.Entity is Con);
        //}
    }
}