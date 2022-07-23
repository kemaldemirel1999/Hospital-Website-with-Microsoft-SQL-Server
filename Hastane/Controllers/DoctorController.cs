using DataLibrary.Logic;
using DataLibrary.Models;
using static DataLibrary.Logic.DoctorProcessor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hastane.Controllers
{
    public class DoctorController : Controller
    {
        // GET: Doctor
        public ActionResult Index()
        {
            var data = Load();
            List<Hastane.Models.DoctorModel> Doctors = new List<Hastane.Models.DoctorModel>();
            foreach (var new_item in data)
            {
                Doctors.Add(new Hastane.Models.DoctorModel
                {
                    EmpId = new_item.EmpId,
                    Clinic_name = new_item.Clinic_name,
                    Branch = new_item.Branch,
                });
            }

            return View(Doctors);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Models.DoctorModel E)
        {
            if(AccountController.isItAdmin == true)
            {
                DoctorProcessor.Create(E.EmpId, E.Clinic_name, E.Branch);
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
        public ActionResult Edit(Models.DoctorModel E)
        {
            if(AccountController.isItAdmin == true)
            {
                DoctorProcessor.Edit(E.EmpId, E.Clinic_name, E.Branch);
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
        public ActionResult Delete(Models.DoctorModel E)
        {
            if (AccountController.isItAdmin == true)
            {
                DoctorProcessor.Delete(E.EmpId);
                return RedirectToAction("Authenticated", "Admin");
            }
            else
            {
                return RedirectToAction("NotAuthenticated", "Admin");
            }
        }
    }
}