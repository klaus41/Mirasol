using DTOModel;
using MirasolProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mirasol.Controllers
{
    public class FacilitiesController : Controller, IController<Facilities>
    {
        private Facade facade = new Facade();
        public ActionResult Create(Facilities t)
        {
            facade.GetFacilitiesProxyService().Create(t);
            return View();
        }

        public ActionResult Delete(int id)
        {
            facade.GetFacilitiesProxyService().Delete(id);
            return View();
        }

        public ActionResult GetUpdate(int id)
        {
            facade.GetFacilitiesProxyService().Find(id);
            return View();
        }

        // GET: Facilities
        public ActionResult Index()
        {
            IEnumerable<Facilities> facilities = facade.GetFacilitiesProxyService().ReadAll();
            return View(facilities);
        }

        public ActionResult PostUpdate(Facilities t)
        {
            facade.GetFacilitiesProxyService().Update(t);
            return View();
        }
    }
}