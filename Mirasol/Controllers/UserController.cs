using DTOModel;
using MirasolProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mirasol.Controllers
{
    public class UserController : Controller, IController<User>
    {
        private Facade facade = new Facade();
        [ValidateAntiForgeryToken]
        public ActionResult Create(User t)
        {
            facade.GetUserProxyService().Create(t);
            return View();
        }
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            facade.GetUserProxyService().Delete(id);
            return View();
        }

        public ActionResult GetUpdate(int id)
        {
            facade.GetUserProxyService().Find(id);
            return View();
        }

        // GET: User
        public ActionResult Index()
        {
            IEnumerable<User> users = facade.GetUserProxyService().ReadAll();
            return View(users);
        }
        [ValidateAntiForgeryToken]
        public ActionResult PostUpdate(User t)
        {
            facade.GetUserProxyService().Update(t);
            return View();
        }
    }
}