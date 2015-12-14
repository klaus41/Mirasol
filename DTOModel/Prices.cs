using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOModel
{
    public class Prices : AbstractModel
    {
        public int FinalCleaning { get; set; }
        public int LinenAndTowels { get; set; }
        public int BeachTowels { get; set; }
        public int LowSeason { get; set; }
        public int MidSeason { get; set; }
        public int HighSeason { get; set; }
    }
}
