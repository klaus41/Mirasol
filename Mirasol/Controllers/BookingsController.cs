using DTOModel;
using MirasolProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mirasol.Controllers
{
    public class BookingsController : Controller, IController<Bookings>
    {
        private Facade facade = new Facade();
        public ActionResult Create(Bookings t)
        {
            facade.GetBookingsProxyService().Create(t);
            return View();
        }

        public ActionResult Delete(int id)
        {
            facade.GetBookingsProxyService().Delete(id);
            return View();
        }

        public ActionResult GetUpdate(int id)
        {
            facade.GetBookingsProxyService().Find(id);
            return View();
        }

        // GET: Bookings
        public ActionResult Index()
        {
            IEnumerable<Bookings> bookings = facade.GetBookingsProxyService().ReadAll();
            return View(bookings);
        }

        public ActionResult PostUpdate(Bookings t)
        {
            facade.GetBookingsProxyService().Update(t);
            return View();
        }
    }
}