using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOModel
{
    public class Prices : AbstractModel
    {
        public double FinalCleaning { get; set; }
        public double LinenAndTowels { get; set; }
        public double BeachTowels { get; set; }
        public double LowSeason { get; set; }
        public double MidSeason { get; set; }
        public double HighSeason { get; set; }
    }
}
