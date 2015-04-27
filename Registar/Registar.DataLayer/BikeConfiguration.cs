using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using System.Threading.Tasks;
using Registar.DomainModel;

namespace Registar.DataLayer
{
    /// <summary>
    /// Klasa vo koja mozat da se namestat odredeni konfiguracii za mapiranjeto
    /// </summary>
    public class BikeConfiguration : EntityTypeConfiguration<Bike>
    {
        /// <summary>
        /// Podesuvanjata se mestat vo konstruktorot na klasata
        /// </summary>
        public BikeConfiguration()
        {
            //if pimary key contains two columns we should do the the commented lines
            //this.ToTable("Bikes", "Data").HasKey(x=>new { Id=x.BikeId,Colour=x.Colour});
            this.ToTable("Bikes", "Data");
            this.Property(x => x.BikeId).HasColumnName("Id");
            
        }
    }
}
