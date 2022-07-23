using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hastane.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Authenticated()
        {
            return View();
        }
        public ActionResult NotAuthenticated()
        {
            return View();
        }
    }
}