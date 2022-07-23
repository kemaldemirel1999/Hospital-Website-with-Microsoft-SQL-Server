using DataLibrary.Logic;
using DataLibrary.Models;
using static DataLibrary.Logic.ManagerProcessor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hastane.Controllers
{
    public class ManagerController : Controller
    {
        // GET: Manager
        public ActionResult Index()
        {
            var data = Load();
            List<Hastane.Models.ManagerModel> Managers = new List<Hastane.Models.ManagerModel>();
            foreach (var new_item in data)
            {
                Managers.Add(new Hastane.Models.ManagerModel
                {
                    EmpId = new_item.EmpId
                });
            }

            return View(Managers);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Models.ManagerModel E)
        {
            if(AccountController.isItAdmin == true)
            {
                ManagerProcessor.Create(E.EmpId);
                return RedirectToAction("Authenticated", "Admin");
            }
            else
            {
                return RedirectToAction("NotAuthenticated", "Admin");
            }
        }
        public ActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Edit(Models.ManagerModel E)
        {
            if (AccountController.isItAdmin == true)
            {
                ManagerProcessor.Edit(E.EmpId);
                return RedirectToAction("Authenticated", "Admin");
            }
            else
            {
                return RedirectToAction("NotAuthenticated", "Admin");
            }
        }
        public ActionResult Delete()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Delete(Models.ManagerModel E)
        {
            if (AccountController.isItAdmin == true)
            {
                ManagerProcessor.Delete(E.EmpId);
                return RedirectToAction("Authenticated", "Admin");
            }
            else
            {
                return RedirectToAction("NotAuthenticated", "Admin");
            }
        }
    }
}