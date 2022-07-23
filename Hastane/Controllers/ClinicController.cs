using DataLibrary.Logic;
using DataLibrary.Models;
using static DataLibrary.Logic.ClinicProcessor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hastane.Controllers
{
    public class ClinicController : Controller
    {
        // GET: Clinic
        public ActionResult Index()
        {
            var data = Load();
            List<Hastane.Models.ClinicModel> clinics = new List<Hastane.Models.ClinicModel>();
            foreach (var new_item in data)
            {
                clinics.Add(new Hastane.Models.ClinicModel
                {
                    HeadDoctorId = new_item.HeadDoctorId,
                    Location = new_item.Location,
                    Name = new_item.Name
                });
            }

            return View(clinics);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Models.ClinicModel E)
        {
            if(AccountController.isItAdmin == true)
            {
                ClinicProcessor.Create(E.HeadDoctorId, E.Location, E.Name);
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
        public ActionResult Edit(Models.ClinicModel E)
        {
            if(AccountController.isItAdmin == true)
            {
                ClinicProcessor.Edit(E.HeadDoctorId, E.Location, E.Name);
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
        public ActionResult Delete(Models.ClinicModel E)
        {
            if (AccountController.isItAdmin == true)
            {
                ClinicProcessor.Delete(E.Name);
                return RedirectToAction("Authenticated", "Admin");
            }
            else
            {
                return RedirectToAction("NotAuthenticated", "Admin");
            }
        }
    }
}