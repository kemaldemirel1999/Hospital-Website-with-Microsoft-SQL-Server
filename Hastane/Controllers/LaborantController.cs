using DataLibrary.Logic;
using DataLibrary.Models;
using static DataLibrary.Logic.LaborantProcessor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hastane.Controllers
{
    public class LaborantController : Controller
    {
        // GET: Laborant
        public ActionResult Index()
        {
            var data = Load();
            List<Hastane.Models.LaborantModel> Laborants = new List<Hastane.Models.LaborantModel>();
            foreach (var new_item in data)
            {
                Laborants.Add(new Hastane.Models.LaborantModel
                {
                    EmpId = new_item.EmpId,
                    Lab_no = new_item.Lab_no
                });
            }

            return View(Laborants);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Models.LaborantModel E)
        {
            if(AccountController.isItAdmin == true)
            {
                LaborantProcessor.Create(E.EmpId, E.Lab_no);
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
        public ActionResult Edit(Models.LaborantModel E)
        {
            if(AccountController.isItAdmin == true)
            {
                LaborantProcessor.Edit(E.EmpId, E.Lab_no);
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
        public ActionResult Delete(Models.LaborantModel E)
        {
            if (AccountController.isItAdmin == true)
            {
                LaborantProcessor.Delete(E.EmpId,E.Lab_no);
                return RedirectToAction("Authenticated", "Admin");
            }
            else
            {
                return RedirectToAction("NotAuthenticated", "Admin");
            }
        }
    }
}