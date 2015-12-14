using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOModel
{
    public class Facilities : AbstractModel
    {
        public string Inside { get; set; }
        public string Kitchen { get; set; }
        public string Bathroom { get; set; }
        public string Beds { get; set; }
        public string Views { get; set; }
        public string SuitableFor { get; set; }
        public string Notes { get; set; }
        public string General { get; set; }
        public string Outside { get; set; }
    }
}
