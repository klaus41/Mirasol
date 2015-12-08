using DTOModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MirasolProxy.Proxies
{
    public class UserProxyService : IProxy<User>
    {
        string apiUrl = "http://localhost:9262/api/user/";
        public User Create(User t)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = client.PostAsJsonAsync(apiUrl, t).Result;
                return response.Content.ReadAsAsync<User>().Result;
            }
        }

        public User Delete(int id)
        {
            throw new NotImplementedException();
        }

        public User Find(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> ReadAll()
        {
            throw new NotImplementedException();
        }

        public User Update(User t)
        {
            throw new NotImplementedException();
        }
    }
}
