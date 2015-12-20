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
            IEnumerable<Apartment> apartments = facade.GetApartmentFilter().ReadAllApartments();
            return View(apartments);
        }
        [HttpGet]
        public ActionResult Create()
        {
            Apartment apartment = new Apartment();
            return View(apartment);
        }
        [HttpPost]
        public ActionResult Create(Apartment apartment)
        {
            facade.GetApartmentProxyService().Create(apartment);
            return Redirect("Index");
        }
        [HttpGet]
        public ActionResult Update(int id)
        {
            Apartment apartment = facade.GetApartmentProxyService().Find(id);
            return View();
        }

        [HttpPost]
        public ActionResult Update(Apartment apartment)
        {
            facade.GetApartmentProxyService().Update(apartment);
            return View();
        }

        public ActionResult Delete(int id)
        {
            facade.GetApartmentProxyService().Delete(id);
            return View();
        }
    }
}