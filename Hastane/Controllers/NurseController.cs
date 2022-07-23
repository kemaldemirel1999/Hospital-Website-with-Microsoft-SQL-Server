using DataLibrary.Logic;
using DataLibrary.Models;
using static DataLibrary.Logic.NurseProcessor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hastane.Controllers
{
    public class NurseController : Controller
    {
        // GET: Nurse
        public ActionResult Index()
        {
            var data = Load();
            List<Hastane.Models.NurseModel> Nurses = new List<Hastane.Models.NurseModel>();
            foreach (var new_item in data)
            {
                Nurses.Add(new Hastane.Models.NurseModel
                {
                    EmpId = new_item.EmpId,
                    Room_responsible = new_item.Room_responsible
                });
            }

            return View(Nurses);
        }

       public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Models.NurseModel E)
        {
            if (AccountController.isItAdmin == true)
            {
                NurseProcessor.Create(E.EmpId, E.Room_responsible);
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
        public ActionResult Edit(Models.NurseModel E)
        {
            if (AccountController.isItAdmin == true)
            {
                NurseProcessor.Edit(E.EmpId, E.Room_responsible);
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
        public ActionResult Delete(Models.NurseModel E)
        {
            if (AccountController.isItAdmin == true)
            {
                NurseProcessor.Delete(E.EmpId);
                return RedirectToAction("Authenticated", "Admin");
            }
            else
            {
                return RedirectToAction("NotAuthenticated", "Admin");
            }
        }
    }
}