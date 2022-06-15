using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet1.Data
{
    internal class DB : DbContext
    {
        public DB() : base("name=myCnx")
        {

        }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            modelBuilder.Entity<Plat>().ToTable("plat");
            modelBuilder.Entity<Table>().ToTable("tabler");
            modelBuilder.Entity<Commande>().ToTable("commande");
            modelBuilder.Entity<Serveur>().ToTable("serveur");
            modelBuilder.Entity<Contient>().ToTable("contient");
            modelBuilder.Entity<Affecter>().ToTable("affecter");


        }

        //Afficher
        public DbSet<Plat> Plats{ get; set; }

        public DbSet<Affecter> Affecters{ get; set; }

        public DbSet<Commande> Commandes { get; set; }

        public DbSet<Serveur> Serveurs { get; set; }

        public DbSet<Table> Tables { get; set; }

        public DbSet<Contient> Contients { get; set; }

        

    }
}
