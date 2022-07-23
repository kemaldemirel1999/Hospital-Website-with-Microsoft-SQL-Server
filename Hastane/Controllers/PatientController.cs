using DataLibrary.Logic;
using DataLibrary.Models;
using static DataLibrary.Logic.PatientProcessor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hastane.Controllers
{
    public class PatientController : Controller
    {
        // GET: Patient
        public ActionResult Index()
        {
            var data = Load();
            List<Hastane.Models.PatientModel> Patients = new List<Hastane.Models.PatientModel>();
            foreach (var new_item in data)
            {
                Patients.Add(new Hastane.Models.PatientModel
                {
                    Ssn = new_item.Ssn,
                    FirstName = new_item.FirstName,
                    Surname = new_item.Surname,
                    Phone = new_item.Phone,
                    Birthdate = new_item.Birthdate,
                    Gender = new_item.Gender,
                    Address = new_item.Address

                });
            }

            return View(Patients);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Models.PatientModel E)
        {
            if (AccountController.isItAdmin == true)
            {
                PatientProcessor.Create(E.Ssn, E.FirstName, E.Surname, E.Phone, E.Birthdate, E.Gender, E.Address);
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
        public ActionResult Edit(Models.PatientModel E)
        {
            if (AccountController.isItAdmin == true)
            {
                PatientProcessor.Edit(E.Ssn, E.Phone, E.Birthdate, E.Address);
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
        public ActionResult Delete(Models.PatientModel E)
        {
            if (AccountController.isItAdmin == true)
            {
                PatientProcessor.Delete(E.Ssn);
                return RedirectToAction("Authenticated", "Admin");
            }
            else
            {
                return RedirectToAction("NotAuthenticated", "Admin");
            }
        }
    }
}