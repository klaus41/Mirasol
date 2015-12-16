using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mirasol.Controllers
{
    public interface IController<T>
    {
        ActionResult Index();
        ActionResult Create(T t);
        ActionResult Delete(int id);
        ActionResult GetUpdate(int id);
        ActionResult PostUpdate(T t);
    }
}