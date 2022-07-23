using DataLibrary.Logic;
using DataLibrary.Models;
using static DataLibrary.Logic.LaboratoryProcessor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hastane.Controllers
{
    public class LaboratoryController : Controller
    {
        // GET: Laboratory
        public ActionResult Index()
        {
            var data = Load();
            List<Hastane.Models.LaboratoryModel> Labs = new List<Hastane.Models.LaboratoryModel>();
            foreach (var new_item in data)
            {
                Labs.Add(new Hastane.Models.LaboratoryModel
                {
                    Room_no = new_item.Room_no,
                    Supervisor_name = new_item.Supervisor_name,
                });
            }

            return View(Labs);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Models.LaboratoryModel E)
        {
            if(AccountController.isItAdmin == true)
            {
                LaboratoryProcessor.Create(E.Supervisor_name, E.Room_no);
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
        public ActionResult Edit(Models.LaboratoryModel E)
        {
            if(AccountController.isItAdmin == true)
            {
                LaboratoryProcessor.Edit(E.Supervisor_name, E.Room_no);
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
        public ActionResult Delete(Models.LaboratoryModel E)
        {
            if (AccountController.isItAdmin == true)
            {
                LaboratoryProcessor.Delete(E.Room_no);
                return RedirectToAction("Authenticated", "Admin");
            }
            else
            {
                return RedirectToAction("NotAuthenticated", "Admin");
            }
        }
    }
}