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
        string apiUrl = "http://localhost:41434/api/apartment/";

        public Apartment Find(int id)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync(apiUrl + id).Result;
                return response.Content.ReadAsAsync<Apartment>().Result;
            }
        }
        public IEnumerable<Apartment> ReadAll()
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync(apiUrl).Result;
                return response.Content.ReadAsAsync<IEnumerable<Apartment>>().Result;
            }
        }

        public Apartment Create(Apartment apartment)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = client.PostAsJsonAsync(apiUrl, apartment).Result;
                return response.Content.ReadAsAsync<Apartment>().Result;
            }
        }

        public Apartment Update(Apartment apartment)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = client.PutAsJsonAsync(apiUrl + apartment.Id, apartment).Result;
                return response.Content.ReadAsAsync<Apartment>().Result;
            }
        }

        public Apartment Delete(int id)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = client.DeleteAsync(apiUrl + id).Result;
                return response.Content.ReadAsAsync<Apartment>().Result;
            }
        }
    }
}
