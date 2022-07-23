using DataLibrary.Logic;
using DataLibrary.Models;
using static DataLibrary.Logic.PatientRoomProcessor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hastane.Controllers
{
    public class Patient_RoomController : Controller
    {
        // GET: Patient_Room
        public ActionResult Index()
        {
            var data = Load();
            List<Hastane.Models.PatientRoomModel> Patient_Rooms = new List<Hastane.Models.PatientRoomModel>();
            foreach (var new_item in data)
            {
                Patient_Rooms.Add(new Hastane.Models.PatientRoomModel
                {
                    Room_no = new_item.Room_no,
                    Pssn = new_item.Pssn,
                    Capacity = new_item.Capacity
                });
            }

            return View(Patient_Rooms);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Models.PatientRoomModel E)
        {
            if(AccountController.isItAdmin == true)
            {
                PatientRoomProcessor.Create(E.Room_no, E.Pssn, E.Capacity);
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
        public ActionResult Edit(Models.PatientRoomModel E)
        {
            if(AccountController.isItAdmin == true)
            {
                PatientRoomProcessor.Edit(E.Room_no, E.Pssn, E.Capacity);
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
        public ActionResult Delete(Models.PatientRoomModel E)
        {
            if (AccountController.isItAdmin == true)
            {
                PatientRoomProcessor.Delete(E.Room_no);
                return RedirectToAction("Authenticated", "Admin");
            }
            else
            {
                return RedirectToAction("NotAuthenticated", "Admin");
            }
        }
    }
}