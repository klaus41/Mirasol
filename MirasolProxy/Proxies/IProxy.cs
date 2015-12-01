using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MirasolProxy.Proxies
{
    public interface IProxy<T>
    { 
        IEnumerable<T> ReadAll();
        void Create(T t);
        void Delete(int id);
        void Update(T t);
        void FInd(int id);


    }
}
