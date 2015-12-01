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
            //facade.GetApartmentProxy().Add(apartment);
            return View();
        }

        public ActionResult Update()
        {
            return View();
        }

        public ActionResult Delete()
        {
            return View();
        }
    }
}