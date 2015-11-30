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
        public ApartmentProxyService GetApartmentProxy()
        {
            return new ApartmentProxyService;
        }
    }
}
