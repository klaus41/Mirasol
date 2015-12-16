using DTOModel;
using MirasolProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mirasol.Controllers
{
    public class PricesController : Controller, IController<Prices>
    {
        private Facade facade = new Facade();
        public ActionResult Create(Prices t)
        {
            facade.GetPricesProxyService().Create(t);
            return View();
        }

        public ActionResult Delete(int id)
        {
            facade.GetPricesProxyService().Delete(id);
            return View();
        }

        public ActionResult GetUpdate(int id)
        {
            facade.GetPricesProxyService().Find(id);
            return View();
        }

        // GET: Prices
        public ActionResult Index()
        {
            IEnumerable<Prices> prices = facade.GetPricesProxyService().ReadAll();
            return View(prices);
        }

        public ActionResult PostUpdate(Prices t)
        {
            facade.GetPricesProxyService().Update(t);
            return View();
        }
    }
}