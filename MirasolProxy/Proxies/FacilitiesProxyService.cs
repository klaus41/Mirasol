using DTOModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MirasolProxy.Proxies
{
    public class FacilitiesProxyService : AbstractProxy<Facilities>
    {
        string apiUrl = "http://localhost:9262/api/facilities/";
        public Facilities Create(Facilities t)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = client.PostAsJsonAsync(apiUrl, t).Result;
                return response.Content.ReadAsAsync<Facilities>().Result;
            }
        }

        public Facilities Delete(int id)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = client.DeleteAsync(apiUrl + id).Result;
                return response.Content.ReadAsAsync<Facilities>().Result;
            }
        }

        public Facilities Find(int id)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync(apiUrl + id).Result;
                return response.Content.ReadAsAsync<Facilities>().Result;
            }
        }

        public IEnumerable<Facilities> ReadAll()
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync(apiUrl).Result;
                return response.Content.ReadAsAsync<IEnumerable<Facilities>>().Result;
            }
        }

        public Facilities Update(Facilities t)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = client.PutAsJsonAsync(apiUrl + t.Id, t).Result;
                return response.Content.ReadAsAsync<Facilities>().Result;
            }
        }
    }
}
