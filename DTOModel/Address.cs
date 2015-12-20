using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOModel
{
    public class Address : AbstractModel
    {
        public int HouseNr { get; set; }
        public int Floor { get; set; }
        public string StreetName { get; set; }
        public int ZipCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public override string ToString()
        {
            return StreetName + " " + HouseNr + " " + ZipCode + " " + City + " " + Country;
        }
    }
}
