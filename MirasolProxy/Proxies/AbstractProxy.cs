using DTOModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MirasolProxy.Proxies
{
    public abstract class AbstractProxy<T> where T : AbstractModel
    {
        string apiUrl = "http://localhost:9262/api/";
        IEnumerable<T> ReadAll()
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync(apiUrl).Result;
                return response.Content.ReadAsAsync<IEnumerable<T>>().Result;
            }
        }
        T Create(T t) {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = client.PostAsJsonAsync(apiUrl, t).Result;
                return response.Content.ReadAsAsync<T>().Result;
            }
        }
        T Delete(int id)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = client.DeleteAsync(apiUrl + id).Result;
                return response.Content.ReadAsAsync<T>().Result;
            }
        }
        T Update(T t)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = client.PutAsJsonAsync(apiUrl + t.Id, t).Result;
                return response.Content.ReadAsAsync<T>().Result;
            }
        }
        T Find(int id)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync(apiUrl + id).Result;
                return response.Content.ReadAsAsync<T>().Result;
            }
        }

        
    }
}
