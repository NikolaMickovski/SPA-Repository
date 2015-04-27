using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registar.DomainModel
{
    public class Bike : Registar.DomainModel.IBike
    {
        [Key]
        public int BikeId { set; get; }        
        public string RegNumber { set; get; }
        public string Producer { set; get; }
        public string Model { set; get; }
        public string Colour { set; get; }
        public string City { set; get; }

        [NotMapped]
        public Object IgnoreMe { set; get; }

        [Timestamp,NotMapped]
        public byte[] TimeStamp { set; get; }

        //povrzuvame so tabela itn i ako sakame Bike so BikeHistory da ni pravi join vidi vo BikeSearchCommandHandler
        //[Table("BikeHistory")]
       // public IEnumerable<BikeHistory> History { set; get; }
    }
    /// <summary>
    /// Probna klasa od predavana, ne ja koristam
    /// </summary>
    public class BikeHistory
    {
        public int BikeId { set; get; }
        public DateTime Date { set; get; }
    }
    
}
