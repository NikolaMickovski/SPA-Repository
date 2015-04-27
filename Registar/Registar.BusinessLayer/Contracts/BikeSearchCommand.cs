using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registar.BusinessLayer.Contracts
{
    /// <summary>
    /// Komandi za prebaruvanje bi bile:
    /// 1. Komanda za prebaruvanje po Producer
    /// 2. Komanda za prebaruvanje po Boja
    /// 3. PageSize i PageIndex se pomosni Properties koi gi def. za da prikazeme 
    /// paging vo Entity Framwork - ot
    /// </summary>
    public class BikeSearchCommand:Command
    {
        public string Producer { set; get; }
        public string Colour { set; get; }
        public int PageSize { set; get; }
        public int PageIndex { set; get; }
    }
}
