using DataLibrary.Logic;
using DataLibrary.Models;
using static DataLibrary.Logic.AppointmentProcessor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hastane.Controllers
{
    public class AppointmentController : Controller
    {
        // GET: Appointment
        public ActionResult Index()
        {
            var data = Load();
            List<Hastane.Models.AppointmentModel> appointments = new List<Hastane.Models.AppointmentModel>();
            foreach (var new_item in data)
            {
                appointments.Add(new Hastane.Models.AppointmentModel
                {
                    DoctorId = new_item.DoctorId,
                    Date = new_item.Date,
                    ClinicName = new_item.ClinicName,
                    Pssn = new_item.Pssn
                });
            }

            return View(appointments);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Models.AppointmentModel E)
        {
            if(AccountController.isItAdmin == true)
            {
                AppointmentProcessor.Create(E.DoctorId, E.Date, E.ClinicName, E.Pssn);
                return RedirectToAction("Authenticated","Admin");
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
        public ActionResult Edit(Models.AppointmentModel E)
        {
            if(AccountController.isItAdmin == true)
            {
                AppointmentProcessor.Edit(E.DoctorId, E.Date, E.ClinicName, E.Pssn);
                return RedirectToAction("Authenticated", "Admin");
            }
            else
            {
                return RedirectToAction("NotAuthenticated","Admin");
            }
            
        }
        public ActionResult Delete()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Delete(Models.AppointmentModel E)
        {
            if (AccountController.isItAdmin == true)
            {
                AppointmentProcessor.Delete(E.DoctorId,E.Pssn,E.ClinicName);
                return RedirectToAction("Authenticated", "Admin");
            }
            else
            {
                return RedirectToAction("NotAuthenticated", "Admin");
            }
        }
    }
}