using DTOModel;
using MirasolProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mirasol.Controllers
{
    public class ApartmentController : Controller
    {
        private Facade facade = new Facade();

        public ActionResult Index()
        {
            IEnumerable<Apartment> apartments = facade.GetApartmentProxy().ReadAll();
            return View(apartments);
        }

        public ActionResult Create(Apartment apartment)
        {
            facade.GetApartmentProxy().Create(apartment);
            return View();
        }
        [HttpGet]
        public ActionResult Update(int id)
        {
            Apartment apartment = facade.GetApartmentProxy().Find(id);
            return View();
        }

        [HttpPost]
        public ActionResult Update(Apartment apartment)
        {
            facade.GetApartmentProxy().Update(apartment);
            return View();
        }

        public ActionResult Delete(int id)
        {
            facade.GetApartmentProxy().Delete(id);
            return View();
        }
    }
}