using Registar.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registar.BusinessLayer.Contracts
{
    /// <summary>
    /// Klasa koja go vraka nazad rezultatot od komandite za Tocak
    /// </summary>
    public class BikeSearchResult:CommandResult
    {
        public List<Bike> Result { get; set; }

        /// <summary>
        /// Vo konstruktorot mora da ja instancirame listata
        /// </summary>
        public BikeSearchResult()
        {
            Result = new List<Bike>();
        }
    }
}
