using DTOModel;
using MirasolProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mirasol.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Torrox()
        {
            Facade facade = new Facade();
            IEnumerable<Apartment> listOfTorroxApartments = facade.GetApartmentFilter().GetAllTorroxApartments();
            return View(listOfTorroxApartments);
        }
    }
}