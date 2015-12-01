using DTOModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MirasolProxy.Proxies
{
    public class ApartmentProxyService
    {
        public IEnumerable<Apartment> ReadAll()
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync("http://localhost:41434/api/apartment/").Result;
                return response.Content.ReadAsAsync<IEnumerable<Apartment>>().Result;
            }
        }

        public Apartment Create()
        {
            using (var client = new HttpClient())
            {
                return null;
            }
        }
    }
}
