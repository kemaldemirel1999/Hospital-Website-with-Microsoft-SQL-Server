using DataLibrary.Logic;
using DataLibrary.Models;
using static DataLibrary.Logic.PrescriptionProcessor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hastane.Controllers
{
    public class PrescriptionController : Controller
    {
        // GET: Prescription
        public ActionResult Index()
        {
            var data = Load();
            List<Hastane.Models.PrescriptionModel> Prescriptions = new List<Hastane.Models.PrescriptionModel>();
            foreach (var new_item in data)
            {
                Prescriptions.Add(new Hastane.Models.PrescriptionModel
                {
                    Pssn = new_item.Pssn,
                    EmpId = new_item.EmpId,
                    Date = new_item.Date,
                    Drug_name = new_item.Drug_name,
                    Given_date = new_item.Given_date
                }) ;
            }

            return View(Prescriptions);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Models.PrescriptionModel E)
        {
            if (AccountController.isItAdmin == true)
            {
                PrescriptionProcessor.Create(E.Pssn, E.EmpId, E.Date, E.Drug_name, E.Given_date);
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
        public ActionResult Edit(Models.PrescriptionModel E)
        {
            if (AccountController.isItAdmin == true)
            {
                PrescriptionProcessor.Edit(E.Pssn, E.EmpId, E.Date, E.Drug_name, E.Given_date);
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
        public ActionResult Delete(Models.PrescriptionModel E)
        {
            if (AccountController.isItAdmin == true)
            {
                PrescriptionProcessor.Delete(E.Pssn,E.EmpId);
                return RedirectToAction("Authenticated", "Admin");
            }
            else
            {
                return RedirectToAction("NotAuthenticated", "Admin");
            }
        }
    }
}