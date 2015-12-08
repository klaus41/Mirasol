using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOModel
{
    public class AbstractModel
    {
        public int Id { get; set; }

        public string PlsWork()
        {
            return base.GetType().Name;
        }


    }
}
