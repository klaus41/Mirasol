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

        public ActionResult Marbella()
        {
            Facade facade = new Facade();
            IEnumerable<Apartment> listOfMarbellaApartments = facade.GetApartmentFilter().GetAllMarbellaApartments();
            return View(listOfMarbellaApartments);
        }

        [HttpGet]
        public ActionResult SpecificApartment(Apartment apartment)
        {
            Apartment testApartment = new Apartment() { PictureURLs = new List<string>() { "http://leaguematch.altervista.org/testpictures/image1.jpg", "http://leaguematch.altervista.org/testpictures/image2.jpg", "http://leaguematch.altervista.org/testpictures/image3.jpg", "http://leaguematch.altervista.org/testpictures/image4.jpg", "http://leaguematch.altervista.org/testpictures/image5.jpg" } };
            return View(testApartment);
        }
    }
}