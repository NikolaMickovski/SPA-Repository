using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registar.DataLayer.Factory
{
    /// <summary>
    /// Kreirame staticka klasa koja nazad ke vrakja DBCONTEXT objekt
    /// Ovaa klasa e zamislena kako FACTORY koja bi mozela da vraka i drugi
    /// klasi koi nasleduvaat od DBContext klasata
    /// </summary>
    public static class DbContextFactory
    {
        public static DbContext CreateContext(string contextName)
        {
            if(contextName == "RegistarDbContext"){
                return new RegistarDbContext();
            }
            //drug mozen Context (samo za ilustracija)
            if(contextName == "RegistaCarDbContext")
            {
                //return...
            }
            return null;            
        }
    }
}
