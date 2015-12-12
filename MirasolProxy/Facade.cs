using MirasolProxy.Filter;
using MirasolProxy.Proxies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MirasolProxy
{
    public class Facade
    {
        public ApartmentFilter GetApartmentFilter()
        {
            return new ApartmentFilter();
        }

        public ApartmentProxyService GetApartmentProxyService()
        {
            return new ApartmentProxyService();
        }
    }
}
