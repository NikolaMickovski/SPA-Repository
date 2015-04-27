using Registar.DomainModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registar.DataLayer
{
    /// <summary>
    /// Public klasa koja ke ja dava "sodrznata" na bazata
    /// Tuka naveduvame deka Bazata ke se sostoi od nekoj Entity Bikes (od tip DbSet)
    /// </summary>
    public class RegistarDbContext : DbContext, IDbBikeContext
    {
        /// <summary>
        /// Property Bikes koe bez malku e Tabelata vo Baza
        /// </summary>
        public DbSet<Bike> Bikes { get; set; }
        //tuka moze da dojdat i dr. setovi, na pr. ako imame i DbSet<Car> Cars { get; set; }


        public RegistarDbContext()
            : base("RegistarDB")//ime na konekciskiot string
        {
            Bikes = this.Set<Bike>();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new BikeConfiguration());
        }
    }

    public interface IDbContext
    {
        //interface koj treba da pomogne okolku Dependency Inversion
    }

    public interface IDbBikeContext : IDbContext
    {
        DbSet<Bike> Bikes { get; set; }
    }

}
