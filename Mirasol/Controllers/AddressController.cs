using DTOModel;
using MirasolProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mirasol.Controllers
{
    public class AddressController : Controller, IController<Address>
    {

        private Facade facade = new Facade();
        public ActionResult Create(Address t)
        {
            facade.GetAddressProxyService().Create(t);
            return View();
        }

        public ActionResult Delete(int id)
        {
            facade.GetAddressProxyService().Delete(id);
            return View();
        }

        public ActionResult GetUpdate(int id)
        {
            facade.GetAddressProxyService().Find(id);
            return View();
        }

        // GET: Address
        public ActionResult Index()
        {
            IEnumerable<Address> addresses = facade.GetAddressProxyService().ReadAll();
            return View(addresses);
        }

        public ActionResult PostUpdate(Address t)
        {
            facade.GetAddressProxyService().Update(t);
            return View();
        }
    }
}