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
            Apartment testApartment = new Apartment() {
                PictureURLs = new List<string>() {
                    "http://leaguematch.altervista.org/testpictures/image1.jpg",
                    "http://leaguematch.altervista.org/testpictures/image2.jpg",
                    "http://leaguematch.altervista.org/testpictures/image3.jpg",
                    "http://leaguematch.altervista.org/testpictures/image4.jpg",
                    "http://leaguematch.altervista.org/testpictures/image5.jpg",
                    "'C:/wokr/Mirasol/Mirasol/Resources/1202-1.jpeg'"
                },
                Name = "Calaceite 1202",
                Description = "Calaceite is located on the outskirts of the coastal town of Torrox-Costa, on a hillside overlooking the Mediterranean." +
                              "Just 300 meters from the beach where you can find five beach restaurants offering fresh fish for lunch every day." +
                              "The beautiful penthouse is light and spacious, featuring a dining area with glass doors to the large(53m2) west facing terrace" +
                              "where you can enjoy the beautiful views and sunsets.The compact kitchen is fully fitted and well equipped with oven and hob," +
                              " microwave, fridge - freezer, washer / dryer combination and dishwasher.Furthermore, a bathroom with shower / tub and a double" +
                              "bedroom with sea view and a large wardrobe. The apartment has air conditioning, hot and cold throughout, electric blinds and awnings," +
                              "Marble Flooring, Double Glazing, SAT - TV, WiFi. There is also a parking space in the communal garage." +
                              "The common areas have swimming pools for adults and children, sun loungers and parasols. Any golf enthusiasts can play on the best" +
                              "courses on the eastern Costa del Sol. The nearest golf courses are Baviera and Añoreta Golf. WiFi free Electricity is charged according" +
                              "to consumption. Pets: ask owner Obligatory final cleaning incl.bed linen and towes. 85, -  € Possibility of" +
                              "renting linen / towels(1 large + 1 small) only 13, - € per.Per. Big beach towels per.per. 5, - €"
            };
            return View(testApartment);
        }
    }
}