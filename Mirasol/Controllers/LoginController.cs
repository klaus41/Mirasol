using DTOModel;
using MirasolProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Mirasol.Controllers
{
    public class LoginController : Controller
    {
        private Facade facade = new Facade();
        // GET: Login

        public ActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        
        public ActionResult Login(User user)
        {
            Session["userLogin"] = user;
            if (facade.GetLoginChecker().CheckCredentials(user) == true)
            {
                return RedirectToAction("Index", "home");
            }
            return View();
        }
    }
}