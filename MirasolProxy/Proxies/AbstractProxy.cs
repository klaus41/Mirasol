using DTOModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MirasolProxy.Proxies
{
    public abstract class AbstractProxy<T> where T : AbstractModel, new()
    {
        static T type = new T();
        static string[] splitUp = type.ToString().Split('.');
        string apiUrl = "http://localhost:9262/api/" + splitUp[1];
        public IEnumerable<T> ReadAll()
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync(apiUrl).Result;
                return response.Content.ReadAsAsync<IEnumerable<T>>().Result;
            }
        }
        public T Create(T t) {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = client.PostAsJsonAsync(apiUrl, t).Result;
                return response.Content.ReadAsAsync<T>().Result;
            }
        }
        public T Delete(int id)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = client.DeleteAsync(apiUrl + id).Result;
                return response.Content.ReadAsAsync<T>().Result;
            }
        }
        public T Update(T t)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = client.PutAsJsonAsync(apiUrl + t.Id, t).Result;
                return response.Content.ReadAsAsync<T>().Result;
            }
        }
        public T Find(int id)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync(apiUrl + id).Result;
                return response.Content.ReadAsAsync<T>().Result;
            }
        }

        
    }
}
